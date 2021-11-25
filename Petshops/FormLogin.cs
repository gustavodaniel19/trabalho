using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Petshops
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string login, senha;
            login = txtLogin.Text;
            senha = txtSenha.Text;
            if (login == "admin" && senha == "admin")
            {
                FormPrincipal principal = new FormPrincipal();
                principal.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Suas credencias não foram validadas, tente novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Text = "";
                txtSenha.Text = "";
            }
        }
    }
}
