using Integracion.dsCoreTableAdapters;
using System;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Web.Services;
using static Integracion.dsCore;

namespace Integracion
{
    /// <summary>
    /// Summary description for wsIntegracion
    /// </summary>
    [WebService(Namespace = "http://intec.edu.do/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsIntegracion : System.Web.Services.WebService
    {

        public static void RegistrarLog(string Descripcion)
        {
            tbl_Log4NetTableAdapter tbl_Log = new tbl_Log4NetTableAdapter();
            tbl_Log.Connection.Open();
            SqlTransaction transaction = tbl_Log.Connection.BeginTransaction();
            tbl_Log.Transaction = transaction;
            try
            {
                tbl_Log.RegistrarLog(Descripcion);
                transaction.Commit();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback(); //revertir la transaccion
            }
        }

                [WebMethod]
        public bool ValidarUsuario(string Usuario_nombre, string Usuario_clave)
        {
            //Conexion al webservice del CORE
            wsCore.wsCoreSoapClient webServiceCore = new wsCore.wsCoreSoapClient();

            bool Valido;

            bool conCore = false;
            //Conexion a base de datos exitosa
            if (conCore)
            {
                //Variable con el valor de retorno de eso
                Valido = webServiceCore.ValidarInicioSesionCaja(Usuario_nombre, Usuario_clave);
                RegistrarLog("Crendeciales validadas exitosamente");

                return Valido;
            }
            else
            {
                UsuarioTableAdapter tblUsuario = new UsuarioTableAdapter();
                tblUsuario.Connection.Open();
                HashAlgorithm sha256 = SHA256.Create();
                byte[] bytes = Encoding.UTF8.GetBytes(Usuario_clave);
                byte[] hash = sha256.ComputeHash(bytes);
                Usuario_clave = Convert.ToBase64String(hash);

                Valido = (bool)tblUsuario.VerificarCredencialesCaja(Usuario_nombre, Usuario_clave);

                if (Valido)
                {
                    RegistrarLog("Crendeciales validadas exitosamente");
                    return Valido;
                }
                else
                {
                    RegistrarLog("Ha ocurrido un erro al validar un usuario");
                    return Valido;
                }
            }
        }

        //Validar existencia de un codigo de cuenta




        //Get monto de la cuenta de un numero de cuenta
        [WebMethod]
        public decimal GetMontoNumeroCuenta(int numero_cuenta)
        {
            //Conexion al webservice del CORE
            wsCore.wsCoreSoapClient webServiceCore = new wsCore.wsCoreSoapClient();

            bool conCore = true;
            
            //Conexion a base de datos exitosa
            if (conCore)
            {
                //Variable con el valor de retorno de eso
                wsCore.Cuentas cuenta = webServiceCore.ObtenerCuentaPorNo(numero_cuenta);
                RegistrarLog("Se ha solicitado exitosamente el monto de una cuenta");
                return cuenta.Monto; //retorna el monto del objeto cuenta
            }
            else
            {
                CuentaTableAdapter tblCuenta = new CuentaTableAdapter();
                tblCuenta.Connection.Open();
                SqlTransaction transaction = tblCuenta.Connection.BeginTransaction();
                tblCuenta.Transaction = transaction;
                Cuentas acc = new Cuentas();

                try
                {
                    CuentaDataTable cuentas = tblCuenta.sp_ObtenerCuentaPorNo(numero_cuenta);
                    transaction.Commit(); //confirmar la transaccion

                    foreach (var x in cuentas)
                    {
                        acc.Tipo_Cuenta = x.Tipo_Cuenta_ID;
                        acc.Cliente = x.Cliente_ID;
                        acc.Numero_Cuenta = x.Numero_Cuenta;
                        acc.Moneda = x.Moneda_ID;
                        acc.Monto = x.Monto;
                    }
                    RegistrarLog("Se ha solicitado exitosamente el monto de una cuenta");
                    return acc.Monto;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    RegistrarLog("Error al solicitar el monto de una cuenta");
                    transaction.Rollback(); //revertir la transaccion
                }

                return 0;
            }
        }



        //Insert de las transacciones
        [WebMethod]
        public bool InsertTransaccion(int Tipo_transaccion_ID, int Cuenta_ID, int Cuenta_Destino_ID, int Transaccion_Monto, int Estado_ID)
        {
            //Conexion al webservice del CORE
            wsCore.wsCoreSoapClient webServiceCore = new wsCore.wsCoreSoapClient();

            bool Valido = false;

            bool conCore = true;
            //Conexion a base de datos exitosa
            if (conCore)
            {
                //Variable con el valor de retorno de eso
                Valido = webServiceCore.InsertTransaccion(Tipo_transaccion_ID, Cuenta_ID, Cuenta_Destino_ID, Transaccion_Monto, Estado_ID);
                RegistrarLog("Se ha realizado una transaccion");
                return Valido;
            }
            else
            {
                TransaccionTableAdapter tblTransaccion = new TransaccionTableAdapter();
                tblTransaccion.Connection.Open();
                SqlTransaction trans = tblTransaccion.Connection.BeginTransaction();
                tblTransaccion.Transaction = trans;

                try
                {
                    tblTransaccion.sp_InsertTransaccion(Tipo_transaccion_ID, Cuenta_ID, Cuenta_Destino_ID, Transaccion_Monto, Estado_ID);
                    trans.Commit();
                    return Valido = true;
                    RegistrarLog("Se ha realizado una transaccion");

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    RegistrarLog("Error al realizar una transaccion");
                    trans.Rollback();
                    return Valido = false;

                }

            }

        }
    }
}