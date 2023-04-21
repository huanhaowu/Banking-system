using Integracion.dsCoreTableAdapters;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
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
                    return Valido;
                }
                else
                {
                    return Valido;
                }
            }
        }

        //TODO

        //Validar existencia de un codigo de cuenta
        [WebMethod]
        public bool ValidarExistenciaCodigo(int numero_cuenta)
        {
            //Conexion al webservice del CORE
            wsCore.wsCoreSoapClient webServiceCore = new wsCore.wsCoreSoapClient();

            bool valor_monto = false;

            bool conCore = false;
            //Conexion a base de datos exitosa
            if (conCore)
            {
                //Variable con el valor de retorno de eso
                wsCore.Cuentas cuenta = webServiceCore.ObtenerCuentaPorNo(numero_cuenta);
                if(cuenta.Numero_Cuenta != 0) return true; //ahí retorna el valor
            }
            else
            {
                CuentaTableAdapter tblCuenta = new CuentaTableAdapter();
                tblCuenta.Connection.Open();
                SqlTransaction transaction = tblCuenta.Connection.BeginTransaction();
                tblCuenta.Transaction = transaction;

                try
                {
                    //VALIDAR LA EXISTENCIA DE UNA CUENTA

                    //CuentaDataTable cuentas = tblCuenta.sp_ObtenerCuentaPorNo(numero_cuenta);
                    //transaction.Commit(); //confirmar la transaccion
                    return valor_monto;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    transaction.Rollback(); //revertir la transaccion
                }

            }
        }

        //TODO

        //Get monto de la cuenta de un numero de cuenta
        [WebMethod]
        public decimal GetMontoNumeroCuenta(int numero_cuenta)
        {
            //Conexion al webservice del CORE
            wsCore.wsCoreSoapClient webServiceCore = new wsCore.wsCoreSoapClient();

            decimal valor_monto = 0;

            bool conCore = false;
            //Conexion a base de datos exitosa
            if (conCore)
            {
                //Variable con el valor de retorno de eso
                wsCore.Cuentas cuenta = webServiceCore.ObtenerCuentaPorNo(numero_cuenta);
                return valor_monto = cuenta.Monto; //ahí retorna el valor
            }
            else
            {
                CuentaTableAdapter tblCuenta = new CuentaTableAdapter();
                tblCuenta.Connection.Open();
                SqlTransaction transaction = tblCuenta.Connection.BeginTransaction();
                tblCuenta.Transaction = transaction;

                try
                {
                    //OBTENER EL MONTO DE UNA CUENTA DE MANERA LOCAL

                    //CuentaDataTable cuentas = tblCuenta.sp_ObtenerCuentaPorNo(numero_cuenta);
                    //transaction.Commit(); //confirmar la transaccion
                    return valor_monto;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    transaction.Rollback(); //revertir la transaccion
                }

            }
        }

        //TODO

        //Insert de las transacciones
        [WebMethod]
        public bool InsertTransaccion(int Tipo_transaccion_ID, int Cuenta_ID, int Cuenta_Destino_ID, int Transaccion_Monto, int Estado_ID)
        {
            //Conexion al webservice del CORE
            wsCore.wsCoreSoapClient webServiceCore = new wsCore.wsCoreSoapClient();

            bool Valido = false;

            bool conCore = false;
            //Conexion a base de datos exitosa
            if (conCore)
            {
                //Variable con el valor de retorno de eso
                //Valido = webServiceCore.ValidarInicioSesionCaja(Usuario_nombre, Usuario_clave);

                return Valido;
            }
            else
            {
                Transaccion1TableAdapter tblTransaccion = new Transaccion1TableAdapter();
                tblTransaccion.Connection.Open();
                SqlTransaction trans = tblTransaccion.Connection.BeginTransaction();
                tblTransaccion.Transaction = trans;

                try
                {
                    tblTransaccion.sp_InsertTransaccion(Tipo_transaccion_ID, Cuenta_ID, Cuenta_Destino_ID, Transaccion_Monto, Estado_ID);
                    trans.Commit();
                    return Valido = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    trans.Rollback();
                    return Valido = false;
                }

            }

        }
    }
