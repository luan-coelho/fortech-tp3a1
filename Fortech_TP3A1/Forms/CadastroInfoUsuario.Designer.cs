using System.ComponentModel;

namespace Fortech_TP3A1.Forms
{
    partial class CadastroInfoUsuario
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
            this.btAvancar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.txCpf = new System.Windows.Forms.MaskedTextBox();
            this.lbNascimento = new System.Windows.Forms.Label();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.rdPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.rdPessoaFisica = new System.Windows.Forms.RadioButton();
            this.txCnpj = new System.Windows.Forms.TextBox();
            this.lbCnpj = new System.Windows.Forms.Label();
            this.txRg = new System.Windows.Forms.TextBox();
            this.txNome = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbGerencia = new System.Windows.Forms.Label();
            this.lbRg = new System.Windows.Forms.Label();
            this.lbCpf = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdPj = new System.Windows.Forms.RadioButton();
            this.rdPf = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAvancar
            // 
            this.btAvancar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btAvancar.FlatAppearance.BorderSize = 0;
            this.btAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAvancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAvancar.ForeColor = System.Drawing.Color.White;
            this.btAvancar.Location = new System.Drawing.Point(235, 353);
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
            this.btCancelar.Location = new System.Drawing.Point(148, 353);
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
            this.txCpf.Location = new System.Drawing.Point(29, 232);
            this.txCpf.Mask = "999,999,999-99";
            this.txCpf.Name = "txCpf";
            this.txCpf.Size = new System.Drawing.Size(136, 29);
            this.txCpf.TabIndex = 48;
            // 
            // lbNascimento
            // 
            this.lbNascimento.AutoSize = true;
            this.lbNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNascimento.Location = new System.Drawing.Point(28, 279);
            this.lbNascimento.Name = "lbNascimento";
            this.lbNascimento.Size = new System.Drawing.Size(162, 24);
            this.lbNascimento.TabIndex = 61;
            this.lbNascimento.Text = "Data Nascimento: ";
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(30, 306);
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
            // 
            // txCnpj
            // 
            this.txCnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCnpj.Location = new System.Drawing.Point(29, 232);
            this.txCnpj.Multiline = true;
            this.txCnpj.Name = "txCnpj";
            this.txCnpj.Size = new System.Drawing.Size(282, 32);
            this.txCnpj.TabIndex = 46;
            // 
            // lbCnpj
            // 
            this.lbCnpj.AutoSize = true;
            this.lbCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCnpj.Location = new System.Drawing.Point(28, 205);
            this.lbCnpj.Name = "lbCnpj";
            this.lbCnpj.Size = new System.Drawing.Size(68, 24);
            this.lbCnpj.TabIndex = 58;
            this.lbCnpj.Text = "CNPJ: ";
            // 
            // txRg
            // 
            this.txRg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txRg.Location = new System.Drawing.Point(193, 232);
            this.txRg.MaxLength = 9;
            this.txRg.Multiline = true;
            this.txRg.Name = "txRg";
            this.txRg.Size = new System.Drawing.Size(118, 32);
            this.txRg.TabIndex = 49;
            // 
            // txNome
            // 
            this.txNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.Location = new System.Drawing.Point(29, 158);
            this.txNome.MaxLength = 255;
            this.txNome.Multiline = true;
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(282, 32);
            this.txNome.TabIndex = 44;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Controls.Add(this.lbGerencia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 70);
            this.panel1.TabIndex = 46;
            // 
            // lbGerencia
            // 
            this.lbGerencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGerencia.ForeColor = System.Drawing.Color.White;
            this.lbGerencia.Location = new System.Drawing.Point(16, 18);
            this.lbGerencia.Name = "lbGerencia";
            this.lbGerencia.Size = new System.Drawing.Size(235, 29);
            this.lbGerencia.TabIndex = 1;
            this.lbGerencia.Text = "Informações Básicas";
            // 
            // lbRg
            // 
            this.lbRg.AutoSize = true;
            this.lbRg.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRg.Location = new System.Drawing.Point(191, 205);
            this.lbRg.Name = "lbRg";
            this.lbRg.Size = new System.Drawing.Size(47, 24);
            this.lbRg.TabIndex = 53;
            this.lbRg.Text = "RG: ";
            // 
            // lbCpf
            // 
            this.lbCpf.AutoSize = true;
            this.lbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCpf.Location = new System.Drawing.Point(28, 205);
            this.lbCpf.Name = "lbCpf";
            this.lbCpf.Size = new System.Drawing.Size(57, 24);
            this.lbCpf.TabIndex = 51;
            this.lbCpf.Text = "CPF: ";
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(28, 131);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(72, 24);
            this.lbNome.TabIndex = 47;
            this.lbNome.Text = "Nome: ";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.rdPj);
            this.panel2.Controls.Add(this.rdPf);
            this.panel2.Controls.Add(this.btAvancar);
            this.panel2.Controls.Add(this.btCancelar);
            this.panel2.Controls.Add(this.txCpf);
            this.panel2.Controls.Add(this.lbNascimento);
            this.panel2.Controls.Add(this.dtpNascimento);
            this.panel2.Controls.Add(this.rdPessoaJuridica);
            this.panel2.Controls.Add(this.rdPessoaFisica);
            this.panel2.Controls.Add(this.txCnpj);
            this.panel2.Controls.Add(this.lbCnpj);
            this.panel2.Controls.Add(this.txRg);
            this.panel2.Controls.Add(this.lbRg);
            this.panel2.Controls.Add(this.lbCpf);
            this.panel2.Controls.Add(this.txNome);
            this.panel2.Controls.Add(this.lbNome);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 398);
            this.panel2.TabIndex = 47;
            // 
            // rdPj
            // 
            this.rdPj.AutoSize = true;
            this.rdPj.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPj.Location = new System.Drawing.Point(162, 85);
            this.rdPj.Name = "rdPj";
            this.rdPj.Size = new System.Drawing.Size(155, 26);
            this.rdPj.TabIndex = 65;
            this.rdPj.Text = "Pessoa Jurídica";
            this.rdPj.UseVisualStyleBackColor = true;
            this.rdPj.CheckedChanged += new System.EventHandler(this.rdPj_CheckedChanged);
            // 
            // rdPf
            // 
            this.rdPf.AutoSize = true;
            this.rdPf.Checked = true;
            this.rdPf.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdPf.Location = new System.Drawing.Point(16, 85);
            this.rdPf.Name = "rdPf";
            this.rdPf.Size = new System.Drawing.Size(140, 26);
            this.rdPf.TabIndex = 64;
            this.rdPf.TabStop = true;
            this.rdPf.Text = "Pessoa Física";
            this.rdPf.UseVisualStyleBackColor = true;
            this.rdPf.CheckedChanged += new System.EventHandler(this.rdPf_CheckedChanged);
            // 
            // CadastroInfoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(339, 398);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "CadastroInfoUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lbGerencia;

        private System.Windows.Forms.RadioButton rdPj;
        private System.Windows.Forms.RadioButton rdPf;

        private System.Windows.Forms.Button btAvancar;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.MaskedTextBox txCpf;
        private System.Windows.Forms.Label lbNascimento;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.RadioButton rdPessoaJuridica;
        private System.Windows.Forms.RadioButton rdPessoaFisica;
        private System.Windows.Forms.TextBox txCnpj;
        private System.Windows.Forms.Label lbCnpj;
        private System.Windows.Forms.TextBox txRg;
        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbRg;
        private System.Windows.Forms.Label lbCpf;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Panel panel2;

        #endregion
    }
}