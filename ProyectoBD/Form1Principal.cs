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
namespace ProyectoBD
{
    public partial class Form1Principal : MaterialForm
    {
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        private void btnguar_Click(object sender, EventArgs e)
        {

        }

        private void btnGP_Click(object sender, EventArgs e)
        {

        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
