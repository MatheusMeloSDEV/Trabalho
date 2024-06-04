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
    public partial class frmModificaProcesso : Form
    {
        public Processo processo;
        public frmModificaProcesso()
        {
            InitializeComponent();
        }

        private void frmModificaProcesso_Load(object sender, EventArgs e)
        {
            bsModificaProcesso.DataSource = processo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            processo.NR = 1;
            processo.SR = 1;
            processo.Importador = "insImportador.Text";
            processo.Terminal = "insTerminal.Text";
            processo.StatusDoProcesso = "insTerminal.Text";
            DialogResult = DialogResult.OK;
        }
    }
}
