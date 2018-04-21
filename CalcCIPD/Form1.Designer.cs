namespace CalcCIPD
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbProgramEuroFaraTVA = new System.Windows.Forms.TextBox();
            this.tbMembershipEuroFaraTVA = new System.Windows.Forms.TextBox();
            this.btSumaTotalFaraTVA = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCostTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbProcentDiscount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btSumaCuDiscount = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbCostTotalCuDiscount = new System.Windows.Forms.Label();
            this.cb4Rate = new System.Windows.Forms.CheckBox();
            this.cb5Rate = new System.Windows.Forms.CheckBox();
            this.cb6Rate = new System.Windows.Forms.CheckBox();
            this.cb7Rate = new System.Windows.Forms.CheckBox();
            this.btCalculRate = new System.Windows.Forms.Button();
            this.lbCalculRate = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduceți costul programului în Euro fără TVA inclus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(320, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Introduceți taxa de Student Member CIPD în Euro fără TVA inclus:";
            // 
            // tbProgramEuroFaraTVA
            // 
            this.tbProgramEuroFaraTVA.Location = new System.Drawing.Point(353, 32);
            this.tbProgramEuroFaraTVA.Name = "tbProgramEuroFaraTVA";
            this.tbProgramEuroFaraTVA.Size = new System.Drawing.Size(107, 20);
            this.tbProgramEuroFaraTVA.TabIndex = 2;
            // 
            // tbMembershipEuroFaraTVA
            // 
            this.tbMembershipEuroFaraTVA.Location = new System.Drawing.Point(365, 61);
            this.tbMembershipEuroFaraTVA.Name = "tbMembershipEuroFaraTVA";
            this.tbMembershipEuroFaraTVA.Size = new System.Drawing.Size(107, 20);
            this.tbMembershipEuroFaraTVA.TabIndex = 3;
            // 
            // btSumaTotalFaraTVA
            // 
            this.btSumaTotalFaraTVA.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btSumaTotalFaraTVA.Location = new System.Drawing.Point(45, 93);
            this.btSumaTotalFaraTVA.Name = "btSumaTotalFaraTVA";
            this.btSumaTotalFaraTVA.Size = new System.Drawing.Size(75, 23);
            this.btSumaTotalFaraTVA.TabIndex = 4;
            this.btSumaTotalFaraTVA.Text = "Calculează";
            this.btSumaTotalFaraTVA.UseVisualStyleBackColor = false;
            this.btSumaTotalFaraTVA.Click += new System.EventHandler(this.btSumaTotalFaraTVA_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(126, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Total costuri: ";
            // 
            // lbCostTotal
            // 
            this.lbCostTotal.AutoSize = true;
            this.lbCostTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCostTotal.Location = new System.Drawing.Point(217, 98);
            this.lbCostTotal.Name = "lbCostTotal";
            this.lbCostTotal.Size = new System.Drawing.Size(99, 13);
            this.lbCostTotal.TabIndex = 6;
            this.lbCostTotal.Text = "Se calculează...";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Discount:";
            // 
            // tbProcentDiscount
            // 
            this.tbProcentDiscount.Location = new System.Drawing.Point(103, 123);
            this.tbProcentDiscount.Name = "tbProcentDiscount";
            this.tbProcentDiscount.Size = new System.Drawing.Size(34, 20);
            this.tbProcentDiscount.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(143, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(466, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 10;
            this.label7.Text = "Euro + TVA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(478, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 16);
            this.label8.TabIndex = 11;
            this.label8.Text = "Euro + TVA";
            // 
            // btSumaCuDiscount
            // 
            this.btSumaCuDiscount.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btSumaCuDiscount.Location = new System.Drawing.Point(177, 121);
            this.btSumaCuDiscount.Name = "btSumaCuDiscount";
            this.btSumaCuDiscount.Size = new System.Drawing.Size(75, 23);
            this.btSumaCuDiscount.TabIndex = 12;
            this.btSumaCuDiscount.Text = "Calculează";
            this.btSumaCuDiscount.UseVisualStyleBackColor = false;
            this.btSumaCuDiscount.Click += new System.EventHandler(this.btSumaCuDiscount_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(279, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(283, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Cost program (fără Taxa Membru CIPD) cu discount inclus:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(42, 182);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Variantă de plată în rate:";
            // 
            // lbCostTotalCuDiscount
            // 
            this.lbCostTotalCuDiscount.AutoSize = true;
            this.lbCostTotalCuDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCostTotalCuDiscount.Location = new System.Drawing.Point(279, 151);
            this.lbCostTotalCuDiscount.Name = "lbCostTotalCuDiscount";
            this.lbCostTotalCuDiscount.Size = new System.Drawing.Size(99, 13);
            this.lbCostTotalCuDiscount.TabIndex = 15;
            this.lbCostTotalCuDiscount.Text = "Se calculează...";
            // 
            // cb4Rate
            // 
            this.cb4Rate.AutoSize = true;
            this.cb4Rate.Location = new System.Drawing.Point(42, 208);
            this.cb4Rate.Name = "cb4Rate";
            this.cb4Rate.Size = new System.Drawing.Size(58, 17);
            this.cb4Rate.TabIndex = 17;
            this.cb4Rate.Text = "4 Rate";
            this.cb4Rate.UseVisualStyleBackColor = true;
            // 
            // cb5Rate
            // 
            this.cb5Rate.AutoSize = true;
            this.cb5Rate.Location = new System.Drawing.Point(105, 208);
            this.cb5Rate.Name = "cb5Rate";
            this.cb5Rate.Size = new System.Drawing.Size(58, 17);
            this.cb5Rate.TabIndex = 18;
            this.cb5Rate.Text = "5 Rate";
            this.cb5Rate.UseVisualStyleBackColor = true;
            // 
            // cb6Rate
            // 
            this.cb6Rate.AutoSize = true;
            this.cb6Rate.Location = new System.Drawing.Point(169, 208);
            this.cb6Rate.Name = "cb6Rate";
            this.cb6Rate.Size = new System.Drawing.Size(58, 17);
            this.cb6Rate.TabIndex = 19;
            this.cb6Rate.Text = "6 Rate";
            this.cb6Rate.UseVisualStyleBackColor = true;
            // 
            // cb7Rate
            // 
            this.cb7Rate.AutoSize = true;
            this.cb7Rate.Location = new System.Drawing.Point(233, 208);
            this.cb7Rate.Name = "cb7Rate";
            this.cb7Rate.Size = new System.Drawing.Size(58, 17);
            this.cb7Rate.TabIndex = 20;
            this.cb7Rate.Text = "7 Rate";
            this.cb7Rate.UseVisualStyleBackColor = true;
            // 
            // btCalculRate
            // 
            this.btCalculRate.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btCalculRate.Location = new System.Drawing.Point(297, 202);
            this.btCalculRate.Name = "btCalculRate";
            this.btCalculRate.Size = new System.Drawing.Size(75, 23);
            this.btCalculRate.TabIndex = 21;
            this.btCalculRate.Text = "Calculează";
            this.btCalculRate.UseVisualStyleBackColor = false;
            this.btCalculRate.Click += new System.EventHandler(this.btCalculRate_Click);
            // 
            // lbCalculRate
            // 
            this.lbCalculRate.AutoSize = true;
            this.lbCalculRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalculRate.Location = new System.Drawing.Point(39, 251);
            this.lbCalculRate.Name = "lbCalculRate";
            this.lbCalculRate.Size = new System.Drawing.Size(99, 13);
            this.lbCalculRate.TabIndex = 22;
            this.lbCalculRate.Text = "Se calculează...";
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(42, 307);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 23);
            this.btReset.TabIndex = 23;
            this.btReset.Text = "Resetează";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::CalcCIPD.Properties.Resources.Noosfera_logo_white_landscape_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = global::CalcCIPD.Properties.Resources.Noosfera_logo_white_landscape_1;
            this.pictureBox1.Location = new System.Drawing.Point(469, 251);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 79);
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(564, 314);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(161, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "Developed by Andrei Roca";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(794, 373);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.lbCalculRate);
            this.Controls.Add(this.btCalculRate);
            this.Controls.Add(this.cb7Rate);
            this.Controls.Add(this.cb6Rate);
            this.Controls.Add(this.cb5Rate);
            this.Controls.Add(this.cb4Rate);
            this.Controls.Add(this.lbCostTotalCuDiscount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btSumaCuDiscount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbProcentDiscount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbCostTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btSumaTotalFaraTVA);
            this.Controls.Add(this.tbMembershipEuroFaraTVA);
            this.Controls.Add(this.tbProgramEuroFaraTVA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator CIPD";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbProgramEuroFaraTVA;
        private System.Windows.Forms.TextBox tbMembershipEuroFaraTVA;
        private System.Windows.Forms.Button btSumaTotalFaraTVA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbCostTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbProcentDiscount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btSumaCuDiscount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbCostTotalCuDiscount;
        private System.Windows.Forms.CheckBox cb4Rate;
        private System.Windows.Forms.CheckBox cb5Rate;
        private System.Windows.Forms.CheckBox cb6Rate;
        private System.Windows.Forms.CheckBox cb7Rate;
        private System.Windows.Forms.Button btCalculRate;
        private System.Windows.Forms.Label lbCalculRate;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label11;
    }
}

