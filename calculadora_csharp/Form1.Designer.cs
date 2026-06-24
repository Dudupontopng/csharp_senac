namespace calculadora_csharp
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
            btn_1 = new Button();
            btn_2 = new Button();
            btn_3 = new Button();
            btn_6 = new Button();
            btn_5 = new Button();
            btn_4 = new Button();
            btn_9 = new Button();
            btn_8 = new Button();
            btn_7 = new Button();
            btn_c = new Button();
            btn_0 = new Button();
            btn_virgula = new Button();
            btn_dividir = new Button();
            btn_multi = new Button();
            btn_sub = new Button();
            btn_adc = new Button();
            btn_igual = new Button();
            numero = new TextBox();
            numero_2 = new TextBox();
            SuspendLayout();
            // 
            // btn_1
            // 
            btn_1.Location = new Point(252, 273);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(60, 49);
            btn_1.TabIndex = 0;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += button1_Click;
            // 
            // btn_2
            // 
            btn_2.Location = new Point(318, 273);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(60, 49);
            btn_2.TabIndex = 1;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += btn_2_Click_1;
            // 
            // btn_3
            // 
            btn_3.Location = new Point(384, 273);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(60, 49);
            btn_3.TabIndex = 2;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += btn_3_Click;
            // 
            // btn_6
            // 
            btn_6.Location = new Point(384, 218);
            btn_6.Name = "btn_6";
            btn_6.Size = new Size(60, 49);
            btn_6.TabIndex = 5;
            btn_6.Text = "6";
            btn_6.UseVisualStyleBackColor = true;
            btn_6.Click += btn_6_Click;
            // 
            // btn_5
            // 
            btn_5.Location = new Point(318, 218);
            btn_5.Name = "btn_5";
            btn_5.Size = new Size(60, 49);
            btn_5.TabIndex = 4;
            btn_5.Text = "5";
            btn_5.UseVisualStyleBackColor = true;
            btn_5.Click += btn_5_Click;
            // 
            // btn_4
            // 
            btn_4.Location = new Point(252, 218);
            btn_4.Name = "btn_4";
            btn_4.Size = new Size(60, 49);
            btn_4.TabIndex = 3;
            btn_4.Text = "4";
            btn_4.UseVisualStyleBackColor = true;
            btn_4.Click += btn_4_Click;
            // 
            // btn_9
            // 
            btn_9.Location = new Point(384, 163);
            btn_9.Name = "btn_9";
            btn_9.Size = new Size(60, 49);
            btn_9.TabIndex = 8;
            btn_9.Text = "9";
            btn_9.UseVisualStyleBackColor = true;
            btn_9.Click += btn_9_Click;
            // 
            // btn_8
            // 
            btn_8.Location = new Point(318, 163);
            btn_8.Name = "btn_8";
            btn_8.Size = new Size(60, 49);
            btn_8.TabIndex = 7;
            btn_8.Text = "8";
            btn_8.UseVisualStyleBackColor = true;
            btn_8.Click += btn_8_Click;
            // 
            // btn_7
            // 
            btn_7.Location = new Point(252, 163);
            btn_7.Name = "btn_7";
            btn_7.Size = new Size(60, 49);
            btn_7.TabIndex = 6;
            btn_7.Text = "7";
            btn_7.UseVisualStyleBackColor = true;
            btn_7.Click += btn_7_Click;
            // 
            // btn_c
            // 
            btn_c.Location = new Point(384, 108);
            btn_c.Name = "btn_c";
            btn_c.Size = new Size(60, 49);
            btn_c.TabIndex = 10;
            btn_c.Text = "C";
            btn_c.UseVisualStyleBackColor = true;
            btn_c.Click += btn_c_Click;
            // 
            // btn_0
            // 
            btn_0.Location = new Point(318, 328);
            btn_0.Name = "btn_0";
            btn_0.Size = new Size(60, 49);
            btn_0.TabIndex = 11;
            btn_0.Text = "0";
            btn_0.UseVisualStyleBackColor = true;
            btn_0.Click += btn_0_Click;
            // 
            // btn_virgula
            // 
            btn_virgula.Location = new Point(384, 328);
            btn_virgula.Name = "btn_virgula";
            btn_virgula.Size = new Size(60, 49);
            btn_virgula.TabIndex = 12;
            btn_virgula.Text = ",";
            btn_virgula.UseVisualStyleBackColor = true;
            btn_virgula.Click += btn_virgula_Click;
            // 
            // btn_dividir
            // 
            btn_dividir.Location = new Point(450, 108);
            btn_dividir.Name = "btn_dividir";
            btn_dividir.Size = new Size(60, 49);
            btn_dividir.TabIndex = 13;
            btn_dividir.Text = "/";
            btn_dividir.UseVisualStyleBackColor = true;
            btn_dividir.Click += btn_dividir_Click;
            // 
            // btn_multi
            // 
            btn_multi.Location = new Point(450, 163);
            btn_multi.Name = "btn_multi";
            btn_multi.Size = new Size(60, 49);
            btn_multi.TabIndex = 14;
            btn_multi.Text = "X";
            btn_multi.UseVisualStyleBackColor = true;
            btn_multi.Click += btn_multi_Click;
            // 
            // btn_sub
            // 
            btn_sub.Location = new Point(450, 218);
            btn_sub.Name = "btn_sub";
            btn_sub.Size = new Size(60, 49);
            btn_sub.TabIndex = 15;
            btn_sub.Text = "-";
            btn_sub.UseVisualStyleBackColor = true;
            btn_sub.Click += btn_sub_Click;
            // 
            // btn_adc
            // 
            btn_adc.Location = new Point(450, 273);
            btn_adc.Name = "btn_adc";
            btn_adc.Size = new Size(60, 49);
            btn_adc.TabIndex = 16;
            btn_adc.Text = "+";
            btn_adc.UseVisualStyleBackColor = true;
            btn_adc.Click += btn_adc_Click;
            // 
            // btn_igual
            // 
            btn_igual.BackColor = SystemColors.Highlight;
            btn_igual.ForeColor = Color.Black;
            btn_igual.Location = new Point(450, 328);
            btn_igual.Name = "btn_igual";
            btn_igual.Size = new Size(60, 49);
            btn_igual.TabIndex = 17;
            btn_igual.Text = "=";
            btn_igual.UseVisualStyleBackColor = false;
            btn_igual.Click += btn_igual_Click;
            // 
            // numero
            // 
            numero.Location = new Point(252, 71);
            numero.Name = "numero";
            numero.ReadOnly = true;
            numero.Size = new Size(255, 31);
            numero.TabIndex = 18;
            numero.Text = "0";
            numero.TextAlign = HorizontalAlignment.Right;
            numero.TextChanged += numero_TextChanged;
            // 
            // numero_2
            // 
            numero_2.ForeColor = SystemColors.ScrollBar;
            numero_2.Location = new Point(252, 34);
            numero_2.Name = "numero_2";
            numero_2.ReadOnly = true;
            numero_2.Size = new Size(255, 31);
            numero_2.TabIndex = 19;
            numero_2.TextAlign = HorizontalAlignment.Right;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numero_2);
            Controls.Add(numero);
            Controls.Add(btn_igual);
            Controls.Add(btn_adc);
            Controls.Add(btn_sub);
            Controls.Add(btn_multi);
            Controls.Add(btn_dividir);
            Controls.Add(btn_virgula);
            Controls.Add(btn_0);
            Controls.Add(btn_c);
            Controls.Add(btn_9);
            Controls.Add(btn_8);
            Controls.Add(btn_7);
            Controls.Add(btn_6);
            Controls.Add(btn_5);
            Controls.Add(btn_4);
            Controls.Add(btn_3);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_1;
        private Button btn_2;
        private Button btn_3;
        private Button btn_6;
        private Button btn_5;
        private Button btn_4;
        private Button btn_9;
        private Button btn_8;
        private Button btn_7;
        private Button btn_c;
        private Button btn_0;
        private Button btn_virgula;
        private Button btn_dividir;
        private Button btn_multi;
        private Button btn_sub;
        private Button btn_adc;
        private Button btn_igual;
        private TextBox numero;
        private TextBox numero_2;
    }
}
