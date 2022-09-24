namespace Fortech_TP3A1
{
    partial class AcessoForm
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
            this.lbLogin = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.txLogin = new System.Windows.Forms.TextBox();
            this.txSenha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btAcessar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbLogin
            // 
            this.lbLogin.AutoSize = true;
            this.lbLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.Location = new System.Drawing.Point(28, 104);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(119, 39);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "Login: ";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.Location = new System.Drawing.Point(28, 169);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(134, 39);
            this.lbSenha.TabIndex = 1;
            this.lbSenha.Text = "Senha: ";
            // 
            // txLogin
            // 
            this.txLogin.Location = new System.Drawing.Point(153, 104);
            this.txLogin.Multiline = true;
            this.txLogin.Name = "txLogin";
            this.txLogin.Size = new System.Drawing.Size(187, 39);
            this.txLogin.TabIndex = 2;
            // 
            // txSenha
            // 
            this.txSenha.Location = new System.Drawing.Point(153, 169);
            this.txSenha.Multiline = true;
            this.txSenha.Name = "txSenha";
            this.txSenha.Size = new System.Drawing.Size(187, 39);
            this.txSenha.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(139, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btAcessar
            // 
            this.btAcessar.Location = new System.Drawing.Point(181, 242);
            this.btAcessar.Name = "btAcessar";
            this.btAcessar.Size = new System.Drawing.Size(75, 23);
            this.btAcessar.TabIndex = 5;
            this.btAcessar.Text = "Acessar";
            this.btAcessar.UseVisualStyleBackColor = true;
            this.btAcessar.Click += new System.EventHandler(this.btAcessar_Click);
            // 
            // AcessoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 309);
            this.Controls.Add(this.btAcessar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txSenha);
            this.Controls.Add(this.txLogin);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbLogin);
            this.Name = "AcessoForm";
            this.Text = "Acesso";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox txLogin;
        private System.Windows.Forms.TextBox txSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btAcessar;
    }
}