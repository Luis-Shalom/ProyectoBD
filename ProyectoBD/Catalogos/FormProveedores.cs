using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoDAO;
using ProyectoEDM.ModeloBD;
using System.Windows.Forms;

namespace ProyectoBD.Catalogos
{
    public partial class Proveedores : Form
    {
        private ProveedoresDAO proveeDAO  = new ProveedoresDAO();
        private bool NuevoRegistro = false;
        private Proveedor oprovee;

        //readonly MaterialSkin.MaterialSkinManager materialSkinManager;


        public Proveedores()
        {
            InitializeComponent();
            
            //materialSkinManager = MaterialSkin.MaterialSkinManager.Instance;
            //materialSkinManager.EnforceBackcolorOnAllComponents = true;
            //materialSkinManager.AddFormToManage(this);
            //materialSkinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //materialSkinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

        }

        private void cargar()
        {
            using (ProyectoEntities2 contexto = new ProyectoEntities2())
            {
                var lst = from d in contexto.Proveedors
                          select d;

                dataGridView1.DataSource = lst.ToList();
            }

        }
        private void DesactivarControles(bool EstadoCtrl)
        {
            txtcodig.Enabled = !EstadoCtrl;
            txtnom.Enabled = !EstadoCtrl;
            txtcorre.Enabled = !EstadoCtrl;
           rsocial.Enabled = !EstadoCtrl;
            txttel.Enabled = !EstadoCtrl;
            direcc.Enabled = !EstadoCtrl;
            btnguardar.Enabled = !EstadoCtrl;
            btnelimi.Enabled = !EstadoCtrl;


        }
        private void LimpiarControles()
        {

            txtcodig.Text = "";
            txtnom.Text = "";
            txtcorre.Text = "";
            rsocial.Text = "";
            txttel.Text = "";
            direcc.Text = "";

            //CBC.SelectedIndex = -1; //no hay nada seleccionado

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void barraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Proveedores_Load(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (NuevoRegistro == true)
            {
                Proveedor pro = new Proveedor();
                pro.Codigo = txtcodig.Text.Trim();
                pro.Nombre = txtnom.Text.Trim();
                pro.Razon_Social = rsocial.Text.Trim();
                pro.Telefono = txttel.Text.Trim();
                pro.Direccion = direcc.Text.Trim();


                if (proveeDAO.Agregar(pro) == false)
                {
                    MessageBox.Show("El nuevo registro no pudo ser grabado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return;
                }
                else
                {
                    MessageBox.Show("El nuevo registro fue grabado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // return;
                    cargar();
                }

            }
            else
            {
                Proveedor pro = proveeDAO.Buscar(txtcodig.Text.Trim());  
                pro.Nombre = txtnom.Text.Trim();
                pro.Razon_Social = rsocial.Text.Trim();
                pro.Telefono = txttel.Text.Trim();
                pro.Direccion = direcc.Text.Trim();


                if (proveeDAO.Modificar(pro) == false)
                {
                    MessageBox.Show("El Registro no fue Modificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return;
                }
                else
                {
                    MessageBox.Show("Registro Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar();



                    // return;
                }


            }
            LimpiarControles();
            DesactivarControles(true);
            txtcodig.Text = "";
            txtcodig.Focus();

        }

        private void btnelimi_Click(object sender, EventArgs e)
        {
            Proveedor pro = proveeDAO.Buscar(txtcodig.Text.Trim());
            if (proveeDAO.Eliminar(pro) == false)
            {
                MessageBox.Show("El registro no puede ser eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {
                MessageBox.Show("El registro eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargar();


                LimpiarControles();
                DesactivarControles(true);
                txtcodig.Text = "";
                txtcodig.Focus();

                return;

            }
        }

        private void txtcodig_Validating(object sender, CancelEventArgs e)
        {
            DesactivarControles(true);
            LimpiarControles();
            if (txtcodig.Text.Trim().Length < 3)
            {
                MessageBox.Show("Longitud debe ser 3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }
            oprovee = proveeDAO.Buscar(txtcodig.Text.Trim());
            if (oprovee != null)
            {

                NuevoRegistro = false;
                txtcodig.Text=  oprovee.Codigo.Trim();
                txtnom.Text= oprovee.Nombre.Trim();
                rsocial.Text= oprovee.Razon_Social.Trim();
                txttel.Text= oprovee.Telefono.Trim();
                direcc.Text= oprovee.Direccion.Trim();
                DesactivarControles(false);
                //btnguardar.Enabled = true;
                //btnelimi.Enabled = true;

                //cboTipo.SelectedValue = oCliente.TipoDeClienteId;
                //DesactivaControles(false);
            }

            else
            {
                //LimpiarControles();
                NuevoRegistro = true;
                DesactivarControles(false);
                // btnguardar.Enabled = true;
                btnelimi.Enabled = false;
            }
        }
    }
}
