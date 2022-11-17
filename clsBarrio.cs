using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;

namespace pryParedesWendlerIEFI
{
    internal class clsBarrio
    {
        private OleDbConnection BDConexion = new OleDbConnection();
        private OleDbCommand BDComando = new OleDbCommand();//Se envian ordenes a la base de datos
        private OleDbDataAdapter BDAdap = new OleDbDataAdapter();//Se adaptan los datos que esten en la BD 


        private string BDCadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDclientes.accdb";
        private string DatosBDTabla = "Tabla_Barrio";

        public void Listarcmb(ComboBox cmbListar)
        {
            try
            {
                BDConexion.ConnectionString = BDCadenaConexion;//Cadena de conexion
                BDConexion.Open();
                BDComando.Connection = BDConexion; //Para su funcionamiento, el comando necesita una conexion (BDConexion)
                BDComando.CommandType = CommandType.TableDirect; //Se muestra la tabla, nombre de la tabla
                BDComando.CommandText = DatosBDTabla; //Este es el nombre de la tabla(DatosBDTabla), antes declarada con TableDirect para "traer" la tabla
                BDAdap = new OleDbDataAdapter(BDComando);
                DataSet DataSet = new DataSet();//Una tabla que esta situada en la memoria RAM, la cual posee los datos, // DataSet --> Nombre variable
                BDAdap.Fill(DataSet, DatosBDTabla);
                cmbListar.DataSource = DataSet.Tables[DatosBDTabla];
                cmbListar.DisplayMember = "Detalle_Sucursal";//Informacion que se va a mostrar en la CMBe
                


                BDConexion.Close(); //Se cierra la conexion

            }
            catch (Exception)
            {

                //Evitar el crasheo
            }


        }

        public void FiltrajeBarrio(DataGridView dgvBarrio, Int32 Barrio)
        {
            try
            {

                BDConexion.ConnectionString = BDCadenaConexion;
                BDConexion.Open();
                BDComando.Connection = BDConexion;
                BDComando.CommandType = CommandType.TableDirect;
                BDComando.CommandText = "Socio";
                OleDbDataReader Lector = BDComando.ExecuteReader();
                dgvBarrio.Rows.Clear();
                if (Lector.HasRows)// Si se encuentran filas (HasRows), PROCEDE a leer
                {
                    while (Lector.Read())//Mientras se encuentra informacion, va a leer
                    {
                        if (Lector.GetInt32(3) == Barrio)
                        {
                            dgvBarrio.Rows.Add(Lector.GetInt32(0), Lector.GetString(1), Lector.GetString(2), Lector.GetDecimal(5));
                        }
                    }
                }
                BDConexion.Close();
            }
            catch (Exception)
            {
                //Eviatr el crasheo
            }
        }
    }

}

