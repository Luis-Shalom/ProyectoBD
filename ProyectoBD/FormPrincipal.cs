﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoEDM.ModeloBD;
using ProyectoBD.Catalogos;
namespace ProyectoBD
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        public void Pantallaok()
        {
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        

        private void Wrapper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            Pantallaok();
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            //DialogResult result = new DialogResult();
            //Form mensaje = new 
        }

        private void Sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox4.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
            MessageBox.Show("CERRANDO");

        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox4.Visible = true;
            btnMaximizar.Visible = false;
        }

        private void btncliente_Click(object sender, EventArgs e)
        {
            // Form  Cliente = new FormCliente();
            //Cliente.Visible = true;
            // Visible = false;

            AbrirFormHijos(new FormCliente());
        }




        private void btnArea_Click(object sender, EventArgs e)
        {
            AbrirFormHijos(new Proveedor());
              
        }
        //https://www.youtube.com/watch?v=Z7TfV7LZzp4
        private void AbrirFormHijos( object formhijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
            
                this.panelContenedor.Controls.RemoveAt(0);

                Form fh = formhijo as Form;

                fh.TopLevel = true;
                fh.Dock = DockStyle.Fill;
                this.panelContenedor.Controls.Add(fh);
                this.panelContenedor.Tag = fh;
                fh.Show();


            
        }
    }
}
