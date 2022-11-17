using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;


namespace pryParedesWendlerIEFI
{
    internal class clsActividada
    {
        private OleDbConnection BDConexion = new OleDbConnection();
        private OleDbCommand BDComando = new OleDbCommand();//Se envian ordenes a la base de datos
        private OleDbDataAdapter BDAdap = new OleDbDataAdapter();//Se adaptan los datos que esten en la BD 
        private OleDbDataReader DataReader;

        public string NombreActividad;
        private string BDCadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDclientes.accdb";
        private string DatosBDTabla = "Actividad";

        public void Listar(DataGridView dgvGrilla)
        {
            try
            {
                BDConexion.ConnectionString = BDCadenaConexion;//Cadena de conexion
                BDConexion.Open();

                BDComando.Connection = BDConexion; //Para su funcionamiento, el comando necesita una conexxion (BDConexion)
                BDComando.CommandType = CommandType.TableDirect; //Se muestra la tabla, nombre de la tabla
                BDComando.CommandText = DatosBDTabla;//Este es el nombre de la tabla (DatosBDTabla), antes declarada con TableDirect para "traer" la tabla

                BDAdap = new OleDbDataAdapter(BDComando);
                DataSet DataSet = new DataSet();//Una tabla que esta situada en la memoria RAM, la cual posee los datos, // DataSet --> Nombre variable
                BDAdap.Fill(DataSet);
                dgvGrilla.DataSource = DataSet.Tables[0];
                BDConexion.Close();

            }
            catch (Exception)
            {

                //Evita el crasheo
            }

        }

        public void ListarLista(ComboBox cmbListar)
        {
            try
            {
                BDConexion.ConnectionString = BDCadenaConexion;//Cadena de conexion
                BDConexion.Open();
                BDComando.Connection = BDConexion; //Para su funcionamiento, el comando necesita una conexion (BDConexion)
                BDComando.CommandType = CommandType.TableDirect; //Se muestra la tabla, nombre de la tabla
                BDComando.CommandText = DatosBDTabla;//Este es el nombre de la tabla (DatosBDTabla), antes declarada con TableDirect para "traer" la tabla
                BDAdap = new OleDbDataAdapter(BDComando);
                DataSet DataSet = new DataSet();//Una tabla que esta situada en la memoria RAM, la cual posee los datos, // DataSet --> Nombre variable
                BDAdap.Fill(DataSet, DatosBDTabla);
                cmbListar.DataSource = DataSet.Tables[DatosBDTabla];
                cmbListar.DisplayMember = "Detalle_Actividad";//Informacion que se va a mostrar en la CMB
                //cmbListar.ValueMember = "Codigo_Actividad";//esta invisible, pero esta


                BDConexion.Close(); //Se cierra la conexion

            }
            catch (Exception)
            {

                 //Evita un crasheo de la aplicacion
            }

        }

        public void BuscarActivid(int codigo)
        {
            try
            {
                
                BDConexion.ConnectionString = BDCadenaConexion; //Conexion a la base de datos
               
                BDConexion.Open(); //Abro BD
                
                BDComando.Connection = BDConexion; //Que conexion voy a utilizar
               
                BDComando.CommandType = CommandType.Text; //Uso de la tabla
                
                BDComando.CommandText = "SELECT * FROM Actividad WHERE Codigo_Actividad =" + codigo;
                //Elemento que me permite convertir los datos que se encuentran en la base de datos a un conjunto de valores que entienda .NET
                //le paso a adaptador el comando (quequierodelabase)
                DataReader = BDComando.ExecuteReader();

                while (DataReader.Read()) //Mientras se encuentre informacion
                {
                    NombreActividad = DataReader[1].ToString();
                }

                BDConexion.Close();
            }
            catch (Exception Mensaje)
            {
                
            }
        }
    }


}
