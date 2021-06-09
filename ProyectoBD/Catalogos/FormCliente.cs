using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoDAO;
using ProyectoEDM.ModeloBD;

namespace ProyectoBD.Catalogos
{
    public partial class FormCliente : Form
    {
        private ClienteDAO oclienteDAO = new ClienteDAO();
        private bool NuevoRegistro = false;
        private Cliente oCliente;
        public FormCliente()
        {
            InitializeComponent();
        }
        private void cargar()
        {
            using (ProyectoEntities2 contexto = new ProyectoEntities2())
            {
                var lst = from d in contexto.Clientes
                          select d;

               dataGridView1.DataSource = lst.ToList();
            }

        }
        private void DesactivaControles(bool EstadoCtrl)
        {
            txtCodig.Enabled = !EstadoCtrl;
            txtnombre.Enabled = !EstadoCtrl;
            txtapellido.Enabled = !EstadoCtrl;
            //oCliente.TipoDeClienteId = (int)cboTipo.SelectedValue;
            cbxSexo.Enabled = !EstadoCtrl;
            txttelef.Enabled = !EstadoCtrl;
            txtedad.Enabled = !EstadoCtrl;
            //txtid.Enabled = !EstadoCtrl;
            multilineDir.Enabled = !EstadoCtrl;
        }//fin del método desactivar controles
        private void LimpiarControles()
        {
            //txtNombres.Text = "";
            //txtApellidos.Text = "";
            //cboTipo.SelectedIndex = -1;

            txtCodig.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
         
            txttelef.Text = "";
            txtedad.Text = "";
            //txtid.Text = "";
            multilineDir.Text = "";

            //no hay nada seleccionado
        }
       



        private void btnguardar_Click(object sender, EventArgs e)
        {


            if (NuevoRegistro == true)
            {


                Cliente oCliente = new Cliente();
                oCliente.Codigo = txtCodig.Text.Trim();
                oCliente.Nombre = txtnombre.Text.Trim();
                oCliente.Apellido = txtapellido.Text.Trim();
                //oCliente.TipoDeClienteId = (int)cboTipo.SelectedValue;
                oCliente.Sexo = cbxSexo.Text.Trim();
             //   oCliente.Sexo = CheckboxM.Text.Trim();
                oCliente.Telefono = txttelef.Text.Trim();
                oCliente.Edad = (int.Parse(txtedad.Text.Trim()));
                //oCliente.IdCliente = (int.Parse(txtid.Text.Trim()));
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
                    cargar();
                }

            }
            else
            {
                Cliente oCliente = oclienteDAO.Buscar(txtCodig.Text.Trim());


           

                oCliente.Nombre = txtnombre.Text.Trim();
                oCliente.Apellido = txtapellido.Text.Trim();
                //oCliente.Sexo = CheckboxF.Text.Trim();
                //oCliente.Sexo = CheckboxM.Text.Trim();
                oCliente.Sexo = cbxSexo.Text.Trim();
                oCliente.Telefono = txttelef.Text.Trim();
                oCliente.Direccion = multilineDir.Text.Trim();
                oCliente.Edad = (int.Parse(txtedad.Text.Trim()));
                //oCliente.IdCliente = (int)txtid.SelectedValue;
                //oCliente.NombresDelCliente = txtNombres.Text.Trim();
                //oCliente.ApellidosDelCliente = txtApellidos.Text.Trim();
                //oCliente.TipoDeClienteId = (int)cboTipo.SelectedValue;

                if (oclienteDAO.Modificar(oCliente) == false)
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
            //DesactivaControles(true);
           txtCodig.Text = "";
           txtCodig.Focus();

        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void barraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditClient_Click(object sender, EventArgs e)
        {



           

        }

        private void txtCodig_Validating(object sender, CancelEventArgs e)
        {
            ////Cliente oCliente ;
            //DesactivaControles(true);
            //LimpiarControles();
            if (txtCodig.Text.Trim().Length < 3)
            {
                MessageBox.Show("Longitud debe ser 3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }
            oCliente = oclienteDAO.Buscar(txtCodig.Text.Trim());
            if (oCliente != null)
            {
                NuevoRegistro = false;
                txtnombre.Text = oCliente.Nombre.Trim();
                txtapellido.Text = oCliente.Apellido.Trim();
                //CheckboxF.Text = oCliente.Sexo.Trim();
                //CheckboxM.Text = oCliente.Sexo.Trim();
                cbxSexo.Text = oCliente.Sexo.Trim();
             //   txt.Sexo = cbxSexo.Text.Trim();
                txttelef.Text = oCliente.Telefono.Trim();
                multilineDir.Text = oCliente.Direccion.Trim();
                txtedad.Text= oCliente.Edad.ToString();

               // DesactivaControles(false);
                btnguardar.Enabled = true;
                btnelimi.Enabled = true;
             
                //cboTipo.SelectedValue = oCliente.TipoDeClienteId;
                //DesactivaControles(false);
            }
          
            else
            {
                //LimpiarControles();
                NuevoRegistro = true;
                //DesactivaControles(false);
                btnguardar.Enabled = true;
                btnelimi.Enabled = false;
            }

        }

        private void btnelimi_Click(object sender, EventArgs e)
        {
            
                Cliente oCliente = oclienteDAO.Buscar(txtCodig.Text.Trim());
                if (oclienteDAO.Eliminar(oCliente) == false)
                {
                    MessageBox.Show("El registro no puede ser eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;

                }
                else
                {
                    MessageBox.Show("El registro eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar();

                txtCodig.Text = "";
                txtnombre.Text = "";
                txtapellido.Text = "";
              
                multilineDir.Text = "";
                txttelef.Text = "";
                txtedad.Text = "";

                btnguardar.Enabled = false;
                btnelimi.Enabled = false;
                //LimpiarControles();
                //    DesactivaControles(true);
                //    //txtCodig.Text = "";
                    txtCodig.Focus();

                return;

                }
            
        }
    }
}
