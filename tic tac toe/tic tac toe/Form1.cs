using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tic_tac_toe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        void disALL()
        {
            btn1.Enabled = false;
            btn2.Enabled = false;
            btn3.Enabled = false;
            btn4.Enabled = false;
            btn5.Enabled = false;
            btn6.Enabled = false;
            btn7.Enabled = false;
            btn8.Enabled = false;
            btn9.Enabled = false;
          
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.PerformClick();
            btnrsc.PerformClick();
            lblX.Visible = false;
            
            label1.Text = "all rights reserved 2021 steven john sunga";
                }
        bool isX;
        bool result=false;
        int count = 0;
        int pX = 0;
        int pO = 0;
        int pD = 0;
        int j = 0;
        private void btn1_Click(object sender, EventArgs e)
        {
            
            if (count==0)
            {
                btn1.Text = "X";
                isX = false;
                count = count + 1;
                btn1.Enabled = false;
                btn1.BackColor = Color.LightCoral;
                
            }
            else if (!isX)
            {
                btn1.Text = "O";
                isX = true;
                count = count + 1;
                btn1.Enabled = false;
                btn1.BackColor = Color.Cyan;
                
                if (btn2.Text=="O" && btn3.Text == "O")
                {
                    lblX.Text = "Player O wins!";
                    lblX.Visible = true;
                    result = true;
                    pO += 1;
                    txtO.Text = pO.ToString();
                    disALL();
                }
                if (btn4.Text == "O" && btn7.Text == "O")
                {
                    lblX.Text = "Player O wins!";
                    lblX.Visible = true;
                    result = true;
                    pO += 1;
                    txtO.Text = pO.ToString();
                    disALL();
                }
                if (btn5.Text == "O" && btn9.Text == "O")
                {
                    lblX.Text = "Player O wins!";
                    lblX.Visible = true;
                    result = true;
                    disALL();
                    pO += 1;
                    txtO.Text = pO.ToString();
                }


            }
            else
            {
                btn1.Text = "X";
                isX = false;
                count = count + 1;
                btn1.Enabled = false;
                btn1.BackColor = Color.LightCoral;
                if (btn2.Text == "X" && btn3.Text == "X")
                {
                    lblX.Text = "Player X wins!";
                    lblX.Visible = true;
                    pX += 1;
                    txtX.Text = pX.ToString();
                    disALL();
                    result = true;
                }
                if (btn4.Text == "X" && btn7.Text == "X")
                {
                    lblX.Text = "Player X wins!";
                    lblX.Visible = true;
                    pX += 1;
                    txtX.Text = pX.ToString();
                    disALL();
                    result = true;
                }
                if (btn5.Text == "X" && btn9.Text == "X")
                {
                    lblX.Text = "Player X wins!";
                    lblX.Visible = true;
                    pX += 1;
                    txtX.Text = pX.ToString();
                    disALL();
                    result = true;
                }

            }

            if (count == 9)
            {
                lblX.Text = "GAME IS DRAW!";
                lblX.Visible = true;
                pD += 1;
                txtDraw.Text = pD.ToString();
                disALL();
                result = true;
            }
        }
        string myb = "all rights reserved 2021 steven john sunga";
        private void btn9_Click(object sender, EventArgs e)
        {
            

            
            btn9.Enabled = false;
            
            if (count == 0)
            {
                btn9.Text = "X";
                isX = false;
                count = count + 1;
                btn9.BackColor = Color.LightCoral;
                
            }
            else if (!isX)
            {
                btn9.Text = "O";
                isX = true;
                count = count + 1;
                btn9.BackColor = Color.Cyan;
                if (btn5.Text == "O" && btn1.Text == "O")
                {
                    lblX.Text = "Player O wins!";
                    lblX.Visible = true;
                    pO += 1;
                    txtO.Text = pO.ToString();
                    disALL();
                    result = true;
                }
                if (btn7.Text == "O" && btn8.Text == "O")
                {
                    lblX.Text = "Player O wins!";
                    lblX.Visible = true;
                    pO += 1;
                    txtO.Text = pO.ToString();
                    disALL();
                    result = true;

                }
                if (btn3.Text == "O" && btn6.Text == "O")
                {
                    lblX.Text = "Player O wins!";
                    lblX.Visible = true;
                    pO += 1;
                    txtO.Text = pO.ToString();
                    disALL();
                    result = true;

                }
            }
            else
            {
                btn9.Text = "X";
                isX = false;
                count = count + 1;
                btn9.BackColor = Color.LightCoral;
                if (btn5.Text == "X" && btn1.Text == "X")
                {
                    lblX.Text = "Player X wins!";
                    lblX.Visible = true;
                    pX += 1;
                    txtX.Text = pX.ToString();
                    disALL();
                    result = true;


                }
                if (btn7.Text == "X" && btn8.Text == "X")
                {
                    lblX.Text = "Player X wins!";
                    lblX.Visible = true;
                    pX += 1;
                    txtX.Text = pX.ToString();
                    disALL();
                    result = true;

                }
                if (btn3.Text == "X" && btn6.Text == "X")
                {
                    lblX.Text = "Player X wins!";
                    lblX.Visible = true;
                    pX += 1;
                    txtX.Text = pX.ToString();
                    result = true;
                    disALL();
                }
            }
            if (count == 9)
            {
                lblX.Text = "GAME IS DRAW!";
                lblX.Visible = true;
                pD += 1;
                txtDraw.Text = pD.ToString();
                disALL();
                result = true;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (btn1.Enabled == false)
            {
                lblX.Text = "New game started!";
            }
            lblres.Visible = false;
            result = false;
            j = 0;
            count = 0;
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
           btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            label1.Text = myb;
            btn1.Enabled = true;
            btn2.Enabled = true;
            btn3.Enabled = true;
            btn4.Enabled = true;
            btn5.Enabled = true;
            btn6.Enabled = true;
            btn7.Enabled = true;
            btn8.Enabled = true;
            btn9.Enabled = true;
            btn1.BackColor = Color.SteelBlue;
            btn2.BackColor = Color.SteelBlue;
            btn3.BackColor = Color.SteelBlue;
            btn4.BackColor = Color.SteelBlue;
            btn5.BackColor = Color.SteelBlue;
            btn6.BackColor = Color.SteelBlue;
            btn7.BackColor = Color.SteelBlue;
            btn8.BackColor = Color.SteelBlue;
            btn9.BackColor = Color.SteelBlue;
           
        }

        private void btn2_Click(object sender, EventArgs e)
        {
           
            btn2.Enabled = false;
           
            if (count == 0)
            {
                btn2.Text = "X";
                isX = false;
                count = count + 1;
                btn2.BackColor = Color.LightCoral;
            }
            else if (!isX)
            {
                btn2.Text = "O";
                isX = true;
                count = count + 1;
                btn2.BackColor = Color.Cyan;
                if (btn5.Text == "O" && btn8.Text == "O")
                {
                    lblX.Text = "Player O wins!";
                    lblX.Visible = true;
                    pO += 1;
                    txtO.Text = pO.ToString();
                    disALL();
                    result = true;
                }
                if (btn1.Text == "O" && btn3.Text == "O")
                {
                    lblX.Text = "Player O wins!";
                    lblX.Visible = true;
                    pO += 1;
                    txtO.Text = pO.ToString();
                    disALL();
                    result = true;
                }
            }
            else
            {
                btn2.Text = "X";
                isX = false;
                count = count + 1;
                btn2.BackColor = Color.LightCoral;
                if (btn1.Text == "X" && btn3.Text == "X")
                {
                    lblX.Text = "Player X wins!";
                    lblX.Visible = true;
                    pX += 1;
                    txtX.Text = pX.ToString();
                    disALL();
                    result = true;
                }
                if (btn5.Text == "X" && btn8.Text == "X")
                {
                    lblX.Text = "Player X wins!";
                    lblX.Visible = true;
                    pX += 1;
                    txtX.Text = pX.ToString();
                    disALL();
                    result = true;
                }
            }
            if (count == 9)
            {
                lblX.Text = "Game is DRAW!";
                lblX.Visible = true;
                pD += 1;
                txtDraw.Text = pD.ToString();
                disALL();
                result = true;
            }

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            
            btn3.Enabled = false;
            
            if (count == 0)
            {
                btn3.Text = "X";
                isX = false;
                count = count + 1;
                btn3.BackColor = Color.LightCoral;
                

            }
            else if (!isX)
            {
                btn3.Text = "O";
                isX = true;
                count = count + 1;
                btn3.BackColor = Color.Cyan;
                if (btn6.Text == "O" && btn9.Text == "O")
                {
                    lblX.Text = "Player O wins!";
                    lblX.Visible = true;
                    pO += 1;
                    txtO.Text = pO.ToString();
                    disALL();
                    result = true;
                }
                if (btn5.Text == "O" && btn7.Text == "O")
                {
                    lblX.Text = "Player O wins!";
                    lblX.Visible = true;
                    pO += 1;
                    txtO.Text = pO.ToString();
                    disALL();
                    result = true;
                }
                if (btn2.Text == "O" && btn1.Text == "O")
                {
                    lblX.Text = "Player O wins!";
                    lblX.Visible = true;
                    pO += 1;
                    txtO.Text = pO.ToString();
                    disALL();
                    result = true;
                }

            }
            else
            {
                btn3.Text = "X";
                isX = false;
                count = count + 1;
                btn3.BackColor = Color.LightCoral;
                if (btn6.Text == "X" && btn9.Text == "X")
                {
                    lblX.Text = "Player X wins!";
                    lblX.Visible = true;
                    pX += 1;
                    txtX.Text = pX.ToString();
                    disALL();
                    result = true;
                }
                if (btn5.Text == "X" && btn7.Text == "X")
                {
                    lblX.Text = "Player X wins!";
                    lblX.Visible = true;
                    pX += 1;
                    txtX.Text = pX.ToString();
                    disALL();
                    result = true;
                }
                if (btn2.Text == "X" && btn1.Text == "X")
                {
                    lblX.Text = "Player X wins!";
                    lblX.Visible = true;
                    pX += 1;
                    txtX.Text = pX.ToString();
                    disALL();
                    result = true;
                }
            }
            if (count == 9)
            {
                lblX.Text = "GAME IS DRAW!";
                lblX.Visible = true;
                pD += 1;
                txtDraw.Text = pD.ToString();
                disALL();
                result = true;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            
            btn4.Enabled = false;
            
            if (count == 0)
            {
                btn4.Text = "X";
                isX = false;
                count = count + 1;
                btn4.BackColor = Color.LightCoral;
            }
            else if (!isX)
            {
                btn4.Text = "O";
                isX = true;
                count = count + 1;
                btn4.BackColor = Color.Cyan;
                if (btn6.Text == "O" && btn5.Text == "O")
                {
                    lblX.Text = "Player O wins!";
                    lblX.Visible = true;
                    pO += 1;
                    txtO.Text = pO.ToString();
                    disALL();
                    result = true;

                }
                if (btn1.Text == "O" && btn7.Text == "O")
                {
                    lblX.Text = "Player O wins!";
                    lblX.Visible = true;
                    pO += 1;
                    txtO.Text = pO.ToString();
                    disALL();
                    result = true;

                }
            }
            else
            {
                btn4.Text = "X";
                isX = false;
                count = count + 1;
                btn4.BackColor = Color.LightCoral;
                if (btn6.Text == "X" && btn5.Text == "X")
                {
                    lblX.Text = "Player X wins!";
                    lblX.Visible = true;
                    pX += 1;
                    txtX.Text = pX.ToString();
                    disALL();
                    result = true;

                }
                if (btn1.Text == "X" && btn7.Text == "X")
                {
                    lblX.Text = "Player X wins!";
                    lblX.Visible = true;
                    pX += 1;
                    txtX.Text = pX.ToString();
                    disALL();
                    result = true;

                }
            }
            if (count == 9)
            {
                lblX.Text = "Game is DRAW!";
                lblX.Visible = true;
                pD += 1;
                txtDraw.Text = pD.ToString();
                result = true;
                disALL();
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
         
            btn5.Enabled = false;
            
            if (count == 0)
            {
                btn5.Text = "X";
                isX = false;
                count = count + 1;
                btn5.BackColor = Color.LightCoral;

            }
            else if (!isX)
            {
                btn5.Text = "O";
                isX = true;
                count = count + 1;
                btn5.BackColor = Color.Cyan;
                if (btn1.Text == "O" && btn9.Text == "O")
                {
                    lblX.Text = "Player O wins!";
                    lblX.Visible = true;
                    pO += 1;
                    txtO.Text = pO.ToString();
                    result = true;
                    disALL();
                }
                if (btn2.Text == "O" && btn8.Text == "O")
                {
                    lblX.Text = "Player O wins!";
                    lblX.Visible = true;
                    pO += 1;
                    txtO.Text = pO.ToString();
                    disALL();
                    result = true;
                }
                if (btn3.Text == "O" && btn7.Text == "O")
                {
                    lblX.Text = "Player O wins!";
                    lblX.Visible = true;
                    pO += 1;
                    txtO.Text = pO.ToString();
                    disALL();
                    result = true;
                }
                if (btn4.Text == "O" && btn6.Text == "O")
                {
                    lblX.Text = "Player O wins!";
                    lblX.Visible = true;
                    pO += 1;
                    txtO.Text = pO.ToString();
                    disALL();
                    result = true;
                }

            }
            else
            {
                btn5.Text = "X";
                isX = false;
                count = count + 1;
                btn5.BackColor = Color.LightCoral;
                if (btn1.Text == "X" && btn9.Text == "X")
                {
                    lblX.Text = "Player X wins!";
                    lblX.Visible = true;
                    pX += 1;
                    txtX.Text = pX.ToString();
                    disALL();
                    result = true;
                }
                if (btn2.Text == "X" && btn8.Text == "X")
                {
                    lblX.Text = "Player X wins!";
                    lblX.Visible = true;
                    pX += 1;
                    txtX.Text = pX.ToString();
                    disALL();
                    result = true;
                }
                if (btn3.Text == "X" && btn7.Text == "X")
                {
                    lblX.Text = "Player X wins!";
                    lblX.Visible = true;
                    pX += 1;
                    txtX.Text = pX.ToString();
                    disALL();
                    result = true;
                }
                if (btn4.Text == "X" && btn6.Text == "X")
                {
                    lblX.Text = "Player X wins!";
                    lblX.Visible = true;
                    pX += 1;
                    txtX.Text = pX.ToString();
                    disALL();
                    result = true;
                }
            }
            if (count == 9)
            {
                lblX.Text = "GAME IS DRAW!";
                lblX.Visible = true;
                pD += 1;
                txtDraw.Text = pD.ToString();
                disALL();
                result = true;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {

            btn6.Enabled = false;
            
            if (count == 0)
            {
                btn6.Text = "X";
                isX = false;
                count = count + 1;
                btn6.BackColor = Color.LightCoral;
            }
            else if (!isX)
            {
                btn6.Text = "O";
                isX = true;
                count = count + 1;
                btn6.BackColor = Color.Cyan;
                if (btn3.Text == "O" && btn9.Text == "O")
                {
                    lblX.Text = "Player O wins!";
                    lblX.Visible = true;
                    pO += 1;
                    txtO.Text = pO.ToString();
                    disALL();
                    result = true;
                }
                if (btn5.Text == "O" && btn4.Text == "O")
                {
                    lblX.Text = "Player O wins!";
                    lblX.Visible = true;
                    pO += 1;
                    txtO.Text = pO.ToString();
                    disALL();
                    result = true;
                }
            }
            else
            {
                btn6.Text = "X";
                isX = false;
                count = count + 1;
                btn6.BackColor = Color.LightCoral;
                if (btn3.Text == "X" && btn9.Text == "X")
                {
                    lblX.Text = "Player X wins!";
                    lblX.Visible = true;
                    pX += 1;
                    txtX.Text = pX.ToString();
                    disALL();
                    result = true;
                }
                if (btn5.Text == "X" && btn4.Text == "X")
                {
                    lblX.Text = "Player X wins!";
                    lblX.Visible = true;
                    pX += 1;
                    txtX.Text = pX.ToString();
                    disALL();
                    result = true;
                }
            }
            if (count == 9)
            {
                lblX.Text = "Game is DRAW!";
                lblX.Visible = true;
                pD += 1;
                txtDraw.Text = pD.ToString();
                disALL();
                result = true;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
           
            btn7.Enabled = false;
            
            if (count == 0)
            {
                btn7.Text = "X";
                isX = false;
                count = count + 1;
                btn7.BackColor = Color.LightCoral;
            }
            else if (!isX)
            {
                btn7.Text = "O";
                isX = true;
                count = count + 1;
                btn7.BackColor = Color.Cyan;
                if (btn1.Text == "O" && btn4.Text == "O")
                {
                    lblX.Text = "Player O wins!";
                    lblX.Visible = true;
                    pO += 1;
                    txtO.Text = pO.ToString();
                    disALL();
                    result = true;
                }
                if (btn8.Text == "O" && btn9.Text == "O")
                {
                    lblX.Text = "Player O wins!";
                    lblX.Visible = true;
                    pO += 1;
                    txtO.Text = pO.ToString();
                    disALL();
                    result = true;
                }
                if (btn5.Text == "O" && btn3.Text == "O")
                {
                    lblX.Text = "Player O wins!";
                    lblX.Visible = true;
                    pO += 1;
                    txtO.Text = pO.ToString();
                    disALL();
                    result = true;
                }
            }
            else
            {
                btn7.Text = "X";
                isX = false;
                count = count + 1;
                btn7.BackColor = Color.LightCoral;
                if (btn1.Text == "X" && btn4.Text == "X")
                {
                    lblX.Text = "Player X wins!";
                    lblX.Visible = true;
                    pX += 1;
                    txtX.Text = pX.ToString();
                    result = true;
                    disALL();
                }
                if (btn8.Text == "X" && btn9.Text == "X")
                {
                    lblX.Text = "Player X wins!";
                    lblX.Visible = true;
                    pX += 1;
                    txtX.Text = pX.ToString();
                    disALL();
                    result = true;
                }
                if (btn5.Text == "X" && btn3.Text == "X")
                {
                    lblX.Text = "Player X wins!";
                    lblX.Visible = true;
                    pX += 1;
                    txtX.Text = pX.ToString();
                    disALL();
                    result = true;
                }
            }
            if (count == 9)
            {
                lblX.Text = "Game is DRAW!";
                lblX.Visible = true;
                pD += 1;
                txtDraw.Text = pD.ToString();
                disALL();
                result = true;

            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            
            btn8.Enabled = false;
            
            if (count == 0)
            {
                btn8.Text = "X";
                isX = false;
                count = count + 1;
                btn8.BackColor = Color.LightCoral;

            }
            else if (!isX)
            {
                btn8.Text = "O";
                isX = true;
                count = count + 1;
                btn8.BackColor = Color.Cyan;
                if (btn5.Text == "O" && btn2.Text == "O")
                {
                    lblX.Text = "Player O wins!";
                    lblX.Visible = true;
                    pO += 1;
                    txtO.Text = pO.ToString();
                    disALL();
                    result = true;

                }
                if (btn7.Text == "O" && btn9.Text == "O")
                {
                    lblX.Text = "Player O wins!";
                    lblX.Visible = true;
                    pO += 1;
                    txtO.Text = pO.ToString();
                    disALL();
                    result = true;
                }
            }
            else
            {
                btn8.Text = "X";
                isX = false;
                count = count + 1;
                btn8.BackColor = Color.LightCoral;
                if (btn5.Text == "X" && btn2.Text == "X")
                {
                    lblX.Text = "Player X wins!";
                    lblX.Visible = true;
                    pX += 1;
                    txtX.Text = pX.ToString();
                    disALL();
                    result = true;
                }
                if (btn7.Text == "X" && btn9.Text == "X")
                {
                    lblX.Text = "Player X wins!";
                    lblX.Visible = true;
                    pX += 1;
                    txtX.Text = pX.ToString();
                    disALL();
                    result = true;
                }
            }
            if (count == 9)
            {
                lblX.Text = "Game is DRAW!";
                lblX.Visible = true;
                pD += 1;
                txtDraw.Text = pD.ToString();
                disALL();
                result = true;
            }
        }

        private void btnrsc_Click(object sender, EventArgs e)
        {
            txtX.Text = "";
            txtO.Text = "";
            txtX.Text = "0";
            txtO.Text = "0";
            txtO.ForeColor = Color.Black;
            txtX.ForeColor = Color.Black;
            txtX.BackColor = Color.White;
            txtO.BackColor = Color.White;
            label1.Text = "all rights reserved 2021 steven john sunga";
            txtDraw.Text = "";
            txtDraw.Text = "0";
            pD = 0;
            pX = 0;
            pO = 0;
            lblX.Text = "Scores have been reset.";
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.F1)
            {
                MessageBox.Show("Developed by Steven John Sunga.");
            }
                    
                   
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnrsc_MouseEnter(object sender, EventArgs e)
        {
            btnrsc.BackColor = Color.LightSkyBlue;
        }

        private void btnrsc_MouseLeave(object sender, EventArgs e)
        {
            btnrsc.BackColor = Color.SteelBlue;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.LightSkyBlue;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.SteelBlue;
        }

        private void btn1_MouseEnter(object sender, EventArgs e)
        {
            if (btn1.Text == "")
            {
                btn1.BackColor = Color.LightSkyBlue;
            }
        }

        private void btn2_MouseEnter(object sender, EventArgs e)
        {
            if (btn2.Text == "")
            {
                btn2.BackColor = Color.LightSkyBlue;
            }
        }

        private void btn3_MouseEnter(object sender, EventArgs e)
        {
            btn3.BackColor = Color.LightSkyBlue;
        }

        private void btn4_MouseEnter(object sender, EventArgs e)
        {
            if (btn4.Text == "")
            {
                btn4.BackColor = Color.LightSkyBlue;
            }
        }

        private void btn5_MouseEnter(object sender, EventArgs e)
        {
            if (btn5.Text == "")
            {
                btn5.BackColor = Color.LightSkyBlue;
            }
        }

        private void btn6_MouseEnter(object sender, EventArgs e)
        {
            if (btn6.Text == "")
            {
                btn6.BackColor = Color.LightSkyBlue;
            }
        }

        private void btn7_MouseEnter(object sender, EventArgs e)
        {
            if (btn7.Text == "")
            {
                btn7.BackColor = Color.LightSkyBlue;
            }
        }

        private void btn8_MouseEnter(object sender, EventArgs e)
        {
            if (btn8.Text == "")
            {
                btn8.BackColor = Color.LightSkyBlue;
            }
        }

        private void btn9_MouseEnter(object sender, EventArgs e)
        {
            if (btn9.Text == "")
            {
                btn9.BackColor = Color.LightSkyBlue;
            }
        }

        private void btn1_MouseLeave(object sender, EventArgs e)
        {
            if (btn1.Text == "")
            {
                btn1.BackColor = Color.SteelBlue;
            }
        }

        private void btn2_MouseLeave(object sender, EventArgs e)
        {
            if (btn2.Text == "")
            {
                btn2.BackColor = Color.SteelBlue;
            }
        }

        private void btn3_MouseLeave(object sender, EventArgs e)
        {
            if (btn3.Text == "")
            {
                btn3.BackColor = Color.SteelBlue;
            }
        }

        private void btn4_MouseLeave(object sender, EventArgs e)
        {
            if (btn4.Text == "")
            {
                btn4.BackColor = Color.SteelBlue;
            }
        }

        private void btn5_Leave(object sender, EventArgs e)
        {
            if (btn5.Text == "")
            {
                btn5.BackColor = Color.SteelBlue;
            }
        }

        private void btn6_MouseLeave(object sender, EventArgs e)
        {
            if (btn6.Text == "")
            {
                btn6.BackColor = Color.SteelBlue;
            }
        }

        private void btn7_MouseLeave(object sender, EventArgs e)
        {
            if (btn7.Text == "")
            {
                btn7.BackColor = Color.SteelBlue;
            }
        }

        private void btn8_MouseLeave(object sender, EventArgs e)
        {
            if (btn8.Text == "")
            {
                btn8.BackColor = Color.SteelBlue;
            }
        }

        private void btn9_MouseLeave(object sender, EventArgs e)
        {
            if (btn9.Text == "")
            {
                btn9.BackColor = Color.SteelBlue;
            }
        }

        private void btn5_MouseLeave(object sender, EventArgs e)
        {

            if (btn5.Text == "")
            {
                btn5.BackColor = Color.SteelBlue;
            }
        }

        private void btn8_MouseClick(object sender, MouseEventArgs e)
        {
            if (result)
            {

               
                    
                    lblres.Visible = true;
                
                j += 1;


            }
        }

        private void btn9_MouseClick(object sender, MouseEventArgs e)
        {
            if  (result)
            {

               
                    
                    lblres.Visible = true;
                
                j += 1;


            }
        }

        private void btn7_MouseClick(object sender, MouseEventArgs e)
        {
            if  (result)
            {

                
                  
                    lblres.Visible = true;
                
                j += 1;


            }
        }

        private void btn1_MouseClick(object sender, MouseEventArgs e)
        {
            if (result)
            {

               
                  
                    lblres.Visible = true;
                
                j += 1;


            }
        }

        private void btn2_MouseClick(object sender, MouseEventArgs e)
        {
            if (result)
            {

               
                   
                    lblres.Visible = true;
                
                j += 1;


            }
        }

        private void btn3_MouseClick(object sender, MouseEventArgs e)
        {
            if (result)
            {

                
                   
                    lblres.Visible = true;
                
                j += 1;


            }
        }

        private void btn4_MouseClick(object sender, MouseEventArgs e)
        {
            if (result)
            {

               
                    
                    lblres.Visible = true;
                
                j += 1;


            }
        }

        private void btn5_MouseClick(object sender, MouseEventArgs e)
        {
            if (result)
            {

                
                    
                    lblres.Visible = true;
                
                j += 1;


            }
        }

        private void btn6_MouseClick(object sender, MouseEventArgs e)
        {
            if (result)
            {

                j += 1;
               
                    lblres.Visible = true;
                
                


            }
        }
    }
}
