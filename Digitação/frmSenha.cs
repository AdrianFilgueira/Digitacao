using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digitação
{
    public partial class frmSenha : Form
    {
        public frmSenha()
        {
            InitializeComponent();
        }
        public string senha = "";


        private void btnAcessar_Click(object sender, EventArgs e)
        {
            senha = txtSenha.Text;
            Close();
        }

        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAcessar_Click(sender, e);
            }
        }

        private void frmSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
