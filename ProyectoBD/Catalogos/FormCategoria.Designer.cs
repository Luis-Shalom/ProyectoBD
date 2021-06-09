
namespace ProyectoBD.Catalogos
{
    partial class FormCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.txtnombre = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton7 = new MaterialSkin.Controls.MaterialButton();
            this.materialButton8 = new MaterialSkin.Controls.MaterialButton();
            this.btnGP = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialMultiLineDesc = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.txtcodi = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnelimi = new MaterialSkin.Controls.MaterialButton();
            this.btncanceC = new MaterialSkin.Controls.MaterialButton();
            this.btnguardar = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.materialTextBox1);
            this.materialCard3.Controls.Add(this.btnelimi);
            this.materialCard3.Controls.Add(this.btncanceC);
            this.materialCard3.Controls.Add(this.btnguardar);
            this.materialCard3.Controls.Add(this.dataGridView1);
            this.materialCard3.Controls.Add(this.txtnombre);
            this.materialCard3.Controls.Add(this.materialButton7);
            this.materialCard3.Controls.Add(this.materialButton8);
            this.materialCard3.Controls.Add(this.btnGP);
            this.materialCard3.Controls.Add(this.materialLabel7);
            this.materialCard3.Controls.Add(this.materialMultiLineDesc);
            this.materialCard3.Controls.Add(this.txtcodi);
            this.materialCard3.Controls.Add(this.materialLabel8);
            this.materialCard3.Controls.Add(this.materialLabel9);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(20, 17);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(1044, 540);
            this.materialCard3.TabIndex = 14;
            this.materialCard3.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard3_Paint);
            // 
            // txtnombre
            // 
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.Depth = 0;
            this.txtnombre.Font = new System.Drawing.Font("Roboto", 12F);
            this.txtnombre.Location = new System.Drawing.Point(672, 214);
            this.txtnombre.MaxLength = 50;
            this.txtnombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtnombre.Multiline = false;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(251, 50);
            this.txtnombre.TabIndex = 14;
            this.txtnombre.Text = "";
            // 
            // materialButton7
            // 
            this.materialButton7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton7.Depth = 0;
            this.materialButton7.DrawShadows = true;
            this.materialButton7.HighEmphasis = true;
            this.materialButton7.Icon = null;
            this.materialButton7.Location = new System.Drawing.Point(418, 539);
            this.materialButton7.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton7.Name = "materialButton7";
            this.materialButton7.Size = new System.Drawing.Size(88, 36);
            this.materialButton7.TabIndex = 12;
            this.materialButton7.Text = "eliminar";
            this.materialButton7.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton7.UseAccentColor = false;
            this.materialButton7.UseVisualStyleBackColor = true;
            // 
            // materialButton8
            // 
            this.materialButton8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton8.Depth = 0;
            this.materialButton8.DrawShadows = true;
            this.materialButton8.HighEmphasis = true;
            this.materialButton8.Icon = null;
            this.materialButton8.Location = new System.Drawing.Point(547, 539);
            this.materialButton8.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton8.Name = "materialButton8";
            this.materialButton8.Size = new System.Drawing.Size(94, 36);
            this.materialButton8.TabIndex = 11;
            this.materialButton8.Text = "Terminar";
            this.materialButton8.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton8.UseAccentColor = false;
            this.materialButton8.UseVisualStyleBackColor = true;
            // 
            // btnGP
            // 
            this.btnGP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGP.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGP.Depth = 0;
            this.btnGP.DrawShadows = true;
            this.btnGP.HighEmphasis = true;
            this.btnGP.Icon = null;
            this.btnGP.Location = new System.Drawing.Point(289, 539);
            this.btnGP.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGP.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGP.Name = "btnGP";
            this.btnGP.Size = new System.Drawing.Size(88, 36);
            this.btnGP.TabIndex = 9;
            this.btnGP.Text = "Guardar";
            this.btnGP.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGP.UseAccentColor = false;
            this.btnGP.UseVisualStyleBackColor = true;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.BackColor = System.Drawing.Color.White;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(607, 126);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(59, 19);
            this.materialLabel7.TabIndex = 0;
            this.materialLabel7.Text = "Código: ";
            // 
            // materialMultiLineDesc
            // 
            this.materialMultiLineDesc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialMultiLineDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialMultiLineDesc.Depth = 0;
            this.materialMultiLineDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialMultiLineDesc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialMultiLineDesc.Hint = "";
            this.materialMultiLineDesc.Location = new System.Drawing.Point(610, 371);
            this.materialMultiLineDesc.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialMultiLineDesc.Name = "materialMultiLineDesc";
            this.materialMultiLineDesc.Size = new System.Drawing.Size(340, 70);
            this.materialMultiLineDesc.TabIndex = 8;
            this.materialMultiLineDesc.Text = "";
            // 
            // txtcodi
            // 
            this.txtcodi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcodi.Depth = 0;
            this.txtcodi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtcodi.Location = new System.Drawing.Point(672, 107);
            this.txtcodi.MaxLength = 50;
            this.txtcodi.MouseState = MaterialSkin.MouseState.OUT;
            this.txtcodi.Multiline = false;
            this.txtcodi.Name = "txtcodi";
            this.txtcodi.Size = new System.Drawing.Size(203, 50);
            this.txtcodi.TabIndex = 8;
            this.txtcodi.Text = "";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.BackColor = System.Drawing.Color.White;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(607, 334);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(92, 19);
            this.materialLabel8.TabIndex = 7;
            this.materialLabel8.Text = "Descripcion: ";
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.BackColor = System.Drawing.Color.White;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(605, 235);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(65, 19);
            this.materialLabel9.TabIndex = 1;
            this.materialLabel9.Text = "Nombre: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 334);
            this.dataGridView1.TabIndex = 21;
            // 
            // btnelimi
            // 
            this.btnelimi.AutoSize = false;
            this.btnelimi.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnelimi.Depth = 0;
            this.btnelimi.DrawShadows = true;
            this.btnelimi.HighEmphasis = true;
            this.btnelimi.Icon = null;
            this.btnelimi.Location = new System.Drawing.Point(31, 471);
            this.btnelimi.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnelimi.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnelimi.Name = "btnelimi";
            this.btnelimi.Size = new System.Drawing.Size(173, 36);
            this.btnelimi.TabIndex = 26;
            this.btnelimi.Text = "eliminar";
            this.btnelimi.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnelimi.UseAccentColor = false;
            this.btnelimi.UseVisualStyleBackColor = true;
            // 
            // btncanceC
            // 
            this.btncanceC.AutoSize = false;
            this.btncanceC.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btncanceC.BackColor = System.Drawing.Color.White;
            this.btncanceC.Depth = 0;
            this.btncanceC.DrawShadows = true;
            this.btncanceC.HighEmphasis = true;
            this.btncanceC.Icon = null;
            this.btncanceC.Location = new System.Drawing.Point(305, 471);
            this.btncanceC.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btncanceC.MouseState = MaterialSkin.MouseState.HOVER;
            this.btncanceC.Name = "btncanceC";
            this.btncanceC.Size = new System.Drawing.Size(173, 36);
            this.btncanceC.TabIndex = 25;
            this.btncanceC.Text = "Terminar";
            this.btncanceC.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btncanceC.UseAccentColor = false;
            this.btncanceC.UseVisualStyleBackColor = false;
            // 
            // btnguardar
            // 
            this.btnguardar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnguardar.AutoSize = false;
            this.btnguardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnguardar.Depth = 0;
            this.btnguardar.DrawShadows = true;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.HighEmphasis = true;
            this.btnguardar.Icon = null;
            this.btnguardar.Location = new System.Drawing.Point(610, 471);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnguardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(340, 36);
            this.btnguardar.TabIndex = 24;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnguardar.UseAccentColor = false;
            this.btnguardar.UseVisualStyleBackColor = true;
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.materialTextBox1.Location = new System.Drawing.Point(79, 17);
            this.materialTextBox1.MaxLength = 3;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(399, 50);
            this.materialTextBox1.TabIndex = 27;
            this.materialTextBox1.Text = "";
            // 
            // FormCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1090, 573);
            this.Controls.Add(this.materialCard3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCategoria";
            this.Text = "FormCategoria";
            this.materialCard3.ResumeLayout(false);
            this.materialCard3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialTextBox txtnombre;
        private MaterialSkin.Controls.MaterialButton materialButton7;
        private MaterialSkin.Controls.MaterialButton materialButton8;
        private MaterialSkin.Controls.MaterialButton btnGP;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialMultiLineTextBox materialMultiLineDesc;
        private MaterialSkin.Controls.MaterialTextBox txtcodi;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private MaterialSkin.Controls.MaterialButton btnelimi;
        private MaterialSkin.Controls.MaterialButton btncanceC;
        private MaterialSkin.Controls.MaterialButton btnguardar;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
    }
}