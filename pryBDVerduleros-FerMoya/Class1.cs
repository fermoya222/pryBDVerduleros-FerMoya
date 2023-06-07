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
        public partial class FrmVerduleria : Form
        {
            OleDbCommand Micommand;
            OleDbConnection Miconnection;
            OleDbDataReader Reader;

          

            private void FrmVerduleria_Load(object sender, EventArgs e)
            {
                Miconnection = new OleDbConnection();

                Miconnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VERDULEROS.mdb";

                Miconnection.Open();



            }

            private void btnCargar_Click(object sender, EventArgs, DataGridView dgv 
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
                catch
                {
                }
            }

        }
    }
}
                
