namespace FormsN1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.txtsuma = new System.Windows.Forms.TextBox();
            this.txtresta = new System.Windows.Forms.TextBox();
            this.txtmulti = new System.Windows.Forms.TextBox();
            this.txtdivi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btncalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "NUMERO 1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(88, 14);
            this.txtn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(137, 23);
            this.txtn1.TabIndex = 1;
            this.txtn1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(88, 46);
            this.txtn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(137, 23);
            this.txtn2.TabIndex = 2;
            // 
            // txtsuma
            // 
            this.txtsuma.Location = new System.Drawing.Point(88, 80);
            this.txtsuma.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsuma.Name = "txtsuma";
            this.txtsuma.ReadOnly = true;
            this.txtsuma.Size = new System.Drawing.Size(137, 23);
            this.txtsuma.TabIndex = 3;
            this.txtsuma.TextChanged += new System.EventHandler(this.txtsuma_TextChanged);
            // 
            // txtresta
            // 
            this.txtresta.Location = new System.Drawing.Point(88, 112);
            this.txtresta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtresta.Name = "txtresta";
            this.txtresta.ReadOnly = true;
            this.txtresta.Size = new System.Drawing.Size(137, 23);
            this.txtresta.TabIndex = 4;
            // 
            // txtmulti
            // 
            this.txtmulti.Location = new System.Drawing.Point(88, 144);
            this.txtmulti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmulti.Name = "txtmulti";
            this.txtmulti.ReadOnly = true;
            this.txtmulti.Size = new System.Drawing.Size(137, 23);
            this.txtmulti.TabIndex = 5;
            this.txtmulti.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // txtdivi
            // 
            this.txtdivi.Location = new System.Drawing.Point(88, 179);
            this.txtdivi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdivi.Name = "txtdivi";
            this.txtdivi.ReadOnly = true;
            this.txtdivi.Size = new System.Drawing.Size(137, 23);
            this.txtdivi.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "NUMERO 2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Suma";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Resta";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Multiply";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Division";
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(43, 233);
            this.btncalcular.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(257, 21);
            this.btncalcular.TabIndex = 12;
            this.btncalcular.Text = "CALCULAR";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(333, 338);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtdivi);
            this.Controls.Add(this.txtmulti);
            this.Controls.Add(this.txtresta);
            this.Controls.Add(this.txtsuma);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "MINI CALCULADORA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtn1;
        private TextBox txtn2;
        private TextBox txtsuma;
        private TextBox txtresta;
        private TextBox txtmulti;
        private TextBox txtdivi;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btncalcular;
    }
}