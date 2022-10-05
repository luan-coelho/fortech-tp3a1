using System.ComponentModel;

namespace Fortech_TP3A1.Forms.Admin
{
    partial class CadastrarEletronico
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
            this.txNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btVoltar = new System.Windows.Forms.Button();
            this.lbGerencia = new System.Windows.Forms.Label();
            this.txModelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txNotaFiscal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txObservacoes = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDtFabricacao = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txNome
            // 
            this.txNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.Location = new System.Drawing.Point(33, 152);
            this.txNome.MaxLength = 255;
            this.txNome.Multiline = true;
            this.txNome.Name = "txNome";
            this.txNome.Size = new System.Drawing.Size(282, 32);
            this.txNome.TabIndex = 48;
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(32, 125);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(72, 24);
            this.lbNome.TabIndex = 49;
            this.lbNome.Text = "Nome: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btVoltar);
            this.panel1.Controls.Add(this.lbGerencia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 100);
            this.panel1.TabIndex = 50;
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.DarkGray;
            this.btVoltar.FlatAppearance.BorderSize = 0;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.ForeColor = System.Drawing.Color.White;
            this.btVoltar.Location = new System.Drawing.Point(528, 35);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(76, 33);
            this.btVoltar.TabIndex = 68;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // lbGerencia
            // 
            this.lbGerencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGerencia.ForeColor = System.Drawing.Color.White;
            this.lbGerencia.Location = new System.Drawing.Point(32, 39);
            this.lbGerencia.Name = "lbGerencia";
            this.lbGerencia.Size = new System.Drawing.Size(252, 29);
            this.lbGerencia.TabIndex = 67;
            this.lbGerencia.Text = "Adicionar eletrônico";
            // 
            // txModelo
            // 
            this.txModelo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txModelo.Location = new System.Drawing.Point(322, 152);
            this.txModelo.MaxLength = 255;
            this.txModelo.Multiline = true;
            this.txModelo.Name = "txModelo";
            this.txModelo.Size = new System.Drawing.Size(282, 32);
            this.txModelo.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 52;
            this.label1.Text = "Modelo: ";
            // 
            // txMarca
            // 
            this.txMarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txMarca.Location = new System.Drawing.Point(33, 228);
            this.txMarca.MaxLength = 255;
            this.txMarca.Multiline = true;
            this.txMarca.Name = "txMarca";
            this.txMarca.Size = new System.Drawing.Size(194, 32);
            this.txMarca.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 54;
            this.label2.Text = "Marca: ";
            // 
            // txNotaFiscal
            // 
            this.txNotaFiscal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txNotaFiscal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNotaFiscal.Location = new System.Drawing.Point(233, 228);
            this.txNotaFiscal.MaxLength = 255;
            this.txNotaFiscal.Multiline = true;
            this.txNotaFiscal.Name = "txNotaFiscal";
            this.txNotaFiscal.Size = new System.Drawing.Size(216, 32);
            this.txNotaFiscal.TabIndex = 55;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(233, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 24);
            this.label3.TabIndex = 56;
            this.label3.Text = "Número da nota fiscal";
            // 
            // txObservacoes
            // 
            this.txObservacoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txObservacoes.Location = new System.Drawing.Point(32, 302);
            this.txObservacoes.MaxLength = 255;
            this.txObservacoes.Multiline = true;
            this.txObservacoes.Name = "txObservacoes";
            this.txObservacoes.Size = new System.Drawing.Size(579, 124);
            this.txObservacoes.TabIndex = 59;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 24);
            this.label5.TabIndex = 60;
            this.label5.Text = "Observações: ";
            // 
            // dtpDtFabricacao
            // 
            this.dtpDtFabricacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDtFabricacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtFabricacao.Location = new System.Drawing.Point(455, 233);
            this.dtpDtFabricacao.MaxDate = new System.DateTime(2140, 12, 31, 0, 0, 0, 0);
            this.dtpDtFabricacao.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDtFabricacao.Name = "dtpDtFabricacao";
            this.dtpDtFabricacao.Size = new System.Drawing.Size(106, 27);
            this.dtpDtFabricacao.TabIndex = 61;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(455, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 24);
            this.label6.TabIndex = 62;
            this.label6.Text = "Data Fabricação: ";
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btAdicionar.FlatAppearance.BorderSize = 0;
            this.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionar.ForeColor = System.Drawing.Color.White;
            this.btAdicionar.Location = new System.Drawing.Point(535, 433);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(76, 33);
            this.btAdicionar.TabIndex = 71;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = false;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // CadastrarEletronico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(637, 478);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDtFabricacao);
            this.Controls.Add(this.txObservacoes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txNotaFiscal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txModelo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.lbNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastrarEletronico";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Eletrônico";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btVoltar;

        private System.Windows.Forms.Button btAdicionar;

        private System.Windows.Forms.Label lbGerencia;

        private System.Windows.Forms.DateTimePicker dtpDtFabricacao;
        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.TextBox txObservacoes;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.TextBox txNotaFiscal;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox txMarca;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox txModelo;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Panel panel1;

        #endregion
    }
}