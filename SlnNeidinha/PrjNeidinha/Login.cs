using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjNeidinha
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAcessarLogin_Click(object sender, EventArgs e)
        {
            Inicio inicio = new Inicio();
            inicio.Show();
        }
    }
}
