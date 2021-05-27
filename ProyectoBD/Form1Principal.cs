using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using ProyectoDAO;
using ProyectoEDM;
using ProyectoEDM.ModeloBD;
namespace ProyectoBD
{
    public partial class Form1Principal : MaterialForm
    {
        private ClienteDAO oclienteDAO = new ClienteDAO();
        private bool NuevoRegistro = false;
        private Cliente ocliente;


        //       readonly MaterialSkin.MaterialSkinManager materialSkinManager;
        public Form1Principal()
        {
            
            InitializeComponent();

            MaterialSkinManager M = MaterialSkinManager.Instance;
            M.AddFormToManage(this);
            //M = MaterialSkin.MaterialSkinManager.Instance;
           // materialSkinManager.AddFormToManage(this);
            M.EnforceBackcolorOnAllComponents = true;
            
            M.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            M.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Indigo500, MaterialSkin.Primary.Indigo700, MaterialSkin.Primary.Indigo100, MaterialSkin.Accent.Pink200, MaterialSkin.TextShade.WHITE);

         }

        //private void btnGuardar_Click(object sender, EventArgs e)
        //{

        //}
        //private void btnGP_Click(object sender, EventArgs e)
        //{

        //}
        private void DesactivaControles(bool EstadoCtrl)
        {
            //txtNombres.Enabled = !EstadoCtrl;
            //txtApellidos.Enabled = !EstadoCtrl;
            //cboTipo.Enabled = !EstadoCtrl;
            //btnGuardar.Enabled = !EstadoCtrl;
            //btnEliminar.Enabled = !EstadoCtrl;
        }//fin del método desactivar controles
        private void LimpiarControles()
        {
            //txtNombres.Text = "";
            //txtApellidos.Text = "";
            //cboTipo.SelectedIndex = -1;  //no hay nada seleccionado
        }

        private void btnguar_Click(object sender, EventArgs e) //BTN DE CLIENTE GUARDAR
        {
            if (NuevoRegistro == true)
            {
                Cliente oCliente = new Cliente();
                oCliente.Codigo= txtCodig.Text.Trim();
                oCliente.Nombre = txtnombre.Text.Trim();
                oCliente.Apellido = txtapellido.Text.Trim();
                //oCliente.TipoDeClienteId = (int)cboTipo.SelectedValue;
                oCliente.Sexo = CheckboxF.Text.Trim();
                oCliente.Sexo = CheckboxM.Text.Trim();
                oCliente.Edad = ( int.Parse(txtedad.Text.Trim()));
                oCliente.IdCliente = (int.Parse(txtid.Text.Trim()));
                oCliente.Direccion = multilineDir.Text.Trim();
              



                if (oclienteDAO.Agregar(oCliente) == false)
                {
                    MessageBox.Show("El nuevo registro no pudo ser grabado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return;
                }
                else
                {
                    MessageBox.Show("El nuevo registro fue grabado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // return;
                }

            }
            //else
            //{
                //Cliente oCliente = oclienteDAO.Buscar(txtCodig.Text.Trim());
                //oCliente.Nombre = txtnombre.Text.Trim();
                //oCliente.Apellido = txtapellido.Text.Trim();
                //oCliente.Sexo = CheckboxF.Text.Trim();
                //oCliente.Sexo = CheckboxF.Text.Trim();
                //oCliente.Direccion = multilineDir.Text.Trim();
                //oCliente.NombresDelCliente = txtNombres.Text.Trim();
                //oCliente.ApellidosDelCliente = txtApellidos.Text.Trim();
                //oCliente.TipoDeClienteId = (int)cboTipo.SelectedValue;

                //if (oclienteDAO.Modificar(oCliente) == false)
                //{
                //    MessageBox.Show("El Registro no fue Modificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    //return;
                //}
                //else
                //{
                //    MessageBox.Show("Registro Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    // return;
                //}


            //}
            //LimpiarControles();
            //DesactivaControles(true);
            //txtCodig.Text = "";
            //txtCodig.Focus();

        }
        private void txt3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
