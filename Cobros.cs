using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoConsultorioDental
{
    class Cobros
    {
        //atributos
        private string nombrepaciente;
        private string nombreservicio;
        private string fecha;
        private float total;

        //propiedades
        public string NombrePaciente
        {
            get
            {
                return nombrepaciente;
            }
            set
            {
                nombrepaciente = value;
            }
        }

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

        public string Fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                fecha = value;
            }
        }

        public float Total
        {
            get
            {
                return total;
            }
            set
            {
                total = value;
            }
        }

        //constructor
        public Cobros()
        {
            NombrePaciente = string.Empty;
            NombreServicio = string.Empty;
            Fecha = DateTime.Now.ToString("yyyy-MM-dd");
            Total = 0.0F;           
        }

        public Cobros(string nombrepaciente, string nombreservicio, float total)
        {
            NombrePaciente = nombrepaciente;
            NombreServicio = nombreservicio;
            Fecha = DateTime.Now.ToString("yyyy-MM-dd");
            Total = total;
        }

        //metodos
        public void Guardar()
        {
            string SQL = "insert into Cobros (NombrePaciente, NombreServicio, Fecha, Total) VALUES ('"
                + NombrePaciente + "', '"
                + NombreServicio + "', '"
                + Fecha + "', '"
                + Total + "');";

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
            string SQL = "SELECT * FROM Cobros;";
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
