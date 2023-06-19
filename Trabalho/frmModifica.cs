using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLUSA;

namespace Trabalho
{
    public partial class frmModifica : Form
    {
        public MAPA mapa;

        public frmModifica()
        {
            InitializeComponent();
        }

        private void frmModifica_Load(object sender, EventArgs e)
        {
            bsModificaMAPA.DataSource = mapa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
