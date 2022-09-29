namespace Fortech_TP3A1
{
    partial class CadastrarForm
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
            this.txNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.lbCpf = new System.Windows.Forms.Label();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txRg = new System.Windows.Forms.TextBox();
            this.lbRg = new System.Windows.Forms.Label();
            this.txConfirmarSenha = new System.Windows.Forms.TextBox();
            this.lbConfirmarSenha = new System.Windows.Forms.Label();
            this.txSenha = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.btCadastrar = new System.Windows.Forms.Button();
            this.txCnpj = new System.Windows.Forms.TextBox();
            this.lbCnpj = new System.Windows.Forms.Label();
            this.rdPessoaFisica = new System.Windows.Forms.RadioButton();
            this.rdPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.lbNascimento = new System.Windows.Forms.Label();
            this.txCpf = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // txNome
            // 
            this.txNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.Location = new System.Drawing.Point(18, 109);
            this.txNome.MaxLength = 255;
            this.txNome.Multiline = true;
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(187, 32);
            this.txNome.TabIndex = 1;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(17, 82);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(72, 24);
            this.lbNome.TabIndex = 3;
            this.lbNome.Text = "Nome: ";
            this.lbNome.Click += new System.EventHandler(this.lbNome_Click);
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpf.Location = new System.Drawing.Point(420, 82);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(57, 24);
            this.lbCpf.TabIndex = 5;
            this.lbCpf.Text = "CPF: ";
            this.lbCpf.Click += new System.EventHandler(this.lbCpf_Click);
            // 
            // txEmail
            // 
            this.txEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txEmail.Location = new System.Drawing.Point(221, 109);
            this.txEmail.MaxLength = 255;
            this.txEmail.Multiline = true;
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(187, 32);
            this.txEmail.TabIndex = 2;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(217, 82);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(67, 24);
            this.lbEmail.TabIndex = 9;
            this.lbEmail.Text = "Email: ";
            this.lbEmail.Click += new System.EventHandler(this.lbEmail_Click);
            // 
            // txRg
            // 
            this.txRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txRg.Location = new System.Drawing.Point(578, 110);
            this.txRg.MaxLength = 9;
            this.txRg.Multiline = true;
            this.txRg.Name = "txRg";
            this.txRg.Size = new System.Drawing.Size(118, 32);
            this.txRg.TabIndex = 4;
            // 
            // lbRg
            // 
            this.lbRg.AutoSize = true;
            this.lbRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRg.Location = new System.Drawing.Point(574, 83);
            this.lbRg.Name = "lbRg";
            this.lbRg.Size = new System.Drawing.Size(47, 24);
            this.lbRg.TabIndex = 7;
            this.lbRg.Text = "RG: ";
            this.lbRg.Click += new System.EventHandler(this.lbRg_Click);
            // 
            // txConfirmarSenha
            // 
            this.txConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txConfirmarSenha.Location = new System.Drawing.Point(221, 184);
            this.txConfirmarSenha.MaxLength = 100;
            this.txConfirmarSenha.Multiline = true;
            this.txConfirmarSenha.Name = "txConfirmarSenha";
            this.txConfirmarSenha.PasswordChar = '*';
            this.txConfirmarSenha.Size = new System.Drawing.Size(187, 32);
            this.txConfirmarSenha.TabIndex = 6;
            // 
            // lbConfirmarSenha
            // 
            this.lbConfirmarSenha.AutoSize = true;
            this.lbConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmarSenha.Location = new System.Drawing.Point(217, 157);
            this.lbConfirmarSenha.Name = "lbConfirmarSenha";
            this.lbConfirmarSenha.Size = new System.Drawing.Size(161, 24);
            this.lbConfirmarSenha.TabIndex = 13;
            this.lbConfirmarSenha.Text = "Confirmar Senha: ";
            this.lbConfirmarSenha.Click += new System.EventHandler(this.lbConfirmarSenha_Click);
            // 
            // txSenha
            // 
            this.txSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSenha.Location = new System.Drawing.Point(21, 184);
            this.txSenha.MaxLength = 100;
            this.txSenha.Multiline = true;
            this.txSenha.Name = "txSenha";
            this.txSenha.PasswordChar = '*';
            this.txSenha.Size = new System.Drawing.Size(183, 32);
            this.txSenha.TabIndex = 5;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.Location = new System.Drawing.Point(14, 157);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(75, 24);
            this.lbSenha.TabIndex = 11;
            this.lbSenha.Text = "Senha: ";
            this.lbSenha.Click += new System.EventHandler(this.lbSenha_Click);
            // 
            // btCadastrar
            // 
            this.btCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCadastrar.Location = new System.Drawing.Point(543, 244);
            this.btCadastrar.Name = "btCadastrar";
            this.btCadastrar.Size = new System.Drawing.Size(153, 36);
            this.btCadastrar.TabIndex = 8;
            this.btCadastrar.Text = "Cadastrar";
            this.btCadastrar.UseVisualStyleBackColor = true;
            this.btCadastrar.Click += new System.EventHandler(this.btCadastrar_Click);
            // 
            // txCnpj
            // 
            this.txCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCnpj.Location = new System.Drawing.Point(424, 109);
            this.txCnpj.Multiline = true;
            this.txCnpj.Name = "txCnpj";
            this.txCnpj.Size = new System.Drawing.Size(187, 32);
            this.txCnpj.TabIndex = 3;
            this.txCnpj.TextChanged += new System.EventHandler(this.txCnpj_TextChanged);
            // 
            // lbCnpj
            // 
            this.lbCnpj.AutoSize = true;
            this.lbCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCnpj.Location = new System.Drawing.Point(420, 83);
            this.lbCnpj.Name = "lbCnpj";
            this.lbCnpj.Size = new System.Drawing.Size(68, 24);
            this.lbCnpj.TabIndex = 18;
            this.lbCnpj.Text = "CNPJ: ";
            this.lbCnpj.Click += new System.EventHandler(this.lbCnpj_Click);
            // 
            // rdPessoaFisica
            // 
            this.rdPessoaFisica.AutoSize = true;
            this.rdPessoaFisica.Checked = true;
            this.rdPessoaFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPessoaFisica.Location = new System.Drawing.Point(39, 27);
            this.rdPessoaFisica.Name = "rdPessoaFisica";
            this.rdPessoaFisica.Size = new System.Drawing.Size(140, 26);
            this.rdPessoaFisica.TabIndex = 20;
            this.rdPessoaFisica.TabStop = true;
            this.rdPessoaFisica.Text = "Pessoa Física";
            this.rdPessoaFisica.UseVisualStyleBackColor = true;
            this.rdPessoaFisica.Click += new System.EventHandler(this.rdPessoaFisica_Click);
            // 
            // rdPessoaJuridica
            // 
            this.rdPessoaJuridica.AutoSize = true;
            this.rdPessoaJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPessoaJuridica.Location = new System.Drawing.Point(185, 29);
            this.rdPessoaJuridica.Name = "rdPessoaJuridica";
            this.rdPessoaJuridica.Size = new System.Drawing.Size(155, 26);
            this.rdPessoaJuridica.TabIndex = 21;
            this.rdPessoaJuridica.Text = "Pessoa Jurídica";
            this.rdPessoaJuridica.UseVisualStyleBackColor = true;
            this.rdPessoaJuridica.Click += new System.EventHandler(this.rdPessoaJuridica_Click);
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(424, 189);
            this.dtpNascimento.MaxDate = new System.DateTime(2140, 12, 31, 0, 0, 0, 0);
            this.dtpNascimento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(106, 27);
            this.dtpNascimento.TabIndex = 7;
            // 
            // lbNascimento
            // 
            this.lbNascimento.AutoSize = true;
            this.lbNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNascimento.Location = new System.Drawing.Point(420, 157);
            this.lbNascimento.Name = "lbNascimento";
            this.lbNascimento.Size = new System.Drawing.Size(162, 24);
            this.lbNascimento.TabIndex = 23;
            this.lbNascimento.Text = "Data Nascimento: ";
            // 
            // txCpf
            // 
            this.txCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCpf.Location = new System.Drawing.Point(424, 110);
            this.txCpf.Mask = "000.000.000-00";
            this.txCpf.Name = "txCpf";
            this.txCpf.Size = new System.Drawing.Size(136, 29);
            this.txCpf.TabIndex = 3;
            this.txCpf.ValidatingType = typeof(int);
            // 
            // CadastrarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 291);
            this.Controls.Add(this.txCpf);
            this.Controls.Add(this.lbNascimento);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.rdPessoaJuridica);
            this.Controls.Add(this.rdPessoaFisica);
            this.Controls.Add(this.txCnpj);
            this.Controls.Add(this.lbCnpj);
            this.Controls.Add(this.btCadastrar);
            this.Controls.Add(this.txConfirmarSenha);
            this.Controls.Add(this.lbConfirmarSenha);
            this.Controls.Add(this.txSenha);
            this.Controls.Add(this.lbSenha);
            this.Controls.Add(this.txEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.txRg);
            this.Controls.Add(this.lbRg);
            this.Controls.Add(this.lbCpf);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.lbNome);
            this.Name = "CadastrarForm";
            this.Text = "Cadastrar";
            this.Load += new System.EventHandler(this.CadastrarForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txRg;
        private System.Windows.Forms.Label lbRg;
        private System.Windows.Forms.TextBox txConfirmarSenha;
        private System.Windows.Forms.Label lbConfirmarSenha;
        private System.Windows.Forms.TextBox txSenha;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Button btCadastrar;
        private System.Windows.Forms.TextBox txCnpj;
        private System.Windows.Forms.Label lbCnpj;
        private System.Windows.Forms.RadioButton rdPessoaFisica;
        private System.Windows.Forms.RadioButton rdPessoaJuridica;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label lbNascimento;
        private System.Windows.Forms.MaskedTextBox txCpf;
    }
}