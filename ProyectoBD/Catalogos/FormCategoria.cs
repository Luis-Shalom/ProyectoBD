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
    public partial class FormCategoria : Form
    {

        private CategoriaDAO productDAO = new CategoriaDAO();
        private bool NuevoRegistro = false;
        public FormCategoria()
        {
            InitializeComponent();
        }

        private void materialCard3_Paint(object sender, PaintEventArgs e)
        {

        }
        private void cargar()
        {
            using (ProyectoEntities2 contexto = new ProyectoEntities2())
            {
                var lst = from d in contexto.Categorias
                          select d;

                dataGridView1.DataSource = lst.ToList();
            }

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if( NuevoRegistro ==  true){

                Categoria otipo = new Categoria();

                otipo.Codigo = txtcodi.Text.Trim();
                otipo.Nombre = txtnombre.Text.Trim();
                otipo.Descripcion = materialMultiLineDesc.Text.Trim();

                if ( productDAO.Agregar(otipo)== false)
                {
                    MessageBox.Show("El nuevo registro no pudo ser grabado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    MessageBox.Show("El nuevo registro fue grabado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargar();
                }

            }
            else
            {
                Categoria otipo = productDAO.Buscar(txtcodi.Text.Trim());
                otipo.Nombre = txtnombre.Text.Trim();
                otipo.Descripcion = materialMultiLineDesc.Text.Trim();
                if(productDAO.Modificar(otipo)== false)
                {
                    MessageBox.Show("El Registro no fue Modificado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Registro Modificado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cargar();
                }


            }
            LimpiarControles();
            //DesactivaControles(true);
            txtcodi.Text = "";
            materialMultiLineDesc.Text = "";
            btnguardar.Enabled = false;
            btnelimi.Enabled = false;
            txtcodi.Focus();


        }

        private void btnelimi_Click(object sender, EventArgs e)
        {
            Categoria otipo = productDAO.Buscar(txtcodi.Text.Trim());


            if(productDAO.Eliminar(otipo)== false)
            {

                MessageBox.Show("El registro no puede ser eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {
                MessageBox.Show("El registro eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimpiarControles();
                btnguardar.Enabled = false;
                btnelimi.Enabled = false;
                txtcodi.Focus();

                return;

            }
        }

        private void LimpiarControles()
        {
            

            txtcodi.Text = "";
            txtnombre.Text = "";
            materialMultiLineDesc.Text = "";

            
        }

        private void txtcodi_Validating(object sender, CancelEventArgs e)
        {
            Categoria otipo;

            if(txtcodi.Text.Trim().Length < 3)
            {
                MessageBox.Show("La longitud del codigo es de 3", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                return;

            }
            otipo = productDAO.Buscar(txtcodi.Text.Trim());
            if(otipo != null)
            {
                NuevoRegistro = false;
                txtnombre.Text = otipo.Nombre.Trim();
                materialMultiLineDesc.Text = otipo.Descripcion.Trim();
                btnguardar.Enabled = true;
                btnelimi.Enabled = true;

            }
            else
            {
                NuevoRegistro = true;
                txtnombre.Text = "";
                materialMultiLineDesc.Text = "";
                btnguardar.Enabled = true;
                btnelimi.Enabled = false;
            }

        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            cargar();
        }

        private void btncanceC_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
