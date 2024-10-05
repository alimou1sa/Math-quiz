namespace project_6_math_quize
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbmix = new System.Windows.Forms.RadioButton();
            this.rdbeasy = new System.Windows.Forms.RadioButton();
            this.rdbmed = new System.Windows.Forms.RadioButton();
            this.rdbHard = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbdiv = new System.Windows.Forms.RadioButton();
            this.rdbmixe = new System.Windows.Forms.RadioButton();
            this.rdbsub = new System.Windows.Forms.RadioButton();
            this.rdbmul = new System.Windows.Forms.RadioButton();
            this.rdbadd = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.lbnumber1 = new System.Windows.Forms.Label();
            this.lbnumber2 = new System.Windows.Forms.Label();
            this.lboperation = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtinputresult = new System.Windows.Forms.TextBox();
            this.btnresult = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(21, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the number of questions\r\n";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Green;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(28, 141);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 47);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "3";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Goldenrod;
            this.button1.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(423, 533);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(281, 96);
            this.button1.TabIndex = 2;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(17, 424);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(298, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enster questions level";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbmix);
            this.groupBox1.Controls.Add(this.rdbeasy);
            this.groupBox1.Controls.Add(this.rdbmed);
            this.groupBox1.Controls.Add(this.rdbHard);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(24, 460);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 142);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "levels";
            // 
            // rdbmix
            // 
            this.rdbmix.AutoSize = true;
            this.rdbmix.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbmix.Location = new System.Drawing.Point(153, 94);
            this.rdbmix.Name = "rdbmix";
            this.rdbmix.Size = new System.Drawing.Size(63, 26);
            this.rdbmix.TabIndex = 3;
            this.rdbmix.TabStop = true;
            this.rdbmix.Text = "Mix";
            this.rdbmix.UseVisualStyleBackColor = true;
            // 
            // rdbeasy
            // 
            this.rdbeasy.AutoSize = true;
            this.rdbeasy.Checked = true;
            this.rdbeasy.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbeasy.Location = new System.Drawing.Point(153, 35);
            this.rdbeasy.Name = "rdbeasy";
            this.rdbeasy.Size = new System.Drawing.Size(69, 26);
            this.rdbeasy.TabIndex = 2;
            this.rdbeasy.TabStop = true;
            this.rdbeasy.Text = "Easy";
            this.rdbeasy.UseVisualStyleBackColor = true;
            // 
            // rdbmed
            // 
            this.rdbmed.AutoSize = true;
            this.rdbmed.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbmed.Location = new System.Drawing.Point(16, 94);
            this.rdbmed.Name = "rdbmed";
            this.rdbmed.Size = new System.Drawing.Size(63, 24);
            this.rdbmed.TabIndex = 1;
            this.rdbmed.TabStop = true;
            this.rdbmed.Text = "Med";
            this.rdbmed.UseVisualStyleBackColor = true;
            // 
            // rdbHard
            // 
            this.rdbHard.AutoSize = true;
            this.rdbHard.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHard.Location = new System.Drawing.Point(16, 35);
            this.rdbHard.Name = "rdbHard";
            this.rdbHard.Size = new System.Drawing.Size(71, 26);
            this.rdbHard.TabIndex = 0;
            this.rdbHard.TabStop = true;
            this.rdbHard.Text = "Hard";
            this.rdbHard.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Gold;
            this.label3.Location = new System.Drawing.Point(18, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enster operation type";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbdiv);
            this.groupBox2.Controls.Add(this.rdbmixe);
            this.groupBox2.Controls.Add(this.rdbsub);
            this.groupBox2.Controls.Add(this.rdbmul);
            this.groupBox2.Controls.Add(this.rdbadd);
            this.groupBox2.Location = new System.Drawing.Point(24, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 142);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Operations type";
            // 
            // rdbdiv
            // 
            this.rdbdiv.AutoSize = true;
            this.rdbdiv.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbdiv.Location = new System.Drawing.Point(191, 96);
            this.rdbdiv.Name = "rdbdiv";
            this.rdbdiv.Size = new System.Drawing.Size(61, 26);
            this.rdbdiv.TabIndex = 4;
            this.rdbdiv.TabStop = true;
            this.rdbdiv.Text = "Div";
            this.rdbdiv.UseVisualStyleBackColor = true;
            // 
            // rdbmixe
            // 
            this.rdbmixe.AutoSize = true;
            this.rdbmixe.Checked = true;
            this.rdbmixe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbmixe.Location = new System.Drawing.Point(107, 61);
            this.rdbmixe.Name = "rdbmixe";
            this.rdbmixe.Size = new System.Drawing.Size(63, 26);
            this.rdbmixe.TabIndex = 3;
            this.rdbmixe.TabStop = true;
            this.rdbmixe.Text = "Mix";
            this.rdbmixe.UseVisualStyleBackColor = true;
            // 
            // rdbsub
            // 
            this.rdbsub.AutoSize = true;
            this.rdbsub.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbsub.Location = new System.Drawing.Point(191, 23);
            this.rdbsub.Name = "rdbsub";
            this.rdbsub.Size = new System.Drawing.Size(61, 26);
            this.rdbsub.TabIndex = 2;
            this.rdbsub.TabStop = true;
            this.rdbsub.Text = "Sub";
            this.rdbsub.UseVisualStyleBackColor = true;
            // 
            // rdbmul
            // 
            this.rdbmul.AutoSize = true;
            this.rdbmul.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbmul.Location = new System.Drawing.Point(16, 96);
            this.rdbmul.Name = "rdbmul";
            this.rdbmul.Size = new System.Drawing.Size(59, 24);
            this.rdbmul.TabIndex = 1;
            this.rdbmul.TabStop = true;
            this.rdbmul.Text = "Mul";
            this.rdbmul.UseVisualStyleBackColor = true;
            // 
            // rdbadd
            // 
            this.rdbadd.AutoSize = true;
            this.rdbadd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbadd.Location = new System.Drawing.Point(16, 23);
            this.rdbadd.Name = "rdbadd";
            this.rdbadd.Size = new System.Drawing.Size(65, 26);
            this.rdbadd.TabIndex = 0;
            this.rdbadd.TabStop = true;
            this.rdbadd.Text = "Add";
            this.rdbadd.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Viner Hand ITC", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(217, -2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(652, 97);
            this.label4.TabIndex = 6;
            this.label4.Text = "MATH QUIZE GAME";
            // 
            // lbnumber1
            // 
            this.lbnumber1.AutoSize = true;
            this.lbnumber1.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnumber1.Location = new System.Drawing.Point(679, 95);
            this.lbnumber1.Name = "lbnumber1";
            this.lbnumber1.Size = new System.Drawing.Size(0, 97);
            this.lbnumber1.TabIndex = 7;
            // 
            // lbnumber2
            // 
            this.lbnumber2.AutoSize = true;
            this.lbnumber2.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnumber2.Location = new System.Drawing.Point(681, 265);
            this.lbnumber2.Name = "lbnumber2";
            this.lbnumber2.Size = new System.Drawing.Size(0, 97);
            this.lbnumber2.TabIndex = 8;
            // 
            // lboperation
            // 
            this.lboperation.AutoSize = true;
            this.lboperation.Font = new System.Drawing.Font("Tahoma", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lboperation.Location = new System.Drawing.Point(672, 179);
            this.lboperation.Name = "lboperation";
            this.lboperation.Size = new System.Drawing.Size(0, 97);
            this.lboperation.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(631, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(393, 72);
            this.label8.TabIndex = 10;
            this.label8.Text = "___________";
            // 
            // txtinputresult
            // 
            this.txtinputresult.Font = new System.Drawing.Font("Tahoma", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinputresult.Location = new System.Drawing.Point(640, 422);
            this.txtinputresult.Name = "txtinputresult";
            this.txtinputresult.Size = new System.Drawing.Size(266, 80);
            this.txtinputresult.TabIndex = 11;
            // 
            // btnresult
            // 
            this.btnresult.BackColor = System.Drawing.Color.Goldenrod;
            this.btnresult.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnresult.Location = new System.Drawing.Point(902, 422);
            this.btnresult.Name = "btnresult";
            this.btnresult.Size = new System.Drawing.Size(91, 65);
            this.btnresult.TabIndex = 12;
            this.btnresult.Text = "OK";
            this.btnresult.UseVisualStyleBackColor = false;
            this.btnresult.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(368, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 45);
            this.label5.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(368, 296);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 45);
            this.label6.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1042, 662);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnresult);
            this.Controls.Add(this.txtinputresult);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lboperation);
            this.Controls.Add(this.lbnumber2);
            this.Controls.Add(this.lbnumber1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbmix;
        private System.Windows.Forms.RadioButton rdbeasy;
        private System.Windows.Forms.RadioButton rdbmed;
        private System.Windows.Forms.RadioButton rdbHard;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbmixe;
        private System.Windows.Forms.RadioButton rdbsub;
        private System.Windows.Forms.RadioButton rdbmul;
        private System.Windows.Forms.RadioButton rdbadd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbdiv;
        private System.Windows.Forms.Label lbnumber1;
        private System.Windows.Forms.Label lbnumber2;
        private System.Windows.Forms.Label lboperation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtinputresult;
        private System.Windows.Forms.Button btnresult;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

