using System.ComponentModel;

namespace Fortech_TP3A1.Forms.Admin
{
    partial class SolicitacaoServicoForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txNome = new System.Windows.Forms.TextBox();
            this.lbNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txDetalhes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btVoltar = new System.Windows.Forms.Button();
            this.lbGerencia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btSalvar = new System.Windows.Forms.Button();
            this.cbTipoServico = new System.Windows.Forms.ComboBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fortechDataSet2 = new Fortech_TP3A1.fortechDataSet2();
            this.tipoServicoTableAdapter1 = new Fortech_TP3A1.fortechDataSet2TableAdapters.TipoServicoTableAdapter();
            this.txValor = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btAdicionarCliente = new System.Windows.Forms.Button();
            this.lbNomeUsuario = new System.Windows.Forms.Label();
            this.dtgEletronico = new System.Windows.Forms.DataGridView();
            this.clmRemover = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btEncerrarSessao = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fortechDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEletronico)).BeginInit();
            this.SuspendLayout();
            // 
            // txNome
            // 
            this.txNome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNome.Location = new System.Drawing.Point(18, 108);
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
            this.lbNome.Location = new System.Drawing.Point(17, 81);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(72, 24);
            this.lbNome.TabIndex = 49;
            this.lbNome.Text = "Nome: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 24);
            this.label1.TabIndex = 50;
            this.label1.Text = "Detalhes";
            // 
            // txDetalhes
            // 
            this.txDetalhes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txDetalhes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txDetalhes.Location = new System.Drawing.Point(17, 182);
            this.txDetalhes.MaxLength = 255;
            this.txDetalhes.Multiline = true;
            this.txDetalhes.Name = "txDetalhes";
            this.txDetalhes.Size = new System.Drawing.Size(282, 214);
            this.txDetalhes.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(341, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 53;
            this.label2.Text = "Eletrônicos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 55;
            this.label3.Text = "Valor: ";
            // 
            // btAdicionar
            // 
            this.btAdicionar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btAdicionar.FlatAppearance.BorderSize = 0;
            this.btAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionar.ForeColor = System.Drawing.Color.White;
            this.btAdicionar.Location = new System.Drawing.Point(344, 221);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(101, 33);
            this.btAdicionar.TabIndex = 64;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = false;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btEncerrarSessao);
            this.panel1.Controls.Add(this.btVoltar);
            this.panel1.Controls.Add(this.lbGerencia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 65);
            this.panel1.TabIndex = 65;
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.DarkGray;
            this.btVoltar.FlatAppearance.BorderSize = 0;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.ForeColor = System.Drawing.Color.White;
            this.btVoltar.Location = new System.Drawing.Point(476, 15);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(76, 33);
            this.btVoltar.TabIndex = 67;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // lbGerencia
            // 
            this.lbGerencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGerencia.ForeColor = System.Drawing.Color.White;
            this.lbGerencia.Location = new System.Drawing.Point(19, 20);
            this.lbGerencia.Name = "lbGerencia";
            this.lbGerencia.Size = new System.Drawing.Size(252, 29);
            this.lbGerencia.TabIndex = 66;
            this.lbGerencia.Text = "Solicitação de Serviço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(344, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 24);
            this.label4.TabIndex = 67;
            this.label4.Text = "Tipo Serviço";
            // 
            // btSalvar
            // 
            this.btSalvar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btSalvar.FlatAppearance.BorderSize = 0;
            this.btSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalvar.ForeColor = System.Drawing.Color.White;
            this.btSalvar.Location = new System.Drawing.Point(603, 457);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(76, 33);
            this.btSalvar.TabIndex = 69;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = false;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // cbTipoServico
            // 
            this.cbTipoServico.DataSource = this.bindingSource1;
            this.cbTipoServico.DisplayMember = "nome";
            this.cbTipoServico.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoServico.FormattingEnabled = true;
            this.cbTipoServico.Location = new System.Drawing.Point(344, 297);
            this.cbTipoServico.Name = "cbTipoServico";
            this.cbTipoServico.Size = new System.Drawing.Size(195, 33);
            this.cbTipoServico.TabIndex = 72;
            this.cbTipoServico.ValueMember = "id";
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "TipoServico";
            this.bindingSource1.DataSource = this.fortechDataSet2;
            // 
            // fortechDataSet2
            // 
            this.fortechDataSet2.DataSetName = "fortechDataSet2";
            this.fortechDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoServicoTableAdapter1
            // 
            this.tipoServicoTableAdapter1.ClearBeforeFill = true;
            // 
            // txValor
            // 
            this.txValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txValor.Location = new System.Drawing.Point(49, 436);
            this.txValor.Mask = "00000";
            this.txValor.Name = "txValor";
            this.txValor.Size = new System.Drawing.Size(73, 35);
            this.txValor.TabIndex = 73;
            this.txValor.ValidatingType = typeof(int);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 24);
            this.label5.TabIndex = 74;
            this.label5.Text = "R$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(344, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 24);
            this.label6.TabIndex = 75;
            this.label6.Text = "Cliente";
            // 
            // btAdicionarCliente
            // 
            this.btAdicionarCliente.BackColor = System.Drawing.SystemColors.Highlight;
            this.btAdicionarCliente.FlatAppearance.BorderSize = 0;
            this.btAdicionarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAdicionarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionarCliente.ForeColor = System.Drawing.Color.White;
            this.btAdicionarCliente.Location = new System.Drawing.Point(344, 373);
            this.btAdicionarCliente.Name = "btAdicionarCliente";
            this.btAdicionarCliente.Size = new System.Drawing.Size(101, 33);
            this.btAdicionarCliente.TabIndex = 76;
            this.btAdicionarCliente.Text = "Adicionar";
            this.btAdicionarCliente.UseVisualStyleBackColor = false;
            this.btAdicionarCliente.Click += new System.EventHandler(this.btAdicionarCliente_Click);
            // 
            // lbNomeUsuario
            // 
            this.lbNomeUsuario.AutoSize = true;
            this.lbNomeUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeUsuario.Location = new System.Drawing.Point(344, 412);
            this.lbNomeUsuario.Name = "lbNomeUsuario";
            this.lbNomeUsuario.Size = new System.Drawing.Size(98, 20);
            this.lbNomeUsuario.TabIndex = 77;
            this.lbNomeUsuario.Text = "nomeCliente";
            this.lbNomeUsuario.Visible = false;
            // 
            // dtgEletronico
            // 
            this.dtgEletronico.AllowUserToAddRows = false;
            this.dtgEletronico.AllowUserToDeleteRows = false;
            this.dtgEletronico.AllowUserToResizeColumns = false;
            this.dtgEletronico.AllowUserToResizeRows = false;
            this.dtgEletronico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEletronico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmRemover});
            this.dtgEletronico.Location = new System.Drawing.Point(344, 108);
            this.dtgEletronico.MultiSelect = false;
            this.dtgEletronico.Name = "dtgEletronico";
            this.dtgEletronico.Size = new System.Drawing.Size(335, 107);
            this.dtgEletronico.TabIndex = 78;
            this.dtgEletronico.VirtualMode = true;
            this.dtgEletronico.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEletronico_CellClick);
            // 
            // clmRemover
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.clmRemover.DefaultCellStyle = dataGridViewCellStyle2;
            this.clmRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clmRemover.HeaderText = "";
            this.clmRemover.Name = "clmRemover";
            this.clmRemover.Text = "Remover";
            // 
            // btEncerrarSessao
            // 
            this.btEncerrarSessao.BackColor = System.Drawing.Color.Red;
            this.btEncerrarSessao.FlatAppearance.BorderSize = 0;
            this.btEncerrarSessao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEncerrarSessao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEncerrarSessao.ForeColor = System.Drawing.Color.White;
            this.btEncerrarSessao.Location = new System.Drawing.Point(558, 18);
            this.btEncerrarSessao.Name = "btEncerrarSessao";
            this.btEncerrarSessao.Size = new System.Drawing.Size(121, 27);
            this.btEncerrarSessao.TabIndex = 68;
            this.btEncerrarSessao.Text = "Encerrar Sessão";
            this.btEncerrarSessao.UseVisualStyleBackColor = false;
            this.btEncerrarSessao.Click += new System.EventHandler(this.btEncerrarSessao_Click);
            // 
            // SolicitacaoServicoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 502);
            this.Controls.Add(this.dtgEletronico);
            this.Controls.Add(this.lbNomeUsuario);
            this.Controls.Add(this.btAdicionarCliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txValor);
            this.Controls.Add(this.cbTipoServico);
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txDetalhes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txNome);
            this.Controls.Add(this.lbNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SolicitacaoServicoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitação de Serviço";
            this.Load += new System.EventHandler(this.SolicitacaoServicoForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fortechDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEletronico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.DataGridView dtgEletronico;

        private System.Windows.Forms.Label label6;

        private System.Windows.Forms.ComboBox cbTipoServico;

        private System.Windows.Forms.Button btVoltar;

        private System.Windows.Forms.Button btSalvar;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Label lbGerencia;

        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox txNome;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox txDetalhes;

        #endregion

        private fortechDataSet1 fortechDataSet1;
        private System.Windows.Forms.BindingSource tipoServicoBindingSource;
        private fortechDataSet1TableAdapters.TipoServicoTableAdapter tipoServicoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private fortechDataSet2 fortechDataSet2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private fortechDataSet2TableAdapters.TipoServicoTableAdapter tipoServicoTableAdapter1;
        private System.Windows.Forms.MaskedTextBox txValor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btAdicionarCliente;
        private System.Windows.Forms.Label lbNomeUsuario;
        private System.Windows.Forms.DataGridViewButtonColumn clmRemover;
        private System.Windows.Forms.Button btEncerrarSessao;
    }
}