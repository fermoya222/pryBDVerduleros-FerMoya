using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryBDVerduleros_FerMoya
{
    public partial class FrmCargarD : Form
    {
        Class1 objClaseBD = new Class1(); 

        public FrmCargarD()
        {
            InitializeComponent();
        }

        private void FrmCargarD_Load(object sender, EventArgs e)
        {

            objClaseBD.ConectarBD();
            objClaseBD.CargarCmb(cmbVendedor);
            objClaseBD.CargarCmbP(cmbProducto);






        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {
            if (cmbProducto.SelectedIndex != -1 && cmbProducto.SelectedIndex != -1 && mtxtb.Text != "    ")
            {
                
                objClaseBD.RegistrarVentas(cmbVendedor.SelectedValue.ToString(), cmbProducto.SelectedValue.ToString(), dtmFecha.Value, mtxtb.Text);

            }
            else
            {
                //cargue los datos 
            }
        }
    }
}
