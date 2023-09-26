namespace Calculator_WinForm
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
            this.btn_1 = new System.Windows.Forms.Button();
            this.Lbl_nummbers = new System.Windows.Forms.Label();
            this.btb_2 = new System.Windows.Forms.Button();
            this.btn_3 = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btn_4 = new System.Windows.Forms.Button();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_6 = new System.Windows.Forms.Button();
            this.btn_7 = new System.Windows.Forms.Button();
            this.btn_8 = new System.Windows.Forms.Button();
            this.btn_9 = new System.Windows.Forms.Button();
            this.btn_0 = new System.Windows.Forms.Button();
            this.btn_c = new System.Windows.Forms.Button();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.minus = new System.Windows.Forms.Button();
            this.mal_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(12, 118);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(158, 67);
            this.btn_1.TabIndex = 0;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Lbl_nummbers
            // 
            this.Lbl_nummbers.AutoSize = true;
            this.Lbl_nummbers.Location = new System.Drawing.Point(21, 50);
            this.Lbl_nummbers.Name = "Lbl_nummbers";
            this.Lbl_nummbers.Size = new System.Drawing.Size(0, 25);
            this.Lbl_nummbers.TabIndex = 1;
            this.Lbl_nummbers.Click += new System.EventHandler(this.label1_Click);
            // 
            // btb_2
            // 
            this.btb_2.Location = new System.Drawing.Point(177, 118);
            this.btb_2.Name = "btb_2";
            this.btb_2.Size = new System.Drawing.Size(157, 67);
            this.btb_2.TabIndex = 3;
            this.btb_2.Text = "2";
            this.btb_2.UseVisualStyleBackColor = true;
            this.btb_2.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btn_3
            // 
            this.btn_3.Location = new System.Drawing.Point(340, 118);
            this.btn_3.Name = "btn_3";
            this.btn_3.Size = new System.Drawing.Size(130, 67);
            this.btn_3.TabIndex = 4;
            this.btn_3.Text = "3";
            this.btn_3.UseVisualStyleBackColor = true;
            this.btn_3.Click += new System.EventHandler(this.btn_3_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(12, 79);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(458, 31);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.TextChanged += new System.EventHandler(this.nummern_TextChanged);
            // 
            // btn_4
            // 
            this.btn_4.Location = new System.Drawing.Point(12, 192);
            this.btn_4.Name = "btn_4";
            this.btn_4.Size = new System.Drawing.Size(158, 67);
            this.btn_4.TabIndex = 7;
            this.btn_4.Text = "4";
            this.btn_4.UseVisualStyleBackColor = true;
            this.btn_4.Click += new System.EventHandler(this.btn_4_Click);
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(177, 192);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(157, 67);
            this.btn_5.TabIndex = 8;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_6
            // 
            this.btn_6.Location = new System.Drawing.Point(341, 192);
            this.btn_6.Name = "btn_6";
            this.btn_6.Size = new System.Drawing.Size(129, 67);
            this.btn_6.TabIndex = 9;
            this.btn_6.Text = "6";
            this.btn_6.UseVisualStyleBackColor = true;
            this.btn_6.Click += new System.EventHandler(this.btn_6_Click);
            // 
            // btn_7
            // 
            this.btn_7.Location = new System.Drawing.Point(12, 265);
            this.btn_7.Name = "btn_7";
            this.btn_7.Size = new System.Drawing.Size(158, 59);
            this.btn_7.TabIndex = 10;
            this.btn_7.Text = "7";
            this.btn_7.UseVisualStyleBackColor = true;
            this.btn_7.Click += new System.EventHandler(this.btn_7_Click);
            // 
            // btn_8
            // 
            this.btn_8.Location = new System.Drawing.Point(177, 265);
            this.btn_8.Name = "btn_8";
            this.btn_8.Size = new System.Drawing.Size(157, 59);
            this.btn_8.TabIndex = 11;
            this.btn_8.Text = "8";
            this.btn_8.UseVisualStyleBackColor = true;
            this.btn_8.Click += new System.EventHandler(this.btn_8_Click);
            // 
            // btn_9
            // 
            this.btn_9.Location = new System.Drawing.Point(340, 266);
            this.btn_9.Name = "btn_9";
            this.btn_9.Size = new System.Drawing.Size(130, 58);
            this.btn_9.TabIndex = 12;
            this.btn_9.Text = "9";
            this.btn_9.UseVisualStyleBackColor = true;
            this.btn_9.Click += new System.EventHandler(this.btn_9_Click);
            // 
            // btn_0
            // 
            this.btn_0.Location = new System.Drawing.Point(177, 331);
            this.btn_0.Name = "btn_0";
            this.btn_0.Size = new System.Drawing.Size(157, 67);
            this.btn_0.TabIndex = 13;
            this.btn_0.Text = "0";
            this.btn_0.UseVisualStyleBackColor = true;
            this.btn_0.Click += new System.EventHandler(this.btn_0_Click);
            // 
            // btn_c
            // 
            this.btn_c.Location = new System.Drawing.Point(12, 331);
            this.btn_c.Name = "btn_c";
            this.btn_c.Size = new System.Drawing.Size(158, 67);
            this.btn_c.TabIndex = 14;
            this.btn_c.Text = "C";
            this.btn_c.UseVisualStyleBackColor = true;
            this.btn_c.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // btn_Enter
            // 
            this.btn_Enter.Location = new System.Drawing.Point(340, 331);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(130, 67);
            this.btn_Enter.TabIndex = 15;
            this.btn_Enter.Text = "Enter";
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.Location = new System.Drawing.Point(476, 118);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(112, 141);
            this.btn_plus.TabIndex = 16;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // minus
            // 
            this.minus.Location = new System.Drawing.Point(477, 266);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(111, 58);
            this.minus.TabIndex = 17;
            this.minus.Text = "-";
            this.minus.UseVisualStyleBackColor = true;
            this.minus.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // mal_btn
            // 
            this.mal_btn.Location = new System.Drawing.Point(477, 331);
            this.mal_btn.Name = "mal_btn";
            this.mal_btn.Size = new System.Drawing.Size(111, 67);
            this.mal_btn.TabIndex = 18;
            this.mal_btn.Text = "*";
            this.mal_btn.UseVisualStyleBackColor = true;
            this.mal_btn.Click += new System.EventHandler(this.mal_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mal_btn);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.btn_c);
            this.Controls.Add(this.btn_0);
            this.Controls.Add(this.btn_9);
            this.Controls.Add(this.btn_8);
            this.Controls.Add(this.btn_7);
            this.Controls.Add(this.btn_6);
            this.Controls.Add(this.btn_5);
            this.Controls.Add(this.btn_4);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btn_3);
            this.Controls.Add(this.btb_2);
            this.Controls.Add(this.Lbl_nummbers);
            this.Controls.Add(this.btn_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.Label Lbl_nummbers;
        private System.Windows.Forms.Button btb_2;
        private System.Windows.Forms.Button btn_3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btn_4;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_6;
        private System.Windows.Forms.Button btn_7;
        private System.Windows.Forms.Button btn_8;
        private System.Windows.Forms.Button btn_9;
        private System.Windows.Forms.Button btn_0;
        private System.Windows.Forms.Button btn_c;
        private System.Windows.Forms.Button btn_Enter;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.Button minus;
        private System.Windows.Forms.Button mal_btn;
    }
}

