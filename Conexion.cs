using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class Conexion
    {
        private string cadenaConexion = string.Empty;
        SqlConnection con = new SqlConnection();

        public bool conectar()
        {
            try
            {
                con.ConnectionString = @"Password=Zw1XF-M48~2f;Persist Security Info=True;User ID=smartpropertysiw;Initial Catalog=smartpropertysiw;Data Source=mssql1.gear.host";
                //con.ConnectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SmartProperty;Data Source=DESKTOP-L0GLE2A";
                con.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public void Desconectar()
        {
            if (this.con.State == System.Data.ConnectionState.Open)
                this.con.Close();
        }
        public DataTable SelecionarId(int id)
        {
            if (conectar())
            {
                DataTable dt = new DataTable();
                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = con;
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.CommandText = "obtenerInformacionDeUsuario";
                myCommand.Parameters.AddWithValue("@idUsuario", id);
                myCommand.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(myCommand);
                adp.Fill(dt);
                return dt;
            }

            else
            {
                return null;
            }
        }
        public DataTable CargarDatosUsuario()
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = this.con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM  InformacionUsuarios";
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataTable dtDatosUsuario = new DataTable();
                    adp.Fill(dtDatosUsuario);
                    return dtDatosUsuario;
                }
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable CargarDatosUsuariocpEmpleado()
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = this.con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM  InformacionUsuarioscpEmpleado";
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataTable dtDatosUsuario = new DataTable();
                    adp.Fill(dtDatosUsuario);
                    return dtDatosUsuario;
                }
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable cargarTipoDocumento()
        {
            try
            {
                if (this.conectar())
                {
                    DataTable dtTipoDocumento = new DataTable();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = this.con;
                    cmd.CommandType = CommandType.Text;
                    //Consultando una vista
                    cmd.CommandText = "SELECT * FROM TipoDocumento";
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(dtTipoDocumento);
                    return dtTipoDocumento;
                }
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
        public DataTable cargarGenero()
        {
            try
            {
                if (this.conectar())
                {
                    DataTable dtGenero = new DataTable();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = this.con;
                    cmd.CommandType = CommandType.Text;
                    //Consultando una vista
                    cmd.CommandText = "SELECT * FROM Genero";
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(dtGenero);
                    return dtGenero;
                }
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
        public DataTable cargarRol()
        {
            try
            {
                if (this.conectar())
                {
                    DataTable dtRol = new DataTable();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = this.con;
                    cmd.CommandType = CommandType.Text;
                    //Consultando una vista
                    cmd.CommandText = "SELECT * FROM Rol";
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(dtRol);
                    return dtRol;
                }
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
        public DataTable cargarRolcpEmpleado()
        {
            try
            {
                if (this.conectar())
                {
                    DataTable dtRol = new DataTable();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = this.con;
                    cmd.CommandType = CommandType.Text;
                    //Consultando una vista
                    cmd.CommandText = "SELECT * FROM  RolCpEmpleado";
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(dtRol);
                    return dtRol;
                }
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
        public DataTable SelecionarIdInmueble(int id)
        {
            if (conectar())
            {
                DataTable dt = new DataTable();
                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = con;
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.CommandText = "obtenerInformacionDeInmuebles";
                myCommand.Parameters.AddWithValue("@idInmueble", id);
                myCommand.ExecuteNonQuery();
                SqlDataAdapter adp = new SqlDataAdapter(myCommand);
                adp.Fill(dt);
                return dt;
            }

            else
            {
                return null;
            }
        }
        public DataTable CargarDatosInmuebles()
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = this.con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM InformacionInmuebles";
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataTable dtDatosUsuario = new DataTable();
                    adp.Fill(dtDatosUsuario);
                    return dtDatosUsuario;
                }
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DataTable cargarTipoOferta()
        {
            try
            {
                if (this.conectar())
                {
                    DataTable dtTipoOferta = new DataTable();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = this.con;
                    cmd.CommandType = CommandType.Text;
                    //Consultando una vista
                    cmd.CommandText = "select * from Oferta";
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(dtTipoOferta);
                    return dtTipoOferta;
                }
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
        public DataTable cargarTipoInmueble()
        {
            try
            {
                if (this.conectar())
                {
                    DataTable dtTipoInmueble = new DataTable();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = this.con;
                    cmd.CommandType = CommandType.Text;
                    //Consultando una vista
                    cmd.CommandText = "SELECT * FROM  TipoInmueble";
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(dtTipoInmueble);
                    return dtTipoInmueble;
                }
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
        public DataTable cargarUbicacion()
        {
            try
            {
                if (this.conectar())
                {
                    DataTable dtUbicacion = new DataTable();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = this.con;
                    cmd.CommandType = CommandType.Text;
                    //Consultando una vista
                    cmd.CommandText = "SELECT * FROM ciudad";
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(dtUbicacion);
                    return dtUbicacion;
                }
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
        public DataTable cargarEstadoInmueble()
        {
            try
            {
                if (this.conectar())
                {
                    DataTable dtEstadoInmueble = new DataTable();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = this.con;
                    cmd.CommandType = CommandType.Text;
                    //Consultando una vista
                    cmd.CommandText = "SELECT * FROM Estado";
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(dtEstadoInmueble);
                    return dtEstadoInmueble;
                }
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
        public void RegistrarInmueble(string nombres,string apellidos,string numeroContacto,string direccionCliente,int codTipoOferta,int codTipoInmueble,int codUbicacion,string barrio,string direccion,string zona,decimal precioAvaluado,decimal precioCliente,string area,string estrato,decimal valorAdministracion,string hablitaciones,string baños,string pisos,string clima,int codEstado,string caracteristicasInteriores,string caracteristicasExteriores,string sector,string comentarios,int codUsuario)
        {
            if (conectar())
            {
                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = con;
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.CommandText = "RegistroInmuebles";
                myCommand.Parameters.AddWithValue("@nombresCliente", nombres);
                myCommand.Parameters.AddWithValue("@apellidosCliente", apellidos);
                myCommand.Parameters.AddWithValue("@numeroContactoCliente", numeroContacto);
                myCommand.Parameters.AddWithValue("@direccionCliente", direccion);
                myCommand.Parameters.AddWithValue("@codTipoOferta", codTipoOferta);
                myCommand.Parameters.AddWithValue("@codTipoInmueble", codTipoInmueble);
                myCommand.Parameters.AddWithValue("@codUbicacion", codUbicacion);
                myCommand.Parameters.AddWithValue("@barrio", barrio);
                myCommand.Parameters.AddWithValue("@direccion", direccion);
                myCommand.Parameters.AddWithValue("@zona", zona);
                myCommand.Parameters.AddWithValue("@precioAvaluado", precioAvaluado);
                myCommand.Parameters.AddWithValue("@precioCliente", precioCliente);
                myCommand.Parameters.AddWithValue("@area", area);
                myCommand.Parameters.AddWithValue("@estrato", estrato);
                myCommand.Parameters.AddWithValue("@valorAdministracion", valorAdministracion);
                myCommand.Parameters.AddWithValue("@habitaciones", hablitaciones);
                myCommand.Parameters.AddWithValue("@baños", baños);
                myCommand.Parameters.AddWithValue("@pisos", pisos);
                myCommand.Parameters.AddWithValue("@clima", clima);
                myCommand.Parameters.AddWithValue("@codEstadoFisico", codEstado);
                myCommand.Parameters.AddWithValue("@caracteristicasInteriores", caracteristicasInteriores);
                myCommand.Parameters.AddWithValue("@caracteristicasExteriotes", caracteristicasExteriores);
                myCommand.Parameters.AddWithValue("@sector", sector);
                myCommand.Parameters.AddWithValue("@comentarios", comentarios);
                myCommand.Parameters.AddWithValue("@codUsuario", codUsuario);
                myCommand.ExecuteNonQuery();
            }           
        }        
        public void ActualizarInmueble(int idInmueble, string nombres, string apellidos, string numeroContacto, string direccionCliente, int codTipoOferta, int codTipoInmueble, int codUbicacion, string barrio, string direccion, string zona, decimal precioAvaluado, decimal precioCliente, string area, string estrato, decimal valorAdministracion, string hablitaciones, string baños, string pisos, string clima, int codEstado, string caracteristicasInteriores, string caracteristicasExteriores, string sector, string comentarios)
        {
            if (conectar())
            {
                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = con;
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.CommandText = "ActualizarInmuebles";
                myCommand.Parameters.AddWithValue("@idInmueble", idInmueble);
                myCommand.Parameters.AddWithValue("@nombresCliente", nombres);
                myCommand.Parameters.AddWithValue("@apellidosCliente", apellidos);
                myCommand.Parameters.AddWithValue("@numeroContactoCliente", numeroContacto);
                myCommand.Parameters.AddWithValue("@direccionCliente", direccion);
                myCommand.Parameters.AddWithValue("@codTipoOferta", codTipoOferta);
                myCommand.Parameters.AddWithValue("@codTipoInmueble", codTipoInmueble);
                myCommand.Parameters.AddWithValue("@codUbicacion", codUbicacion);
                myCommand.Parameters.AddWithValue("@barrio", barrio);
                myCommand.Parameters.AddWithValue("@direccion", direccion);
                myCommand.Parameters.AddWithValue("@zona", zona);
                myCommand.Parameters.AddWithValue("@precioAvaluado", precioAvaluado);
                myCommand.Parameters.AddWithValue("@precioCliente", precioCliente);
                myCommand.Parameters.AddWithValue("@area", area);
                myCommand.Parameters.AddWithValue("@estrato", estrato);
                myCommand.Parameters.AddWithValue("@valorAdministracion", valorAdministracion);
                myCommand.Parameters.AddWithValue("@habitaciones", hablitaciones);
                myCommand.Parameters.AddWithValue("@baños", baños);
                myCommand.Parameters.AddWithValue("@pisos", pisos);
                myCommand.Parameters.AddWithValue("@clima", clima);
                myCommand.Parameters.AddWithValue("@codEstadoFisico", codEstado);
                myCommand.Parameters.AddWithValue("@caracteristicasInteriores", caracteristicasInteriores);
                myCommand.Parameters.AddWithValue("@caracteristicasExteriotes", caracteristicasExteriores);
                myCommand.Parameters.AddWithValue("@sector", sector);
                myCommand.Parameters.AddWithValue("@comentarios", comentarios);
                myCommand.ExecuteNonQuery();
            }
        }
        public void EliminarInmueble(int idInmueble)
        {
            if (conectar())
            {
                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = con;
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.CommandText = "EliminarInmueble";
                myCommand.Parameters.AddWithValue("@idInmueble", idInmueble);
                myCommand.ExecuteNonQuery();
            }
        }
        public void RegistrarUsuario(string nombres, string apellidos, int codTipoDocumento, string documento, DateTime fechaNacimiento, int codGenero, int codCiudad, string direccion, string numeroCelular, int codRol, string correo, string usuario, string contraseña)
        {
            if (conectar())
            {
                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = con;
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.CommandText = "RegistrarUsuarios";
                myCommand.Parameters.AddWithValue("@nombres", nombres);
                myCommand.Parameters.AddWithValue("@apellidos", apellidos);
                myCommand.Parameters.AddWithValue("@codTipoDocumento", codTipoDocumento);
                myCommand.Parameters.AddWithValue("@documento", documento);
                myCommand.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                myCommand.Parameters.AddWithValue("@codGenero", codGenero);
                myCommand.Parameters.AddWithValue("@codCiudad", codCiudad);
                myCommand.Parameters.AddWithValue("@direccion", direccion);
                myCommand.Parameters.AddWithValue("@numeroCelular", numeroCelular);
                myCommand.Parameters.AddWithValue("@codRol", codRol);
                myCommand.Parameters.AddWithValue("@correo", correo);
                myCommand.Parameters.AddWithValue("@usuario", usuario);
                myCommand.Parameters.AddWithValue("@contraseña", contraseña);
                myCommand.ExecuteNonQuery();
            }
        }
        public void ActualizarUsuario(int idUs,string nombres, string apellidos, int codTipoDocumento, string documento, DateTime fechaNacimiento, int codGenero, int codCiudad, string direccion, string numeroCelular, int codRol, string correo, string usuario, string contraseña)
        {
            if (conectar())
            {
                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = con;
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.CommandText = "ActualizarUsuario";
                myCommand.Parameters.AddWithValue("@idUs", idUs);
                myCommand.Parameters.AddWithValue("@nombres", nombres);
                myCommand.Parameters.AddWithValue("@apellidos", apellidos);
                myCommand.Parameters.AddWithValue("@codTipoDocumento", codTipoDocumento);
                myCommand.Parameters.AddWithValue("@documento", documento);
                myCommand.Parameters.AddWithValue("@fechaNacimiento", fechaNacimiento);
                myCommand.Parameters.AddWithValue("@codGenero", codGenero);
                myCommand.Parameters.AddWithValue("@codCiudad", codCiudad);
                myCommand.Parameters.AddWithValue("@direccion", direccion);
                myCommand.Parameters.AddWithValue("@numeroCelular", numeroCelular);
                myCommand.Parameters.AddWithValue("@codRol", codRol);
                myCommand.Parameters.AddWithValue("@correo", correo);
                myCommand.Parameters.AddWithValue("@usuario", usuario);
                myCommand.Parameters.AddWithValue("@contraseña", contraseña);
                myCommand.ExecuteNonQuery();
            }
        }
        public void EliminarUsuario(int idUs)
        {
            if (conectar())
            {
                SqlCommand myCommand = new SqlCommand();
                myCommand.Connection = con;
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.CommandText = "EliminarUsuario";
                myCommand.Parameters.AddWithValue("@idUsuario", idUs);
                myCommand.ExecuteNonQuery();
            }
        }
        public bool LoginUsuario(string usuario, string contraseña)
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = this.con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "LogInUsuarios";
                    cmd.Parameters.AddWithValue("@Usuario", usuario);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    if (count == 0)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
            }
            finally
            {
                Desconectar();
            }
        }

        public DataTable ConsultarUsuario(string usuario, string contraseña)
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.Connection = this.con;
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.CommandText = "LogInUsuarios";
                    myCommand.Parameters.AddWithValue("@usuario", usuario);
                    myCommand.Parameters.AddWithValue("@contraseña", contraseña);
                    SqlDataAdapter myAd = new SqlDataAdapter(myCommand);
                    DataTable dtDatos = new DataTable();
                    myAd.Fill(dtDatos);                    
                    return dtDatos;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
        public DataTable BusquedaConsultarUsuario(int documentoUsuario)
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.Connection = this.con;
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.CommandText = "BuscarUsuario";
                    myCommand.Parameters.AddWithValue("@idUsuario", documentoUsuario);
                    SqlDataAdapter myAd = new SqlDataAdapter(myCommand);
                    DataTable dtDatos = new DataTable();
                    myAd.Fill(dtDatos);
                    return dtDatos;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
        public DataTable BusquedaFiltroOferta(int oferta)
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.Connection = this.con;
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.CommandText = "filtroOferta";
                    myCommand.Parameters.AddWithValue("@oferta", oferta);
                    SqlDataAdapter myAd = new SqlDataAdapter(myCommand);
                    DataTable dtDatos = new DataTable();
                    myAd.Fill(dtDatos);
                    return dtDatos;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
        public DataTable BusquedafiltroTipoInmueble(int oferta)
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.Connection = this.con;
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.CommandText = "filtroTipoInmueble";
                    myCommand.Parameters.AddWithValue("@tipoInmueble", oferta);
                    SqlDataAdapter myAd = new SqlDataAdapter(myCommand);
                    DataTable dtDatos = new DataTable();
                    myAd.Fill(dtDatos);
                    return dtDatos;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
        public DataTable BusquedafiltroVenta()
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.Connection = this.con;
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.CommandText = "filtroVenta";                    
                    SqlDataAdapter myAd = new SqlDataAdapter(myCommand);
                    DataTable dtDatos = new DataTable();
                    myAd.Fill(dtDatos);
                    return dtDatos;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }

        public DataTable BusquedaFiltroVentaTipoInmueble(int oferta)
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.Connection = this.con;
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.CommandText = "filtroVentaTipoInmueble";
                    myCommand.Parameters.AddWithValue("@tipoInmueble", oferta);
                    SqlDataAdapter myAd = new SqlDataAdapter(myCommand);
                    DataTable dtDatos = new DataTable();
                    myAd.Fill(dtDatos);
                    return dtDatos;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }

        public DataTable BusquedafiltroVentaUbicacion(int oferta)
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.Connection = this.con;
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.CommandText = "filtroVentaUbicacion";
                    myCommand.Parameters.AddWithValue("@ciudad", oferta);
                    SqlDataAdapter myAd = new SqlDataAdapter(myCommand);
                    DataTable dtDatos = new DataTable();
                    myAd.Fill(dtDatos);
                    return dtDatos;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
        public DataTable BusquedafiltroArriendo()
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.Connection = this.con;
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.CommandText = "filtroArriendo";
                    SqlDataAdapter myAd = new SqlDataAdapter(myCommand);
                    DataTable dtDatos = new DataTable();
                    myAd.Fill(dtDatos);
                    return dtDatos;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
        public DataTable BusquedaFiltroArriendoTipoInmueble(int oferta)
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.Connection = this.con;
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.CommandText = "filtroArriendoTipoInmueble";
                    myCommand.Parameters.AddWithValue("@tipoInmueble", oferta);
                    SqlDataAdapter myAd = new SqlDataAdapter(myCommand);
                    DataTable dtDatos = new DataTable();
                    myAd.Fill(dtDatos);
                    return dtDatos;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }

        public DataTable BusquedafiltroArriendoUbicacion(int oferta)
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.Connection = this.con;
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.CommandText = "filtroArriendoUbicacion";
                    myCommand.Parameters.AddWithValue("@ciudad", oferta);
                    SqlDataAdapter myAd = new SqlDataAdapter(myCommand);
                    DataTable dtDatos = new DataTable();
                    myAd.Fill(dtDatos);
                    return dtDatos;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
        public DataTable BusquedafiltroAlquiler()
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.Connection = this.con;
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.CommandText = "filtroAlquiler";
                    SqlDataAdapter myAd = new SqlDataAdapter(myCommand);
                    DataTable dtDatos = new DataTable();
                    myAd.Fill(dtDatos);
                    return dtDatos;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
        public DataTable BusquedaFiltroAlquilerTipoInmueble(int oferta)
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.Connection = this.con;
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.CommandText = "filtroAlquilerTipoInmueble";
                    myCommand.Parameters.AddWithValue("@tipoInmueble", oferta);
                    SqlDataAdapter myAd = new SqlDataAdapter(myCommand);
                    DataTable dtDatos = new DataTable();
                    myAd.Fill(dtDatos);
                    return dtDatos;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }

        public DataTable BusquedafiltroAlquilerUbicacion(int oferta)
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.Connection = this.con;
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.CommandText = "filtroAlquilerUbicacion";
                    myCommand.Parameters.AddWithValue("@ciudad", oferta);
                    SqlDataAdapter myAd = new SqlDataAdapter(myCommand);
                    DataTable dtDatos = new DataTable();
                    myAd.Fill(dtDatos);
                    return dtDatos;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }

        public DataTable BusquedafiltroUbicacion(int oferta)
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.Connection = this.con;
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.CommandText = "filtroUbicacion";
                    myCommand.Parameters.AddWithValue("@ciudad", oferta);
                    SqlDataAdapter myAd = new SqlDataAdapter(myCommand);
                    DataTable dtDatos = new DataTable();
                    myAd.Fill(dtDatos);
                    return dtDatos;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }

        public DataTable BusquedaConsultarUsuarioCpEmpleado(int documentoUsuario)
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.Connection = this.con;
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.CommandText = "BuscarUsuarioCpEmpleado";
                    myCommand.Parameters.AddWithValue("@idUsuario", documentoUsuario);
                    SqlDataAdapter myAd = new SqlDataAdapter(myCommand);
                    DataTable dtDatos = new DataTable();
                    myAd.Fill(dtDatos);
                    return dtDatos;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
        public DataTable BusquedaConsultarInmueble(string direccionInmueble)
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.Connection = this.con;
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.CommandText = "BuscarInmueble";
                    myCommand.Parameters.AddWithValue("@DireccionInmueble", direccionInmueble);
                    SqlDataAdapter myAd = new SqlDataAdapter(myCommand);
                    DataTable dtDatos = new DataTable();
                    myAd.Fill(dtDatos);
                    return dtDatos;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
        public DataTable BusquedaConsultarInmuebleEncargado(string nombreEncargado)
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.Connection = this.con;
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.CommandText = "BuscarInmuebleEncargado";
                    myCommand.Parameters.AddWithValue("@nombreEncargado", nombreEncargado);
                    SqlDataAdapter myAd = new SqlDataAdapter(myCommand);
                    DataTable dtDatos = new DataTable();
                    myAd.Fill(dtDatos);
                    return dtDatos;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
        public DataTable ReportesConsultarUsuariosRegistrados()
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.Connection = this.con;
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.CommandText = "ReporteUsuariosRegistrados";
                    SqlDataAdapter myAd = new SqlDataAdapter(myCommand);
                    DataTable dtDatos = new DataTable();
                    myAd.Fill(dtDatos);
                    return dtDatos;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
             public DataTable ReportesConsultarInmueblesRegistrados()
             {
            try
            {
                if (this.conectar())
                {
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.Connection = this.con;
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.CommandText = "ReporteInmueblesRegitrados";
                    SqlDataAdapter myAd = new SqlDataAdapter(myCommand);
                    DataTable dtDatos = new DataTable();
                    myAd.Fill(dtDatos);
                    return dtDatos;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
        public DataTable ReportesConsultarUsuariosEliminados()
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.Connection = this.con;
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.CommandText = "ReporteUsuariosEliminados";
                    SqlDataAdapter myAd = new SqlDataAdapter(myCommand);
                    DataTable dtDatos = new DataTable();
                    myAd.Fill(dtDatos);
                    return dtDatos;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
        public DataTable ReportesConsultarInmueblesEliminados()
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.Connection = this.con;
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.CommandText = "ReporteInmueblesEliminados";
                    SqlDataAdapter myAd = new SqlDataAdapter(myCommand);
                    DataTable dtDatos = new DataTable();
                    myAd.Fill(dtDatos);
                    return dtDatos;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
        public DataTable ReportesConsultarInmueblesArrendados()
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.Connection = this.con;
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.CommandText = "ReporteInmueblesArrendados";
                    SqlDataAdapter myAd = new SqlDataAdapter(myCommand);
                    DataTable dtDatos = new DataTable();
                    myAd.Fill(dtDatos);
                    return dtDatos;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
        public DataTable ReportesConsultarInmueblesVendidos()
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.Connection = this.con;
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.CommandText = "ReporteInmueblesVendidos";
                    SqlDataAdapter myAd = new SqlDataAdapter(myCommand);
                    DataTable dtDatos = new DataTable();
                    myAd.Fill(dtDatos);
                    return dtDatos;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
        public DataTable ReportesConsultarInmueblesArriendo()
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = this.con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM InmueblesArrendadosTotal";
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataTable dtDescripcion = new DataTable();
                    adp.Fill(dtDescripcion);
                    return dtDescripcion;
                }
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable ReportesConsultarInmueblesVenta()
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = this.con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM InmueblesVendidosTotal";
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataTable dtDescripcion = new DataTable();
                    adp.Fill(dtDescripcion);
                    return dtDescripcion;
                }
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable ReportesConsultarInmueblesAlquiler()
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = this.con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT * FROM InmueblesAlquiladosTotal";
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataTable dtDescripcion = new DataTable();
                    adp.Fill(dtDescripcion);
                    return dtDescripcion;
                }
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
        }


        public DataTable SeleccionarMiInmueble(int idUsuario)
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.Connection = this.con;
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.CommandText = "CargarMiInmueble";
                    myCommand.Parameters.AddWithValue("@idUsuario", idUsuario);
                    SqlDataAdapter myAd = new SqlDataAdapter(myCommand);
                    DataTable dtDatos = new DataTable();
                    myAd.Fill(dtDatos);
                    return dtDatos;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
        public DataTable SeleccionarMisDatos(int idUsuario)
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand myCommand = new SqlCommand();
                    myCommand.Connection = this.con;
                    myCommand.CommandType = CommandType.StoredProcedure;
                    myCommand.CommandText = "CargarMisDatos";
                    myCommand.Parameters.AddWithValue("@idUsuario", idUsuario);
                    SqlDataAdapter myAd = new SqlDataAdapter(myCommand);
                    DataTable dtDatos = new DataTable();
                    myAd.Fill(dtDatos);
                    return dtDatos;

                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
        }
        public DataTable cargarExtension()
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = this.con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select * from extension";
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataTable dtExtension = new DataTable();
                    adp.Fill(dtExtension);
                    return dtExtension;
                }
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public DataTable CargarDescripcion()
        {
            try
            {
                if (this.conectar())
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = this.con;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "SELECT* FROM InformacionInmuebles";
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    DataTable dtDescripcion = new DataTable();
                    adp.Fill(dtDescripcion);
                    return dtDescripcion;
                }
                else
                    return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}