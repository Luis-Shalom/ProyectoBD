using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void usertex_Enter(object sender, EventArgs e)
        {
            if (usertex.Text == "USERNAME")
            {
                usertex.Text = "";
                usertex.ForeColor = Color.LightGray;
            }
        }

        private void usertex_Leave(object sender, EventArgs e)
        {
            if (usertex.Text == "")
            {
                usertex.Text = "USERNAME";
                usertex.ForeColor = Color.DimGray;
            }
        }

        private void passtxt_Enter(object sender, EventArgs e)
        {
            if (passtxt.Text == "PASSWORD")
            {
                passtxt.Text = "";
                passtxt.ForeColor = Color.LightGray;
                passtxt.UseSystemPasswordChar = true;
            }
        }

        private void passtxt_Leave(object sender, EventArgs e)
        {
            if (passtxt.Text == "")
            {
                passtxt.Text = "PASSWORD";
                passtxt.ForeColor = Color.DimGray;
                passtxt.UseSystemPasswordChar = false;
            }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
