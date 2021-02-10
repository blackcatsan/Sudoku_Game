namespace Sudoku_Game
{
    partial class Game
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.Generate = new System.Windows.Forms.Button();
            this.SudokuGrid = new System.Windows.Forms.DataGridView();
            this.Back = new System.Windows.Forms.Button();
            this.Test = new System.Windows.Forms.Button();
            this.TestLbl = new System.Windows.Forms.Label();
            this.Trys = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Instr1 = new System.Windows.Forms.Button();
            this.Instr2 = new System.Windows.Forms.Button();
            this.Instr3 = new System.Windows.Forms.Button();
            this.Instr4 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Sudoku9x9 = new System.Windows.Forms.ToolStripMenuItem();
            this.Sudoku16x16 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.SudokuGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(26, 143);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(146, 56);
            this.Generate.TabIndex = 0;
            this.Generate.Text = "Начать";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // SudokuGrid
            // 
            this.SudokuGrid.AllowUserToAddRows = false;
            this.SudokuGrid.AllowUserToDeleteRows = false;
            this.SudokuGrid.AllowUserToResizeColumns = false;
            this.SudokuGrid.AllowUserToResizeRows = false;
            this.SudokuGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.SudokuGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SudokuGrid.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SudokuGrid.DefaultCellStyle = dataGridViewCellStyle1;
            this.SudokuGrid.Location = new System.Drawing.Point(311, 33);
            this.SudokuGrid.Margin = new System.Windows.Forms.Padding(30);
            this.SudokuGrid.MinimumSize = new System.Drawing.Size(50, 50);
            this.SudokuGrid.MultiSelect = false;
            this.SudokuGrid.Name = "SudokuGrid";
            this.SudokuGrid.RowHeadersVisible = false;
            this.SudokuGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.SudokuGrid.RowTemplate.Height = 40;
            this.SudokuGrid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SudokuGrid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SudokuGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.SudokuGrid.Size = new System.Drawing.Size(450, 450);
            this.SudokuGrid.TabIndex = 1;
            this.SudokuGrid.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.SudokuGrid_CellValueChanged);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(26, 48);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(146, 50);
            this.Back.TabIndex = 2;
            this.Back.Text = "Назад";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // Test
            // 
            this.Test.Enabled = false;
            this.Test.Location = new System.Drawing.Point(12, 287);
            this.Test.Name = "Test";
            this.Test.Size = new System.Drawing.Size(237, 64);
            this.Test.TabIndex = 3;
            this.Test.Text = "Проверить";
            this.Test.UseVisualStyleBackColor = true;
            this.Test.Click += new System.EventHandler(this.Test_Click);
            // 
            // TestLbl
            // 
            this.TestLbl.AutoSize = true;
            this.TestLbl.Location = new System.Drawing.Point(12, 271);
            this.TestLbl.Name = "TestLbl";
            this.TestLbl.Size = new System.Drawing.Size(106, 13);
            this.TestLbl.TabIndex = 4;
            this.TestLbl.Text = "Осталось попыток:";
            // 
            // Trys
            // 
            this.Trys.AutoSize = true;
            this.Trys.Location = new System.Drawing.Point(165, 271);
            this.Trys.Name = "Trys";
            this.Trys.Size = new System.Drawing.Size(19, 13);
            this.Trys.TabIndex = 5;
            this.Trys.Text = "10";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Instr1
            // 
            this.Instr1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Instr1.Location = new System.Drawing.Point(178, 48);
            this.Instr1.Name = "Instr1";
            this.Instr1.Size = new System.Drawing.Size(22, 23);
            this.Instr1.TabIndex = 20;
            this.Instr1.Text = "?";
            this.Instr1.UseVisualStyleBackColor = true;
            this.Instr1.Click += new System.EventHandler(this.Instr1_Click);
            // 
            // Instr2
            // 
            this.Instr2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Instr2.Location = new System.Drawing.Point(178, 143);
            this.Instr2.Name = "Instr2";
            this.Instr2.Size = new System.Drawing.Size(22, 23);
            this.Instr2.TabIndex = 21;
            this.Instr2.Text = "?";
            this.Instr2.UseVisualStyleBackColor = true;
            this.Instr2.Click += new System.EventHandler(this.Instr2_Click);
            // 
            // Instr3
            // 
            this.Instr3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Instr3.Location = new System.Drawing.Point(255, 308);
            this.Instr3.Name = "Instr3";
            this.Instr3.Size = new System.Drawing.Size(22, 23);
            this.Instr3.TabIndex = 22;
            this.Instr3.Text = "?";
            this.Instr3.UseVisualStyleBackColor = true;
            this.Instr3.Click += new System.EventHandler(this.Instr3_Click);
            // 
            // Instr4
            // 
            this.Instr4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Instr4.Location = new System.Drawing.Point(285, 33);
            this.Instr4.Name = "Instr4";
            this.Instr4.Size = new System.Drawing.Size(22, 23);
            this.Instr4.TabIndex = 23;
            this.Instr4.Text = "?";
            this.Instr4.UseVisualStyleBackColor = true;
            this.Instr4.Click += new System.EventHandler(this.Instr4_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Sudoku9x9,
            this.Sudoku16x16});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Sudoku9x9
            // 
            this.Sudoku9x9.Enabled = false;
            this.Sudoku9x9.Name = "Sudoku9x9";
            this.Sudoku9x9.Size = new System.Drawing.Size(75, 20);
            this.Sudoku9x9.Text = "Sudoku 9x9";
            this.Sudoku9x9.Click += new System.EventHandler(this.Sudoku9x9_Click);
            // 
            // Sudoku16x16
            // 
            this.Sudoku16x16.Name = "Sudoku16x16";
            this.Sudoku16x16.Size = new System.Drawing.Size(86, 20);
            this.Sudoku16x16.Text = "sudoku 16x16";
            this.Sudoku16x16.Click += new System.EventHandler(this.Sudoku16x16_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Instr4);
            this.Controls.Add(this.Instr3);
            this.Controls.Add(this.Instr2);
            this.Controls.Add(this.Instr1);
            this.Controls.Add(this.Trys);
            this.Controls.Add(this.TestLbl);
            this.Controls.Add(this.Test);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.SudokuGrid);
            this.Controls.Add(this.Generate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Game";
            this.Text = "Судоку";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.Load += new System.EventHandler(this.Game_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Game_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.SudokuGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.DataGridView SudokuGrid;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button Test;
        private System.Windows.Forms.Label TestLbl;
        private System.Windows.Forms.Label Trys;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Instr1;
        private System.Windows.Forms.Button Instr2;
        private System.Windows.Forms.Button Instr3;
        private System.Windows.Forms.Button Instr4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Sudoku9x9;
        private System.Windows.Forms.ToolStripMenuItem Sudoku16x16;
    }
}