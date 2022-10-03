using System.ComponentModel;

namespace Fortech_TP3A1.Forms
{
    partial class EnderecoForm
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
            this.btVoltar = new System.Windows.Forms.Button();
            this.txRua = new System.Windows.Forms.TextBox();
            this.lbCep = new System.Windows.Forms.Label();
            this.lbRua = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txNumero = new System.Windows.Forms.TextBox();
            this.lbBairro = new System.Windows.Forms.Label();
            this.txBairro = new System.Windows.Forms.TextBox();
            this.panel = new System.Windows.Forms.Panel();
            this.lbGerencia = new System.Windows.Forms.Label();
            this.txCep = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txComplemento = new System.Windows.Forms.TextBox();
            this.txCidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txEstado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btAvancar = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.dtgEndereco = new System.Windows.Forms.DataGridView();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEndereco)).BeginInit();
            this.SuspendLayout();
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.Silver;
            this.btVoltar.FlatAppearance.BorderSize = 0;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.ForeColor = System.Drawing.Color.Black;
            this.btVoltar.Location = new System.Drawing.Point(250, 434);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(76, 33);
            this.btVoltar.TabIndex = 63;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click_1);
            // 
            // txRua
            // 
            this.txRua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txRua.Location = new System.Drawing.Point(32, 173);
            this.txRua.MaxLength = 255;
            this.txRua.Multiline = true;
            this.txRua.Name = "txRua";
            this.txRua.Size = new System.Drawing.Size(282, 32);
            this.txRua.TabIndex = 64;
            // 
            // lbCep
            // 
            this.lbCep.AutoSize = true;
            this.lbCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCep.Location = new System.Drawing.Point(32, 106);
            this.lbCep.Name = "lbCep";
            this.lbCep.Size = new System.Drawing.Size(58, 24);
            this.lbCep.TabIndex = 65;
            this.lbCep.Text = "CEP: ";
            // 
            // lbRua
            // 
            this.lbRua.AutoSize = true;
            this.lbRua.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRua.Location = new System.Drawing.Point(32, 146);
            this.lbRua.Name = "lbRua";
            this.lbRua.Size = new System.Drawing.Size(54, 24);
            this.lbRua.TabIndex = 66;
            this.lbRua.Text = "Rua: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(331, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 68;
            this.label1.Text = "Número: ";
            // 
            // txNumero
            // 
            this.txNumero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNumero.Location = new System.Drawing.Point(331, 173);
            this.txNumero.MaxLength = 255;
            this.txNumero.Multiline = true;
            this.txNumero.Name = "txNumero";
            this.txNumero.Size = new System.Drawing.Size(77, 32);
            this.txNumero.TabIndex = 67;
            // 
            // lbBairro
            // 
            this.lbBairro.AutoSize = true;
            this.lbBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBairro.Location = new System.Drawing.Point(32, 215);
            this.lbBairro.Name = "lbBairro";
            this.lbBairro.Size = new System.Drawing.Size(69, 24);
            this.lbBairro.TabIndex = 70;
            this.lbBairro.Text = "Bairro: ";
            // 
            // txBairro
            // 
            this.txBairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBairro.Location = new System.Drawing.Point(32, 242);
            this.txBairro.MaxLength = 255;
            this.txBairro.Multiline = true;
            this.txBairro.Name = "txBairro";
            this.txBairro.Size = new System.Drawing.Size(376, 32);
            this.txBairro.TabIndex = 69;
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel.Controls.Add(this.lbGerencia);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(809, 75);
            this.panel.TabIndex = 71;
            // 
            // lbGerencia
            // 
            this.lbGerencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGerencia.ForeColor = System.Drawing.Color.White;
            this.lbGerencia.Location = new System.Drawing.Point(32, 20);
            this.lbGerencia.Name = "lbGerencia";
            this.lbGerencia.Size = new System.Drawing.Size(235, 29);
            this.lbGerencia.TabIndex = 2;
            this.lbGerencia.Text = "Endereço";
            this.lbGerencia.Click += new System.EventHandler(this.lbGerencia_Click);
            // 
            // txCep
            // 
            this.txCep.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCep.Location = new System.Drawing.Point(85, 102);
            this.txCep.Mask = "99999-999";
            this.txCep.Name = "txCep";
            this.txCep.Size = new System.Drawing.Size(112, 32);
            this.txCep.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 282);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 24);
            this.label2.TabIndex = 74;
            this.label2.Text = "Complemento:";
            // 
            // txComplemento
            // 
            this.txComplemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txComplemento.Location = new System.Drawing.Point(32, 309);
            this.txComplemento.MaxLength = 255;
            this.txComplemento.Multiline = true;
            this.txComplemento.Name = "txComplemento";
            this.txComplemento.Size = new System.Drawing.Size(376, 32);
            this.txComplemento.TabIndex = 73;
            // 
            // txCidade
            // 
            this.txCidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txCidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txCidade.Location = new System.Drawing.Point(32, 379);
            this.txCidade.MaxLength = 255;
            this.txCidade.Multiline = true;
            this.txCidade.Name = "txCidade";
            this.txCidade.Size = new System.Drawing.Size(184, 32);
            this.txCidade.TabIndex = 75;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 352);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 76;
            this.label3.Text = "Cidade:";
            // 
            // txEstado
            // 
            this.txEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txEstado.Location = new System.Drawing.Point(224, 379);
            this.txEstado.MaxLength = 255;
            this.txEstado.Multiline = true;
            this.txEstado.Name = "txEstado";
            this.txEstado.Size = new System.Drawing.Size(184, 32);
            this.txEstado.TabIndex = 77;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(224, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 78;
            this.label4.Text = "Estado:";
            // 
            // btAvancar
            // 
            this.btAvancar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btAvancar.FlatAppearance.BorderSize = 0;
            this.btAvancar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAvancar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAvancar.ForeColor = System.Drawing.Color.White;
            this.btAvancar.Location = new System.Drawing.Point(332, 434);
            this.btAvancar.Name = "btAvancar";
            this.btAvancar.Size = new System.Drawing.Size(76, 33);
            this.btAvancar.TabIndex = 79;
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
            this.btCancelar.Location = new System.Drawing.Point(32, 434);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(76, 33);
            this.btCancelar.TabIndex = 80;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btPesquisar
            // 
            this.btPesquisar.BackColor = System.Drawing.Color.Silver;
            this.btPesquisar.FlatAppearance.BorderSize = 0;
            this.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btPesquisar.ForeColor = System.Drawing.Color.Black;
            this.btPesquisar.Location = new System.Drawing.Point(198, 104);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(83, 29);
            this.btPesquisar.TabIndex = 81;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.UseVisualStyleBackColor = false;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // dtgEndereco
            // 
            this.dtgEndereco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEndereco.Location = new System.Drawing.Point(426, 146);
            this.dtgEndereco.MultiSelect = false;
            this.dtgEndereco.Name = "dtgEndereco";
            this.dtgEndereco.Size = new System.Drawing.Size(371, 265);
            this.dtgEndereco.TabIndex = 82;
            // 
            // EnderecoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 479);
            this.Controls.Add(this.dtgEndereco);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAvancar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txEstado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txCidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txComplemento);
            this.Controls.Add(this.txCep);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lbBairro);
            this.Controls.Add(this.txBairro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txNumero);
            this.Controls.Add(this.lbRua);
            this.Controls.Add(this.txRua);
            this.Controls.Add(this.lbCep);
            this.Controls.Add(this.btVoltar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnderecoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Endereço";
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEndereco)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.DataGridView dtgEndereco;

        private System.Windows.Forms.Button btPesquisar;

        private System.Windows.Forms.Button btCancelar;

        private System.Windows.Forms.Button btAvancar;

        private System.Windows.Forms.TextBox txEstado;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.TextBox txCidade;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txComplemento;

        private System.Windows.Forms.MaskedTextBox txCep;

        private System.Windows.Forms.Label lbGerencia;

        private System.Windows.Forms.TextBox txRua;
        private System.Windows.Forms.Label lbCep;
        private System.Windows.Forms.Label lbRua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txNumero;
        private System.Windows.Forms.Label lbBairro;
        private System.Windows.Forms.TextBox txBairro;
        private System.Windows.Forms.Panel panel;

        private System.Windows.Forms.Button btVoltar;

        #endregion
    }
}