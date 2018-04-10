using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoConsultorioDental
{
    public class Servicios
    {
        //atributos
        public string nombreservicio;
        public string descripcion;
        public float  precio;

        //propiedades
        public string NombreServicio
        {
            get
            {
                return nombreservicio;
            }
            set
            {
                nombreservicio = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }
            set
            {
                descripcion = value;
            }
        }

        public float Precio
        {
            get
            {
                return precio;
            }
            set
            {
                precio = value;
            }
        }

        //constructores
        public Servicios()
        {
            NombreServicio = string.Empty;
            Descripcion = string.Empty;
            Precio = 0.0F;         
        }

        public Servicios(string nombreServicio, string descripcion, float precio)
        {
            NombreServicio = nombreServicio;
            Descripcion = descripcion;
            Precio = precio;
        }

        //metodos
        public void Guardar()
        {
            string SQL = "insert into Servicios (NombreServicio, Descripcion, Precio) VALUES ('"
                + NombreServicio + "','"
                + Descripcion + "','"
                + Precio +"');";

            AccesoBaseDatos bd = new AccesoBaseDatos();
            try
            {
                if (bd.EjecutaComando(SQL) == 0)
                {
                    throw new Exception("No se afectaron registros");
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }
         
        public void Actualizar()
        {
            string SQL = "UPDATE Servicios SET NombreServicio = '"
           + NombreServicio + "', Descripcion = '"
           + Descripcion + "', Precio = '"
           + Precio +"' WHERE NombreServicio = '" + NombreServicio + "';";

            AccesoBaseDatos bd = new AccesoBaseDatos();
            try
            {
                if (bd.EjecutaComando(SQL) == 0)
                {
                    throw new Exception("No se afectaron registros.");
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }
        
        public void Eliminar()
        {
            string SQL = "DELETE FROM Servicios WHERE NombreServicio = '" + NombreServicio + "';";

            AccesoBaseDatos bd = new AccesoBaseDatos();
            try
            {
                if (bd.EjecutaComando(SQL) == 0)
                {
                    throw new Exception("No se afectaron registros.");
                }
            }
            catch (Exception error)
            {
                throw error;
            }
        }
        
        public void Consultar(System.Data.DataTable dt)
        {
            string SQL = "SELECT * FROM Servicios;";
            AccesoBaseDatos bd = new AccesoBaseDatos();
            try
            {
                bd.EjecutaConsulta(SQL, dt);
            }
            catch (Exception error)
            {
                throw error;
            }
        }       
    }
}
