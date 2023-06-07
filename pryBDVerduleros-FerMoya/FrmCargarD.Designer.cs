namespace pryBDVerduleros_FerMoya
{
    partial class FrmCargarD
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
            this.lblVentas = new System.Windows.Forms.Label();
            this.lblverndedor = new System.Windows.Forms.Label();
            this.cmbVendedor = new System.Windows.Forms.ComboBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtmFecha = new System.Windows.Forms.DateTimePicker();
            this.lblKg = new System.Windows.Forms.Label();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            this.mtxtb = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.ForeColor = System.Drawing.Color.Olive;
            this.lblVentas.Location = new System.Drawing.Point(88, 41);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(88, 25);
            this.lblVentas.TabIndex = 0;
            this.lblVentas.Text = "Ventas";
            // 
            // lblverndedor
            // 
            this.lblverndedor.AutoSize = true;
            this.lblverndedor.Location = new System.Drawing.Point(19, 104);
            this.lblverndedor.Name = "lblverndedor";
            this.lblverndedor.Size = new System.Drawing.Size(108, 13);
            this.lblverndedor.TabIndex = 1;
            this.lblverndedor.Text = "Seleccione vendedor";
            // 
            // cmbVendedor
            // 
            this.cmbVendedor.FormattingEnabled = true;
            this.cmbVendedor.Location = new System.Drawing.Point(20, 133);
            this.cmbVendedor.Name = "cmbVendedor";
            this.cmbVendedor.Size = new System.Drawing.Size(206, 21);
            this.cmbVendedor.TabIndex = 2;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(19, 187);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(105, 13);
            this.lblProducto.TabIndex = 3;
            this.lblProducto.Text = "Seleccione producto";
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(22, 219);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(203, 21);
            this.cmbProducto.TabIndex = 4;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(19, 287);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(82, 13);
            this.lblFecha.TabIndex = 5;
            this.lblFecha.Text = "Fecha de venta";
            // 
            // dtmFecha
            // 
            this.dtmFecha.Location = new System.Drawing.Point(22, 317);
            this.dtmFecha.Name = "dtmFecha";
            this.dtmFecha.Size = new System.Drawing.Size(204, 20);
            this.dtmFecha.TabIndex = 6;
            // 
            // lblKg
            // 
            this.lblKg.AutoSize = true;
            this.lblKg.Location = new System.Drawing.Point(19, 382);
            this.lblKg.Name = "lblKg";
            this.lblKg.Size = new System.Drawing.Size(55, 13);
            this.lblKg.TabIndex = 7;
            this.lblKg.Text = "Peso (kg):";
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.Location = new System.Drawing.Point(102, 457);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(57, 21);
            this.btnCargarDatos.TabIndex = 9;
            this.btnCargarDatos.Text = "Cargar";
            this.btnCargarDatos.UseVisualStyleBackColor = true;
            // 
            // mtxtb
            // 
            this.mtxtb.Location = new System.Drawing.Point(22, 414);
            this.mtxtb.Mask = "99999";
            this.mtxtb.Name = "mtxtb";
            this.mtxtb.Size = new System.Drawing.Size(204, 20);
            this.mtxtb.TabIndex = 10;
            this.mtxtb.ValidatingType = typeof(int);
            // 
            // FrmCargarD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 500);
            this.Controls.Add(this.mtxtb);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.lblKg);
            this.Controls.Add(this.dtmFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cmbProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.cmbVendedor);
            this.Controls.Add(this.lblverndedor);
            this.Controls.Add(this.lblVentas);
            this.ForeColor = System.Drawing.Color.OliveDrab;
            this.Name = "FrmCargarD";
            this.Text = "FrmCargarD";
            this.Load += new System.EventHandler(this.FrmCargarD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label lblverndedor;
        private System.Windows.Forms.ComboBox cmbVendedor;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtmFecha;
        private System.Windows.Forms.Label lblKg;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.MaskedTextBox mtxtb;
    }
}