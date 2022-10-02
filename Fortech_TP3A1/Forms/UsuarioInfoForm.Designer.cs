using System.ComponentModel;

namespace Fortech_TP3A1.Forms
{
    partial class UsuarioInfoForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbGerencia = new System.Windows.Forms.Label();
            this.toolStripDropDown1 = new System.Windows.Forms.ToolStripDropDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btAvancar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.txCpf = new System.Windows.Forms.MaskedTextBox();
            this.lbNascimento = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.rdPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.rdPessoaFisica = new System.Windows.Forms.RadioButton();
            this.txCnpj = new System.Windows.Forms.TextBox();
            this.lbCnpj = new System.Windows.Forms.Label();
            this.txConfirmarSenha = new System.Windows.Forms.TextBox();
            this.lbConfirmarSenha = new System.Windows.Forms.Label();
            this.txSenha = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.txEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.txRg = new System.Windows.Forms.TextBox();
            this.lbRg = new System.Windows.Forms.Label();
            this.lbCpf = new System.Windows.Forms.Label();
            this.txNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.lbGerencia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 92);
            this.panel1.TabIndex = 3;
            // 
            // lbGerencia
            // 
            this.lbGerencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGerencia.ForeColor = System.Drawing.Color.White;
            this.lbGerencia.Location = new System.Drawing.Point(31, 29);
            this.lbGerencia.Name = "lbGerencia";
            this.lbGerencia.Size = new System.Drawing.Size(247, 29);
            this.lbGerencia.TabIndex = 0;
            this.lbGerencia.Text = "Cadastrar/Editar Usuário";
            // 
            // toolStripDropDown1
            // 
            this.toolStripDropDown1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStripDropDown1.Name = "toolStripDropDown1";
            this.toolStripDropDown1.Size = new System.Drawing.Size(2, 4);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btAvancar);
            this.panel2.Controls.Add(this.btCancelar);
            this.panel2.Controls.Add(this.txCpf);
            this.panel2.Controls.Add(this.lbNascimento);
            this.panel2.Controls.Add(this.dtpNascimento);
            this.panel2.Controls.Add(this.rdPessoaJuridica);
            this.panel2.Controls.Add(this.rdPessoaFisica);
            this.panel2.Controls.Add(this.txCnpj);
            this.panel2.Controls.Add(this.lbCnpj);
            this.panel2.Controls.Add(this.txConfirmarSenha);
            this.panel2.Controls.Add(this.lbConfirmarSenha);
            this.panel2.Controls.Add(this.txSenha);
            this.panel2.Controls.Add(this.lbSenha);
            this.panel2.Controls.Add(this.txEmail);
            this.panel2.Controls.Add(this.lbEmail);
            this.panel2.Controls.Add(this.txRg);
            this.panel2.Controls.Add(this.lbRg);
            this.panel2.Controls.Add(this.lbCpf);
            this.panel2.Controls.Add(this.txNome);
            this.panel2.Controls.Add(this.lbNome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 92);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(761, 279);
            this.panel2.TabIndex = 45;
            // 
            // btAvancar
            // 
            this.btAvancar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btAvancar.FlatAppearance.BorderSize = 0;
            this.btAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAvancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAvancar.ForeColor = System.Drawing.Color.White;
            this.btAvancar.Location = new System.Drawing.Point(648, 234);
            this.btAvancar.Name = "btAvancar";
            this.btAvancar.Size = new System.Drawing.Size(76, 33);
            this.btAvancar.TabIndex = 63;
            this.btAvancar.Text = "Avançar";
            this.btAvancar.UseVisualStyleBackColor = false;
            this.btAvancar.Click += new System.EventHandler(this.btAvancar_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.Red;
            this.btCancelar.FlatAppearance.BorderSize = 0;
            this.btCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.ForeColor = System.Drawing.Color.White;
            this.btCancelar.Location = new System.Drawing.Point(561, 234);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(76, 33);
            this.btCancelar.TabIndex = 62;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // txCpf
            // 
            this.txCpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCpf.Location = new System.Drawing.Point(464, 106);
            this.txCpf.Mask = "999,999,999-99";
            this.txCpf.Name = "txCpf";
            this.txCpf.Size = new System.Drawing.Size(136, 29);
            this.txCpf.TabIndex = 48;
            // 
            // lbNascimento
            // 
            this.lbNascimento.AutoSize = true;
            this.lbNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNascimento.Location = new System.Drawing.Point(419, 151);
            this.lbNascimento.Name = "lbNascimento";
            this.lbNascimento.Size = new System.Drawing.Size(162, 24);
            this.lbNascimento.TabIndex = 61;
            this.lbNascimento.Text = "Data Nascimento: ";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(423, 183);
            this.dtpNascimento.MaxDate = new System.DateTime(2140, 12, 31, 0, 0, 0, 0);
            this.dtpNascimento.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(106, 27);
            this.dtpNascimento.TabIndex = 54;
            // 
            // rdPessoaJuridica
            // 
            this.rdPessoaJuridica.AutoSize = true;
            this.rdPessoaJuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPessoaJuridica.Location = new System.Drawing.Point(184, 31);
            this.rdPessoaJuridica.Name = "rdPessoaJuridica";
            this.rdPessoaJuridica.Size = new System.Drawing.Size(155, 26);
            this.rdPessoaJuridica.TabIndex = 60;
            this.rdPessoaJuridica.Text = "Pessoa Jurídica";
            this.rdPessoaJuridica.UseVisualStyleBackColor = true;
            this.rdPessoaJuridica.CheckedChanged += new System.EventHandler(this.rdPessoaJuridica_CheckedChanged);
            // 
            // rdPessoaFisica
            // 
            this.rdPessoaFisica.AutoSize = true;
            this.rdPessoaFisica.Checked = true;
            this.rdPessoaFisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPessoaFisica.Location = new System.Drawing.Point(38, 31);
            this.rdPessoaFisica.Name = "rdPessoaFisica";
            this.rdPessoaFisica.Size = new System.Drawing.Size(140, 26);
            this.rdPessoaFisica.TabIndex = 59;
            this.rdPessoaFisica.TabStop = true;
            this.rdPessoaFisica.Text = "Pessoa Física";
            this.rdPessoaFisica.UseVisualStyleBackColor = true;
            this.rdPessoaFisica.CheckedChanged += new System.EventHandler(this.rdPessoaFisica_CheckedChanged);
            // 
            // txCnpj
            // 
            this.txCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCnpj.Location = new System.Drawing.Point(464, 103);
            this.txCnpj.Multiline = true;
            this.txCnpj.Name = "txCnpj";
            this.txCnpj.Size = new System.Drawing.Size(187, 32);
            this.txCnpj.TabIndex = 46;
            // 
            // lbCnpj
            // 
            this.lbCnpj.AutoSize = true;
            this.lbCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCnpj.Location = new System.Drawing.Point(459, 76);
            this.lbCnpj.Name = "lbCnpj";
            this.lbCnpj.Size = new System.Drawing.Size(68, 24);
            this.lbCnpj.TabIndex = 58;
            this.lbCnpj.Text = "CNPJ: ";
            // 
            // txConfirmarSenha
            // 
            this.txConfirmarSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txConfirmarSenha.Location = new System.Drawing.Point(230, 178);
            this.txConfirmarSenha.MaxLength = 100;
            this.txConfirmarSenha.Multiline = true;
            this.txConfirmarSenha.Name = "txConfirmarSenha";
            this.txConfirmarSenha.PasswordChar = '*';
            this.txConfirmarSenha.Size = new System.Drawing.Size(187, 32);
            this.txConfirmarSenha.TabIndex = 52;
            // 
            // lbConfirmarSenha
            // 
            this.lbConfirmarSenha.AutoSize = true;
            this.lbConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmarSenha.Location = new System.Drawing.Point(226, 151);
            this.lbConfirmarSenha.Name = "lbConfirmarSenha";
            this.lbConfirmarSenha.Size = new System.Drawing.Size(161, 24);
            this.lbConfirmarSenha.TabIndex = 57;
            this.lbConfirmarSenha.Text = "Confirmar Senha: ";
            // 
            // txSenha
            // 
            this.txSenha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txSenha.Location = new System.Drawing.Point(41, 178);
            this.txSenha.MaxLength = 100;
            this.txSenha.Multiline = true;
            this.txSenha.Name = "txSenha";
            this.txSenha.PasswordChar = '*';
            this.txSenha.Size = new System.Drawing.Size(183, 32);
            this.txSenha.TabIndex = 50;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.Location = new System.Drawing.Point(34, 151);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(75, 24);
            this.lbSenha.TabIndex = 56;
            this.lbSenha.Text = "Senha: ";
            // 
            // txEmail
            // 
            this.txEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txEmail.Location = new System.Drawing.Point(251, 103);
            this.txEmail.MaxLength = 255;
            this.txEmail.Multiline = true;
            this.txEmail.Name = "txEmail";
            this.txEmail.Size = new System.Drawing.Size(207, 32);
            this.txEmail.TabIndex = 45;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(247, 76);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(67, 24);
            this.lbEmail.TabIndex = 55;
            this.lbEmail.Text = "Email: ";
            // 
            // txRg
            // 
            this.txRg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txRg.Location = new System.Drawing.Point(606, 103);
            this.txRg.MaxLength = 9;
            this.txRg.Multiline = true;
            this.txRg.Name = "txRg";
            this.txRg.Size = new System.Drawing.Size(118, 32);
            this.txRg.TabIndex = 49;
            // 
            // lbRg
            // 
            this.lbRg.AutoSize = true;
            this.lbRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRg.Location = new System.Drawing.Point(604, 76);
            this.lbRg.Name = "lbRg";
            this.lbRg.Size = new System.Drawing.Size(47, 24);
            this.lbRg.TabIndex = 53;
            this.lbRg.Text = "RG: ";
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpf.Location = new System.Drawing.Point(459, 76);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(57, 24);
            this.lbCpf.TabIndex = 51;
            this.lbCpf.Text = "CPF: ";
            // 
            // txNome
            // 
            this.txNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.Location = new System.Drawing.Point(38, 103);
            this.txNome.MaxLength = 255;
            this.txNome.Multiline = true;
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(207, 32);
            this.txNome.TabIndex = 44;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(37, 76);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(72, 24);
            this.lbNome.TabIndex = 47;
            this.lbNome.Text = "Nome: ";
            // 
            // UsuarioInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 371);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UsuarioInfoForm";
            this.Text = "Usuário";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btAvancar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.MaskedTextBox txCpf;
        private System.Windows.Forms.Label lbNascimento;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.RadioButton rdPessoaJuridica;
        private System.Windows.Forms.RadioButton rdPessoaFisica;
        private System.Windows.Forms.TextBox txCnpj;
        private System.Windows.Forms.Label lbCnpj;
        private System.Windows.Forms.TextBox txConfirmarSenha;
        private System.Windows.Forms.Label lbConfirmarSenha;
        private System.Windows.Forms.TextBox txSenha;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.TextBox txEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox txRg;
        private System.Windows.Forms.Label lbRg;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label lbNome;

        private System.Windows.Forms.ToolStripDropDown toolStripDropDown1;

        private System.Windows.Forms.Panel panel2;

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbGerencia;

        #endregion
    }
}