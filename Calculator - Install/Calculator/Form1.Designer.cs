namespace Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnBang = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.btnDot = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btnCube = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnSqrt = new System.Windows.Forms.Button();
            this.btnGT = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblCal = new System.Windows.Forms.Label();
            this.btnMoNgoac = new System.Windows.Forms.Button();
            this.btnDongNgoac = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtHT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBang
            // 
            this.btnBang.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBang.Location = new System.Drawing.Point(341, 467);
            this.btnBang.Margin = new System.Windows.Forms.Padding(4);
            this.btnBang.Name = "btnBang";
            this.btnBang.Size = new System.Drawing.Size(68, 48);
            this.btnBang.TabIndex = 84;
            this.btnBang.Text = "=";
            this.btnBang.UseVisualStyleBackColor = true;
            this.btnBang.Click += new System.EventHandler(this.btnBang_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(341, 299);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 48);
            this.btnClear.TabIndex = 82;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCong
            // 
            this.btnCong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCong.Location = new System.Drawing.Point(259, 467);
            this.btnCong.Margin = new System.Windows.Forms.Padding(4);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(68, 48);
            this.btnCong.TabIndex = 81;
            this.btnCong.Tag = "";
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.Cal_Click);
            this.btnCong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // btnTru
            // 
            this.btnTru.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTru.Location = new System.Drawing.Point(259, 411);
            this.btnTru.Margin = new System.Windows.Forms.Padding(4);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(68, 48);
            this.btnTru.TabIndex = 80;
            this.btnTru.Tag = "";
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.Cal_Click);
            this.btnTru.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // btnNhan
            // 
            this.btnNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhan.Location = new System.Drawing.Point(259, 355);
            this.btnNhan.Margin = new System.Windows.Forms.Padding(4);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(68, 48);
            this.btnNhan.TabIndex = 79;
            this.btnNhan.Tag = "";
            this.btnNhan.Text = "*";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.Cal_Click);
            this.btnNhan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // btnChia
            // 
            this.btnChia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChia.Location = new System.Drawing.Point(259, 298);
            this.btnChia.Margin = new System.Windows.Forms.Padding(4);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(68, 48);
            this.btnChia.TabIndex = 78;
            this.btnChia.Tag = "";
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.Cal_Click);
            this.btnChia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // btnDot
            // 
            this.btnDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDot.Location = new System.Drawing.Point(177, 467);
            this.btnDot.Margin = new System.Windows.Forms.Padding(4);
            this.btnDot.Name = "btnDot";
            this.btnDot.Size = new System.Drawing.Size(68, 48);
            this.btnDot.TabIndex = 76;
            this.btnDot.Text = ".";
            this.btnDot.UseVisualStyleBackColor = true;
            this.btnDot.Click += new System.EventHandler(this.button_click);
            this.btnDot.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(177, 411);
            this.btn3.Margin = new System.Windows.Forms.Padding(4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(68, 48);
            this.btn3.TabIndex = 75;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.button_click);
            this.btn3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(177, 355);
            this.btn6.Margin = new System.Windows.Forms.Padding(4);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(68, 48);
            this.btn6.TabIndex = 74;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.button_click);
            this.btn6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(177, 299);
            this.btn9.Margin = new System.Windows.Forms.Padding(4);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(68, 48);
            this.btn9.TabIndex = 77;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.button_click);
            this.btn9.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(95, 411);
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(68, 48);
            this.btn2.TabIndex = 73;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.button_click);
            this.btn2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(95, 355);
            this.btn5.Margin = new System.Windows.Forms.Padding(4);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(68, 48);
            this.btn5.TabIndex = 72;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.button_click);
            this.btn5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(95, 299);
            this.btn8.Margin = new System.Windows.Forms.Padding(4);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(68, 48);
            this.btn8.TabIndex = 71;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.button_click);
            this.btn8.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(13, 467);
            this.btn0.Margin = new System.Windows.Forms.Padding(4);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(150, 48);
            this.btn0.TabIndex = 70;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.button_click);
            this.btn0.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(13, 411);
            this.btn1.Margin = new System.Windows.Forms.Padding(4);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(68, 48);
            this.btn1.TabIndex = 69;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.button_click);
            this.btn1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(13, 355);
            this.btn4.Margin = new System.Windows.Forms.Padding(4);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(68, 48);
            this.btn4.TabIndex = 68;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.button_click);
            this.btn4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(13, 299);
            this.btn7.Margin = new System.Windows.Forms.Padding(4);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(68, 48);
            this.btn7.TabIndex = 67;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.button_click);
            this.btn7.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // btnCube
            // 
            this.btnCube.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCube.Location = new System.Drawing.Point(259, 243);
            this.btnCube.Margin = new System.Windows.Forms.Padding(4);
            this.btnCube.Name = "btnCube";
            this.btnCube.Size = new System.Drawing.Size(68, 48);
            this.btnCube.TabIndex = 65;
            this.btnCube.Tag = "";
            this.btnCube.Text = "^3";
            this.btnCube.UseVisualStyleBackColor = true;
            this.btnCube.Click += new System.EventHandler(this.btnCube_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSquare.Location = new System.Drawing.Point(177, 243);
            this.btnSquare.Margin = new System.Windows.Forms.Padding(4);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(68, 48);
            this.btnSquare.TabIndex = 64;
            this.btnSquare.Text = "^2";
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnSqrt
            // 
            this.btnSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSqrt.Location = new System.Drawing.Point(95, 243);
            this.btnSqrt.Margin = new System.Windows.Forms.Padding(4);
            this.btnSqrt.Name = "btnSqrt";
            this.btnSqrt.Size = new System.Drawing.Size(68, 48);
            this.btnSqrt.TabIndex = 63;
            this.btnSqrt.Text = "√";
            this.btnSqrt.UseVisualStyleBackColor = true;
            this.btnSqrt.Click += new System.EventHandler(this.btnSqrt_Click);
            // 
            // btnGT
            // 
            this.btnGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGT.Location = new System.Drawing.Point(13, 243);
            this.btnGT.Margin = new System.Windows.Forms.Padding(4);
            this.btnGT.Name = "btnGT";
            this.btnGT.Size = new System.Drawing.Size(68, 48);
            this.btnGT.TabIndex = 62;
            this.btnGT.Text = "!";
            this.btnGT.UseVisualStyleBackColor = true;
            this.btnGT.Click += new System.EventHandler(this.btnGT_Click);
            this.btnGT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // txtDisplay
            // 
            this.txtDisplay.BackColor = System.Drawing.Color.Azure;
            this.txtDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisplay.Location = new System.Drawing.Point(13, 57);
            this.txtDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.txtDisplay.Multiline = true;
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(396, 75);
            this.txtDisplay.TabIndex = 86;
            this.txtDisplay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDisplay_KeyPress_1);
            // 
            // txtResult
            // 
            this.txtResult.BackColor = System.Drawing.Color.Azure;
            this.txtResult.Enabled = false;
            this.txtResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.Location = new System.Drawing.Point(13, 179);
            this.txtResult.Margin = new System.Windows.Forms.Padding(4);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(396, 32);
            this.txtResult.TabIndex = 85;
            this.txtResult.Text = "0";
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblCal
            // 
            this.lblCal.AutoSize = true;
            this.lblCal.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCal.ForeColor = System.Drawing.Color.Blue;
            this.lblCal.Location = new System.Drawing.Point(136, 9);
            this.lblCal.Name = "lblCal";
            this.lblCal.Size = new System.Drawing.Size(157, 39);
            this.lblCal.TabIndex = 87;
            this.lblCal.Text = "Calculator";
            // 
            // btnMoNgoac
            // 
            this.btnMoNgoac.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoNgoac.Location = new System.Drawing.Point(341, 355);
            this.btnMoNgoac.Margin = new System.Windows.Forms.Padding(4);
            this.btnMoNgoac.Name = "btnMoNgoac";
            this.btnMoNgoac.Size = new System.Drawing.Size(68, 48);
            this.btnMoNgoac.TabIndex = 88;
            this.btnMoNgoac.Text = "(";
            this.btnMoNgoac.UseVisualStyleBackColor = true;
            this.btnMoNgoac.Click += new System.EventHandler(this.btnMoNgoac_Click);
            this.btnMoNgoac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // btnDongNgoac
            // 
            this.btnDongNgoac.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDongNgoac.Location = new System.Drawing.Point(341, 411);
            this.btnDongNgoac.Margin = new System.Windows.Forms.Padding(4);
            this.btnDongNgoac.Name = "btnDongNgoac";
            this.btnDongNgoac.Size = new System.Drawing.Size(68, 48);
            this.btnDongNgoac.TabIndex = 89;
            this.btnDongNgoac.Text = ")";
            this.btnDongNgoac.UseVisualStyleBackColor = true;
            this.btnDongNgoac.Click += new System.EventHandler(this.btnDongNgoac_Click);
            this.btnDongNgoac.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.button_KeyPress);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(341, 243);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(68, 48);
            this.btnBack.TabIndex = 94;
            this.btnBack.Text = "<--";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtHT
            // 
            this.txtHT.BackColor = System.Drawing.Color.Azure;
            this.txtHT.Enabled = false;
            this.txtHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHT.Location = new System.Drawing.Point(13, 140);
            this.txtHT.Margin = new System.Windows.Forms.Padding(4);
            this.txtHT.Multiline = true;
            this.txtHT.Name = "txtHT";
            this.txtHT.Size = new System.Drawing.Size(396, 32);
            this.txtHT.TabIndex = 95;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 527);
            this.Controls.Add(this.txtHT);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDongNgoac);
            this.Controls.Add(this.btnMoNgoac);
            this.Controls.Add(this.lblCal);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnBang);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnDot);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btnCube);
            this.Controls.Add(this.btnSquare);
            this.Controls.Add(this.btnSqrt);
            this.Controls.Add(this.btnGT);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBang;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnDot;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btnCube;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnSqrt;
        private System.Windows.Forms.Button btnGT;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblCal;
        private System.Windows.Forms.Button btnMoNgoac;
        private System.Windows.Forms.Button btnDongNgoac;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtHT;
    }
}

