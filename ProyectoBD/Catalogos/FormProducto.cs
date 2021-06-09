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
    public partial class FormProducto : Form
    {
        private ProductoDAO product = new ProductoDAO();
        private bool NuevoRegistro = false;
        private Producto  ProduDAO;
        public FormProducto()
        {
            InitializeComponent();
        }
        private void cargar()
        {
            using (ProyectoEntities2 contexto = new ProyectoEntities2())
            {
                var lst = from d in contexto.Productoes
                          select d;

                dataGridView1.DataSource = lst.ToList();
            }

        }
        private void LimpiarControles()
        {
            //txtNombres.Text = "";
            //txtApellidos.Text = "";
            //cboTipo.SelectedIndex = -1;

            txtCod.Text = "";
            txtnom.Text = "";
            materialMultiLineDes.Text = "";

            txtprecio.Text = "";
            CBC.SelectedIndex = -1;
            //txtedad.Text = "";
            ////txtid.Text = "";
            //multilineDir.Text = "";

            //no hay nada seleccionado
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (NuevoRegistro == true)
            {


                Producto produc = new Producto();
                produc.Codigo = txtCod.Text.Trim();
                produc.Nombre = txtnom.Text.Trim();
                produc.IdCategoria = (int)CBC.SelectedValue;
                produc.Descripcion =materialMultiLineDes.Text .Trim();
                produc.Precio= int.Parse(txtprecio .Text.Trim());
                



                if (product.Agregar(produc) == false)
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
               Producto Produt =product.Buscar(txtCod.Text.Trim());


                //Produt.Codigo = txtCod.Text.Trim();
                Produt.Nombre = txtnom.Text.Trim();
                Produt.IdCategoria = (int)CBC.SelectedValue;
                Produt.Descripcion = materialMultiLineDes.Text.Trim();
                Produt.Precio = decimal.Parse(txtprecio.Text.Trim());

                
                
                if (product.Modificar(Produt) == false)
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
            txtCod.Text = "";
            txtCod.Focus();

        }

        private void btnelimi_Click(object sender, EventArgs e)
        {
            Producto pro = product.Buscar(txtCod.Text.Trim());
            if (product.Eliminar(pro) == false)
            {
                MessageBox.Show("El registro no puede ser eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {
                MessageBox.Show("El registro eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargar();


                LimpiarControles();
                //txtCodig.Text = "";
                //txtnombre.Text = "";
                //txtapellido.Text = "";

                //multilineDir.Text = "";
                //txttelef.Text = "";
                //txtedad.Text = "";

                btnguardar.Enabled = false;
                btnelimi.Enabled = false;
               //LimpiarControles();
                //    DesactivaControles(true);
                //    //txtCodig.Text = "";
                txtCod.Focus();

                return;

            }
        }

        private void txtCod_Validating(object sender, CancelEventArgs e)
        {
            if (txtCod.Text.Trim().Length < 3)
            {
                MessageBox.Show("Longitud debe ser 3", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;
            }
            ProduDAO = product.Buscar(txtCod.Text.Trim());
            if (ProduDAO != null)
            {
                NuevoRegistro = false;
                txtnom.Text = ProduDAO.Nombre.Trim();
                txtprecio.Text = ProduDAO.Precio.ToString();
                materialMultiLineDes.Text = ProduDAO.Descripcion.Trim();
                CBC.SelectedValue = ProduDAO.IdCategoria;
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
    }
}
