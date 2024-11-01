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
            DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
    }
}
