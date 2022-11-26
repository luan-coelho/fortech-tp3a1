namespace Fortech_TP3A1.Forms.Admin
{
    partial class SolicitacoesForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fortechDataSet5 = new Fortech_TP3A1.fortechDataSet5();
            this.solicitacaoServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.solicitacaoServicoTableAdapter = new Fortech_TP3A1.fortechDataSet5TableAdapters.SolicitacaoServicoTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalhesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eletronicoIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoServicoidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbGerencia = new System.Windows.Forms.Label();
            this.btVoltar = new System.Windows.Forms.Button();
            this.btEncerrarSessao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fortechDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitacaoServicoBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.detalhesDataGridViewTextBoxColumn,
            this.valorDataGridViewTextBoxColumn,
            this.usuarioIdDataGridViewTextBoxColumn,
            this.eletronicoIdDataGridViewTextBoxColumn,
            this.tipoServicoidDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.solicitacaoServicoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(744, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // fortechDataSet5
            // 
            this.fortechDataSet5.DataSetName = "fortechDataSet5";
            this.fortechDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // solicitacaoServicoBindingSource
            // 
            this.solicitacaoServicoBindingSource.DataMember = "SolicitacaoServico";
            this.solicitacaoServicoBindingSource.DataSource = this.fortechDataSet5;
            // 
            // solicitacaoServicoTableAdapter
            // 
            this.solicitacaoServicoTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // detalhesDataGridViewTextBoxColumn
            // 
            this.detalhesDataGridViewTextBoxColumn.DataPropertyName = "detalhes";
            this.detalhesDataGridViewTextBoxColumn.HeaderText = "detalhes";
            this.detalhesDataGridViewTextBoxColumn.Name = "detalhesDataGridViewTextBoxColumn";
            this.detalhesDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorDataGridViewTextBoxColumn
            // 
            this.valorDataGridViewTextBoxColumn.DataPropertyName = "valor";
            this.valorDataGridViewTextBoxColumn.HeaderText = "valor";
            this.valorDataGridViewTextBoxColumn.Name = "valorDataGridViewTextBoxColumn";
            this.valorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioIdDataGridViewTextBoxColumn
            // 
            this.usuarioIdDataGridViewTextBoxColumn.DataPropertyName = "Usuario_Id";
            this.usuarioIdDataGridViewTextBoxColumn.HeaderText = "Usuario_Id";
            this.usuarioIdDataGridViewTextBoxColumn.Name = "usuarioIdDataGridViewTextBoxColumn";
            this.usuarioIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // eletronicoIdDataGridViewTextBoxColumn
            // 
            this.eletronicoIdDataGridViewTextBoxColumn.DataPropertyName = "eletronico_Id";
            this.eletronicoIdDataGridViewTextBoxColumn.HeaderText = "eletronico_Id";
            this.eletronicoIdDataGridViewTextBoxColumn.Name = "eletronicoIdDataGridViewTextBoxColumn";
            this.eletronicoIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoServicoidDataGridViewTextBoxColumn
            // 
            this.tipoServicoidDataGridViewTextBoxColumn.DataPropertyName = "tipoServico_id";
            this.tipoServicoidDataGridViewTextBoxColumn.HeaderText = "tipoServico_id";
            this.tipoServicoidDataGridViewTextBoxColumn.Name = "tipoServicoidDataGridViewTextBoxColumn";
            this.tipoServicoidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.btVoltar);
            this.panel1.Controls.Add(this.btEncerrarSessao);
            this.panel1.Controls.Add(this.lbGerencia);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 75);
            this.panel1.TabIndex = 1;
            // 
            // lbGerencia
            // 
            this.lbGerencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGerencia.ForeColor = System.Drawing.Color.White;
            this.lbGerencia.Location = new System.Drawing.Point(31, 22);
            this.lbGerencia.Name = "lbGerencia";
            this.lbGerencia.Size = new System.Drawing.Size(272, 29);
            this.lbGerencia.TabIndex = 1;
            this.lbGerencia.Text = "Solicitações de serviço";
            // 
            // btVoltar
            // 
            this.btVoltar.BackColor = System.Drawing.Color.DarkGray;
            this.btVoltar.FlatAppearance.BorderSize = 0;
            this.btVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVoltar.ForeColor = System.Drawing.Color.White;
            this.btVoltar.Location = new System.Drawing.Point(553, 19);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(76, 33);
            this.btVoltar.TabIndex = 5;
            this.btVoltar.Text = "Voltar";
            this.btVoltar.UseVisualStyleBackColor = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btEncerrarSessao
            // 
            this.btEncerrarSessao.BackColor = System.Drawing.Color.Red;
            this.btEncerrarSessao.FlatAppearance.BorderSize = 0;
            this.btEncerrarSessao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btEncerrarSessao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEncerrarSessao.ForeColor = System.Drawing.Color.White;
            this.btEncerrarSessao.Location = new System.Drawing.Point(635, 22);
            this.btEncerrarSessao.Name = "btEncerrarSessao";
            this.btEncerrarSessao.Size = new System.Drawing.Size(121, 27);
            this.btEncerrarSessao.TabIndex = 6;
            this.btEncerrarSessao.Text = "Encerrar Sessão";
            this.btEncerrarSessao.UseVisualStyleBackColor = false;
            this.btEncerrarSessao.Click += new System.EventHandler(this.btEncerrarSessao_Click);
            // 
            // SolicitacoesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 414);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SolicitacoesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitações";
            this.Load += new System.EventHandler(this.SolicitacoesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fortechDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.solicitacaoServicoBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private fortechDataSet5 fortechDataSet5;
        private System.Windows.Forms.BindingSource solicitacaoServicoBindingSource;
        private fortechDataSet5TableAdapters.SolicitacaoServicoTableAdapter solicitacaoServicoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalhesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn eletronicoIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoServicoidDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbGerencia;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Button btEncerrarSessao;
    }
}