using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_afsar_jamkarani
{
    public partial class Form1 : Form
    {
        int shomareshotp;
        int dark = 0;
        double number11 = 0;
        double number22 = 0;
        string otp = "";
        bool isfirstnumber = true;
        public Form1()
        {
            InitializeComponent();
            foreach (Control c in this.Controls)
            {
                if (c is Button)
                {
                    Button btn = (Button)c;
                    btn.TabStop = false;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                }

            }


        }
        private void darkmode_Click(object sender, EventArgs e)
        {
            if (dark % 2 == 0)
            {
                darkmode.BackColor = Color.Black;
                darkmode.ForeColor = Color.White;
                this.BackColor = Color.Black;
                this.darkmode.ForeColor = Color.White;
                jam.BackColor = Color.Black;
                menha.BackColor = Color.Black;
                taghsim.BackColor = Color.Black;
                zarb.BackColor = Color.Black;
                tavan2.BackColor = Color.Black;
                mosavi.BackColor = Color.Black;
                number0.BackColor = Color.Black;
                number1.BackColor = Color.Black;
                number2.BackColor = Color.Black;
                number3.BackColor = Color.Black;
                number4.BackColor = Color.Black;
                number5.BackColor = Color.Black;
                number6.BackColor = Color.Black;
                number7.BackColor = Color.Black;
                number8.BackColor = Color.Black;
                number9.BackColor = Color.Black;
                fact.BackColor = Color.Black;
                darsad.BackColor = Color.Black;
                mosbat_manfi.BackColor = Color.Black;
                backspace.BackColor = Color.Black;
                delete.BackColor = Color.Black;
                slash.BackColor = Color.Black;
            }
            else
            {
                darkmode.BackColor = Color.White;
                darkmode.ForeColor = Color.Black;
                this.BackColor = Color.White;
                this.darkmode.ForeColor = Color.Black;
                jam.BackColor = Color.White;
                menha.BackColor = Color.White;
                taghsim.BackColor = Color.White;
                zarb.BackColor = Color.White;
                tavan2.BackColor = Color.White;
                mosavi.BackColor = Color.White;
                number0.BackColor = Color.White;
                number1.BackColor = Color.White;
                number2.BackColor = Color.White;
                number3.BackColor = Color.White;
                number4.BackColor = Color.White;
                number5.BackColor = Color.White;
                number6.BackColor = Color.White;
                number7.BackColor = Color.White;
                number8.BackColor = Color.White;
                number9.BackColor = Color.White;
                fact.BackColor = Color.White;
                darsad.BackColor = Color.White;
                mosbat_manfi.BackColor = Color.White;
                backspace.BackColor = Color.White;
                delete.BackColor = Color.White;
                slash.BackColor = Color.White;
            }
            dark++;
        }
        void setnumber(string Text)
        {
            if (isfirstnumber)
            {
                number11 = Convert.ToDouble(display.Text);
            }
            else
            {
                number22 = Convert.ToDouble(display.Text);
            }
        }
        private void run_number(object sender, EventArgs e)
        {
            Button number = (Button)sender;
            display.Text += number.Text;
            setnumber(display.Text);
            this.ActiveControl = display;
        }
        private void delete_Click(object sender, EventArgs e)
        {
            display.Text = "0";
            isfirstnumber = true;
        }
        private void backspace_Click(object sender, EventArgs e)
        {
            if (display.Text.Length != 0)
            {
                string back = display.Text;
                back = back.Remove(back.Length - 1);
                display.Text = back + "";
            }
            this.ActiveControl = display;
        }
        double calc()
        {
            double javab = 0;
            switch (otp)
            {
                case "plus":
                    javab = number11 + number22;
                    break;
                case "mines":
                    javab = number11 - number22;
                    break;
                case "tagh":
                    javab = number11 / number22;
                    break;
                case "zarbb":
                    javab = number11 * number22;
                    break;
                case "tavan":
                    javab = Math.Pow(number11, number22);
                    break;
                case "factorial":
                    double sum = 1;
                    for (double i = Convert.ToDouble(number11); i >= 1; i--)
                    {
                        sum *= i;
                    }
                    javab = sum;
                    break;
                case "darsad":
                    javab = number11 % number22;
                    break;
            }
            return javab;



        }
        private void otp_otp(object sender, EventArgs e)
        {
            isfirstnumber = false;
            Button runotp = (Button)sender;
            otp = runotp.Tag + "";
            display.Text = "";
            this.ActiveControl = display;
        }

        private void mosavi_Click(object sender, EventArgs e)
        {
            double javab = calc();
            display.Text = javab + "";
            isfirstnumber = true;
            double number13 = javab;
            number11 = number13;
            display.Text = number13.ToString();
            this.ActiveControl = display;

        }
        
        private void mosbat_manfi_Click(object sender, EventArgs e)
        {
            if (display.Text.Length > 0)
            {
                display.Text = (Convert.ToDouble(display.Text) * -1) + "";
                calc();
                setnumber(display.Text);
            }
            else
            {
                display.Text = "0";
            }


        }

        private void display_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad1)
            {
                display.Text += "1";
                setnumber(display.Text);
            }
            else if (e.KeyCode == Keys.NumPad2)
            {
                display.Text += "2";
                setnumber(display.Text);
            }
            else if (e.KeyCode == Keys.NumPad3)
            {
                display.Text += "3";
                setnumber(display.Text);
            }
            else if (e.KeyCode == Keys.NumPad4)
            {
                display.Text += "4";
                setnumber(display.Text);
            }
            else if (e.KeyCode == Keys.NumPad5)
            {
                display.Text += "5";
                setnumber(display.Text);
            }
            else if (e.KeyCode == Keys.NumPad6)
            {
                display.Text += "6";
                setnumber(display.Text);
            }
            else if (e.KeyCode == Keys.NumPad7)
            {
                display.Text += "7";
                setnumber(display.Text);
            }
            else if (e.KeyCode == Keys.NumPad8)
            {
                display.Text += "8";
                setnumber(display.Text);
            }
            else if (e.KeyCode == Keys.NumPad9)
            {
                display.Text += "9";
                setnumber(display.Text);
            }
            else if (e.KeyCode == Keys.Return)
            {
                mosavi.PerformClick();
            }
            else if (e.KeyCode == Keys.Add)
            {
                otp = "plus";
                isfirstnumber = false;
                display.Text = "";
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                otp = "zarbb";
                isfirstnumber = false;
                display.Text = "";
            }
            else if (e.KeyCode == Keys.Divide)
            {
                otp = "tagh";
                isfirstnumber = false;
                display.Text = "";
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                otp = "mines";
                isfirstnumber = false;
                display.Text = "";
            }
            else if (e.KeyCode == Keys.Back)
            {
                if (display.Text.Length != 0)
                {
                    string back = display.Text;
                    back = back.Remove(back.Length - 1);
                    display.Text = back + "";
                }
                this.ActiveControl = display;
            }
            else if (e.KeyCode == Keys.Delete)
            {
                display.Text = "0";
                isfirstnumber = true;
            }
        }

        private void slash_Click(object sender, EventArgs e)
        {
            if(display.Text.IndexOf ('/') < 0){

            display.Text += "/";
            }
        }
        }
    }
