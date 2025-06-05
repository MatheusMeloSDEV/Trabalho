using CLUSA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabalho
{
    public partial class FrmModifica : Form
    {
        public FrmModifica()
        {
            InitializeComponent();  
            var repositorio = new RepositorioOrgaoAnuente<TiposOrgaoAnuente>("MAPA");
        }

        private void FrmModifica_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            // Crie uma instância do repositório para a entidade desejada (exemplo: MAPA)
            var repositorio = new RepositorioOrgaoAnuente<TiposOrgaoAnuente>("MAPA");
            var lista = repositorio.ListarTodos();
            BsModifica.DataSource = lista;

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            // Implemente aqui a lógica de salvar/editar os dados do formulário
            // Exemplo: validar campos, atualizar entidade, definir DialogResult
            DialogResult = DialogResult.OK;
        }

        private void TErro_Tick(object sender, EventArgs e)
        {
            // Lógica para exibir ou ocultar mensagens de erro temporárias, se necessário
            // Exemplo: LblErro.Visible = false;
        }
    }
}
