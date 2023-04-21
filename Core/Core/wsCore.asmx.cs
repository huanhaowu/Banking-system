using Core.dsCoreTableAdapters;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Security.RightsManagement;
using System.Text;
using System.Web;
using System.Web.Services;
using static Core.dsCore;

namespace Core
{
    /// <summary>
    /// Summary description for wsCore
    /// </summary>
    [WebService(Namespace = "http://intec.edu.do/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class wsCore : System.Web.Services.WebService
    {
        public static bool EsBuenaContraseña(string contraseña)
        {
            int longitudMinima = 8; // Establecer la longitud mínima requerida
            bool tieneMayusculas = false;
            bool tieneMinusculas = false;
            bool tieneNumeros = false;
            bool tieneSimbolos = false;

            // Verificar la longitud
            if (contraseña.Length < longitudMinima)
            {
                return false;
            }

            // Verificar la dificultad
            foreach (char c in contraseña)
            {
                if (char.IsUpper(c))
                {
                    tieneMayusculas = true;
                }
                else if (char.IsLower(c))
                {
                    tieneMinusculas = true;
                }
                else if (char.IsDigit(c))
                {
                    tieneNumeros = true;
                }
                else
                {
                    tieneSimbolos = true;
                }
            }

            if (!tieneMayusculas || !tieneMinusculas || !tieneNumeros || !tieneSimbolos)
            {
                return false;
            }

            // Verificar la complejidad
            if (contraseña.ToLower().Contains("usuario") || contraseña.ToLower().Contains("contraseña"))
            {
                return false;
            }

            return true;
        }

            //Clientes
            [WebMethod]
        public void InsertarCliente(Cliente cliente)
        {
            ClienteTableAdapter tblCliente = new ClienteTableAdapter();
            tblCliente.Connection.Open();
            SqlTransaction transaction = tblCliente.Connection.BeginTransaction();
            tblCliente.Transaction = transaction;
            try
            {
                tblCliente.sp_InsertarCliente(cliente.Nombre, cliente.Apellido, cliente.TipoDocumento, cliente.Documento, cliente.Email, cliente.Telefono, cliente.Direccion, cliente.FechaNacimiento);
                transaction.Commit(); //confirmar la transaccion
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback(); //revertir la transaccion

            }
        }

        [WebMethod]
        public void BorrarCliente(int ID_Cliente)
        {
            ClienteTableAdapter tblCliente = new ClienteTableAdapter();
            tblCliente.Connection.Open();
            SqlTransaction transaction = tblCliente.Connection.BeginTransaction();
            tblCliente.Transaction = transaction;
            try
            {
                tblCliente.sp_EliminarCliente(ID_Cliente);
                transaction.Commit(); //confirmar la transaccion
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback(); //revertir la transaccion

            }
        }

        [WebMethod]
        public void ActualizarCliente(int ID_Cliente, Cliente cliente)
        {
            ClienteTableAdapter tblCliente = new ClienteTableAdapter();
            tblCliente.Connection.Open();
            SqlTransaction transaction = tblCliente.Connection.BeginTransaction();
            tblCliente.Transaction = transaction;
            try
            {
                tblCliente.sp_ActualizarCliente(ID_Cliente, cliente.Nombre, cliente.Apellido, cliente.TipoDocumento, cliente.Documento, cliente.Email, cliente.Telefono, cliente.Direccion, cliente.FechaNacimiento);
                transaction.Commit(); //confirmar la transaccion
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback(); //revertir la transaccion

            }
        }

        [WebMethod]
        public void ObtenerClientes()
        {
            ClienteTableAdapter tblCliente = new ClienteTableAdapter();
            tblCliente.Connection.Open();
            SqlTransaction transaction = tblCliente.Connection.BeginTransaction();
            tblCliente.Transaction = transaction;
            try
            {
                tblCliente.sp_ObtenerTodosLosClientes();
                transaction.Commit(); //confirmar la transaccion
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback(); //revertir la transaccion

            }
        }

        [WebMethod]
        public Cliente ObtenerClienteByID(int Cliente_ID)
        {
            ClienteTableAdapter tblCliente = new ClienteTableAdapter();
            tblCliente.Connection.Open();
            SqlTransaction transaction = tblCliente.Connection.BeginTransaction();
            tblCliente.Transaction = transaction;
            Cliente client = new Cliente();

            try
            {
                ClienteDataTable cliente= tblCliente.sp_ObtenerClientePorID(Cliente_ID);
                transaction.Commit(); //confirmar la transaccion

                foreach (var x in cliente)
                {
                    client.Nombre = x.Cliente_Nombre;
                    client.Apellido = x.Cliente_Apellido;
                    client.TipoDocumento = x.Cliente_TipoDocumento;
                    client.Email = x.Cliente_Correo;
                    client.Telefono = x.Cliente_Telefono;
                    client.Direccion = x.Cliente_Direccion;
                    client.FechaNacimiento = x.Cliente_FNacimiento;
                }
                return client;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback(); //revertir la transaccion

            }
            return client;
        }

        //Usuarios
        [WebMethod]
        public string CrearUsuarioCaja(int Cliente_ID, string Nombre, string Clave)
        {
            UsuarioTableAdapter tblUsuario = new UsuarioTableAdapter();
            tblUsuario.Connection.Open();
            if (EsBuenaContraseña(Clave) == false)
            {
                return "La contraseña no cumple con los requisitos de seguridad";
            }
            else
            {
                HashAlgorithm sha256 = SHA256.Create();
                byte[] bytes = Encoding.UTF8.GetBytes(Clave);
                byte[] hash = sha256.ComputeHash(bytes);
                Clave = Convert.ToBase64String(hash);

                if ((bool)tblUsuario.VerificarCredencialesCaja(Nombre, Clave))
                {
                    return "Ese usuario ya existe";
                }
                else
                {
                    SqlTransaction transaction = tblUsuario.Connection.BeginTransaction();
                    tblUsuario.Transaction = transaction;
                    try
                    {
                        tblUsuario.sp_InsertarUsuario(Cliente_ID, Nombre, Clave, 3);
                        transaction.Commit(); //confirmar la transaccion
                        return "Usuario creado correctamente";
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        transaction.Rollback(); //revertir la transaccion
                        return "Error al crear usuario";
                    }
                }

            }
        }

        [WebMethod]
        public string CrearUsuarioCore(int Cliente_ID, string Nombre, string Clave)
        {
            UsuarioTableAdapter tblUsuario = new UsuarioTableAdapter();
            tblUsuario.Connection.Open();
            if (EsBuenaContraseña(Clave) == false)
            {
                return "La contraseña no cumple con los requisitos de seguridad";
            }
            else
            {
                HashAlgorithm sha256 = SHA256.Create();
                byte[] bytes = Encoding.UTF8.GetBytes(Clave);
                byte[] hash = sha256.ComputeHash(bytes);
                Clave = Convert.ToBase64String(hash);


                if ((bool)tblUsuario.VerificarCredencialesCore(Nombre, Clave))
                {
                    return "Ese usuario ya existe";
                }
                else
                {
                    SqlTransaction transaction = tblUsuario.Connection.BeginTransaction();
                    tblUsuario.Transaction = transaction;
                    try
                    {
                        tblUsuario.sp_InsertarUsuario(Cliente_ID, Nombre, Clave, 1);
                        transaction.Commit(); //confirmar la transaccion
                        return "Usuario creado correctamente";
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        transaction.Rollback(); //revertir la transaccion
                        return "Error al crear usuario";
                    }
                }
            }
        }

        [WebMethod]
        public void BorrarUsuario(int Usuario_ID)
        {
            UsuarioTableAdapter tblUsuario = new UsuarioTableAdapter();
            tblUsuario.Connection.Open();
            SqlTransaction transaction = tblUsuario.Connection.BeginTransaction();
            tblUsuario.Transaction = transaction;
            try
            {
                tblUsuario.sp_EliminarUsuario(Usuario_ID);
                transaction.Commit(); //confirmar la transaccion
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback(); //revertir la transaccion
            }
        }

        [WebMethod]
        public string ActualizarUsuario(int Usuario_ID, int Cliente_ID, string Nombre, string Clave)
        {
            UsuarioTableAdapter tblUsuario = new UsuarioTableAdapter();
            tblUsuario.Connection.Open();
            if (EsBuenaContraseña(Clave) == false)
            {
                return"La contraseña no cumple con los requisitos de seguridad";
            }
            else
            {
                HashAlgorithm sha256 = SHA256.Create();
                byte[] bytes = Encoding.UTF8.GetBytes(Clave);
                byte[] hash = sha256.ComputeHash(bytes);
                Clave = Convert.ToBase64String(hash);

                if ((bool)tblUsuario.VerificarCredencialesCaja(Nombre, Clave))
                {
                    return"Ese usuario ya existe";
                }
                else
                {
                    SqlTransaction transaction = tblUsuario.Connection.BeginTransaction();
                    tblUsuario.Transaction = transaction;
                    try
                    {
                        tblUsuario.sp_ActualizarUsuario(Usuario_ID, Cliente_ID, Nombre, Clave);
                        transaction.Commit(); //confirmar la transaccion
                        return "Usuario actualizado correctamente";
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        transaction.Rollback(); //revertir la transaccion
                        return "Error al actualizar usuario";
                    }
                }
            }
        }

        [WebMethod]
        public void ObtenerUsuario()
        {
            UsuarioTableAdapter tblUsuario = new UsuarioTableAdapter();
            tblUsuario.Connection.Open();
            SqlTransaction transaction = tblUsuario.Connection.BeginTransaction();
            tblUsuario.Transaction = transaction;
            try
            {
                tblUsuario.sp_ObtenerTodosLosUsuarios();
                transaction.Commit(); //confirmar la transaccion
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback(); //revertir la transaccion
            }
        }

        [WebMethod]
        public Usuario ObtenerUsuarioByID(int Usuario_ID)
        {
            UsuarioTableAdapter tblUsuario = new UsuarioTableAdapter();
            tblUsuario.Connection.Open();
            SqlTransaction transaction = tblUsuario.Connection.BeginTransaction();
            tblUsuario.Transaction = transaction;
            Usuario user = new Usuario();
            try
            {
                UsuarioDataTable usuarios = tblUsuario.sp_ObtenerUsuarioPorID(Usuario_ID);
                transaction.Commit(); //confirmar la transaccion
                //tblUsuario.Connection.Close();
             
                foreach (var x in usuarios)
                {
                    user.UsuarioId = x.Usuario_ID;
                    user.ClienteId = x.Cliente_ID;
                    user.NombreUser = x.Usuario_Nombre;
                    user.Password = x.Usuario_Clave;
                    user.PerfilId = x.Perfil_ID;
                    user.FCreacion = x.Fecha_creacion;
      
                }
                return user;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback(); //revertir la transaccion
            }
            return user;
        }

        //Cuentas
        [WebMethod]
        public void CrearCuenta(Cuentas cuenta)
        {
            CuentaTableAdapter tblCuenta = new CuentaTableAdapter();
            tblCuenta.Connection.Open();
            SqlTransaction transaction = tblCuenta.Connection.BeginTransaction();
            tblCuenta.Transaction = transaction;
            try
            {
                tblCuenta.sp_InsertarCuenta(cuenta.Tipo_Cuenta, cuenta.Cliente, 0, cuenta.Numero_Cuenta, cuenta.Moneda);
                transaction.Commit(); //confirmar la transaccion
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback(); //revertir la transaccion
            }
        }

        [WebMethod]
        public void BorrarCuenta(int Cuenta_ID)
        {
            CuentaTableAdapter tblCuenta = new CuentaTableAdapter();
            tblCuenta.Connection.Open();
            SqlTransaction transaction = tblCuenta.Connection.BeginTransaction();
            tblCuenta.Transaction = transaction;
            try
            {
                tblCuenta.sp_EliminarCuenta(Cuenta_ID);
                transaction.Commit(); //confirmar la transaccion
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback(); //revertir la transaccion
            }
        }

        [WebMethod]
        public void ActualizarCuenta(int Cuenta_ID, Cuentas cuentas)
        {
            CuentaTableAdapter tblCuenta = new CuentaTableAdapter();
            tblCuenta.Connection.Open();
            SqlTransaction transaction = tblCuenta.Connection.BeginTransaction();
            tblCuenta.Transaction = transaction;
            try
            {
                tblCuenta.sp_ActualizarCuenta(Cuenta_ID, cuentas.Tipo_Cuenta, cuentas.Cliente, cuentas.Numero_Cuenta, cuentas.Moneda);
                transaction.Commit(); //confirmar la transaccion
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback(); //revertir la transaccion
            }
        }

        [WebMethod]
        public void ObtenerCuentas(int Cliente_ID)
        {
            CuentaTableAdapter tblCuenta = new CuentaTableAdapter();
            tblCuenta.Connection.Open();
            SqlTransaction transaction = tblCuenta.Connection.BeginTransaction();
            tblCuenta.Transaction = transaction;
            try
            {
                tblCuenta.sp_ObtenerTodasLasCuentas(Cliente_ID);
                transaction.Commit(); //confirmar la transaccion
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback(); //revertir la transaccion
            }
        }

        [WebMethod]
        public Cuentas ObtenerCuentaByID(int Cuenta_ID)
        {
            CuentaTableAdapter tblCuenta = new CuentaTableAdapter();
            tblCuenta.Connection.Open();
            SqlTransaction transaction = tblCuenta.Connection.BeginTransaction();
            tblCuenta.Transaction = transaction;
            Cuentas acc = new Cuentas();

            try
            {
                CuentaDataTable cuentas = tblCuenta.sp_ObtenerCuentaPorID(Cuenta_ID);
                transaction.Commit(); //confirmar la transaccion

                foreach (var x in cuentas)
                {
                    acc.Tipo_Cuenta = x.Tipo_Cuenta_ID;
                    acc.Cliente = x.Cliente_ID;
                    acc.Numero_Cuenta = x.Numero_Cuenta;
                    acc.Moneda = x.Moneda_ID;
                    acc.Monto = x.Monto;
                }
                return acc;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback(); //revertir la transaccion
            }

            return acc;
        }


        [WebMethod]
        public void ConsultarMovimientos(int Cuenta_ID)
        {
            CuentaTableAdapter tblCuenta = new CuentaTableAdapter();
            tblCuenta.Connection.Open();
            SqlTransaction transaction = tblCuenta.Connection.BeginTransaction();
            tblCuenta.Transaction = transaction;
            try
            {
                tblCuenta.sp_ConsultarMovimientosCuenta(Cuenta_ID);
                transaction.Commit(); //confirmar la transaccion
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback(); //revertir la transaccion
            }
        }

        //Prestamos
        [WebMethod]
        public void CrearPrestamos(Prestamos prestamo)
        {
            decimal MontoPagar = prestamo.Monto * prestamo.Tasa_Interes;
            PrestamoTableAdapter tblPrestamo = new PrestamoTableAdapter();
            tblPrestamo.Connection.Open();
            SqlTransaction transaction = tblPrestamo.Connection.BeginTransaction();
            tblPrestamo.Transaction = transaction;
            try
            {
                tblPrestamo.sp_InsertPrestamo(prestamo.Cliente_ID, prestamo.Tasa_Interes, prestamo.FechaFinal, prestamo.Monto, MontoPagar, prestamo.Banco_ID, prestamo.Estado, prestamo.Moneda);
                transaction.Commit(); //confirmar la transaccion
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback(); //revertir la transaccion
            }
        }

        [WebMethod]
        public void BorrarPrestamos(int Prestamo_ID)
        {
            PrestamoTableAdapter tblPrestamo = new PrestamoTableAdapter();
            tblPrestamo.Connection.Open();
            SqlTransaction transaction = tblPrestamo.Connection.BeginTransaction();
            tblPrestamo.Transaction = transaction;
            try
            {
                tblPrestamo.sp_DeletePrestamo(Prestamo_ID);
                transaction.Commit(); //confirmar la transaccion
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback(); //revertir la transaccion
            }
        }

        [WebMethod]
        public void ActualizarPrestamos(int Prestamo_ID, Prestamos prestamo)
        {
            decimal MontoPagar = prestamo.Monto * prestamo.Tasa_Interes;
            PrestamoTableAdapter tblPrestamo = new PrestamoTableAdapter();
            tblPrestamo.Connection.Open();
            SqlTransaction transaction = tblPrestamo.Connection.BeginTransaction();
            tblPrestamo.Transaction = transaction;
            try
            {
                tblPrestamo.sp_UpdatePrestamo(Prestamo_ID, prestamo.Cliente_ID, prestamo.Tasa_Interes, prestamo.FechaFinal, prestamo.Monto, MontoPagar, prestamo.Banco_ID, prestamo.Estado, prestamo.Moneda);
                transaction.Commit(); //confirmar la transaccion
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback(); //revertir la transaccion
            }
        }

        [WebMethod]
        public Prestamos ObtenerPrestamosByID(int Prestamo_ID)
        {
            PrestamoTableAdapter tblPrestamo = new PrestamoTableAdapter();
            tblPrestamo.Connection.Open();
            SqlTransaction transaction = tblPrestamo.Connection.BeginTransaction();
            tblPrestamo.Transaction = transaction;
            Prestamos loan = new Prestamos();

            try
            {
                PrestamoDataTable prestamo = tblPrestamo.sp_GetPrestamoByID(Prestamo_ID);
                transaction.Commit(); //confirmar la transaccion
                
                foreach (var x in  prestamo)
                {
                    loan.Cliente_ID= x.Cliente_ID;
                    loan.Tasa_Interes = x.Tasa_Interes;
                    loan.FechaFinal = x.Fecha_Final;
                    loan.Monto = x.Monto_Prestamo;
                    loan.Banco_ID = x.Banco_ID;
                    loan.Estado = x.Estado_ID;
                    loan.Moneda = x.Moneda_ID;
                }
                return loan;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback(); //revertir la transaccion
            }
            return loan;
        }

        [WebMethod]
        public void ObtenerPrestamos()
        {
            PrestamoTableAdapter tblPrestamo = new PrestamoTableAdapter();
            tblPrestamo.Connection.Open();
            SqlTransaction transaction = tblPrestamo.Connection.BeginTransaction();
            tblPrestamo.Transaction = transaction;
            try
            {
                tblPrestamo.sp_GetPrestamos();
                transaction.Commit(); //confirmar la transaccion
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback(); //revertir la transaccion
            }
        }

        [WebMethod]
        public void CrearTipoTransaccion(string Descripcion)
        {
            Tipo_TransaccionTableAdapter tblTipoT = new Tipo_TransaccionTableAdapter();
            tblTipoT.Connection.Open();
            SqlTransaction transaction = tblTipoT.Connection.BeginTransaction();
            tblTipoT.Transaction = transaction;
            try
            {
                tblTipoT.sp_InsertTipoTransaccion(Descripcion);
                transaction.Commit(); //confirmar la transaccion
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback(); //revertir la transaccion
            }
        }

        [WebMethod]
        public void BorrarTipoTransaccion(int TipoT_ID)
        {
            Tipo_TransaccionTableAdapter tblTipoT = new Tipo_TransaccionTableAdapter();
            tblTipoT.Connection.Open();
            SqlTransaction transaction = tblTipoT.Connection.BeginTransaction();
            tblTipoT.Transaction = transaction;
            try
            {
                tblTipoT.sp_EliminarTipoTransaccion(TipoT_ID);
                transaction.Commit(); //confirmar la transaccion
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback(); //revertir la transaccion
            }
        }

        [WebMethod]
        public void ActualizarTipoTransaccion(string Descripcion, int TipoT_ID)
        {
            Tipo_TransaccionTableAdapter tblTipoT = new Tipo_TransaccionTableAdapter();
            tblTipoT.Connection.Open();
            SqlTransaction transaction = tblTipoT.Connection.BeginTransaction();
            tblTipoT.Transaction = transaction;
            try
            {
                tblTipoT.sp_UpdateTipoTransaccion(TipoT_ID, Descripcion);
                transaction.Commit(); //confirmar la transaccion
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback(); //revertir la transaccion
            }
        }

        [WebMethod]
        public TipoTransaccion ObtenerTipoTransaccionByID(int TipoT_ID)
        {
            Tipo_TransaccionTableAdapter tblTipoT = new Tipo_TransaccionTableAdapter();
            tblTipoT.Connection.Open();
            SqlTransaction transaction = tblTipoT.Connection.BeginTransaction();
            tblTipoT.Transaction = transaction;
            TipoTransaccion transact = new TipoTransaccion();

            try
            {
                Tipo_TransaccionDataTable transaccion = tblTipoT.sp_GetTipoTransaccionByID(TipoT_ID);
                transaction.Commit(); //confirmar la transaccion
                foreach (var x in transaccion)
                {
                    transact.TipoTransaccionID = x.Tipo_Transaccion_ID;
                    transact.Descripcion = x.Descripcion;
                }
                return transact;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback(); //revertir la transaccion
            }
            return transact;
        }

        [WebMethod]
        public void ObtenerTipoTransaccion()
        {
            Tipo_TransaccionTableAdapter tblTipoT = new Tipo_TransaccionTableAdapter();
            tblTipoT.Connection.Open();
            SqlTransaction transaction = tblTipoT.Connection.BeginTransaction();
            tblTipoT.Transaction = transaction;
            try
            {
                tblTipoT.sp_ObtenerTodosTipoTransaccion();
                transaction.Commit(); //confirmar la transaccion
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                transaction.Rollback(); //revertir la transaccion
            }
        }

        [WebMethod]
        public bool ValidarInicioSesionCore(string Usuario, string Clave)
        {
            UsuarioTableAdapter tblUsuario = new UsuarioTableAdapter();
            tblUsuario.Connection.Open();
            HashAlgorithm sha256 = SHA256.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(Clave);
            byte[] hash = sha256.ComputeHash(bytes);
            Clave = Convert.ToBase64String(hash);

            if ((bool)tblUsuario.VerificarCredencialesCore(Usuario, Clave))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [WebMethod]
        public bool ValidarInicioSesionCaja(string Usuario, string Clave)
        {
            UsuarioTableAdapter tblUsuario = new UsuarioTableAdapter();
            tblUsuario.Connection.Open();
            HashAlgorithm sha256 = SHA256.Create();
            byte[] bytes = Encoding.UTF8.GetBytes(Clave);
            byte[] hash = sha256.ComputeHash(bytes);
            Clave = Convert.ToBase64String(hash);

            if ((bool)tblUsuario.VerificarCredencialesCaja(Usuario, Clave))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
