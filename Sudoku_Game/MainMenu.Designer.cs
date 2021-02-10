namespace Sudoku_Game
{
    partial class MainMenu
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.Start = new System.Windows.Forms.Button();
            this.Records = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.NewUser = new System.Windows.Forms.Button();
            this.Users = new System.Windows.Forms.ListBox();
            this.NewUserEnt = new System.Windows.Forms.TextBox();
            this.DelBtn = new System.Windows.Forms.Button();
            this.UsersLbl = new System.Windows.Forms.Label();
            this.CurUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RecordsLbl = new System.Windows.Forms.ListBox();
            this.CloseRec = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.SudokuPic = new System.Windows.Forms.PictureBox();
            this.Instr3 = new System.Windows.Forms.Button();
            this.Instr2 = new System.Windows.Forms.Button();
            this.Instr1 = new System.Windows.Forms.Button();
            this.Instr5 = new System.Windows.Forms.Button();
            this.Instr6 = new System.Windows.Forms.Button();
            this.Instr4 = new System.Windows.Forms.Button();
            this.Instr7 = new System.Windows.Forms.Button();
            this.Instr8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SudokuPic)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(50, 74);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(106, 26);
            this.Start.TabIndex = 0;
            this.Start.Text = "Начать игру";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Records
            // 
            this.Records.Location = new System.Drawing.Point(50, 162);
            this.Records.Name = "Records";
            this.Records.Size = new System.Drawing.Size(106, 23);
            this.Records.TabIndex = 1;
            this.Records.Text = "Рекорды";
            this.Records.UseVisualStyleBackColor = true;
            this.Records.Click += new System.EventHandler(this.Records_Click);
            // 
            // About
            // 
            this.About.Location = new System.Drawing.Point(50, 252);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(106, 23);
            this.About.TabIndex = 2;
            this.About.Text = "О программе";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // NewUser
            // 
            this.NewUser.Location = new System.Drawing.Point(679, 37);
            this.NewUser.Name = "NewUser";
            this.NewUser.Size = new System.Drawing.Size(102, 63);
            this.NewUser.TabIndex = 3;
            this.NewUser.Text = "Добавить пользователя";
            this.NewUser.UseVisualStyleBackColor = true;
            this.NewUser.Click += new System.EventHandler(this.NewUser_Click);
            // 
            // Users
            // 
            this.Users.FormattingEnabled = true;
            this.Users.Location = new System.Drawing.Point(553, 37);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(120, 69);
            this.Users.TabIndex = 4;
            this.Users.SelectedIndexChanged += new System.EventHandler(this.Users_SelectedIndexChanged);
            this.Users.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Users_MouseDoubleClick);
            // 
            // NewUserEnt
            // 
            this.NewUserEnt.Location = new System.Drawing.Point(679, 106);
            this.NewUserEnt.Name = "NewUserEnt";
            this.NewUserEnt.Size = new System.Drawing.Size(100, 21);
            this.NewUserEnt.TabIndex = 5;
            this.NewUserEnt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.NewUserEnt_KeyDown);
            // 
            // DelBtn
            // 
            this.DelBtn.Enabled = false;
            this.DelBtn.Location = new System.Drawing.Point(553, 106);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(120, 23);
            this.DelBtn.TabIndex = 6;
            this.DelBtn.Text = "Удалить";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // UsersLbl
            // 
            this.UsersLbl.AutoSize = true;
            this.UsersLbl.Location = new System.Drawing.Point(553, 13);
            this.UsersLbl.Name = "UsersLbl";
            this.UsersLbl.Size = new System.Drawing.Size(98, 13);
            this.UsersLbl.TabIndex = 7;
            this.UsersLbl.Text = "Все пользователи";
            // 
            // CurUser
            // 
            this.CurUser.Location = new System.Drawing.Point(418, 37);
            this.CurUser.Name = "CurUser";
            this.CurUser.Size = new System.Drawing.Size(100, 21);
            this.CurUser.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(402, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Текущий пользователь";
            // 
            // RecordsLbl
            // 
            this.RecordsLbl.FormattingEnabled = true;
            this.RecordsLbl.Location = new System.Drawing.Point(261, 74);
            this.RecordsLbl.Name = "RecordsLbl";
            this.RecordsLbl.Size = new System.Drawing.Size(220, 264);
            this.RecordsLbl.TabIndex = 10;
            this.RecordsLbl.Visible = false;
            // 
            // CloseRec
            // 
            this.CloseRec.Location = new System.Drawing.Point(261, 345);
            this.CloseRec.Name = "CloseRec";
            this.CloseRec.Size = new System.Drawing.Size(220, 23);
            this.CloseRec.TabIndex = 11;
            this.CloseRec.Text = "Закрыть";
            this.CloseRec.UseVisualStyleBackColor = true;
            this.CloseRec.Visible = false;
            this.CloseRec.Click += new System.EventHandler(this.CloseRec_Click);
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(261, 375);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(220, 23);
            this.Reset.TabIndex = 12;
            this.Reset.Text = "Сбросить";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Visible = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // SudokuPic
            // 
            this.SudokuPic.Image = ((System.Drawing.Image)(resources.GetObject("SudokuPic.Image")));
            this.SudokuPic.Location = new System.Drawing.Point(553, 134);
            this.SudokuPic.Name = "SudokuPic";
            this.SudokuPic.Size = new System.Drawing.Size(226, 234);
            this.SudokuPic.TabIndex = 13;
            this.SudokuPic.TabStop = false;
            // 
            // Instr3
            // 
            this.Instr3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Instr3.Location = new System.Drawing.Point(22, 252);
            this.Instr3.Name = "Instr3";
            this.Instr3.Size = new System.Drawing.Size(22, 23);
            this.Instr3.TabIndex = 14;
            this.Instr3.Text = "?";
            this.Instr3.UseVisualStyleBackColor = true;
            this.Instr3.Click += new System.EventHandler(this.Instr_Click);
            // 
            // Instr2
            // 
            this.Instr2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Instr2.Location = new System.Drawing.Point(22, 162);
            this.Instr2.Name = "Instr2";
            this.Instr2.Size = new System.Drawing.Size(22, 23);
            this.Instr2.TabIndex = 15;
            this.Instr2.Text = "?";
            this.Instr2.UseVisualStyleBackColor = true;
            this.Instr2.Click += new System.EventHandler(this.button1_Click);
            // 
            // Instr1
            // 
            this.Instr1.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Instr1.Location = new System.Drawing.Point(22, 74);
            this.Instr1.Name = "Instr1";
            this.Instr1.Size = new System.Drawing.Size(22, 23);
            this.Instr1.TabIndex = 16;
            this.Instr1.Text = "?";
            this.Instr1.UseVisualStyleBackColor = true;
            this.Instr1.Click += new System.EventHandler(this.button2_Click);
            // 
            // Instr5
            // 
            this.Instr5.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Instr5.Location = new System.Drawing.Point(525, 104);
            this.Instr5.Name = "Instr5";
            this.Instr5.Size = new System.Drawing.Size(22, 23);
            this.Instr5.TabIndex = 18;
            this.Instr5.Text = "?";
            this.Instr5.UseVisualStyleBackColor = true;
            this.Instr5.Click += new System.EventHandler(this.button4_Click);
            // 
            // Instr6
            // 
            this.Instr6.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Instr6.Location = new System.Drawing.Point(757, 8);
            this.Instr6.Name = "Instr6";
            this.Instr6.Size = new System.Drawing.Size(22, 23);
            this.Instr6.TabIndex = 19;
            this.Instr6.Text = "?";
            this.Instr6.UseVisualStyleBackColor = true;
            this.Instr6.Click += new System.EventHandler(this.button5_Click);
            // 
            // Instr4
            // 
            this.Instr4.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Instr4.Location = new System.Drawing.Point(374, 13);
            this.Instr4.Name = "Instr4";
            this.Instr4.Size = new System.Drawing.Size(22, 23);
            this.Instr4.TabIndex = 20;
            this.Instr4.Text = "?";
            this.Instr4.UseVisualStyleBackColor = true;
            this.Instr4.Click += new System.EventHandler(this.button3_Click);
            // 
            // Instr7
            // 
            this.Instr7.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Instr7.Location = new System.Drawing.Point(487, 344);
            this.Instr7.Name = "Instr7";
            this.Instr7.Size = new System.Drawing.Size(22, 23);
            this.Instr7.TabIndex = 21;
            this.Instr7.Text = "?";
            this.Instr7.UseVisualStyleBackColor = true;
            this.Instr7.Visible = false;
            this.Instr7.Click += new System.EventHandler(this.Instr7_Click);
            // 
            // Instr8
            // 
            this.Instr8.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Instr8.Location = new System.Drawing.Point(487, 375);
            this.Instr8.Name = "Instr8";
            this.Instr8.Size = new System.Drawing.Size(22, 23);
            this.Instr8.TabIndex = 22;
            this.Instr8.Text = "?";
            this.Instr8.UseVisualStyleBackColor = true;
            this.Instr8.Visible = false;
            this.Instr8.Click += new System.EventHandler(this.Instr8_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Instr8);
            this.Controls.Add(this.Instr7);
            this.Controls.Add(this.Instr4);
            this.Controls.Add(this.Instr6);
            this.Controls.Add(this.Instr5);
            this.Controls.Add(this.Instr1);
            this.Controls.Add(this.Instr2);
            this.Controls.Add(this.Instr3);
            this.Controls.Add(this.SudokuPic);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.CloseRec);
            this.Controls.Add(this.RecordsLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CurUser);
            this.Controls.Add(this.UsersLbl);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.NewUserEnt);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.NewUser);
            this.Controls.Add(this.About);
            this.Controls.Add(this.Records);
            this.Controls.Add(this.Start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Судоку";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Menu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SudokuPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button Records;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button NewUser;
        private System.Windows.Forms.ListBox Users;
        private System.Windows.Forms.TextBox NewUserEnt;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Label UsersLbl;
        private System.Windows.Forms.TextBox CurUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox RecordsLbl;
        private System.Windows.Forms.Button CloseRec;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.PictureBox SudokuPic;
        private System.Windows.Forms.Button Instr3;
        private System.Windows.Forms.Button Instr2;
        private System.Windows.Forms.Button Instr1;
        private System.Windows.Forms.Button Instr5;
        private System.Windows.Forms.Button Instr6;
        private System.Windows.Forms.Button Instr4;
        private System.Windows.Forms.Button Instr7;
        private System.Windows.Forms.Button Instr8;
    }
}

