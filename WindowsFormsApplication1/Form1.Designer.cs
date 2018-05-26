namespace WindowsFormsApplication1
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
            this.text_wynik = new System.Windows.Forms.TextBox();
            this.p7 = new System.Windows.Forms.Button();
            this.p8 = new System.Windows.Forms.Button();
            this.p9 = new System.Windows.Forms.Button();
            this.p6 = new System.Windows.Forms.Button();
            this.p5 = new System.Windows.Forms.Button();
            this.p4 = new System.Windows.Forms.Button();
            this.p3 = new System.Windows.Forms.Button();
            this.p2 = new System.Windows.Forms.Button();
            this.p1 = new System.Windows.Forms.Button();
            this.iloczyn = new System.Windows.Forms.Button();
            this.roznica = new System.Windows.Forms.Button();
            this.suma = new System.Windows.Forms.Button();
            this.iloraz = new System.Windows.Forms.Button();
            this.p0 = new System.Windows.Forms.Button();
            this.wynik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_wynik
            // 
            this.text_wynik.Location = new System.Drawing.Point(30, 12);
            this.text_wynik.Name = "text_wynik";
            this.text_wynik.Size = new System.Drawing.Size(149, 20);
            this.text_wynik.TabIndex = 0;
            this.text_wynik.TextChanged += new System.EventHandler(this.text_wynik_TextChanged);
            // 
            // p7
            // 
            this.p7.Location = new System.Drawing.Point(37, 47);
            this.p7.Name = "p7";
            this.p7.Size = new System.Drawing.Size(31, 31);
            this.p7.TabIndex = 1;
            this.p7.Text = "7";
            this.p7.UseVisualStyleBackColor = true;
            this.p7.Click += new System.EventHandler(this.p7_Click);
            // 
            // p8
            // 
            this.p8.Location = new System.Drawing.Point(74, 47);
            this.p8.Name = "p8";
            this.p8.Size = new System.Drawing.Size(31, 31);
            this.p8.TabIndex = 2;
            this.p8.Text = "8";
            this.p8.UseVisualStyleBackColor = true;
            this.p8.Click += new System.EventHandler(this.p8_Click);
            // 
            // p9
            // 
            this.p9.Location = new System.Drawing.Point(111, 47);
            this.p9.Name = "p9";
            this.p9.Size = new System.Drawing.Size(31, 31);
            this.p9.TabIndex = 3;
            this.p9.Text = "9";
            this.p9.UseVisualStyleBackColor = true;
            this.p9.Click += new System.EventHandler(this.p9_Click);
            // 
            // p6
            // 
            this.p6.Location = new System.Drawing.Point(111, 84);
            this.p6.Name = "p6";
            this.p6.Size = new System.Drawing.Size(31, 31);
            this.p6.TabIndex = 6;
            this.p6.Text = "6";
            this.p6.UseVisualStyleBackColor = true;
            this.p6.Click += new System.EventHandler(this.p6_Click);
            // 
            // p5
            // 
            this.p5.Location = new System.Drawing.Point(74, 84);
            this.p5.Name = "p5";
            this.p5.Size = new System.Drawing.Size(31, 31);
            this.p5.TabIndex = 5;
            this.p5.Text = "5";
            this.p5.UseVisualStyleBackColor = true;
            this.p5.Click += new System.EventHandler(this.p5_Click);
            // 
            // p4
            // 
            this.p4.Location = new System.Drawing.Point(37, 84);
            this.p4.Name = "p4";
            this.p4.Size = new System.Drawing.Size(31, 31);
            this.p4.TabIndex = 4;
            this.p4.Text = "4";
            this.p4.UseVisualStyleBackColor = true;
            this.p4.Click += new System.EventHandler(this.p4_Click);
            // 
            // p3
            // 
            this.p3.Location = new System.Drawing.Point(111, 121);
            this.p3.Name = "p3";
            this.p3.Size = new System.Drawing.Size(31, 31);
            this.p3.TabIndex = 9;
            this.p3.Text = "3";
            this.p3.UseVisualStyleBackColor = true;
            this.p3.Click += new System.EventHandler(this.p3_Click);
            // 
            // p2
            // 
            this.p2.Location = new System.Drawing.Point(74, 121);
            this.p2.Name = "p2";
            this.p2.Size = new System.Drawing.Size(31, 31);
            this.p2.TabIndex = 8;
            this.p2.Text = "2";
            this.p2.UseVisualStyleBackColor = true;
            this.p2.Click += new System.EventHandler(this.p2_Click);
            // 
            // p1
            // 
            this.p1.Location = new System.Drawing.Point(37, 121);
            this.p1.Name = "p1";
            this.p1.Size = new System.Drawing.Size(31, 31);
            this.p1.TabIndex = 7;
            this.p1.Text = "1";
            this.p1.UseVisualStyleBackColor = true;
            this.p1.Click += new System.EventHandler(this.p1_Click);
            // 
            // iloczyn
            // 
            this.iloczyn.Location = new System.Drawing.Point(148, 121);
            this.iloczyn.Name = "iloczyn";
            this.iloczyn.Size = new System.Drawing.Size(31, 31);
            this.iloczyn.TabIndex = 12;
            this.iloczyn.Text = "*";
            this.iloczyn.UseVisualStyleBackColor = true;
            this.iloczyn.Click += new System.EventHandler(this.iloczyn_Click);
            // 
            // roznica
            // 
            this.roznica.Location = new System.Drawing.Point(148, 84);
            this.roznica.Name = "roznica";
            this.roznica.Size = new System.Drawing.Size(31, 31);
            this.roznica.TabIndex = 11;
            this.roznica.Text = "-";
            this.roznica.UseVisualStyleBackColor = true;
            this.roznica.Click += new System.EventHandler(this.roznica_Click);
            // 
            // suma
            // 
            this.suma.Location = new System.Drawing.Point(148, 47);
            this.suma.Name = "suma";
            this.suma.Size = new System.Drawing.Size(31, 31);
            this.suma.TabIndex = 10;
            this.suma.Text = "+";
            this.suma.UseVisualStyleBackColor = true;
            this.suma.Click += new System.EventHandler(this.suma_Click);
            // 
            // iloraz
            // 
            this.iloraz.Location = new System.Drawing.Point(148, 158);
            this.iloraz.Name = "iloraz";
            this.iloraz.Size = new System.Drawing.Size(31, 31);
            this.iloraz.TabIndex = 14;
            this.iloraz.Text = "/";
            this.iloraz.UseVisualStyleBackColor = true;
            this.iloraz.Click += new System.EventHandler(this.iloraz_Click);
            // 
            // p0
            // 
            this.p0.Location = new System.Drawing.Point(111, 158);
            this.p0.Name = "p0";
            this.p0.Size = new System.Drawing.Size(31, 31);
            this.p0.TabIndex = 13;
            this.p0.Text = "0";
            this.p0.UseVisualStyleBackColor = true;
            this.p0.Click += new System.EventHandler(this.p0_Click);
            // 
            // wynik
            // 
            this.wynik.Location = new System.Drawing.Point(37, 158);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(68, 31);
            this.wynik.TabIndex = 15;
            this.wynik.Text = "=";
            this.wynik.UseVisualStyleBackColor = true;
            this.wynik.Click += new System.EventHandler(this.wynik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 223);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.iloraz);
            this.Controls.Add(this.p0);
            this.Controls.Add(this.iloczyn);
            this.Controls.Add(this.roznica);
            this.Controls.Add(this.suma);
            this.Controls.Add(this.p3);
            this.Controls.Add(this.p2);
            this.Controls.Add(this.p1);
            this.Controls.Add(this.p6);
            this.Controls.Add(this.p5);
            this.Controls.Add(this.p4);
            this.Controls.Add(this.p9);
            this.Controls.Add(this.p8);
            this.Controls.Add(this.p7);
            this.Controls.Add(this.text_wynik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Kalkulator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_wynik;
        private System.Windows.Forms.Button p7;
        private System.Windows.Forms.Button p8;
        private System.Windows.Forms.Button p9;
        private System.Windows.Forms.Button p6;
        private System.Windows.Forms.Button p5;
        private System.Windows.Forms.Button p4;
        private System.Windows.Forms.Button p3;
        private System.Windows.Forms.Button p2;
        private System.Windows.Forms.Button p1;
        private System.Windows.Forms.Button iloczyn;
        private System.Windows.Forms.Button roznica;
        private System.Windows.Forms.Button suma;
        private System.Windows.Forms.Button iloraz;
        private System.Windows.Forms.Button p0;
        private System.Windows.Forms.Button wynik;
    }
}

