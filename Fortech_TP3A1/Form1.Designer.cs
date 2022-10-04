namespace Fortech_TP3A1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btLogin = new System.Windows.Forms.Button();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.btSair = new System.Windows.Forms.Button();
            this.lbGerencia = new System.Windows.Forms.Label();
            this.bbTeste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btLogin
            // 
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Location = new System.Drawing.Point(8, 90);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(143, 52);
            this.btLogin.TabIndex = 0;
            this.btLogin.Text = "Acesso";
            this.btLogin.UseVisualStyleBackColor = true;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(157, 90);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(156, 52);
            this.btCadastrar.TabIndex = 2;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // btSair
            // 
            this.btSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSair.Location = new System.Drawing.Point(319, 90);
            this.btSair.Name = "btSair";
            this.btSair.Size = new System.Drawing.Size(75, 52);
            this.btSair.TabIndex = 3;
            this.btSair.Text = "Sair";
            this.btSair.UseVisualStyleBackColor = true;
            this.btSair.Click += new System.EventHandler(this.btSair_Click);
            // 
            // lbGerencia
            // 
            this.lbGerencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGerencia.ForeColor = System.Drawing.Color.White;
            this.lbGerencia.Location = new System.Drawing.Point(12, 34);
            this.lbGerencia.Name = "lbGerencia";
            this.lbGerencia.Size = new System.Drawing.Size(275, 29);
            this.lbGerencia.TabIndex = 4;
            this.lbGerencia.Text = "Fortech Manutenções";
            // 
            // bbTeste
            // 
            this.bbTeste.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bbTeste.Location = new System.Drawing.Point(276, 20);
            this.bbTeste.Name = "bbTeste";
            this.bbTeste.Size = new System.Drawing.Size(118, 52);
            this.bbTeste.TabIndex = 5;
            this.bbTeste.Text = "Teste";
            this.bbTeste.UseVisualStyleBackColor = true;
            this.bbTeste.Click += new System.EventHandler(this.bbTeste_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(402, 154);
            this.Controls.Add(this.bbTeste);
            this.Controls.Add(this.lbGerencia);
            this.Controls.Add(this.btSair);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.btLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fortech";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button bbTeste;

        private System.Windows.Forms.Label lbGerencia;

        private System.Windows.Forms.Button btSair;

        private System.Windows.Forms.Button btCadastrar;

        #endregion

        private System.Windows.Forms.Button btLogin;
    }
}

