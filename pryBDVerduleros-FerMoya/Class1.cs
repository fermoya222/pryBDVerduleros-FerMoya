using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pryBDVerduleros_FerMoya
{
    internal class Class1
    {
        
            OleDbCommand Micommand;
            OleDbConnection Miconnection;
            OleDbDataReader Reader;

            string CadenaDeConexion;
          

            private void FrmVerduleria_Load(object sender, EventArgs e)
            {
                Miconnection = new OleDbConnection();

                Miconnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VERDULEROS.mdb";

                Miconnection.Open();



            }

            private void MostrarTabla (object sender, DataGridView dgv, EventArgs e)
            {
                try
                {
                    Micommand = new OleDbCommand();

                    Micommand.Connection = Miconnection;
                    Micommand.CommandType = CommandType.TableDirect;
                    Micommand.CommandText = "Ventas";



                    Reader = Micommand.ExecuteReader();

                    while (Reader.Read())
                    {

                        dgv.Rows.Add(Reader[0], Reader[1], Reader[2], Reader[3]);


                    }
                }
                catch { }
            }

            public void ConectarBD()
            {
                CadenaDeConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VERDULEROS.mdb;";

                try
                {
                    Miconnection = new OleDbConnection(CadenaDeConexion);
                    Miconnection.ConnectionString = CadenaDeConexion;
                    Miconnection.Open();

                    //MessageBox.Show("exito");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            public void CargarCmb(ComboBox cmbVendedor)
            {
                Micommand = new OleDbCommand();

                Micommand.Connection = Miconnection;
                Micommand.CommandType = System.Data.CommandType.TableDirect;
                Micommand.CommandText = "Vendedores";

                Reader = Micommand.ExecuteReader();

                cmbVendedor.Items.Clear();

                while (Reader.Read())
                {
            //ExecuteReader: la propiedad Connection no se ha inicializado.'

                    cmbVendedor.Items.Add(Reader.GetString(1));
                }

                Reader.Close();

            }
            public void CargarCmbP (ComboBox cmbProducto)
            {
                Micommand.Connection = Miconnection;
                Micommand.CommandType = System.Data.CommandType.TableDirect;
                Micommand.CommandText = "Productos";

                Reader = Micommand.ExecuteReader();

                cmbProducto.Items.Clear();

                while (Reader.Read())
                {
                    cmbProducto.Items.Add(Reader.GetString(1));
                }

                Reader.Close();

            }
        
    }
}
                
