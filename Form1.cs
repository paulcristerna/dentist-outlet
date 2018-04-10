using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace ProyectoConsultorioDental
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatosPacientes();
            DatosCitas();
            DatosServicios();
            DatosCobros();
            DatosExpedientes();

            ActualizarAutoCompletes();

            dgvExpedientes.Columns[0].Visible = false;
            dgvExpedientes.Columns[5].Visible = false;
            dgvExpedientes.Columns[6].Visible = false;
            dgvExpedientes.Columns[7].Visible = false;
        }

        DataTable DTPaciente = new DataTable();
        DataTable DTServicio = new DataTable();
        DataTable DTCobro = new DataTable();
        DataTable DTCita = new DataTable();
        DataTable DTExpediente = new DataTable();

        Citas Ct = new Citas();
        Pacientes Pct = new Pacientes();
        Servicios Srv = new Servicios();
        Cobros Cbr = new Cobros();
        Expedientes Exp = new Expedientes();

        /* cobros */
        private void DatosCobros()
        {
            try
            {
                Cbr.Consultar(DTCobro);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dgvCobros.DataSource = DTCobro;
        }

        private void btnGuardarCobro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombrePacienteCobro.Text))
            {
                MessageBox.Show("El campo Nombre del Paciente esta vacío, favor de llenarlo correctamente.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombrePaciente.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtServicioCobro.Text))
            {
                MessageBox.Show("El campo Nombre del Servicio esta vacío, favor de llenarlo correctamente.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtServicioCobro.Focus();
            }
            else
            {
                Cbr.NombrePaciente = txtNombrePacienteCobro.Text;
                Cbr.NombreServicio = txtServicioCobro.Text;
                Cbr.Total = float.Parse(txtTotalCobro.Text);

                try
                {
                    Cbr.Guardar();
                    MessageBox.Show("Se guardo el cobro con exito.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    DatosCobros();
                    DatosExpedientes();
                    txtNombreServicio.Focus();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnComprobantePago_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Comprobante de Pago \n\nFecha: " 
                            + DateTime.Now.ToString()
                            + "\nNombre del Paciente: "+ txtNombrePacienteCobro.Text
                            + "\nNombre del Servicio: "+ txtServicioCobro.Text
                            + "\nTotal: $"+ txtTotalCobro.Text +" Pesos MXN.", 
                            "Clínica Dental FIC");
        }

        /* citas */
        private void DatosCitas()
        {
            try
            {
                Ct.Consultar(DTCita);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dgvCitas.DataSource = DTCita;
        }

        private void btnGuardarCita_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombrePacienteCitas.Text))
            {
                MessageBox.Show("El campo Nombre del Paciente esta vacío, favor de llenarlo correctamente.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombrePacienteCitas.Focus();
            }
            else if (dtpFechaCita.Value.Date < DateTime.Today)
            {
                MessageBox.Show("El campo Fecha debe ser de hoy en adelante.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFechaCita.Focus();
            }
            else
            {
                Ct.NombrePaciente = txtNombrePacienteCitas.Text;
                Ct.Fecha = dtpFechaCita.Value.Date.ToString("yyyy-MM-dd");

                try
                {
                    Ct.Guardar();
                    MessageBox.Show("Se guardo la cita con exito.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    DatosCitas();
                    txtNombrePacienteCitas.Focus();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Guardar Paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditarCita_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombrePacienteCitas.Text))
            {
                MessageBox.Show("El campo Nombre del Paciente esta vacío, favor de llenarlo correctamente.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombrePacienteCitas.Focus();
            }
            else if (dtpFechaCita.Value.Date < DateTime.Today)
            {
                MessageBox.Show("El campo Fecha debe ser de hoy en adelante.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFechaCita.Focus();
            }
            else
            {
                Ct.NombrePaciente = txtNombrePacienteCitas.Text;
                Ct.Fecha = dtpFechaCita.Value.Date.ToString("yyyy-MM-dd");

                try
                {
                    Ct.Actualizar();
                    MessageBox.Show("Se actualizo la cita con exito.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    DatosCitas();
                    txtNombrePacienteCitas.Focus();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminarCita_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombrePacienteCitas.Text))
            {
                MessageBox.Show("El campo Nombre del Paciente esta vacío, favor de llenarlo correctamente.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombrePacienteCitas.Focus();
            }
            else
            {
                Ct.NombrePaciente = txtNombrePacienteCitas.Text;
                Ct.Fecha = dtpFechaCita.Value.Date.ToString("yyyy-MM-dd");

                try
                {
                    Ct.Eliminar();
                    MessageBox.Show("Se elimino la cita con exito.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    DatosCitas();
                    txtNombrePacienteCitas.Focus();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }      

        /* pacientes */
        private void DatosPacientes()
        {
            try
            {
                Pct.Consultar(DTPaciente);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dgvPacientes.DataSource = DTPaciente;
        } 

        private void btnGuardarPaciente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombrePaciente.Text))
            {
                MessageBox.Show("El campo Nombre esta vacío, favor de llenarlo correctamente.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombrePaciente.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El campo Apellido esta vacío, favor de llenarlo correctamente.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtDomicilio.Text))
            {
                MessageBox.Show("El campo Domicilio esta vacío, favor de llenarlo correctamente.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDomicilio.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El campo Teléfono esta vacío, favor de llenarlo correctamente.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Focus();
            }
            else
            {
                Pct.NombrePaciente = txtNombrePaciente.Text;
                Pct.Apellido = txtApellido.Text;
                Pct.FechaNacimiento = dtpFechaNacimiento.Value.Date.ToString("yyyy-MM-dd");
                Pct.Sexo = cbSexo.Text;
                Pct.Domicilio = txtDomicilio.Text;
                Pct.Telefono = txtTelefono.Text;

                try
                {
                    Pct.Guardar();
                    MessageBox.Show("Se guardo al paciete con exito.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    DatosPacientes();
                    DatosExpedientes();
                    ActualizarAutoCompletes();
                    txtNombrePaciente.Focus();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEditarPaciente_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombrePaciente.Text))
            {
                MessageBox.Show("El campo Nombre esta vacío, favor de llenarlo correctamente.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombrePaciente.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El campo Apellido esta vacío, favor de llenarlo correctamente.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtDomicilio.Text))
            {
                MessageBox.Show("El campo Domicilio esta vacío, favor de llenarlo correctamente.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDomicilio.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El campo Teléfono esta vacío, favor de llenarlo correctamente.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Focus();
            }
            else
            {
                Pct.NombrePaciente = txtNombrePaciente.Text;
                Pct.Apellido = txtApellido.Text;
                Pct.FechaNacimiento = dtpFechaNacimiento.Value.Date.ToString("yyyy-MM-dd");
                Pct.Sexo = cbSexo.Text;
                Pct.Domicilio = txtDomicilio.Text;
                Pct.Telefono = txtTelefono.Text;

                try
                {
                    Pct.Actualizar();
                    MessageBox.Show("Se actualizo al paciete con exito.", "Actualizar Paciente.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    DatosPacientes();
                    DatosExpedientes();
                    ActualizarAutoCompletes();
                    txtNombrePaciente.Focus();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Actualizar Paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombrePaciente.Text))
            {
                MessageBox.Show("El campo Nombre esta vacío, favor de llenarlo correctamente.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombrePaciente.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtApellido.Text))
            {
                MessageBox.Show("El campo Apellido esta vacío, favor de llenarlo correctamente.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtApellido.Focus();
            }
            else
            {
                Pct.NombrePaciente = txtNombrePaciente.Text;
                Pct.Apellido = txtApellido.Text;

                try
                {
                    Pct.Eliminar();
                    MessageBox.Show("Se elimino al paciente con exito.", "Eliminar Paciente.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    DatosPacientes();
                    DatosExpedientes();
                    ActualizarAutoCompletes();
                    txtNombrePaciente.Focus();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Eliminar Paciente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /* expedientes */
        private void DatosExpedientes()
        {
            try
            {
                Exp.Consultar(DTExpediente);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dgvExpedientes.DataSource = DTExpediente;
            dgvExpedientes.Columns[4].Visible = false;
        }

        /* servicios */
        private void DatosServicios()
        {
            try
            {
                Srv.Consultar(DTServicio);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dgvServicios.DataSource = DTServicio;
        }

        private void btnGuardarServicio_Click(object sender, EventArgs e)
        {
            string Str = txtPrecioServicio.Text.Trim();
            double Num;
            bool isNum = double.TryParse(Str, out Num);
            
            if (string.IsNullOrWhiteSpace(txtNombreServicio.Text))
            {
                MessageBox.Show("El campo Nombre del Servicio esta vacío, favor de llenarlo correctamente.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombrePaciente.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtDescripcionServicio.Text))
            {
                MessageBox.Show("El campo Descripcion esta vacío, favor de llenarlo correctamente.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcionServicio.Focus();
            }
            else if (isNum == false)
            {
                MessageBox.Show("El campo Precio solo acepta numeros, favor de llenarlo correctamente.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecioServicio.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtPrecioServicio.Text) || Convert.ToInt32(txtPrecioServicio.Text) <= 0)
            {
                MessageBox.Show("El campo Precio es invalido, favor de llenarlo correctamente.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecioServicio.Focus();
            }
            else
            {
                Srv.NombreServicio = txtNombreServicio.Text;
                Srv.Descripcion = txtDescripcionServicio.Text;
                Srv.Precio = float.Parse(txtPrecioServicio.Text);

                try
                {
                    Srv.Guardar();
                    MessageBox.Show("Se guardo el servicio con exito.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    DatosServicios();
                    DatosExpedientes();
                    ActualizarAutoCompletes();
                    txtNombreServicio.Focus();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
            
        private void btnEditarServicio_Click(object sender, EventArgs e)
        {
            string Str = txtPrecioServicio.Text.Trim();
            double Num;
            bool isNum = double.TryParse(Str, out Num);

            if (string.IsNullOrWhiteSpace(txtNombreServicio.Text))
            {
                MessageBox.Show("El campo Nombre del Servicio esta vacío, favor de llenarlo correctamente.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombrePaciente.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtDescripcionServicio.Text))
            {
                MessageBox.Show("El campo Descripcion esta vacío, favor de llenarlo correctamente.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescripcionServicio.Focus();
            }
            else if (isNum == false)
            {
                MessageBox.Show("El campo Precio solo acepta numeros, favor de llenarlo correctamente.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecioServicio.Focus();
            }
            else if (string.IsNullOrWhiteSpace(txtPrecioServicio.Text) || Convert.ToInt32(txtPrecioServicio.Text) <= 0)
            {
                MessageBox.Show("El campo Precio es invalido, favor de llenarlo correctamente.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecioServicio.Focus();
            }
            else
            {
                Srv.NombreServicio = txtNombreServicio.Text;
                Srv.Descripcion = txtDescripcionServicio.Text;
                Srv.Precio = float.Parse(txtPrecioServicio.Text);

                try
                {
                    Srv.Actualizar();
                    MessageBox.Show("Se actualizo el servicio con exito.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    DatosServicios();
                    DatosExpedientes();
                    ActualizarAutoCompletes();
                    txtNombreServicio.Focus();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEliminarServicio_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreServicio.Text))
            {
                MessageBox.Show("El campo Nombre del Servicio esta vacío, favor de llenarlo correctamente.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombrePaciente.Focus();
            }
            else
            {
                Srv.NombreServicio = txtNombreServicio.Text;

                try
                {
                    Srv.Eliminar();
                    MessageBox.Show("Se elimino el servicio con exito.", "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    DatosServicios();
                    DatosExpedientes();
                    ActualizarAutoCompletes();
                    txtNombreServicio.Focus();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Sistema Consultorio Dental 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /* metodos */
        private void txtServicioCobro_TextChanged(object sender, EventArgs e)
        {
            string Dato, Precio;
            foreach (DataRow row in DTServicio.Rows)
            {
                Dato = Convert.ToString(row["NombreServicio"]);
                Precio = Convert.ToString(row["Precio"]);

                if (Dato == txtServicioCobro.Text)
                {
                    txtTotalCobro.Text = Precio;
                }
            }
        }

        public AutoCompleteStringCollection ListadoPacientes()
        {
            string Dato;
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in DTPaciente.Rows)
            {
                Dato = Convert.ToString(row["Nombre"]) + " " + Convert.ToString(row["Apellido"]);
                coleccion.Add(Dato);
            }

            return coleccion;
        }

        public AutoCompleteStringCollection ListadoServicios()
        {
            string Dato;
            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in DTServicio.Rows)
            {
                Dato = Convert.ToString(row["NombreServicio"]);
                coleccion.Add(Dato);
            }

            return coleccion;
        }

        private void ActualizarAutoCompletes()
        {
            txtNombrePacienteCobro.AutoCompleteCustomSource = ListadoPacientes();
            txtNombrePacienteCobro.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtNombrePacienteCobro.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtServicioCobro.AutoCompleteCustomSource = ListadoServicios();
            txtServicioCobro.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtServicioCobro.AutoCompleteSource = AutoCompleteSource.CustomSource;

            txtNombrePacienteCitas.AutoCompleteCustomSource = ListadoPacientes();
            txtNombrePacienteCitas.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtNombrePacienteCitas.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void LimpiarCampos()
        {
            txtNombrePacienteCobro.Clear();
            txtServicioCobro.Clear();
            txtTotalCobro.Text = "0.00";

            txtNombrePacienteCitas.Clear();
            dtpFechaCita.Value = DateTime.Today;

            txtNombrePaciente.Clear();
            txtApellido.Clear();
            dtpFechaNacimiento.Value = DateTime.Today;
            cbSexo.SelectedIndex = 0;
            txtDomicilio.Clear();
            txtTelefono.Clear();

            txtNombreServicio.Clear();
            txtDescripcionServicio.Clear();
            txtPrecioServicio.Clear();

            txtNombrePacienteCobro.Focus();
            txtNombrePacienteCitas.Focus();
            txtNombrePaciente.Focus();
            txtNombreServicio.Focus();
        }
    }
}