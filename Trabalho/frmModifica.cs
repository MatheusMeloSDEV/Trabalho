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
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            bsModificaMAPA.DataSource = mapa;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mapa.Previsao = dateTimePicker1.Value.ToShortDateString();
            this.DialogResult = DialogResult.OK;
        }

        private void btnOkMAPA_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }
    }
}
