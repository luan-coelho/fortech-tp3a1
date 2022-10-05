using System;
using System.Windows.Forms;
using Fortech_TP3A1.Model;

namespace Fortech_TP3A1.Forms.Admin
{
    public partial class CadastrarEletronico : Form
    {
        public CadastrarEletronico()
        {
            InitializeComponent();
        }
        
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            var eletronico = new Eletronico
            {
                nome = txNome.Text,
                marca = txMarca.Text,
                modelo = txModelo.Text,
                numeroNotaFiscal = txNotaFiscal.Text,
                dataFabricao = dtpDtFabricacao.Value,
                observacoes = txObservacoes.Text
            };
            
            ContextoGlobal.eletronico = eletronico;
            Close();
            var form = new SolicitacaoServicoForm();
            form.Show();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            Close();
            new SolicitacaoServicoForm().Show();
        }
    }
}