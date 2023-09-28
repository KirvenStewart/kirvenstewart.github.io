namespace Herramienta_ComboBox
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
            this.cbpro = new System.Windows.Forms.ComboBox();
            this.txtco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpre = new System.Windows.Forms.TextBox();
            this.txtimp = new System.Windows.Forms.TextBox();
            this.txtto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbpro
            // 
            this.cbpro.FormattingEnabled = true;
            this.cbpro.Items.AddRange(new object[] {
            "Huevo",
            "Arroz",
            "Aguacate",
            "Salsa",
            "Pollo",
            "Pechuga ",
            "Res",
            "Cubitos",
            "Caldo",
            "Consome"});
            this.cbpro.Location = new System.Drawing.Point(227, 73);
            this.cbpro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbpro.Name = "cbpro";
            this.cbpro.Size = new System.Drawing.Size(133, 23);
            this.cbpro.TabIndex = 0;
            // 
            // txtco
            // 
            this.txtco.Location = new System.Drawing.Point(227, 32);
            this.txtco.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtco.Name = "txtco";
            this.txtco.Size = new System.Drawing.Size(133, 23);
            this.txtco.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(137, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtpre
            // 
            this.txtpre.Location = new System.Drawing.Point(227, 111);
            this.txtpre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpre.Name = "txtpre";
            this.txtpre.Size = new System.Drawing.Size(133, 23);
            this.txtpre.TabIndex = 3;
            // 
            // txtimp
            // 
            this.txtimp.Location = new System.Drawing.Point(227, 150);
            this.txtimp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtimp.Name = "txtimp";
            this.txtimp.ReadOnly = true;
            this.txtimp.Size = new System.Drawing.Size(133, 23);
            this.txtimp.TabIndex = 4;
            // 
            // txtto
            // 
            this.txtto.Location = new System.Drawing.Point(227, 186);
            this.txtto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtto.Name = "txtto";
            this.txtto.ReadOnly = true;
            this.txtto.Size = new System.Drawing.Size(133, 23);
            this.txtto.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(121, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Producto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(147, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Precio";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(118, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Impuesto";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(88, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Total a Pagar";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(97, 262);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 39);
            this.button1.TabIndex = 10;
            this.button1.Text = "PAGAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RosyBrown;
            this.button2.ForeColor = System.Drawing.Color.Beige;
            this.button2.Location = new System.Drawing.Point(286, 269);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(74, 32);
            this.button2.TabIndex = 11;
            this.button2.Text = "SALIR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(700, 338);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtto);
            this.Controls.Add(this.txtimp);
            this.Controls.Add(this.txtpre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtco);
            this.Controls.Add(this.cbpro);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbpro;
        private TextBox txtco;
        private Label label1;
        private TextBox txtpre;
        private TextBox txtimp;
        private TextBox txtto;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}