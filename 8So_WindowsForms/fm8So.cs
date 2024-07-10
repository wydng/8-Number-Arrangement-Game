using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _8So_WindowsForms
{
    public partial class fm8So : Form
    {
        int[,] MaTran;
        C_8So TamSo;
        Stack<int[,]> stk;
        Button[,] Mangbt;
        int n = 3;
        int SoLanDiChuyen = 0;
        public fm8So()
        {
            InitializeComponent();
            MaTran = new int[n, n];
            TamSo = new C_8So();

            stk = new Stack<int[,]>();
            Mangbt = new Button[n, n];
        }

        void load8So(int[,] a, Button[,] b)
        {
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    if (a[i, j] == 0)
                    {
                        b[i, j].Text = "";
                        b[i, j].BackColor = Color.MediumSeaGreen;
                    }
                    else
                    {
                        b[i, j].Text = a[i, j].ToString();
                        b[i, j].BackColor = Color.White;
                    }
                }
        }
        void khoiTao8So()
        {
            MaTran = TamSo.randomMaTran(n);

            load8So(MaTran, Mangbt);

            stk = TamSo.timKetQua(MaTran, n);
            stk.Pop();
            cbbTocDo.Text = cbbTocDo.Items[0].ToString();
            lbSoLanDiChuyen.Text = "0";
            SoLanDiChuyen = 0;
            btnBauDau.Enabled = false;
            btnDung.Enabled = false;
            timer1.Enabled = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            Mangbt[0, 0] = btn1;
            Mangbt[0, 1] = btn2;
            Mangbt[0, 2] = btn3;
            Mangbt[1, 0] = btn8;
            Mangbt[1, 1] = btn0;
            Mangbt[1, 2] = btn4;
            Mangbt[2, 0] = btn7;
            Mangbt[2, 1] = btn6;
            Mangbt[2, 2] = btn5;

            btnBauDau.Enabled = false;
            btnDung.Enabled = false;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(cbbTocDo.Text)
            {
                case "1": timer1.Interval = 2000; break;
                case "2": timer1.Interval = 1500; break;
                case "3": timer1.Interval = 1000; break;
                case "4": timer1.Interval = 500; break;
                case "5": timer1.Interval = 250; break;
            }
                
            int[,] Temp = new int[n, n];

            if (stk.Count != 0)
            {
                Temp = stk.Pop();
                load8So(Temp, Mangbt);

                SoLanDiChuyen++;
                lbSoLanDiChuyen.Text = SoLanDiChuyen.ToString();
            }
            else
                timer1.Enabled = false;
        }

        private void btBauDau_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            btnBauDau.Enabled = false;
            btnDung.Enabled = true;
        }

        private void btDung_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            btnDung.Enabled = false;
            btnBauDau.Enabled = true;
        }

        private void ChoiMoi(object sender, EventArgs e)
        {
            khoiTao8So();
            btnBauDau.Enabled = true;
        }

        private void chơiMớiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fmThongTin thongTim = new fmThongTin();

            thongTim.Show();
        }
    }
}
