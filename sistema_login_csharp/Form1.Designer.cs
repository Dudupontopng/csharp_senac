namespace sistema_login_csharp
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
            texto_usuario = new Label();
            caixa_usuario = new TextBox();
            texto_senha = new Label();
            caixa_senha = new TextBox();
            btn_enviar = new Button();
            texto_confirmar = new Label();
            SuspendLayout();
            // 
            // texto_usuario
            // 
            texto_usuario.AutoSize = true;
            texto_usuario.Font = new Font("Segoe UI", 20F);
            texto_usuario.Location = new Point(3, 9);
            texto_usuario.Name = "texto_usuario";
            texto_usuario.Size = new Size(157, 54);
            texto_usuario.TabIndex = 0;
            texto_usuario.Text = "Usuário";
            // 
            // caixa_usuario
            // 
            caixa_usuario.Location = new Point(10, 66);
            caixa_usuario.Name = "caixa_usuario";
            caixa_usuario.Size = new Size(150, 31);
            caixa_usuario.TabIndex = 1;
            // 
            // texto_senha
            // 
            texto_senha.AutoSize = true;
            texto_senha.Font = new Font("Segoe UI", 20F);
            texto_senha.Location = new Point(3, 100);
            texto_senha.Name = "texto_senha";
            texto_senha.Size = new Size(131, 54);
            texto_senha.TabIndex = 2;
            texto_senha.Text = "Senha";
            // 
            // caixa_senha
            // 
            caixa_senha.Location = new Point(12, 157);
            caixa_senha.Name = "caixa_senha";
            caixa_senha.Size = new Size(150, 31);
            caixa_senha.TabIndex = 3;
            // 
            // btn_enviar
            // 
            btn_enviar.BackColor = Color.FromArgb(128, 255, 128);
            btn_enviar.Cursor = Cursors.Hand;
            btn_enviar.Location = new Point(10, 207);
            btn_enviar.Name = "btn_enviar";
            btn_enviar.Size = new Size(150, 57);
            btn_enviar.TabIndex = 4;
            btn_enviar.Text = "Confirmar";
            btn_enviar.UseVisualStyleBackColor = false;
            btn_enviar.Click += btn_enviar_Click;
            // 
            // texto_confirmar
            // 
            texto_confirmar.AutoSize = true;
            texto_confirmar.Font = new Font("Segoe UI", 20F);
            texto_confirmar.Location = new Point(3, 267);
            texto_confirmar.Name = "texto_confirmar";
            texto_confirmar.Size = new Size(246, 54);
            texto_confirmar.TabIndex = 5;
            texto_confirmar.Text = "Faça o login!";
            
            // 
            // Form1
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(texto_confirmar);
            Controls.Add(btn_enviar);
            Controls.Add(caixa_senha);
            Controls.Add(texto_senha);
            Controls.Add(caixa_usuario);
            Controls.Add(texto_usuario);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label texto_usuario;
        private TextBox caixa_usuario;
        private Label texto_senha;
        private TextBox caixa_senha;
        private Button btn_enviar;
        private Label texto_confirmar;
    }
}
