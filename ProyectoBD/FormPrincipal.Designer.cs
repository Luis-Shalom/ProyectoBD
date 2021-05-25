namespace ProyectoBD
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.Header = new System.Windows.Forms.Panel();
            this.DASHBOARD = new System.Windows.Forms.Label();
            this.Salir = new System.Windows.Forms.PictureBox();
            this.Wrapper = new System.Windows.Forms.Panel();
            this.Sidebar = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BTNPRODUCTO = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BTNCLIENTE = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BTNPROVEEDORES = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BTNTRABAJADORES = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BTNVENTA = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).BeginInit();
            this.Sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.Header.Controls.Add(this.DASHBOARD);
            this.Header.Controls.Add(this.Salir);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(270, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1170, 60);
            this.Header.TabIndex = 0;
            // 
            // DASHBOARD
            // 
            this.DASHBOARD.AutoSize = true;
            this.DASHBOARD.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DASHBOARD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.DASHBOARD.Location = new System.Drawing.Point(20, 23);
            this.DASHBOARD.Name = "DASHBOARD";
            this.DASHBOARD.Size = new System.Drawing.Size(100, 19);
            this.DASHBOARD.TabIndex = 1;
            this.DASHBOARD.Text = "DASHBOARD";
            // 
            // Salir
            // 
            this.Salir.Image = ((System.Drawing.Image)(resources.GetObject("Salir.Image")));
            this.Salir.Location = new System.Drawing.Point(1113, 12);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(35, 35);
            this.Salir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Salir.TabIndex = 0;
            this.Salir.TabStop = false;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // Wrapper
            // 
            this.Wrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(243)))), ((int)(((byte)(239)))));
            this.Wrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wrapper.Location = new System.Drawing.Point(0, 0);
            this.Wrapper.Name = "Wrapper";
            this.Wrapper.Size = new System.Drawing.Size(1440, 940);
            this.Wrapper.TabIndex = 1;
            this.Wrapper.Paint += new System.Windows.Forms.PaintEventHandler(this.Wrapper_Paint);
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(32)))));
            this.Sidebar.Controls.Add(this.BTNVENTA);
            this.Sidebar.Controls.Add(this.BTNTRABAJADORES);
            this.Sidebar.Controls.Add(this.BTNPROVEEDORES);
            this.Sidebar.Controls.Add(this.BTNCLIENTE);
            this.Sidebar.Controls.Add(this.BTNPRODUCTO);
            this.Sidebar.Controls.Add(this.bunifuFlatButton1);
            this.Sidebar.Controls.Add(this.label2);
            this.Sidebar.Controls.Add(this.pictureBox1);
            this.Sidebar.Controls.Add(this.label1);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(270, 940);
            this.Sidebar.TabIndex = 2;
            this.Sidebar.Paint += new System.Windows.Forms.PaintEventHandler(this.Sidebar_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.label2.Location = new System.Drawing.Point(63, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "ADMINISTRADOR";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(48, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.label1.Location = new System.Drawing.Point(68, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "DASHBOARD";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "       DASHBOARD";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage_right_Selected")));
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 65D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(12, 277);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(241, 56);
            this.bunifuFlatButton1.TabIndex = 0;
            this.bunifuFlatButton1.Text = "       DASHBOARD";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BTNPRODUCTO
            // 
            this.BTNPRODUCTO.Activecolor = System.Drawing.Color.Transparent;
            this.BTNPRODUCTO.BackColor = System.Drawing.Color.Transparent;
            this.BTNPRODUCTO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNPRODUCTO.BorderRadius = 0;
            this.BTNPRODUCTO.ButtonText = "       PRODUCTOS";
            this.BTNPRODUCTO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNPRODUCTO.DisabledColor = System.Drawing.Color.Gray;
            this.BTNPRODUCTO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPRODUCTO.Iconcolor = System.Drawing.Color.Transparent;
            this.BTNPRODUCTO.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTNPRODUCTO.Iconimage")));
            this.BTNPRODUCTO.Iconimage_right = null;
            this.BTNPRODUCTO.Iconimage_right_Selected = ((System.Drawing.Image)(resources.GetObject("BTNPRODUCTO.Iconimage_right_Selected")));
            this.BTNPRODUCTO.Iconimage_Selected = null;
            this.BTNPRODUCTO.IconMarginLeft = 0;
            this.BTNPRODUCTO.IconMarginRight = 0;
            this.BTNPRODUCTO.IconRightVisible = true;
            this.BTNPRODUCTO.IconRightZoom = 0D;
            this.BTNPRODUCTO.IconVisible = true;
            this.BTNPRODUCTO.IconZoom = 65D;
            this.BTNPRODUCTO.IsTab = true;
            this.BTNPRODUCTO.Location = new System.Drawing.Point(12, 368);
            this.BTNPRODUCTO.Name = "BTNPRODUCTO";
            this.BTNPRODUCTO.Normalcolor = System.Drawing.Color.Transparent;
            this.BTNPRODUCTO.OnHovercolor = System.Drawing.Color.Transparent;
            this.BTNPRODUCTO.OnHoverTextColor = System.Drawing.Color.White;
            this.BTNPRODUCTO.selected = false;
            this.BTNPRODUCTO.Size = new System.Drawing.Size(241, 56);
            this.BTNPRODUCTO.TabIndex = 4;
            this.BTNPRODUCTO.Text = "       PRODUCTOS";
            this.BTNPRODUCTO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNPRODUCTO.Textcolor = System.Drawing.Color.White;
            this.BTNPRODUCTO.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BTNCLIENTE
            // 
            this.BTNCLIENTE.Activecolor = System.Drawing.Color.Transparent;
            this.BTNCLIENTE.BackColor = System.Drawing.Color.Transparent;
            this.BTNCLIENTE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNCLIENTE.BorderRadius = 0;
            this.BTNCLIENTE.ButtonText = "       CLIENTES";
            this.BTNCLIENTE.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNCLIENTE.DisabledColor = System.Drawing.Color.Gray;
            this.BTNCLIENTE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCLIENTE.Iconcolor = System.Drawing.Color.Transparent;
            this.BTNCLIENTE.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTNCLIENTE.Iconimage")));
            this.BTNCLIENTE.Iconimage_right = null;
            this.BTNCLIENTE.Iconimage_right_Selected = ((System.Drawing.Image)(resources.GetObject("BTNCLIENTE.Iconimage_right_Selected")));
            this.BTNCLIENTE.Iconimage_Selected = null;
            this.BTNCLIENTE.IconMarginLeft = 0;
            this.BTNCLIENTE.IconMarginRight = 0;
            this.BTNCLIENTE.IconRightVisible = true;
            this.BTNCLIENTE.IconRightZoom = 0D;
            this.BTNCLIENTE.IconVisible = true;
            this.BTNCLIENTE.IconZoom = 65D;
            this.BTNCLIENTE.IsTab = true;
            this.BTNCLIENTE.Location = new System.Drawing.Point(12, 459);
            this.BTNCLIENTE.Name = "BTNCLIENTE";
            this.BTNCLIENTE.Normalcolor = System.Drawing.Color.Transparent;
            this.BTNCLIENTE.OnHovercolor = System.Drawing.Color.Transparent;
            this.BTNCLIENTE.OnHoverTextColor = System.Drawing.Color.White;
            this.BTNCLIENTE.selected = false;
            this.BTNCLIENTE.Size = new System.Drawing.Size(241, 56);
            this.BTNCLIENTE.TabIndex = 5;
            this.BTNCLIENTE.Text = "       CLIENTES";
            this.BTNCLIENTE.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNCLIENTE.Textcolor = System.Drawing.Color.White;
            this.BTNCLIENTE.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BTNPROVEEDORES
            // 
            this.BTNPROVEEDORES.Activecolor = System.Drawing.Color.Transparent;
            this.BTNPROVEEDORES.BackColor = System.Drawing.Color.Transparent;
            this.BTNPROVEEDORES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNPROVEEDORES.BorderRadius = 0;
            this.BTNPROVEEDORES.ButtonText = "       PROVEEDORES";
            this.BTNPROVEEDORES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNPROVEEDORES.DisabledColor = System.Drawing.Color.Gray;
            this.BTNPROVEEDORES.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNPROVEEDORES.Iconcolor = System.Drawing.Color.Transparent;
            this.BTNPROVEEDORES.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTNPROVEEDORES.Iconimage")));
            this.BTNPROVEEDORES.Iconimage_right = null;
            this.BTNPROVEEDORES.Iconimage_right_Selected = ((System.Drawing.Image)(resources.GetObject("BTNPROVEEDORES.Iconimage_right_Selected")));
            this.BTNPROVEEDORES.Iconimage_Selected = null;
            this.BTNPROVEEDORES.IconMarginLeft = 0;
            this.BTNPROVEEDORES.IconMarginRight = 0;
            this.BTNPROVEEDORES.IconRightVisible = true;
            this.BTNPROVEEDORES.IconRightZoom = 0D;
            this.BTNPROVEEDORES.IconVisible = true;
            this.BTNPROVEEDORES.IconZoom = 65D;
            this.BTNPROVEEDORES.IsTab = true;
            this.BTNPROVEEDORES.Location = new System.Drawing.Point(12, 550);
            this.BTNPROVEEDORES.Name = "BTNPROVEEDORES";
            this.BTNPROVEEDORES.Normalcolor = System.Drawing.Color.Transparent;
            this.BTNPROVEEDORES.OnHovercolor = System.Drawing.Color.Transparent;
            this.BTNPROVEEDORES.OnHoverTextColor = System.Drawing.Color.White;
            this.BTNPROVEEDORES.selected = false;
            this.BTNPROVEEDORES.Size = new System.Drawing.Size(241, 56);
            this.BTNPROVEEDORES.TabIndex = 6;
            this.BTNPROVEEDORES.Text = "       PROVEEDORES";
            this.BTNPROVEEDORES.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNPROVEEDORES.Textcolor = System.Drawing.Color.White;
            this.BTNPROVEEDORES.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BTNTRABAJADORES
            // 
            this.BTNTRABAJADORES.Activecolor = System.Drawing.Color.Transparent;
            this.BTNTRABAJADORES.BackColor = System.Drawing.Color.Transparent;
            this.BTNTRABAJADORES.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNTRABAJADORES.BorderRadius = 0;
            this.BTNTRABAJADORES.ButtonText = "       TRABAJADORES";
            this.BTNTRABAJADORES.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNTRABAJADORES.DisabledColor = System.Drawing.Color.Gray;
            this.BTNTRABAJADORES.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNTRABAJADORES.Iconcolor = System.Drawing.Color.Transparent;
            this.BTNTRABAJADORES.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTNTRABAJADORES.Iconimage")));
            this.BTNTRABAJADORES.Iconimage_right = null;
            this.BTNTRABAJADORES.Iconimage_right_Selected = ((System.Drawing.Image)(resources.GetObject("BTNTRABAJADORES.Iconimage_right_Selected")));
            this.BTNTRABAJADORES.Iconimage_Selected = null;
            this.BTNTRABAJADORES.IconMarginLeft = 0;
            this.BTNTRABAJADORES.IconMarginRight = 0;
            this.BTNTRABAJADORES.IconRightVisible = true;
            this.BTNTRABAJADORES.IconRightZoom = 0D;
            this.BTNTRABAJADORES.IconVisible = true;
            this.BTNTRABAJADORES.IconZoom = 65D;
            this.BTNTRABAJADORES.IsTab = true;
            this.BTNTRABAJADORES.Location = new System.Drawing.Point(12, 642);
            this.BTNTRABAJADORES.Name = "BTNTRABAJADORES";
            this.BTNTRABAJADORES.Normalcolor = System.Drawing.Color.Transparent;
            this.BTNTRABAJADORES.OnHovercolor = System.Drawing.Color.Transparent;
            this.BTNTRABAJADORES.OnHoverTextColor = System.Drawing.Color.White;
            this.BTNTRABAJADORES.selected = false;
            this.BTNTRABAJADORES.Size = new System.Drawing.Size(241, 56);
            this.BTNTRABAJADORES.TabIndex = 7;
            this.BTNTRABAJADORES.Text = "       TRABAJADORES";
            this.BTNTRABAJADORES.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNTRABAJADORES.Textcolor = System.Drawing.Color.White;
            this.BTNTRABAJADORES.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // BTNVENTA
            // 
            this.BTNVENTA.Activecolor = System.Drawing.Color.Transparent;
            this.BTNVENTA.BackColor = System.Drawing.Color.Transparent;
            this.BTNVENTA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BTNVENTA.BorderRadius = 0;
            this.BTNVENTA.ButtonText = "       VENTAS";
            this.BTNVENTA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTNVENTA.DisabledColor = System.Drawing.Color.Gray;
            this.BTNVENTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNVENTA.Iconcolor = System.Drawing.Color.Transparent;
            this.BTNVENTA.Iconimage = ((System.Drawing.Image)(resources.GetObject("BTNVENTA.Iconimage")));
            this.BTNVENTA.Iconimage_right = null;
            this.BTNVENTA.Iconimage_right_Selected = ((System.Drawing.Image)(resources.GetObject("BTNVENTA.Iconimage_right_Selected")));
            this.BTNVENTA.Iconimage_Selected = null;
            this.BTNVENTA.IconMarginLeft = 0;
            this.BTNVENTA.IconMarginRight = 0;
            this.BTNVENTA.IconRightVisible = true;
            this.BTNVENTA.IconRightZoom = 0D;
            this.BTNVENTA.IconVisible = true;
            this.BTNVENTA.IconZoom = 65D;
            this.BTNVENTA.IsTab = true;
            this.BTNVENTA.Location = new System.Drawing.Point(12, 738);
            this.BTNVENTA.Name = "BTNVENTA";
            this.BTNVENTA.Normalcolor = System.Drawing.Color.Transparent;
            this.BTNVENTA.OnHovercolor = System.Drawing.Color.Transparent;
            this.BTNVENTA.OnHoverTextColor = System.Drawing.Color.White;
            this.BTNVENTA.selected = false;
            this.BTNVENTA.Size = new System.Drawing.Size(241, 56);
            this.BTNVENTA.TabIndex = 8;
            this.BTNVENTA.Text = "       VENTAS";
            this.BTNVENTA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNVENTA.Textcolor = System.Drawing.Color.White;
            this.BTNVENTA.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1440, 940);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Sidebar);
            this.Controls.Add(this.Wrapper);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Salir)).EndInit();
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.PictureBox Salir;
        private System.Windows.Forms.Panel Wrapper;
        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.Label DASHBOARD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton BTNCLIENTE;
        private Bunifu.Framework.UI.BunifuFlatButton BTNPRODUCTO;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton BTNVENTA;
        private Bunifu.Framework.UI.BunifuFlatButton BTNTRABAJADORES;
        private Bunifu.Framework.UI.BunifuFlatButton BTNPROVEEDORES;
    }
}

