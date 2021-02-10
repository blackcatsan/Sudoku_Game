using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku_Game
{

    public partial class Game : Form
    {

        public Game()
        {
            InitializeComponent();
        }

        Random r = new Random();
        int[,] BaseGrid;
        int o;
        int st;
        int time;



        int p;
        private void Generate_Click(object sender, EventArgs e)
        {
            int rs;
            int bl;
            if (Sudoku9x9.Enabled == false)
            {
                rs = 9;
                bl = 3;
            }
            else
            {
                rs = 16;
                bl = 4;
            }
            SudokuStandart d = new SudokuStandart();

            SudokuGrid.Enabled = true;
            //BaseGrid = new int[rs, rs];
            //d.GenBase(BaseGrid, bl, rs);


            int c;
            for (int k = 1; k <= 1000; k++)
            {


                c = r.Next(1, 6);

                switch (c)
                {

                    case 1: d.Transp(BaseGrid, rs); goto case 5;
                    case 2: d.SwapRow(BaseGrid, bl, rs, r); goto case 3;
                    case 3: d.SwapCol(BaseGrid, bl, rs, r); goto case 1;
                    case 4: d.SwapCols(BaseGrid, bl, rs, r); goto case 2;
                    case 5: d.SwapRows(BaseGrid, bl, rs, r); break;

                }

            }

            SudokuGrid.RowCount = rs;
            SudokuGrid.ColumnCount = rs;
            SudokuGrid.AllowUserToAddRows = false;
            SudokuGrid.AllowUserToDeleteRows = false;
            SudokuGrid.AllowUserToResizeRows = false;
            SudokuGrid.AllowUserToResizeColumns = false;

            int w = SudokuGrid.Width;
            int h = SudokuGrid.Height;

            for (int i = 0; i < rs; i++)

                for (int j = 0; j < rs; j++)
                {

                    SudokuGrid[i, j].Value = BaseGrid[i, j];
                    SudokuGrid.Columns[i].Width = w / rs;
                    SudokuGrid.Rows[i].Height = h / rs;
                    SudokuGrid[i, j].Style.BackColor = Color.White;
                    SudokuGrid[i, j].ReadOnly = false;
                    SudokuGrid.Rows[i].DividerHeight = 0;
                    SudokuGrid.Columns[i].DividerWidth = 0;
                }

            int a;
            int b;
            for (int s = 0; s < (rs*rs-15); s++)
            {


                a = r.Next(0, rs);
                b = r.Next(0, rs);

                SudokuGrid[a, b].Value = " ";

            }
            p = 0;
            for (int i = 0; i < rs; i++)
                for (int j = 0; j < rs; j++)
                    if (SudokuGrid[i, j].Value.ToString() != " ")
                    {
                        SudokuGrid[i, j].ReadOnly = true;
                        SudokuGrid[i, j].Style.BackColor = Color.LightGray;
                        p++;
                    }
            Test.Enabled = true;
            o = 10;
            Trys.Text = o.ToString();
            st = 0;
            time = 0;
            for (int i = 1; i < bl; i++)
            {
                SudokuGrid.Rows[bl * i - 1].DividerHeight = 2;
                SudokuGrid.Columns[bl * i - 1].DividerWidth = 2;
            }

        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {

            Application.Exit();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form f = new MainMenu();
            this.Hide();
            f.Show();
        }

        public void Test_Click(object sender, EventArgs e)
        {
            
            int rs;
            //int bl;
            if (Sudoku9x9.Enabled == false)
            {
                rs = 9;
                //bl = 3;
            }
            else
            {
                rs = 16;
                //bl = 4;
            }

            o--;
            Trys.Text = o.ToString();
            int k = 0;
            for (int i = 0; i < rs; i++)
                for (int j = 0; j < rs; j++)
                    if (SudokuGrid[i, j].Value.ToString() == BaseGrid[i, j].ToString())
                    {
                        k++;
                        if (!SudokuGrid[i, j].ReadOnly)
                            SudokuGrid[i, j].Style.BackColor = Color.White;
                    }
                    else
                        SudokuGrid[i, j].Style.BackColor = Color.Red;
            if (k == rs*rs)
            {
                Test.Enabled = false;
                o++;
                Trys.Text = o.ToString();

                StreamWriter sw = new StreamWriter("Records"+rs+"x"+rs+".sgm", true);
                sw.WriteLine(MainMenu.CurrUser + " " + st + "/" + (rs * rs - p) + " " + time / 60 + ":" + time % 60);
                sw.WriteLine();
                sw.Close();
                SudokuGrid.Enabled = false;
                MessageBox.Show("Правильно");
                
            }
            else
            {
                MessageBox.Show("Неправильно");
            }

            if (o == 0)
            {
                Test.Enabled = false;
                MessageBox.Show("Вы проиграли");
                SudokuGrid.Enabled = false;
            }

        }

        private void SudokuGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            st++;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            time++;
            
        }

        private void Game_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                SudokuGrid.CurrentCell.Value = "";
                e.KeyChar = ' ';
                MessageBox.Show("Нужно ввести число");
                SudokuGrid.CurrentCell.Value = "";
                SudokuGrid.CurrentCell = SudokuGrid[0,0];
            }
                
                
        }

        private void Instr1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Возвращает на главный экран");
        }

        private void Instr2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Генерирует новую задачу");
        }

        private void Instr3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проверет решение на правильность");
        }

        private void Instr4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поле Судоку");
        }

        private void Sudoku9x9_Click(object sender, EventArgs e)
        {
            Sudoku9x9.Enabled = false;
            Sudoku16x16.Enabled = true;
            SudokuStandart d = new SudokuStandart();
            BaseGrid = new int[9, 9];
            d.GenBase(BaseGrid, 3, 9);
        }

        private void Sudoku16x16_Click(object sender, EventArgs e)
        {
            Sudoku9x9.Enabled = true;
            Sudoku16x16.Enabled = false;
            SudokuStandart d = new SudokuStandart();
            BaseGrid = new int[16, 16];
            d.GenBase(BaseGrid, 4, 16);
        }

        private void Game_Load(object sender, EventArgs e)
        {
            SudokuStandart d = new SudokuStandart();
            BaseGrid = new int[9, 9];
            d.GenBase(BaseGrid, 3, 9);
        }
    }
}
