namespace Fortech_TP3A1.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcessoForm));
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.txSenha = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btAcessar = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(25, 142);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(103, 42);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email: ";
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Poppins Medium", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.Location = new System.Drawing.Point(25, 199);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(114, 42);
            this.lbSenha.TabIndex = 1;
            this.lbSenha.Text = "Senha: ";
            // 
            // txEmail
            // 
            this.txEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txEmail.Location = new System.Drawing.Point(132, 142);
            this.txEmail.Multiline = true;
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(240, 39);
            this.txEmail.TabIndex = 2;
            // 
            // txSenha
            // 
            this.txSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSenha.Location = new System.Drawing.Point(132, 199);
            this.txSenha.Multiline = true;
            this.txSenha.Name = "txSenha";
            this.txSenha.PasswordChar = '*';
            this.txSenha.Size = new System.Drawing.Size(240, 39);
            this.txSenha.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(162, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btAcessar
            // 
            this.btAcessar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btAcessar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAcessar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAcessar.ForeColor = System.Drawing.Color.White;
            this.btAcessar.Location = new System.Drawing.Point(260, 253);
            this.btAcessar.Name = "btAcessar";
            this.btAcessar.Size = new System.Drawing.Size(112, 44);
            this.btAcessar.TabIndex = 5;
            this.btAcessar.Text = "Acessar";
            this.btAcessar.UseVisualStyleBackColor = false;
            this.btAcessar.Click += new System.EventHandler(this.btAcessar_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.ForeColor = System.Drawing.Color.White;
            this.btVoltar.Location = new System.Drawing.Point(142, 253);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(112, 44);
            this.btVoltar.TabIndex = 6;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // AcessoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 309);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btAcessar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txSenha);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.lbEmail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AcessoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acesso";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btVoltar;

        #endregion

        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.TextBox txSenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btAcessar;
    }
}