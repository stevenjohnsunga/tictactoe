
namespace tic_tac_toe
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDraw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtO = new System.Windows.Forms.TextBox();
            this.btnrsc = new System.Windows.Forms.Button();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.lblres = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox1.Controls.Add(this.lblres);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.lblX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn9);
            this.groupBox1.Controls.Add(this.btn6);
            this.groupBox1.Controls.Add(this.btn3);
            this.groupBox1.Controls.Add(this.btn8);
            this.groupBox1.Controls.Add(this.btn5);
            this.groupBox1.Controls.Add(this.btn2);
            this.groupBox1.Controls.Add(this.btn7);
            this.groupBox1.Controls.Add(this.btn4);
            this.groupBox1.Controls.Add(this.btn1);
            this.groupBox1.Font = new System.Drawing.Font("Open Sans Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(1, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tic Tac Toe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDraw);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtO);
            this.groupBox2.Controls.Add(this.btnrsc);
            this.groupBox2.Controls.Add(this.txtX);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(385, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 197);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tally points";
            // 
            // txtDraw
            // 
            this.txtDraw.Enabled = false;
            this.txtDraw.Location = new System.Drawing.Point(122, 110);
            this.txtDraw.Name = "txtDraw";
            this.txtDraw.Size = new System.Drawing.Size(94, 35);
            this.txtDraw.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 27);
            this.label4.TabIndex = 13;
            this.label4.Text = "DRAW :";
            // 
            // txtO
            // 
            this.txtO.Enabled = false;
            this.txtO.Location = new System.Drawing.Point(122, 72);
            this.txtO.Name = "txtO";
            this.txtO.Size = new System.Drawing.Size(94, 35);
            this.txtO.TabIndex = 3;
            // 
            // btnrsc
            // 
            this.btnrsc.BackColor = System.Drawing.Color.SteelBlue;
            this.btnrsc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnrsc.Font = new System.Drawing.Font("Open Sans Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrsc.Location = new System.Drawing.Point(16, 150);
            this.btnrsc.Name = "btnrsc";
            this.btnrsc.Size = new System.Drawing.Size(200, 37);
            this.btnrsc.TabIndex = 12;
            this.btnrsc.Text = "Reset Score";
            this.btnrsc.UseVisualStyleBackColor = false;
            this.btnrsc.Click += new System.EventHandler(this.btnrsc_Click);
            this.btnrsc.MouseEnter += new System.EventHandler(this.btnrsc_MouseEnter);
            this.btnrsc.MouseLeave += new System.EventHandler(this.btnrsc_MouseLeave);
            // 
            // txtX
            // 
            this.txtX.Enabled = false;
            this.txtX.Font = new System.Drawing.Font("Open Sans Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtX.Location = new System.Drawing.Point(122, 33);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(94, 35);
            this.txtX.TabIndex = 2;
            this.txtX.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 27);
            this.label3.TabIndex = 1;
            this.label3.Text = "Player O :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Player X :";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Open Sans Semibold", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.ForeColor = System.Drawing.Color.Chartreuse;
            this.lblX.Location = new System.Drawing.Point(87, 375);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(228, 41);
            this.lblX.TabIndex = 11;
            this.lblX.Text = "Player X Wins!!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans Semibold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 401);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "all rights reserved 2021 steven john sunga";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Open Sans Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(405, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 57);
            this.button1.TabIndex = 9;
            this.button1.Text = "Reset Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.Color.SteelBlue;
            this.btn9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn9.Font = new System.Drawing.Font("Open Sans Semibold", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(266, 266);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(113, 110);
            this.btn9.TabIndex = 8;
            this.btn9.UseVisualStyleBackColor = false;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            this.btn9.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn9_MouseClick);
            this.btn9.MouseEnter += new System.EventHandler(this.btn9_MouseEnter);
            this.btn9.MouseLeave += new System.EventHandler(this.btn9_MouseLeave);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.Color.SteelBlue;
            this.btn6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn6.Font = new System.Drawing.Font("Open Sans Semibold", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(266, 157);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(113, 110);
            this.btn6.TabIndex = 7;
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            this.btn6.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn6_MouseClick);
            this.btn6.MouseEnter += new System.EventHandler(this.btn6_MouseEnter);
            this.btn6.MouseLeave += new System.EventHandler(this.btn6_MouseLeave);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.SteelBlue;
            this.btn3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn3.Font = new System.Drawing.Font("Open Sans Semibold", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(265, 48);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(113, 110);
            this.btn3.TabIndex = 6;
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            this.btn3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn3_MouseClick);
            this.btn3.MouseEnter += new System.EventHandler(this.btn3_MouseEnter);
            this.btn3.MouseLeave += new System.EventHandler(this.btn3_MouseLeave);
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.Color.SteelBlue;
            this.btn8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn8.Font = new System.Drawing.Font("Open Sans Semibold", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(154, 265);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(113, 110);
            this.btn8.TabIndex = 5;
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            this.btn8.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn8_MouseClick);
            this.btn8.MouseEnter += new System.EventHandler(this.btn8_MouseEnter);
            this.btn8.MouseLeave += new System.EventHandler(this.btn8_MouseLeave);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.Color.SteelBlue;
            this.btn5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn5.Font = new System.Drawing.Font("Open Sans Semibold", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(154, 156);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(113, 110);
            this.btn5.TabIndex = 4;
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            this.btn5.Leave += new System.EventHandler(this.btn5_Leave);
            this.btn5.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn5_MouseClick);
            this.btn5.MouseEnter += new System.EventHandler(this.btn5_MouseEnter);
            this.btn5.MouseLeave += new System.EventHandler(this.btn5_MouseLeave);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.LightCoral;
            this.btn2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn2.Font = new System.Drawing.Font("Open Sans Semibold", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(154, 48);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(113, 110);
            this.btn2.TabIndex = 3;
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            this.btn2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn2_MouseClick);
            this.btn2.MouseEnter += new System.EventHandler(this.btn2_MouseEnter);
            this.btn2.MouseLeave += new System.EventHandler(this.btn2_MouseLeave);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.Color.SteelBlue;
            this.btn7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn7.Font = new System.Drawing.Font("Open Sans Semibold", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(42, 265);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(113, 110);
            this.btn7.TabIndex = 2;
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            this.btn7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn7_MouseClick);
            this.btn7.MouseEnter += new System.EventHandler(this.btn7_MouseEnter);
            this.btn7.MouseLeave += new System.EventHandler(this.btn7_MouseLeave);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.Color.SteelBlue;
            this.btn4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn4.Font = new System.Drawing.Font("Open Sans Semibold", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(42, 156);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(113, 110);
            this.btn4.TabIndex = 1;
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            this.btn4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn4_MouseClick);
            this.btn4.MouseEnter += new System.EventHandler(this.btn4_MouseEnter);
            this.btn4.MouseLeave += new System.EventHandler(this.btn4_MouseLeave);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Cyan;
            this.btn1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn1.Font = new System.Drawing.Font("Open Sans Semibold", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(43, 48);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(113, 110);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            this.btn1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btn1_MouseClick);
            this.btn1.MouseEnter += new System.EventHandler(this.btn1_MouseEnter);
            this.btn1.MouseLeave += new System.EventHandler(this.btn1_MouseLeave);
            // 
            // lblres
            // 
            this.lblres.AutoSize = true;
            this.lblres.BackColor = System.Drawing.Color.Transparent;
            this.lblres.Font = new System.Drawing.Font("Open Sans Semibold", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblres.ForeColor = System.Drawing.Color.White;
            this.lblres.Location = new System.Drawing.Point(117, 13);
            this.lblres.Name = "lblres";
            this.lblres.Size = new System.Drawing.Size(418, 32);
            this.lblres.TabIndex = 14;
            this.lblres.Text = "Reset the game to start a new game.";
            this.lblres.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 425);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtO;
        private System.Windows.Forms.Button btnrsc;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDraw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblres;
    }
}

