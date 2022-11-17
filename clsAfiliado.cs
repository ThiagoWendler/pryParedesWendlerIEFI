using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb; //Se usa para trabajar con base de datos. (Access)
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Drawing.Printing;
using System.Drawing;

namespace pryParedesWendlerIEFI
{
    internal class clsAfiliado //La creacion y el uso de la clase se da principalmente para una mayor eficacia al momento de programar y volver del
                               //programa una experiencia mucho mas veloz. 
    {
        private OleDbConnection BDConexion = new OleDbConnection();
        private OleDbCommand BDComando = new OleDbCommand();//Se envian ordenes a la base de datos
        private OleDbDataAdapter BDAdap = new OleDbDataAdapter();//Se adaptan los datos que esten en la BD 


        private string BDCadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BDclientes.accdb";
        private string DatosBDTabla = "Gimnasio";

        //Declaracion de variables de uso publico
        public decimal Saldo;
        public Int32 Cantidad; //Entero
        public decimal Promedio; //Decimal
        public Int32 DNI;
        public string NombreApellido; //Cadena de caracteres
        public string Direccion; //""
        public Int32 CodigoSucursal;
        public Int32 CodigoActividad;


        /////////////////////////////

        //Lectura y modificaion de datos (public)
        public Int32 Dni_Socio //variable
        {
            get { return DNI; } //Se usa para leer 
            set { DNI = value; }  //Se usa para asignar un nuevo valor
        }


        public string Nombre_Apellido
        {
            get { return NombreApellido; } //Se usa para leer 
            set { NombreApellido = value; }  //Se usa para asignar un nuevo valor
        }

        public decimal SaldoC
        {
            get { return Saldo; } //Se usa para leer 
            set { Saldo = value; }  //Se usa para asignar un nuevo valor
        }


        public decimal TotalSaldo
        {
            get { return Saldo; } //Se usa para leer, solo se muestra el dato, no hay necesidad de editar el valor (SET)
        }

        public Int32 CantidadAfiliados
        {
            get { return Cantidad; } //Se usa para leer, solo se muestra el dato, no hay necesidad de editar el valor (SET) 
        }

        public decimal PromedioSaldo
        {
            get { return Saldo / Cantidad; } //Se usa para leer, solo se muestra el dato, no hay necesidad de editar el valor (SET) 
        }


        public string DireccionC
        {
            get { return Direccion; } //Se usa para leer 
            set { Direccion = value; }  //Se usa para asignar un nuevo valor
        }
        public Int32 CCodigoSucursal
        {
            get { return CodigoSucursal; } //Se usa para leer 
            set { CodigoSucursal = value; }  //Se usa para asignar un nuevo valor
        }
        public Int32 CodigoActividadC //variable
        {
            get { return CodigoActividad; } //Se usa para leer 
            set { CodigoActividad = value; }  //Se usa para asignar un nuevo valor
        }

        //Metodo de uso publico para manejo de datos
        public void Listar(DataGridView dgvGrilla) //Metodo para listar afiliados
        {
            try
            {
                BDConexion.ConnectionString = BDCadenaConexion;//Se usa la cadena de conexion con la BD
                BDConexion.Open();

                BDComando.Connection = BDConexion; //Para su funcionamiento, el comando necesita una conexion (BDConexion)
                BDComando.CommandType = CommandType.TableDirect; //Uso directo del comando
                BDComando.CommandText = DatosBDTabla; //Este es el nombre de la tabla (DatosBDTabla), antes declarada con TableDirect para "traer" la tabla

                BDAdap = new OleDbDataAdapter(BDComando);
                DataSet DataSet = new DataSet();//Una tabla que esta situada en la memoria, la cual posee los datos, // DataSet --> Nombre variable
                BDAdap.Fill(DataSet);

                dgvGrilla.DataSource = DataSet.Tables[0]; //Obtiene o establece el origen de datos que se muestran en el metodo DataGriedView


                BDConexion.Close(); //Se cierra la conexion

            }
            catch (Exception error)
            {

                //Una exepcion en caso de que ocurra un error, evita el "CRASHEO" de la aplicacion
            }

        }

        public void BuscarAfiliado(Int32 Dni_Socio)
        {
            try
            {
                BDConexion.ConnectionString = BDCadenaConexion; //Establece la cadena que se utiliza para abrir la BD
                BDConexion.Open();

                BDComando.Connection = BDConexion;
                BDComando.CommandType = CommandType.TableDirect; //Uso del comando para traer la tabla
                BDComando.CommandText = "Gimnasio";



                //Explicacion DataReader: DataReader proporciona un flujo de datos no almacenado en búfer que permite a la lógica de procedimientos procesar de forma eficaz y secuencial los resultados de un origen de datos.
                //DataReader es la mejor opción cuando se trata de recuperar grandes cantidades de datos, ya que estos no se almacenan en la memoria caché.

                OleDbDataReader DataReader = BDComando.ExecuteReader(); //Lee lo que posee en la tabla y el comando lo ejecuta (BDComando.ExecuteReader)
                if (DataReader.HasRows) //Si DataReader tiene filas...
                {
                    while (DataReader.Read()) //MIENTRAS se puedan leer datos
                    {
                        if (DataReader.GetInt32(0) == Dni_Socio) //Se compara con los datos ingresados
                        {
                            DNI = DataReader.GetInt32(0); //Obtiene el valor de la columna con el valor especificado: Entero32bits
                            NombreApellido = DataReader.GetString(1); //Cadena de caracteres
                            Direccion = DataReader.GetString(2); //""
                            CCodigoSucursal = DataReader.GetInt32(3); //Entero32bits
                            CodigoActividad = DataReader.GetInt32(4); // ""
                            Saldo = DataReader.GetDecimal(5); //Decimal

                        }
                    }
                }
                BDConexion.Close(); //Se cierra conexion

            }
            catch (Exception)
            {
                //Una exepcion en caso de que ocurra un error, evita el "CRASHEO" de la aplicacion

            }


        }

        public void ListarAfiliados(DataGridView dgvListado) 
        {
            try
            {
                BDConexion.ConnectionString = BDCadenaConexion; //Establece la cadena que se utiliza para abrir la BD
                BDConexion.Open();

                BDComando.Connection = BDConexion;
                BDComando.CommandType = CommandType.TableDirect; //Uso del comando para traer la tabla
                BDComando.CommandText = DatosBDTabla;

                OleDbDataReader DataReader = BDComando.ExecuteReader();
                dgvListado.Rows.Clear(); //Limpia las filas
                Cantidad = 0; //Limpia valores
                Saldo = 0;
                while (DataReader.Read())
                {
                    if (DataReader.GetDecimal(5) > 0) //Si es mayor a 5
                    {

                        dgvListado.Rows.Add(DataReader.GetInt32(0), DataReader.GetString(1), DataReader.GetDecimal(5)); //Agrega filas
                        Cantidad++; //Aumenta cantidad
                        Saldo = Saldo + DataReader.GetDecimal(5); //Se suman los datos

                    }

                }
                BDConexion.Close(); //Se cierra la conexion
            }
            catch (Exception)
            {
                //Una exepcion en caso de que ocurra un error, evita el "CRASHEO" de la aplicacion

            }
        }

        public void RegistroDeClientes()
        {
            try
            {
                string DDBD = "";
                DDBD = "INSERT INTO Gimnasio (Dni_Socio,Nombre_Apellido,Direccion,Codigo_Sucursal,Codigo_Actividad,Saldo)"; //Se insertan los datos en la BD
                DDBD = DDBD + " VALUES (" + Dni_Socio + ",'" + Nombre_Apellido + "','" + Direccion + "'," + CCodigoSucursal + "," + CodigoActividad + "," + Saldo + ")";
                BDConexion.ConnectionString = BDCadenaConexion;
                BDConexion.Open();
                BDComando.Connection = BDConexion;
                BDComando.CommandType = CommandType.Text;
                BDComando.CommandText = DDBD;
                BDComando.ExecuteNonQuery();
                BDConexion.Close();
                MessageBox.Show("El registro se logro con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception Error)
            {
                MessageBox.Show("Ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void EliminarAfiliado()
        {
            try
            {
                string DDBD = "";
                DDBD = "DELETE FROM Gimnasio " + //Se eliminan los datos de la tabla "Gimnasio"
                    "WHERE(" + DNI + "=[Dni_Socio])";

                BDConexion.ConnectionString = BDCadenaConexion;
                BDConexion.Open();
                BDComando.Connection = BDConexion;
                BDComando.CommandType = CommandType.Text;
                BDComando.CommandText = DDBD;
                BDComando.ExecuteNonQuery();
                BDConexion.Close();
                MessageBox.Show("El registro se logro con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BusquedaClientesActividad(DataGridView GrillaBusquedaCA, Int32 Actividad) 
        {
            try
            {

                BDConexion.ConnectionString = BDCadenaConexion;
                BDConexion.Open();
                BDComando.Connection = BDConexion;
                BDComando.CommandType = CommandType.TableDirect;
                BDComando.CommandText = "Gimnasio";
                OleDbDataReader Lector = BDComando.ExecuteReader();
                GrillaBusquedaCA.Rows.Clear();
                if (Lector.HasRows)// Si el lector encuentra filas, procedee a leer 
                {
                    while (Lector.Read()) //Mientras se encuentre informacion para leer
                    {
                        if (Lector.GetInt32(4) == Actividad)
                        {
                            GrillaBusquedaCA.Rows.Add(Lector.GetInt32(0), Lector.GetString(1), Lector.GetString(2), Lector.GetDecimal(5));

                        }

                    }
                }
                BDConexion.Close();


            }
            catch (Exception)
            {



            }
        }

        public void ModificarAfiliado(Int32 Dni_Socio)
        {
            try
            {
                string DDBD = "UPDATE Gimnasio SET " + //Se modifican los datos
                    "[Dni_Socio] = " + Dni_Socio + ", " +
                    "[Nombre_Apellido] = '" + Nombre_Apellido + "', " +
                    "[Direccion] = '" + Direccion + "', " +
                    "[Codigo_Sucursal] = " + CCodigoSucursal + " , " +
                    "[Codigo_Actividad] = " + CodigoActividad + " ," +
                    "[Saldo] = " + Saldo + " WHERE [Dni_Socio] = " + Dni_Socio;


                BDConexion.ConnectionString = BDCadenaConexion;
                BDConexion.Open();
                BDComando.Connection = BDConexion;
                BDComando.CommandType = CommandType.Text;
                BDComando.CommandText = DDBD;
                BDComando.ExecuteNonQuery();
                BDConexion.Close();
                MessageBox.Show("El registro se logro con exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ImprimirDatos(PrintPageEventArgs reporte)
        {
            try
            {
                Int32 Lines = 200;
                Font FuenteLetra = new Font("Calibri", 12);
                BDConexion.ConnectionString = BDCadenaConexion; //Se establece la cadena de conexion
                BDConexion.Open(); //Abrimos la conexion
                BDComando.Connection = BDConexion; //Configura el comando, el comando va a usar la conexion que esta abierta
                BDComando.CommandType = CommandType.TableDirect; //Tipo de comando es acceso directo a una tabla
                BDComando.CommandText = "Gimnasio";
                DataSet DataSet = new DataSet();
                BDAdap = new OleDbDataAdapter(BDComando);
                BDAdap.Fill(DataSet, DatosBDTabla);
                if (DataSet.Tables[DatosBDTabla].Rows.Count > 0)
                {
                    foreach (DataRow fila in DataSet.Tables[DatosBDTabla].Rows)
                    {
                        reporte.Graphics.DrawString(fila["Dni_Socio"].ToString(), FuenteLetra, Brushes.Black, 100, Lines);
                        reporte.Graphics.DrawString(fila["Nombre_Apellido"].ToString(), FuenteLetra, Brushes.Black, 200, Lines);
                        reporte.Graphics.DrawString(fila["Direccion"].ToString(), FuenteLetra, Brushes.Black, 300, Lines);
                        reporte.Graphics.DrawString(fila["Saldo"].ToString(), FuenteLetra, Brushes.Black, 400, Lines);
                        Lines = Lines + 15;
                    }
                }
                BDConexion.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }
        public void SalidaDeClientes(Int32 idACtividad)
        {

            try
            {
                BDConexion.ConnectionString = BDCadenaConexion;
                BDConexion.Open();
                BDComando.Connection = BDConexion; //Conexion a origen de datos
                BDComando.CommandType = CommandType.TableDirect;
                BDComando.CommandText = "Gimnasio";
                OleDbDataReader DataReader = BDComando.ExecuteReader();
                //grabamos
                StreamWriter SWCr = new StreamWriter("SalidsDeClientes.csv", false);
                SWCr.WriteLine("Listado de Afiliados\n");
                SWCr.WriteLine("Dni_Socio;Nombre_Apellido;Direccion;Saldo\n");
                Cantidad = 0;
                Saldo = 0;
                if (DataReader.HasRows)
                {
                    while (DataReader.Read())
                    {
                        if (idACtividad == DataReader.GetInt32(4))
                        {
                            SWCr.Write(DataReader.GetInt32(0));
                            SWCr.Write(";");
                            SWCr.Write(DataReader.GetString(1));
                            SWCr.Write(";");
                            SWCr.Write(DataReader.GetString(2));
                            SWCr.Write(";");
                            SWCr.Write(DataReader.GetDecimal(5));


                            Cantidad = Cantidad + 1;
                            Saldo = Saldo + DataReader.GetDecimal(5);
                            Promedio = Saldo / Cantidad;
                            SWCr.Write("\n");

                        }

                    }
                    SWCr.Write("Cantidad de Afiliados:");
                    SWCr.WriteLine(Cantidad);
                    SWCr.Write("Total de saldo:");
                    SWCr.WriteLine(Saldo);
                    SWCr.Write("Promedio:");
                    SWCr.WriteLine(Saldo / Cantidad);

                }
                BDConexion.Close();
                SWCr.Close();
                MessageBox.Show("Tus datos han sido exportados correctamente", "Exito" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Tus datos no pudieron ser exportados correctamente", "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }
        

    }
}
