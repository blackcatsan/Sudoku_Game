using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku_Game
{
    public partial class MainMenu : Form
    {

        public static string CurrUser;
        public MainMenu()
        {

            InitializeComponent();

        }

        

        private void Start_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Users.sgm");
            for (int i = 0; i < Users.Items.Count; i++)
                sw.WriteLine(Users.Items[i]);
            sw.Close();
            Form f = new Game();
            f.Show();
            this.Hide();


        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            StreamWriter sw = new StreamWriter("Users.sgm");
            for (int i = 0; i < Users.Items.Count; i++)
                sw.WriteLine(Users.Items[i]);
            sw.Close();
            
            Application.Exit();

        }

        private void About_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Казаков Артем ИП-31/BlackBars", "Sudoku Game v 1.1", MessageBoxButtons.OK);
        }

        private void NewUser_Click(object sender, EventArgs e)
        {
            Users.Items.Add(NewUserEnt.Text);
            CurUser.Text = NewUserEnt.Text;
            CurrUser = NewUserEnt.Text;
            NewUserEnt.Text = "";
            
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            Users.Items.RemoveAt(Users.SelectedIndex);
            CurUser.Text = "";
        }

        private void Users_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Users.SelectedIndex >= 0)
                DelBtn.Enabled = true;
            else
                DelBtn.Enabled = false;
        }

        

        public void Users_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                CurrUser = Users.SelectedItem.ToString();
                CurUser.Text = CurrUser;
            }
            catch 
            { 
            }
        }

        private void Records_Click(object sender, EventArgs e)
        {
            RecordsLbl.Visible = true;
            CloseRec.Visible = true;
            Reset.Visible = true;
            Instr7.Visible = true;
            Instr8.Visible = true;
            RecordsLbl.Items.Clear();
            RecordsLbl.Items.Add("Sudoku 9x9");
            StreamReader sr9 = new StreamReader("Records9x9.sgm");
            while (!sr9.EndOfStream)
            {
                RecordsLbl.Items.Add(sr9.ReadLine());
            }
            sr9.Close();
            RecordsLbl.Items.Add("Sudoku 16x16");
            StreamReader sr16 = new StreamReader("Records16x16.sgm");
            while (!sr16.EndOfStream)
            {
                RecordsLbl.Items.Add(sr16.ReadLine());
            }
            sr16.Close();
        }

        private void CloseRec_Click(object sender, EventArgs e)
        {
            RecordsLbl.Visible = false;
            CloseRec.Visible = false;
            Reset.Visible = false;
            Instr7.Visible = false;
            Instr8.Visible = false;
            RecordsLbl.Items.Clear();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Records9x9.sgm");
            sw.WriteLine();
            sw.Close();
            StreamWriter sr = new StreamWriter("Records16x16.sgm");
            sr.WriteLine();
            sr.Close();
            RecordsLbl.Items.Clear();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("Users.sgm");
                while (!sr.EndOfStream)
                    Users.Items.Add(sr.ReadLine());
                sr.Close();
            }
            catch
            {
                StreamWriter sr = new StreamWriter("Users.sgm");
                sr.Close();
            }
            finally
            {

            }

            try
            {
                StreamReader r9 = new StreamReader("Records9x9.sgm");
                r9.Close();
            }
            catch
            {
                StreamWriter r9 = new StreamWriter("Records9x9.sgm");
                r9.Close();
            }
            finally
            {

            }

            try
            {
                StreamReader r16 = new StreamReader("Records16x16.sgm");
                r16.Close();
            }
            catch
            {
                StreamWriter r16 = new StreamWriter("Records16x16.sgm");
                r16.Close();
            }
            finally
            {

            }

        }

        private void NewUserEnt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Users.Items.Add(NewUserEnt.Text);
                CurUser.Text = NewUserEnt.Text;
                CurrUser = NewUserEnt.Text;
                NewUserEnt.Text = "";
                
            }
        }

        private void Instr_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выводит сведения о приложении");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Выводит список рекордов");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Начинает игру");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Удаляет выделенного пользователя");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Для выбора текущего пользователя нажмите на него дважды");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Добавляет пользователя, записанного ниже");
        }

        private void Instr7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Закрывает панель рекордов");
        }

        private void Instr8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Очищает панель рекордов");
        }
    }
}
