namespace ProyectoConsultorioDental
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.consultaclienteDataSet = new ProyectoConsultorioDental.consultaclienteDataSet();
            this.pacienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacienteTableAdapter = new ProyectoConsultorioDental.consultaclienteDataSetTableAdapters.pacienteTableAdapter();
            this.ttSistema = new System.Windows.Forms.ToolTip(this.components);
            this.btnGuardarServicio = new System.Windows.Forms.Button();
            this.btnEditarServicio = new System.Windows.Forms.Button();
            this.btnEliminarServicio = new System.Windows.Forms.Button();
            this.btnGuardarPaciente = new System.Windows.Forms.Button();
            this.btnEditarPaciente = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardarCita = new System.Windows.Forms.Button();
            this.btnEditarCita = new System.Windows.Forms.Button();
            this.btnEliminarCita = new System.Windows.Forms.Button();
            this.btnGuardarCobro = new System.Windows.Forms.Button();
            this.btnComprobantePago = new System.Windows.Forms.Button();
            this.tabPageServicios = new System.Windows.Forms.TabPage();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreServicio = new System.Windows.Forms.TextBox();
            this.txtPrecioServicio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescripcionServicio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPageExpedientes = new System.Windows.Forms.TabPage();
            this.dgvExpedientes = new System.Windows.Forms.DataGridView();
            this.tabPagePacientes = new System.Windows.Forms.TabPage();
            this.dgvPacientes = new System.Windows.Forms.DataGridView();
            this.groupBoxDatos = new System.Windows.Forms.GroupBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtNombrePaciente = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.blDomicilio = new System.Windows.Forms.Label();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.tabPageCitas = new System.Windows.Forms.TabPage();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.txtNombrePacienteCitas = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tabPageCobros = new System.Windows.Forms.TabPage();
            this.dgvCobros = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtServicioCobro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTotalCobro = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtNombrePacienteCobro = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tabControlOpciones = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.consultaclienteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).BeginInit();
            this.tabPageServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPageExpedientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpedientes)).BeginInit();
            this.tabPagePacientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).BeginInit();
            this.groupBoxDatos.SuspendLayout();
            this.tabPageCitas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabPageCobros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobros)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabControlOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // consultaclienteDataSet
            // 
            this.consultaclienteDataSet.DataSetName = "consultaclienteDataSet";
            this.consultaclienteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacienteBindingSource
            // 
            this.pacienteBindingSource.DataMember = "paciente";
            this.pacienteBindingSource.DataSource = this.consultaclienteDataSet;
            // 
            // pacienteTableAdapter
            // 
            this.pacienteTableAdapter.ClearBeforeFill = true;
            // 
            // ttSistema
            // 
            this.ttSistema.Tag = "";
            // 
            // btnGuardarServicio
            // 
            this.btnGuardarServicio.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarServicio.Image")));
            this.btnGuardarServicio.Location = new System.Drawing.Point(9, 167);
            this.btnGuardarServicio.Name = "btnGuardarServicio";
            this.btnGuardarServicio.Size = new System.Drawing.Size(50, 46);
            this.btnGuardarServicio.TabIndex = 37;
            this.ttSistema.SetToolTip(this.btnGuardarServicio, "Guardar Servicio");
            this.btnGuardarServicio.UseVisualStyleBackColor = true;
            this.btnGuardarServicio.Click += new System.EventHandler(this.btnGuardarServicio_Click);
            // 
            // btnEditarServicio
            // 
            this.btnEditarServicio.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarServicio.Image")));
            this.btnEditarServicio.Location = new System.Drawing.Point(65, 167);
            this.btnEditarServicio.Name = "btnEditarServicio";
            this.btnEditarServicio.Size = new System.Drawing.Size(47, 46);
            this.btnEditarServicio.TabIndex = 38;
            this.ttSistema.SetToolTip(this.btnEditarServicio, "Editar Servicio");
            this.btnEditarServicio.UseVisualStyleBackColor = true;
            this.btnEditarServicio.Click += new System.EventHandler(this.btnEditarServicio_Click);
            // 
            // btnEliminarServicio
            // 
            this.btnEliminarServicio.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarServicio.Image")));
            this.btnEliminarServicio.Location = new System.Drawing.Point(119, 167);
            this.btnEliminarServicio.Name = "btnEliminarServicio";
            this.btnEliminarServicio.Size = new System.Drawing.Size(43, 46);
            this.btnEliminarServicio.TabIndex = 39;
            this.ttSistema.SetToolTip(this.btnEliminarServicio, "Eliminar Servicio");
            this.btnEliminarServicio.UseVisualStyleBackColor = true;
            this.btnEliminarServicio.Click += new System.EventHandler(this.btnEliminarServicio_Click);
            // 
            // btnGuardarPaciente
            // 
            this.btnGuardarPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarPaciente.Image")));
            this.btnGuardarPaciente.Location = new System.Drawing.Point(16, 328);
            this.btnGuardarPaciente.Name = "btnGuardarPaciente";
            this.btnGuardarPaciente.Size = new System.Drawing.Size(50, 46);
            this.btnGuardarPaciente.TabIndex = 5;
            this.ttSistema.SetToolTip(this.btnGuardarPaciente, "Guardar Paciente");
            this.btnGuardarPaciente.UseVisualStyleBackColor = true;
            this.btnGuardarPaciente.Click += new System.EventHandler(this.btnGuardarPaciente_Click);
            // 
            // btnEditarPaciente
            // 
            this.btnEditarPaciente.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarPaciente.Image")));
            this.btnEditarPaciente.Location = new System.Drawing.Point(72, 328);
            this.btnEditarPaciente.Name = "btnEditarPaciente";
            this.btnEditarPaciente.Size = new System.Drawing.Size(47, 46);
            this.btnEditarPaciente.TabIndex = 31;
            this.ttSistema.SetToolTip(this.btnEditarPaciente, "Editar Paciente");
            this.btnEditarPaciente.UseVisualStyleBackColor = true;
            this.btnEditarPaciente.Click += new System.EventHandler(this.btnEditarPaciente_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(126, 328);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(43, 46);
            this.btnEliminar.TabIndex = 33;
            this.ttSistema.SetToolTip(this.btnEliminar, "Eliminar Paciente");
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardarCita
            // 
            this.btnGuardarCita.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarCita.Image")));
            this.btnGuardarCita.Location = new System.Drawing.Point(6, 147);
            this.btnGuardarCita.Name = "btnGuardarCita";
            this.btnGuardarCita.Size = new System.Drawing.Size(50, 46);
            this.btnGuardarCita.TabIndex = 34;
            this.ttSistema.SetToolTip(this.btnGuardarCita, "Guardar Cita");
            this.btnGuardarCita.UseVisualStyleBackColor = true;
            this.btnGuardarCita.Click += new System.EventHandler(this.btnGuardarCita_Click);
            // 
            // btnEditarCita
            // 
            this.btnEditarCita.Image = ((System.Drawing.Image)(resources.GetObject("btnEditarCita.Image")));
            this.btnEditarCita.Location = new System.Drawing.Point(62, 147);
            this.btnEditarCita.Name = "btnEditarCita";
            this.btnEditarCita.Size = new System.Drawing.Size(47, 46);
            this.btnEditarCita.TabIndex = 35;
            this.ttSistema.SetToolTip(this.btnEditarCita, "Editar Cita");
            this.btnEditarCita.UseVisualStyleBackColor = true;
            this.btnEditarCita.Click += new System.EventHandler(this.btnEditarCita_Click);
            // 
            // btnEliminarCita
            // 
            this.btnEliminarCita.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminarCita.Image")));
            this.btnEliminarCita.Location = new System.Drawing.Point(116, 147);
            this.btnEliminarCita.Name = "btnEliminarCita";
            this.btnEliminarCita.Size = new System.Drawing.Size(43, 46);
            this.btnEliminarCita.TabIndex = 36;
            this.ttSistema.SetToolTip(this.btnEliminarCita, "Eliminar Cita");
            this.btnEliminarCita.UseVisualStyleBackColor = true;
            this.btnEliminarCita.Click += new System.EventHandler(this.btnEliminarCita_Click);
            // 
            // btnGuardarCobro
            // 
            this.btnGuardarCobro.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarCobro.Image")));
            this.btnGuardarCobro.Location = new System.Drawing.Point(10, 188);
            this.btnGuardarCobro.Name = "btnGuardarCobro";
            this.btnGuardarCobro.Size = new System.Drawing.Size(50, 46);
            this.btnGuardarCobro.TabIndex = 35;
            this.ttSistema.SetToolTip(this.btnGuardarCobro, "Guardar Cobro");
            this.btnGuardarCobro.UseVisualStyleBackColor = true;
            this.btnGuardarCobro.Click += new System.EventHandler(this.btnGuardarCobro_Click);
            // 
            // btnComprobantePago
            // 
            this.btnComprobantePago.Image = ((System.Drawing.Image)(resources.GetObject("btnComprobantePago.Image")));
            this.btnComprobantePago.Location = new System.Drawing.Point(66, 188);
            this.btnComprobantePago.Name = "btnComprobantePago";
            this.btnComprobantePago.Size = new System.Drawing.Size(50, 46);
            this.btnComprobantePago.TabIndex = 37;
            this.ttSistema.SetToolTip(this.btnComprobantePago, "Comprobante de Pago");
            this.btnComprobantePago.UseVisualStyleBackColor = true;
            this.btnComprobantePago.Click += new System.EventHandler(this.btnComprobantePago_Click);
            // 
            // tabPageServicios
            // 
            this.tabPageServicios.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageServicios.BackgroundImage")));
            this.tabPageServicios.Controls.Add(this.dgvServicios);
            this.tabPageServicios.Controls.Add(this.groupBox1);
            this.tabPageServicios.Location = new System.Drawing.Point(4, 34);
            this.tabPageServicios.Name = "tabPageServicios";
            this.tabPageServicios.Size = new System.Drawing.Size(884, 414);
            this.tabPageServicios.TabIndex = 4;
            this.tabPageServicios.Text = "Servicios";
            this.tabPageServicios.UseVisualStyleBackColor = true;
            // 
            // dgvServicios
            // 
            this.dgvServicios.AllowUserToAddRows = false;
            this.dgvServicios.AllowUserToDeleteRows = false;
            this.dgvServicios.AllowUserToOrderColumns = true;
            this.dgvServicios.AllowUserToResizeRows = false;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Location = new System.Drawing.Point(339, 15);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.Size = new System.Drawing.Size(542, 382);
            this.dgvServicios.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminarServicio);
            this.groupBox1.Controls.Add(this.btnEditarServicio);
            this.groupBox1.Controls.Add(this.btnGuardarServicio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombreServicio);
            this.groupBox1.Controls.Add(this.txtPrecioServicio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDescripcionServicio);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 222);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de los Servicios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Descripcion:";
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.Location = new System.Drawing.Point(9, 42);
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(266, 20);
            this.txtNombreServicio.TabIndex = 8;
            // 
            // txtPrecioServicio
            // 
            this.txtPrecioServicio.Location = new System.Drawing.Point(64, 119);
            this.txtPrecioServicio.Name = "txtPrecioServicio";
            this.txtPrecioServicio.Size = new System.Drawing.Size(82, 20);
            this.txtPrecioServicio.TabIndex = 13;
            this.txtPrecioServicio.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio: $";
            // 
            // txtDescripcionServicio
            // 
            this.txtDescripcionServicio.Location = new System.Drawing.Point(9, 84);
            this.txtDescripcionServicio.Multiline = true;
            this.txtDescripcionServicio.Name = "txtDescripcionServicio";
            this.txtDescripcionServicio.Size = new System.Drawing.Size(266, 21);
            this.txtDescripcionServicio.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Nombre del Servicio:";
            // 
            // tabPageExpedientes
            // 
            this.tabPageExpedientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageExpedientes.BackgroundImage")));
            this.tabPageExpedientes.Controls.Add(this.dgvExpedientes);
            this.tabPageExpedientes.Location = new System.Drawing.Point(4, 34);
            this.tabPageExpedientes.Name = "tabPageExpedientes";
            this.tabPageExpedientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExpedientes.Size = new System.Drawing.Size(884, 414);
            this.tabPageExpedientes.TabIndex = 3;
            this.tabPageExpedientes.Text = "Expedientes";
            this.tabPageExpedientes.UseVisualStyleBackColor = true;
            // 
            // dgvExpedientes
            // 
            this.dgvExpedientes.AllowUserToAddRows = false;
            this.dgvExpedientes.AllowUserToDeleteRows = false;
            this.dgvExpedientes.AllowUserToOrderColumns = true;
            this.dgvExpedientes.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpedientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExpedientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpedientes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExpedientes.Location = new System.Drawing.Point(27, 15);
            this.dgvExpedientes.Name = "dgvExpedientes";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpedientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExpedientes.Size = new System.Drawing.Size(826, 393);
            this.dgvExpedientes.TabIndex = 12;
            // 
            // tabPagePacientes
            // 
            this.tabPagePacientes.BackColor = System.Drawing.Color.Transparent;
            this.tabPagePacientes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPagePacientes.BackgroundImage")));
            this.tabPagePacientes.Controls.Add(this.dgvPacientes);
            this.tabPagePacientes.Controls.Add(this.groupBoxDatos);
            this.tabPagePacientes.Location = new System.Drawing.Point(4, 34);
            this.tabPagePacientes.Name = "tabPagePacientes";
            this.tabPagePacientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePacientes.Size = new System.Drawing.Size(884, 414);
            this.tabPagePacientes.TabIndex = 2;
            this.tabPagePacientes.Text = "Pacientes";
            // 
            // dgvPacientes
            // 
            this.dgvPacientes.AllowUserToAddRows = false;
            this.dgvPacientes.AllowUserToDeleteRows = false;
            this.dgvPacientes.AllowUserToOrderColumns = true;
            this.dgvPacientes.AllowUserToResizeRows = false;
            this.dgvPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacientes.Location = new System.Drawing.Point(326, 16);
            this.dgvPacientes.Name = "dgvPacientes";
            this.dgvPacientes.Size = new System.Drawing.Size(552, 392);
            this.dgvPacientes.TabIndex = 10;
            // 
            // groupBoxDatos
            // 
            this.groupBoxDatos.Controls.Add(this.btnEliminar);
            this.groupBoxDatos.Controls.Add(this.btnEditarPaciente);
            this.groupBoxDatos.Controls.Add(this.dtpFechaNacimiento);
            this.groupBoxDatos.Controls.Add(this.txtApellido);
            this.groupBoxDatos.Controls.Add(this.lblApellido);
            this.groupBoxDatos.Controls.Add(this.btnGuardarPaciente);
            this.groupBoxDatos.Controls.Add(this.lblTelefono);
            this.groupBoxDatos.Controls.Add(this.txtNombrePaciente);
            this.groupBoxDatos.Controls.Add(this.txtTelefono);
            this.groupBoxDatos.Controls.Add(this.cbSexo);
            this.groupBoxDatos.Controls.Add(this.blDomicilio);
            this.groupBoxDatos.Controls.Add(this.txtDomicilio);
            this.groupBoxDatos.Controls.Add(this.lblSexo);
            this.groupBoxDatos.Controls.Add(this.lblNombre);
            this.groupBoxDatos.Controls.Add(this.lblFechaNacimiento);
            this.groupBoxDatos.Location = new System.Drawing.Point(12, 17);
            this.groupBoxDatos.Name = "groupBoxDatos";
            this.groupBoxDatos.Size = new System.Drawing.Size(300, 391);
            this.groupBoxDatos.TabIndex = 9;
            this.groupBoxDatos.TabStop = false;
            this.groupBoxDatos.Text = "Datos del Paciente";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(15, 136);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaNacimiento.TabIndex = 30;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(15, 86);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(266, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(12, 70);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 29;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(14, 290);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 4;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtNombrePaciente
            // 
            this.txtNombrePaciente.Location = new System.Drawing.Point(15, 40);
            this.txtNombrePaciente.Name = "txtNombrePaciente";
            this.txtNombrePaciente.Size = new System.Drawing.Size(266, 20);
            this.txtNombrePaciente.TabIndex = 1;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(70, 287);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(115, 20);
            this.txtTelefono.TabIndex = 13;
            // 
            // cbSexo
            // 
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Indefinido"});
            this.cbSexo.Location = new System.Drawing.Point(53, 171);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(89, 21);
            this.cbSexo.TabIndex = 12;
            this.cbSexo.Text = "Masculino";
            // 
            // blDomicilio
            // 
            this.blDomicilio.AutoSize = true;
            this.blDomicilio.Location = new System.Drawing.Point(13, 203);
            this.blDomicilio.Name = "blDomicilio";
            this.blDomicilio.Size = new System.Drawing.Size(52, 13);
            this.blDomicilio.TabIndex = 3;
            this.blDomicilio.Text = "Domicilio:";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Location = new System.Drawing.Point(16, 221);
            this.txtDomicilio.Multiline = true;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(266, 47);
            this.txtDomicilio.TabIndex = 11;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(13, 174);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 2;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(12, 120);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(111, 13);
            this.lblFechaNacimiento.TabIndex = 1;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // tabPageCitas
            // 
            this.tabPageCitas.BackColor = System.Drawing.Color.Transparent;
            this.tabPageCitas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageCitas.BackgroundImage")));
            this.tabPageCitas.Controls.Add(this.dgvCitas);
            this.tabPageCitas.Controls.Add(this.groupBox2);
            this.tabPageCitas.Location = new System.Drawing.Point(4, 34);
            this.tabPageCitas.Name = "tabPageCitas";
            this.tabPageCitas.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCitas.Size = new System.Drawing.Size(884, 414);
            this.tabPageCitas.TabIndex = 1;
            this.tabPageCitas.Text = "Citas";
            // 
            // dgvCitas
            // 
            this.dgvCitas.AllowUserToAddRows = false;
            this.dgvCitas.AllowUserToDeleteRows = false;
            this.dgvCitas.AllowUserToOrderColumns = true;
            this.dgvCitas.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCitas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCitas.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCitas.Location = new System.Drawing.Point(327, 15);
            this.dgvCitas.Name = "dgvCitas";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCitas.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCitas.Size = new System.Drawing.Size(551, 393);
            this.dgvCitas.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dtpFechaCita);
            this.groupBox2.Controls.Add(this.txtNombrePacienteCitas);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.btnEliminarCita);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.btnEditarCita);
            this.groupBox2.Controls.Add(this.btnGuardarCita);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 17);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 208);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del Paciente";
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Location = new System.Drawing.Point(9, 101);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(266, 20);
            this.dtpFechaCita.TabIndex = 37;
            // 
            // txtNombrePacienteCitas
            // 
            this.txtNombrePacienteCitas.Location = new System.Drawing.Point(9, 47);
            this.txtNombrePacienteCitas.Name = "txtNombrePacienteCitas";
            this.txtNombrePacienteCitas.Size = new System.Drawing.Size(266, 20);
            this.txtNombrePacienteCitas.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(6, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 13);
            this.label17.TabIndex = 0;
            this.label17.Text = "Nombre del Paciente:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(6, 84);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(40, 13);
            this.label18.TabIndex = 1;
            this.label18.Text = "Fecha:";
            // 
            // tabPageCobros
            // 
            this.tabPageCobros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPageCobros.BackgroundImage")));
            this.tabPageCobros.Controls.Add(this.dgvCobros);
            this.tabPageCobros.Controls.Add(this.groupBox3);
            this.tabPageCobros.Location = new System.Drawing.Point(4, 34);
            this.tabPageCobros.Name = "tabPageCobros";
            this.tabPageCobros.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCobros.Size = new System.Drawing.Size(884, 414);
            this.tabPageCobros.TabIndex = 0;
            this.tabPageCobros.Text = "Cobros";
            this.tabPageCobros.UseVisualStyleBackColor = true;
            // 
            // dgvCobros
            // 
            this.dgvCobros.AllowUserToAddRows = false;
            this.dgvCobros.AllowUserToDeleteRows = false;
            this.dgvCobros.AllowUserToOrderColumns = true;
            this.dgvCobros.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCobros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCobros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCobros.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvCobros.Location = new System.Drawing.Point(327, 17);
            this.dgvCobros.Name = "dgvCobros";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCobros.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvCobros.Size = new System.Drawing.Size(551, 381);
            this.dgvCobros.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnComprobantePago);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnGuardarCobro);
            this.groupBox3.Controls.Add(this.txtServicioCobro);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtTotalCobro);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.txtNombrePacienteCobro);
            this.groupBox3.Controls.Add(this.label20);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(12, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 242);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos del Paciente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(7, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "Total:";
            // 
            // txtServicioCobro
            // 
            this.txtServicioCobro.AcceptsReturn = true;
            this.txtServicioCobro.Location = new System.Drawing.Point(10, 98);
            this.txtServicioCobro.Name = "txtServicioCobro";
            this.txtServicioCobro.Size = new System.Drawing.Size(266, 20);
            this.txtServicioCobro.TabIndex = 2;
            this.txtServicioCobro.TextChanged += new System.EventHandler(this.txtServicioCobro_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(7, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Nombre del Servicio";
            // 
            // txtTotalCobro
            // 
            this.txtTotalCobro.Location = new System.Drawing.Point(41, 148);
            this.txtTotalCobro.Name = "txtTotalCobro";
            this.txtTotalCobro.ReadOnly = true;
            this.txtTotalCobro.Size = new System.Drawing.Size(68, 20);
            this.txtTotalCobro.TabIndex = 20;
            this.txtTotalCobro.Text = "0.00";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(13, 307);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(43, 13);
            this.label21.TabIndex = 19;
            this.label21.Text = "Total: $";
            // 
            // txtNombrePacienteCobro
            // 
            this.txtNombrePacienteCobro.AcceptsReturn = true;
            this.txtNombrePacienteCobro.Location = new System.Drawing.Point(10, 45);
            this.txtNombrePacienteCobro.Name = "txtNombrePacienteCobro";
            this.txtNombrePacienteCobro.Size = new System.Drawing.Size(266, 20);
            this.txtNombrePacienteCobro.TabIndex = 1;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(7, 29);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(109, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Nombre del Paciente:";
            // 
            // tabControlOpciones
            // 
            this.tabControlOpciones.Controls.Add(this.tabPageCobros);
            this.tabControlOpciones.Controls.Add(this.tabPageCitas);
            this.tabControlOpciones.Controls.Add(this.tabPagePacientes);
            this.tabControlOpciones.Controls.Add(this.tabPageExpedientes);
            this.tabControlOpciones.Controls.Add(this.tabPageServicios);
            this.tabControlOpciones.ItemSize = new System.Drawing.Size(30, 30);
            this.tabControlOpciones.Location = new System.Drawing.Point(-1, -1);
            this.tabControlOpciones.Name = "tabControlOpciones";
            this.tabControlOpciones.SelectedIndex = 0;
            this.tabControlOpciones.Size = new System.Drawing.Size(892, 452);
            this.tabControlOpciones.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(898, 449);
            this.Controls.Add(this.tabControlOpciones);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Consultorio Dental 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultaclienteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacienteBindingSource)).EndInit();
            this.tabPageServicios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageExpedientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpedientes)).EndInit();
            this.tabPagePacientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacientes)).EndInit();
            this.groupBoxDatos.ResumeLayout(false);
            this.groupBoxDatos.PerformLayout();
            this.tabPageCitas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPageCobros.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCobros)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControlOpciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private consultaclienteDataSet consultaclienteDataSet;
        private System.Windows.Forms.BindingSource pacienteBindingSource;
        private consultaclienteDataSetTableAdapters.pacienteTableAdapter pacienteTableAdapter;
        private System.Windows.Forms.ToolTip ttSistema;
        private System.Windows.Forms.TabPage tabPageServicios;
        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEliminarServicio;
        private System.Windows.Forms.Button btnEditarServicio;
        private System.Windows.Forms.Button btnGuardarServicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombreServicio;
        private System.Windows.Forms.TextBox txtPrecioServicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescripcionServicio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPageExpedientes;
        private System.Windows.Forms.DataGridView dgvExpedientes;
        private System.Windows.Forms.TabPage tabPagePacientes;
        private System.Windows.Forms.DataGridView dgvPacientes;
        private System.Windows.Forms.GroupBox groupBoxDatos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditarPaciente;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button btnGuardarPaciente;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtNombrePaciente;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label blDomicilio;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.TabPage tabPageCitas;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.TextBox txtNombrePacienteCitas;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnEliminarCita;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnEditarCita;
        private System.Windows.Forms.Button btnGuardarCita;
        private System.Windows.Forms.TabPage tabPageCobros;
        private System.Windows.Forms.DataGridView dgvCobros;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnGuardarCobro;
        private System.Windows.Forms.TextBox txtServicioCobro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTotalCobro;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtNombrePacienteCobro;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TabControl tabControlOpciones;
        private System.Windows.Forms.Button btnComprobantePago;
        
    }
}

