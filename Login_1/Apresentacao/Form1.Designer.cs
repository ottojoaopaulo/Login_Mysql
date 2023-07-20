namespace Login_1
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
            this.button_entrar = new System.Windows.Forms.Button();
            this.text_senha = new System.Windows.Forms.TextBox();
            this.text_usuario = new System.Windows.Forms.TextBox();
            this.tx_senha = new System.Windows.Forms.Label();
            this.tx_login = new System.Windows.Forms.Label();
            this.button_sair = new System.Windows.Forms.Button();
            this.button_cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_entrar
            // 
            this.button_entrar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_entrar.Location = new System.Drawing.Point(75, 184);
            this.button_entrar.Name = "button_entrar";
            this.button_entrar.Size = new System.Drawing.Size(75, 23);
            this.button_entrar.TabIndex = 2;
            this.button_entrar.Text = "Entrar";
            this.button_entrar.UseVisualStyleBackColor = true;
            this.button_entrar.Click += new System.EventHandler(this.button_entrar_Click);
            // 
            // text_senha
            // 
            this.text_senha.Location = new System.Drawing.Point(75, 125);
            this.text_senha.Name = "text_senha";
            this.text_senha.PasswordChar = '*';
            this.text_senha.Size = new System.Drawing.Size(202, 20);
            this.text_senha.TabIndex = 1;
            this.text_senha.TextChanged += new System.EventHandler(this.text_text_Change);
            this.text_senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_senha_KeyDown);
            // 
            // text_usuario
            // 
            this.text_usuario.Location = new System.Drawing.Point(75, 52);
            this.text_usuario.Name = "text_usuario";
            this.text_usuario.Size = new System.Drawing.Size(202, 20);
            this.text_usuario.TabIndex = 0;
            this.text_usuario.TextChanged += new System.EventHandler(this.text_text_Change);
            this.text_usuario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.text_usuario_KeyDown);
            // 
            // tx_senha
            // 
            this.tx_senha.AutoSize = true;
            this.tx_senha.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_senha.Location = new System.Drawing.Point(72, 109);
            this.tx_senha.Name = "tx_senha";
            this.tx_senha.Size = new System.Drawing.Size(43, 16);
            this.tx_senha.TabIndex = 3;
            this.tx_senha.Text = "Senha";
            // 
            // tx_login
            // 
            this.tx_login.AutoSize = true;
            this.tx_login.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tx_login.Location = new System.Drawing.Point(72, 36);
            this.tx_login.Name = "tx_login";
            this.tx_login.Size = new System.Drawing.Size(50, 16);
            this.tx_login.TabIndex = 4;
            this.tx_login.Text = "Usuario";
            // 
            // button_sair
            // 
            this.button_sair.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sair.Location = new System.Drawing.Point(202, 184);
            this.button_sair.Name = "button_sair";
            this.button_sair.Size = new System.Drawing.Size(75, 23);
            this.button_sair.TabIndex = 5;
            this.button_sair.Text = "Sair";
            this.button_sair.UseVisualStyleBackColor = true;
            this.button_sair.Click += new System.EventHandler(this.Sair_Click);
            // 
            // button_cadastrar
            // 
            this.button_cadastrar.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cadastrar.Location = new System.Drawing.Point(76, 244);
            this.button_cadastrar.Name = "button_cadastrar";
            this.button_cadastrar.Size = new System.Drawing.Size(202, 23);
            this.button_cadastrar.TabIndex = 6;
            this.button_cadastrar.Text = "Cadastrar";
            this.button_cadastrar.UseVisualStyleBackColor = true;
            this.button_cadastrar.Click += new System.EventHandler(this.button_cadastrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 302);
            this.Controls.Add(this.button_cadastrar);
            this.Controls.Add(this.button_sair);
            this.Controls.Add(this.tx_login);
            this.Controls.Add(this.tx_senha);
            this.Controls.Add(this.text_usuario);
            this.Controls.Add(this.text_senha);
            this.Controls.Add(this.button_entrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_entrar;
        private System.Windows.Forms.TextBox text_senha;
        private System.Windows.Forms.TextBox text_usuario;
        private System.Windows.Forms.Label tx_senha;
        private System.Windows.Forms.Label tx_login;
        private System.Windows.Forms.Button button_sair;
        private System.Windows.Forms.Button button_cadastrar;
    }
}

