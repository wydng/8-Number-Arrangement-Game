namespace _8So_WindowsForms
{
    partial class fm8So
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDung = new System.Windows.Forms.Button();
            this.btnChoiMoi = new System.Windows.Forms.Button();
            this.btnBauDau = new System.Windows.Forms.Button();
            this.lbSoLanDiChuyen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbTocDo = new System.Windows.Forms.ComboBox();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tùyChọnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chơiMớiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn0);
            this.panel1.Controls.Add(this.btn2);
            this.panel1.Controls.Add(this.btn3);
            this.panel1.Controls.Add(this.btn7);
            this.panel1.Controls.Add(this.btn1);
            this.panel1.Controls.Add(this.btn4);
            this.panel1.Controls.Add(this.btn6);
            this.panel1.Controls.Add(this.btn5);
            this.panel1.Controls.Add(this.btn8);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(674, 485);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.panel2.Controls.Add(this.btnDung);
            this.panel2.Controls.Add(this.btnChoiMoi);
            this.panel2.Controls.Add(this.btnBauDau);
            this.panel2.Controls.Add(this.lbSoLanDiChuyen);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.cbbTocDo);
            this.panel2.Location = new System.Drawing.Point(491, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 487);
            this.panel2.TabIndex = 20;
            // 
            // btnDung
            // 
            this.btnDung.BackColor = System.Drawing.SystemColors.Control;
            this.btnDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDung.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnDung.Location = new System.Drawing.Point(44, 137);
            this.btnDung.Name = "btnDung";
            this.btnDung.Size = new System.Drawing.Size(80, 40);
            this.btnDung.TabIndex = 17;
            this.btnDung.Text = "Tạm dừng";
            this.btnDung.UseVisualStyleBackColor = false;
            this.btnDung.Click += new System.EventHandler(this.btDung_Click);
            // 
            // btnChoiMoi
            // 
            this.btnChoiMoi.BackColor = System.Drawing.SystemColors.Control;
            this.btnChoiMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoiMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnChoiMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnChoiMoi.Location = new System.Drawing.Point(44, 37);
            this.btnChoiMoi.Name = "btnChoiMoi";
            this.btnChoiMoi.Size = new System.Drawing.Size(80, 40);
            this.btnChoiMoi.TabIndex = 18;
            this.btnChoiMoi.Text = "Chơi mới";
            this.btnChoiMoi.UseVisualStyleBackColor = false;
            this.btnChoiMoi.Click += new System.EventHandler(this.ChoiMoi);
            // 
            // btnBauDau
            // 
            this.btnBauDau.BackColor = System.Drawing.SystemColors.Control;
            this.btnBauDau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBauDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnBauDau.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBauDau.Location = new System.Drawing.Point(44, 87);
            this.btnBauDau.Name = "btnBauDau";
            this.btnBauDau.Size = new System.Drawing.Size(80, 40);
            this.btnBauDau.TabIndex = 19;
            this.btnBauDau.Text = "Bắt đầu";
            this.btnBauDau.UseVisualStyleBackColor = false;
            this.btnBauDau.Click += new System.EventHandler(this.btBauDau_Click);
            // 
            // lbSoLanDiChuyen
            // 
            this.lbSoLanDiChuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbSoLanDiChuyen.Location = new System.Drawing.Point(3, 314);
            this.lbSoLanDiChuyen.Name = "lbSoLanDiChuyen";
            this.lbSoLanDiChuyen.Size = new System.Drawing.Size(175, 112);
            this.lbSoLanDiChuyen.TabIndex = 16;
            this.lbSoLanDiChuyen.Text = "0";
            this.lbSoLanDiChuyen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(32, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Số lần di chuyển";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(58, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tốc độ";
            // 
            // cbbTocDo
            // 
            this.cbbTocDo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTocDo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbbTocDo.FormattingEnabled = true;
            this.cbbTocDo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbbTocDo.Location = new System.Drawing.Point(31, 219);
            this.cbbTocDo.Name = "cbbTocDo";
            this.cbbTocDo.Size = new System.Drawing.Size(107, 21);
            this.cbbTocDo.TabIndex = 13;
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn0.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn0.Location = new System.Drawing.Point(168, 168);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(150, 150);
            this.btn0.TabIndex = 19;
            this.btn0.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.White;
            this.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn2.Location = new System.Drawing.Point(168, 12);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(150, 150);
            this.btn2.TabIndex = 11;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.White;
            this.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn3.Location = new System.Drawing.Point(324, 12);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(150, 150);
            this.btn3.TabIndex = 12;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.White;
            this.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn7.Location = new System.Drawing.Point(12, 324);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(150, 150);
            this.btn7.TabIndex = 18;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.White;
            this.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn1.Location = new System.Drawing.Point(12, 12);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(150, 150);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.White;
            this.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn4.Location = new System.Drawing.Point(324, 168);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(150, 150);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.White;
            this.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn6.Location = new System.Drawing.Point(168, 324);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(150, 150);
            this.btn6.TabIndex = 17;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.White;
            this.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn5.Location = new System.Drawing.Point(324, 324);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(150, 150);
            this.btn5.TabIndex = 16;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.White;
            this.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn8.Location = new System.Drawing.Point(12, 168);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(150, 150);
            this.btn8.TabIndex = 15;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tùyChọnToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(674, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tùyChọnToolStripMenuItem
            // 
            this.tùyChọnToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chơiMớiToolStripMenuItem});
            this.tùyChọnToolStripMenuItem.Name = "tùyChọnToolStripMenuItem";
            this.tùyChọnToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.tùyChọnToolStripMenuItem.Text = "Thông tin";
            // 
            // chơiMớiToolStripMenuItem
            // 
            this.chơiMớiToolStripMenuItem.Name = "chơiMớiToolStripMenuItem";
            this.chơiMớiToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.chơiMớiToolStripMenuItem.Text = "Phần mềm";
            this.chơiMớiToolStripMenuItem.Click += new System.EventHandler(this.chơiMớiToolStripMenuItem_Click);
            // 
            // fm8So
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(674, 509);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "fm8So";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mô phỏng trò chơi 8 số";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnDung;
        private System.Windows.Forms.Button btnChoiMoi;
        private System.Windows.Forms.Button btnBauDau;
        private System.Windows.Forms.Label lbSoLanDiChuyen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbTocDo;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tùyChọnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chơiMớiToolStripMenuItem;
    }
}

