using CLUSA;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmMenu : Form
    {
        private RepositorioUsers repositorio;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Users users = new Users();
            users.Username = txtUsername.Text;
            users.Password = txtPassword.Text;
            //txtResultado.Text = users.Username;
            //txtResultado.Text = string.Concat("mongodb+srv://", txtUsername.ToString(), ":", txtPassword.ToString(), "@cluster0.cn10nzt.mongodb.net/");
            repositorio = new RepositorioUsers(users);
            txtResultado.Text = repositorio.Login(users.Username, users.Password);
        }
    }
}
