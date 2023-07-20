namespace Login_1
{
    partial class Cadastro
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
            this.Login = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_cadastrar = new System.Windows.Forms.Button();
            this.text_conf_senha = new System.Windows.Forms.TextBox();
            this.text_senha = new System.Windows.Forms.TextBox();
            this.text_login = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.Location = new System.Drawing.Point(65, 28);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(37, 16);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Senha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Confirmar Senha";
            // 
            // button_cadastrar
            // 
            this.button_cadastrar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_cadastrar.Location = new System.Drawing.Point(132, 283);
            this.button_cadastrar.Name = "button_cadastrar";
            this.button_cadastrar.Size = new System.Drawing.Size(98, 42);
            this.button_cadastrar.TabIndex = 3;
            this.button_cadastrar.Text = "Cadastrar";
            this.button_cadastrar.UseVisualStyleBackColor = true;
            this.button_cadastrar.Click += new System.EventHandler(this.button_cadastrar_Click);
            // 
            // text_conf_senha
            // 
            this.text_conf_senha.Location = new System.Drawing.Point(68, 221);
            this.text_conf_senha.Name = "text_conf_senha";
            this.text_conf_senha.PasswordChar = '*';
            this.text_conf_senha.Size = new System.Drawing.Size(139, 20);
            this.text_conf_senha.TabIndex = 2;
            this.text_conf_senha.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // text_senha
            // 
            this.text_senha.Location = new System.Drawing.Point(68, 132);
            this.text_senha.Name = "text_senha";
            this.text_senha.PasswordChar = '*';
            this.text_senha.Size = new System.Drawing.Size(139, 20);
            this.text_senha.TabIndex = 1;
            // 
            // text_login
            // 
            this.text_login.Location = new System.Drawing.Point(68, 47);
            this.text_login.Name = "text_login";
            this.text_login.Size = new System.Drawing.Size(211, 20);
            this.text_login.TabIndex = 0;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 356);
            this.Controls.Add(this.text_login);
            this.Controls.Add(this.text_senha);
            this.Controls.Add(this.text_conf_senha);
            this.Controls.Add(this.button_cadastrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Cadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.Cadastro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_cadastrar;
        private System.Windows.Forms.TextBox text_conf_senha;
        private System.Windows.Forms.TextBox text_senha;
        private System.Windows.Forms.TextBox text_login;
    }
}