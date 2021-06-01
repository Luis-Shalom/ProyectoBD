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
        public FormCliente()
        {
            InitializeComponent();
        }
        private void cargar()
        {
            //using (ProyectoEntities2 contexto = new ProyectoEntities2())
            //{
            //    var lst = from d in contexto.Clientes
            //              select d;
            //    dataGridView1.DataSource = lst.ToList();

            //}

        }
        private void DesactivaControles(bool EstadoCtrl)
        {
            txtCodig.Enabled = !EstadoCtrl;
            txtnombre.Enabled = !EstadoCtrl;
            txtapellido.Enabled = !EstadoCtrl;
            //oCliente.TipoDeClienteId = (int)cboTipo.SelectedValue;
            CheckboxF.Enabled = !EstadoCtrl;
            CheckboxM.Enabled = !EstadoCtrl;
            txtedad.Enabled = !EstadoCtrl;
            txtid.Enabled = !EstadoCtrl;
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
            CheckboxF.Text = "";
            CheckboxM.Text = "";
            txtedad.Text = "";
            txtid.Text = "";
            multilineDir.Text = "";

            //no hay nada seleccionado
        }
       
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (NuevoRegistro == false)
            {
                Cliente oCliente = new Cliente();
                oCliente.Codigo = txtCodig.Text.Trim();
                oCliente.Nombre = txtnombre.Text.Trim();
                oCliente.Apellido = txtapellido.Text.Trim();
                //oCliente.TipoDeClienteId = (int)cboTipo.SelectedValue;
                oCliente.Sexo = CheckboxF.Text.Trim();
                oCliente.Sexo = CheckboxM.Text.Trim();
                oCliente.Edad = (int.Parse(txtedad.Text.Trim()));
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
                    cargar();
                }

            }
            else
            {
                Cliente oCliente = oclienteDAO.Buscar(txtCodig.Text.Trim());
                oCliente.Nombre = txtnombre.Text.Trim();
                oCliente.Apellido = txtapellido.Text.Trim();
                oCliente.Sexo = CheckboxF.Text.Trim();
                oCliente.Sexo = CheckboxF.Text.Trim();
                oCliente.Direccion = multilineDir.Text.Trim();
                oCliente.Edad = (int.Parse(txtedad.Text.Trim()));
                oCliente.IdCliente = (int.Parse(txtid.Text.Trim()));
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
                    MessageBox.Show("Registro Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    // return;
                }


            }
            LimpiarControles();
            DesactivaControles(true);
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

    }
}
