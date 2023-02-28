using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjNeidinha
{
    public partial class Inicio : Form
    {
        private Form ativarForm;
        public Inicio()
        {
            InitializeComponent();
            btnFecharForm.Visible = false;
        }
        [DllImport("user32.DLL", EntryPoint = "RealizarCaptura")]
        private extern static void RealizarCaptura();
        [DllImport("user32.DLL", EntryPoint = "Mensagem")]
        private extern static void Mensagem(System.IntPtr hWnd, int wMsg, int Wparam, int lParam);
        private void btnEstoque_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Estoque(), sender);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Cadastrar_Funcionario(), sender);
        }
        private void AbrirFormulario(Form Form, object btnSender)
        {
            if (ativarForm != null) 
            {
                ativarForm.Close();
            }
            //ActivateButton(btnSender);
            ativarForm = Form;
            Form.TopLevel = false;
            Form.FormBorderStyle = FormBorderStyle.None;
            Form.Dock = DockStyle.Fill;
            this.painelDesktop.Controls.Add(Form);
            this.painelDesktop.Tag = Form;
            Form.BringToFront();
            Form.Show();
            btnFecharForm.Visible = true;
        }

        private void btnFecharForm_Click(object sender, EventArgs e)
        {
            if(ativarForm != null)
                ativarForm.Close();
                Reset();
            
        }

        private void Reset()
        {
            btnFecharForm.Visible = false;
        }
    }
}
