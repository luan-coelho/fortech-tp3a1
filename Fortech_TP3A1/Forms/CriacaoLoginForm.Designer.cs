using System.ComponentModel;

namespace Fortech_TP3A1.Forms
{
    partial class CriacaoLoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.txConfirmarSenha = new System.Windows.Forms.TextBox();
            this.lbConfirmarSenha = new System.Windows.Forms.Label();
            this.txSenha = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.lbSenha = new System.Windows.Forms.Label();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbGerencia = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txConfirmarSenha
            // 
            this.txConfirmarSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txConfirmarSenha.Location = new System.Drawing.Point(55, 214);
            this.txConfirmarSenha.MaxLength = 100;
            this.txConfirmarSenha.Multiline = true;
            this.txConfirmarSenha.Name = "txConfirmarSenha";
            this.txConfirmarSenha.PasswordChar = '*';
            this.txConfirmarSenha.Size = new System.Drawing.Size(256, 32);
            this.txConfirmarSenha.TabIndex = 52;
            // 
            // lbConfirmarSenha
            // 
            this.lbConfirmarSenha.AutoSize = true;
            this.lbConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmarSenha.Location = new System.Drawing.Point(51, 187);
            this.lbConfirmarSenha.Name = "lbConfirmarSenha";
            this.lbConfirmarSenha.Size = new System.Drawing.Size(161, 24);
            this.lbConfirmarSenha.TabIndex = 57;
            this.lbConfirmarSenha.Text = "Confirmar Senha: ";
            // 
            // txSenha
            // 
            this.txSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSenha.Location = new System.Drawing.Point(55, 140);
            this.txSenha.MaxLength = 100;
            this.txSenha.Multiline = true;
            this.txSenha.Name = "txSenha";
            this.txSenha.PasswordChar = '*';
            this.txSenha.Size = new System.Drawing.Size(256, 32);
            this.txSenha.TabIndex = 50;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btCancelar);
            this.panel2.Controls.Add(this.btSalvar);
            this.panel2.Controls.Add(this.btVoltar);
            this.panel2.Controls.Add(this.txConfirmarSenha);
            this.panel2.Controls.Add(this.lbConfirmarSenha);
            this.panel2.Controls.Add(this.txSenha);
            this.panel2.Controls.Add(this.lbSenha);
            this.panel2.Controls.Add(this.txEmail);
            this.panel2.Controls.Add(this.lbEmail);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(0, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(370, 334);
            this.panel2.TabIndex = 47;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.Red;
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(55, 279);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(76, 33);
            this.btCancelar.TabIndex = 64;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btSalvar.FlatAppearance.BorderSize = 0;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.ForeColor = System.Drawing.Color.White;
            this.btSalvar.Location = new System.Drawing.Point(252, 279);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(59, 33);
            this.btSalvar.TabIndex = 63;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.Silver;
            this.btVoltar.FlatAppearance.BorderSize = 0;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.ForeColor = System.Drawing.Color.Black;
            this.btVoltar.Location = new System.Drawing.Point(185, 279);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(61, 33);
            this.btVoltar.TabIndex = 62;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.Location = new System.Drawing.Point(52, 113);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(75, 24);
            this.lbSenha.TabIndex = 56;
            this.lbSenha.Text = "Senha: ";
            // 
            // txEmail
            // 
            this.txEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txEmail.Location = new System.Drawing.Point(55, 64);
            this.txEmail.MaxLength = 255;
            this.txEmail.Multiline = true;
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(256, 32);
            this.txEmail.TabIndex = 45;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(51, 37);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(67, 24);
            this.lbEmail.TabIndex = 55;
            this.lbEmail.Text = "Email: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.lbGerencia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 92);
            this.panel1.TabIndex = 46;
            // 
            // lbGerencia
            // 
            this.lbGerencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGerencia.ForeColor = System.Drawing.Color.White;
            this.lbGerencia.Location = new System.Drawing.Point(31, 29);
            this.lbGerencia.Name = "lbGerencia";
            this.lbGerencia.Size = new System.Drawing.Size(147, 29);
            this.lbGerencia.TabIndex = 0;
            this.lbGerencia.Text = "Criar Login";
            // 
            // CriacaoLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 426);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CriacaoLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Login";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btCancelar;

        private System.Windows.Forms.TextBox txConfirmarSenha;
        private System.Windows.Forms.Label lbConfirmarSenha;
        private System.Windows.Forms.TextBox txSenha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btSalvar;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbGerencia;

        #endregion
    }
}