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
    public partial class FrmVerduleria : Form
    {
        OleDbCommand Micommand;
        OleDbConnection Miconnection;
        OleDbDataReader Reader;

        public FrmVerduleria()
        {
            InitializeComponent();
        }

        private void FrmVerduleria_Load(object sender, EventArgs e)
        {
            Miconnection = new OleDbConnection();

            Miconnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=VERDULEROS.mdb";

            Miconnection.Open();


            
        }

        private void btnCargar_Click(object sender, EventArgs e)
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
            catch (Exception ex) 
            {
            }

        }
    }
}
