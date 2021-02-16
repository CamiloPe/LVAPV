
namespace Examen
{
    partial class FrmAsignacionPracticaProfecional
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpDatosPersonales = new System.Windows.Forms.GroupBox();
            this.lblNNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidoPaterno = new System.Windows.Forms.TextBox();
            this.lblApellidoPaterno = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblApellidoMaterno = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblTelefonoFijo = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lblTelefonoMobil = new System.Windows.Forms.Label();
            this.grpGenero = new System.Windows.Forms.GroupBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.rdbTipoE = new System.Windows.Forms.RadioButton();
            this.rdbTipoN = new System.Windows.Forms.RadioButton();
            this.grpFotografia = new System.Windows.Forms.GroupBox();
            this.pctMiFoto = new System.Windows.Forms.PictureBox();
            this.grpDatosCarrera = new System.Windows.Forms.GroupBox();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lblSemestre = new System.Windows.Forms.Label();
            this.lblCarrera = new System.Windows.Forms.Label();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.cmbSemestre = new System.Windows.Forms.ComboBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            this.chcServivioSocialConcluido = new System.Windows.Forms.CheckBox();
            this.grpDocumentrosEntregados = new System.Windows.Forms.GroupBox();
            this.chcSolicitudPracticasProfecionales = new System.Windows.Forms.CheckBox();
            this.chcCartaCompromiso = new System.Windows.Forms.CheckBox();
            this.chcCurriculumVitae = new System.Windows.Forms.CheckBox();
            this.chcCartaDeAceptacion = new System.Windows.Forms.CheckBox();
            this.chcSeleccionDeEmpresas = new System.Windows.Forms.CheckBox();
            this.chcEntrevistaPorCompetencias = new System.Windows.Forms.CheckBox();
            this.chcCartaDeLiberacion = new System.Windows.Forms.CheckBox();
            this.chcCartaDePresentacion = new System.Windows.Forms.CheckBox();
            this.chcSeguroGastosMedicos = new System.Windows.Forms.CheckBox();
            this.grpDatosEmpresa = new System.Windows.Forms.GroupBox();
            this.lstEmpresas = new System.Windows.Forms.ListBox();
            this.txtTelefonoMobilAsesor = new System.Windows.Forms.TextBox();
            this.lblTelefonoMobilAsesor = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAsesor = new System.Windows.Forms.TextBox();
            this.lblAsesor = new System.Windows.Forms.Label();
            this.txtContacto = new System.Windows.Forms.TextBox();
            this.lblContacto = new System.Windows.Forms.Label();
            this.lblFechaTermino = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dttFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dttFechaTermino = new System.Windows.Forms.DateTimePicker();
            this.grpDatosPersonales.SuspendLayout();
            this.grpGenero.SuspendLayout();
            this.grpTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMiFoto)).BeginInit();
            this.grpDatosCarrera.SuspendLayout();
            this.grpDocumentrosEntregados.SuspendLayout();
            this.grpDatosEmpresa.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDatosPersonales
            // 
            this.grpDatosPersonales.Controls.Add(this.textBox3);
            this.grpDatosPersonales.Controls.Add(this.lblTelefonoMobil);
            this.grpDatosPersonales.Controls.Add(this.textBox2);
            this.grpDatosPersonales.Controls.Add(this.lblTelefonoFijo);
            this.grpDatosPersonales.Controls.Add(this.textBox1);
            this.grpDatosPersonales.Controls.Add(this.lblApellidoMaterno);
            this.grpDatosPersonales.Controls.Add(this.txtApellidoPaterno);
            this.grpDatosPersonales.Controls.Add(this.lblApellidoPaterno);
            this.grpDatosPersonales.Controls.Add(this.txtNombre);
            this.grpDatosPersonales.Controls.Add(this.lblNNombre);
            this.grpDatosPersonales.Location = new System.Drawing.Point(21, 12);
            this.grpDatosPersonales.Name = "grpDatosPersonales";
            this.grpDatosPersonales.Size = new System.Drawing.Size(555, 190);
            this.grpDatosPersonales.TabIndex = 0;
            this.grpDatosPersonales.TabStop = false;
            this.grpDatosPersonales.Text = "Datos Personales";
            // 
            // lblNNombre
            // 
            this.lblNNombre.AutoSize = true;
            this.lblNNombre.Location = new System.Drawing.Point(6, 30);
            this.lblNNombre.Name = "lblNNombre";
            this.lblNNombre.Size = new System.Drawing.Size(62, 17);
            this.lblNNombre.TabIndex = 1;
            this.lblNNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(149, 25);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(400, 22);
            this.txtNombre.TabIndex = 2;
            // 
            // txtApellidoPaterno
            // 
            this.txtApellidoPaterno.Location = new System.Drawing.Point(149, 53);
            this.txtApellidoPaterno.Name = "txtApellidoPaterno";
            this.txtApellidoPaterno.Size = new System.Drawing.Size(400, 22);
            this.txtApellidoPaterno.TabIndex = 4;
            // 
            // lblApellidoPaterno
            // 
            this.lblApellidoPaterno.AutoSize = true;
            this.lblApellidoPaterno.Location = new System.Drawing.Point(6, 58);
            this.lblApellidoPaterno.Name = "lblApellidoPaterno";
            this.lblApellidoPaterno.Size = new System.Drawing.Size(116, 17);
            this.lblApellidoPaterno.TabIndex = 3;
            this.lblApellidoPaterno.Text = "Apellido Paterno:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(149, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(400, 22);
            this.textBox1.TabIndex = 6;
            // 
            // lblApellidoMaterno
            // 
            this.lblApellidoMaterno.AutoSize = true;
            this.lblApellidoMaterno.Location = new System.Drawing.Point(6, 86);
            this.lblApellidoMaterno.Name = "lblApellidoMaterno";
            this.lblApellidoMaterno.Size = new System.Drawing.Size(118, 17);
            this.lblApellidoMaterno.TabIndex = 5;
            this.lblApellidoMaterno.Text = "Apellido Materno:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(149, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(400, 22);
            this.textBox2.TabIndex = 8;
            // 
            // lblTelefonoFijo
            // 
            this.lblTelefonoFijo.AutoSize = true;
            this.lblTelefonoFijo.Location = new System.Drawing.Point(6, 114);
            this.lblTelefonoFijo.Name = "lblTelefonoFijo";
            this.lblTelefonoFijo.Size = new System.Drawing.Size(94, 17);
            this.lblTelefonoFijo.TabIndex = 7;
            this.lblTelefonoFijo.Text = "Télefono Fijo:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(149, 137);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(400, 22);
            this.textBox3.TabIndex = 10;
            // 
            // lblTelefonoMobil
            // 
            this.lblTelefonoMobil.AutoSize = true;
            this.lblTelefonoMobil.Location = new System.Drawing.Point(6, 142);
            this.lblTelefonoMobil.Name = "lblTelefonoMobil";
            this.lblTelefonoMobil.Size = new System.Drawing.Size(105, 17);
            this.lblTelefonoMobil.TabIndex = 9;
            this.lblTelefonoMobil.Text = "Télefono Móbil:";
            // 
            // grpGenero
            // 
            this.grpGenero.Controls.Add(this.rdbFemenino);
            this.grpGenero.Controls.Add(this.rdbMasculino);
            this.grpGenero.Location = new System.Drawing.Point(582, 12);
            this.grpGenero.Name = "grpGenero";
            this.grpGenero.Size = new System.Drawing.Size(83, 87);
            this.grpGenero.TabIndex = 1;
            this.grpGenero.TabStop = false;
            this.grpGenero.Text = "Género";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(6, 21);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(40, 21);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "M";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(6, 48);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(37, 21);
            this.rdbFemenino.TabIndex = 1;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "F";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // grpTipo
            // 
            this.grpTipo.Controls.Add(this.rdbTipoE);
            this.grpTipo.Controls.Add(this.rdbTipoN);
            this.grpTipo.Location = new System.Drawing.Point(582, 105);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Size = new System.Drawing.Size(83, 97);
            this.grpTipo.TabIndex = 2;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "Tipo";
            // 
            // rdbTipoE
            // 
            this.rdbTipoE.AutoSize = true;
            this.rdbTipoE.Location = new System.Drawing.Point(21, 58);
            this.rdbTipoE.Name = "rdbTipoE";
            this.rdbTipoE.Size = new System.Drawing.Size(38, 21);
            this.rdbTipoE.TabIndex = 3;
            this.rdbTipoE.TabStop = true;
            this.rdbTipoE.Text = "E";
            this.rdbTipoE.UseVisualStyleBackColor = true;
            // 
            // rdbTipoN
            // 
            this.rdbTipoN.AutoSize = true;
            this.rdbTipoN.Location = new System.Drawing.Point(21, 21);
            this.rdbTipoN.Name = "rdbTipoN";
            this.rdbTipoN.Size = new System.Drawing.Size(39, 21);
            this.rdbTipoN.TabIndex = 2;
            this.rdbTipoN.TabStop = true;
            this.rdbTipoN.Text = "N";
            this.rdbTipoN.UseVisualStyleBackColor = true;
            // 
            // grpFotografia
            // 
            this.grpFotografia.Location = new System.Drawing.Point(671, 12);
            this.grpFotografia.Name = "grpFotografia";
            this.grpFotografia.Size = new System.Drawing.Size(197, 190);
            this.grpFotografia.TabIndex = 3;
            this.grpFotografia.TabStop = false;
            this.grpFotografia.Text = "Fotografia";
            // 
            // pctMiFoto
            // 
            this.pctMiFoto.Image = global::Examen.Properties.Resources._20210216_111047;
            this.pctMiFoto.Location = new System.Drawing.Point(671, 30);
            this.pctMiFoto.Name = "pctMiFoto";
            this.pctMiFoto.Size = new System.Drawing.Size(197, 172);
            this.pctMiFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMiFoto.TabIndex = 0;
            this.pctMiFoto.TabStop = false;
            // 
            // grpDatosCarrera
            // 
            this.grpDatosCarrera.Controls.Add(this.chcServivioSocialConcluido);
            this.grpDatosCarrera.Controls.Add(this.txtPromedio);
            this.grpDatosCarrera.Controls.Add(this.cmbSemestre);
            this.grpDatosCarrera.Controls.Add(this.cmbCarrera);
            this.grpDatosCarrera.Controls.Add(this.lblPromedio);
            this.grpDatosCarrera.Controls.Add(this.lblSemestre);
            this.grpDatosCarrera.Controls.Add(this.lblCarrera);
            this.grpDatosCarrera.Location = new System.Drawing.Point(12, 208);
            this.grpDatosCarrera.Name = "grpDatosCarrera";
            this.grpDatosCarrera.Size = new System.Drawing.Size(856, 127);
            this.grpDatosCarrera.TabIndex = 4;
            this.grpDatosCarrera.TabStop = false;
            this.grpDatosCarrera.Text = "Datos Carrera";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(6, 88);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(72, 17);
            this.lblPromedio.TabIndex = 12;
            this.lblPromedio.Text = "Promedio:";
            // 
            // lblSemestre
            // 
            this.lblSemestre.AutoSize = true;
            this.lblSemestre.Location = new System.Drawing.Point(6, 60);
            this.lblSemestre.Name = "lblSemestre";
            this.lblSemestre.Size = new System.Drawing.Size(72, 17);
            this.lblSemestre.TabIndex = 11;
            this.lblSemestre.Text = "Semestre:";
            // 
            // lblCarrera
            // 
            this.lblCarrera.AutoSize = true;
            this.lblCarrera.Location = new System.Drawing.Point(6, 32);
            this.lblCarrera.Name = "lblCarrera";
            this.lblCarrera.Size = new System.Drawing.Size(60, 17);
            this.lblCarrera.TabIndex = 10;
            this.lblCarrera.Text = "Carrera:";
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Items.AddRange(new object[] {
            "Ti",
            "Ingeniería de software",
            "Diseño",
            "Ingeniería industrial"});
            this.cmbCarrera.Location = new System.Drawing.Point(167, 25);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(675, 24);
            this.cmbCarrera.TabIndex = 13;
            // 
            // cmbSemestre
            // 
            this.cmbSemestre.FormattingEnabled = true;
            this.cmbSemestre.Items.AddRange(new object[] {
            "primero",
            "segundo",
            "tercero",
            "cuarto",
            "quinto",
            "sexto",
            "séptimo",
            "octavo",
            "noveno"});
            this.cmbSemestre.Location = new System.Drawing.Point(167, 53);
            this.cmbSemestre.Name = "cmbSemestre";
            this.cmbSemestre.Size = new System.Drawing.Size(675, 24);
            this.cmbSemestre.TabIndex = 14;
            // 
            // txtPromedio
            // 
            this.txtPromedio.Location = new System.Drawing.Point(167, 83);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(219, 22);
            this.txtPromedio.TabIndex = 15;
            // 
            // chcServivioSocialConcluido
            // 
            this.chcServivioSocialConcluido.AutoSize = true;
            this.chcServivioSocialConcluido.CheckAlign = System.Drawing.ContentAlignment.TopRight;
            this.chcServivioSocialConcluido.Location = new System.Drawing.Point(654, 83);
            this.chcServivioSocialConcluido.Name = "chcServivioSocialConcluido";
            this.chcServivioSocialConcluido.Size = new System.Drawing.Size(188, 21);
            this.chcServivioSocialConcluido.TabIndex = 17;
            this.chcServivioSocialConcluido.Text = "Servivio Social Concluido";
            this.chcServivioSocialConcluido.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.chcServivioSocialConcluido.UseVisualStyleBackColor = true;
            // 
            // grpDocumentrosEntregados
            // 
            this.grpDocumentrosEntregados.Controls.Add(this.chcCartaDeLiberacion);
            this.grpDocumentrosEntregados.Controls.Add(this.chcCartaDePresentacion);
            this.grpDocumentrosEntregados.Controls.Add(this.chcSeguroGastosMedicos);
            this.grpDocumentrosEntregados.Controls.Add(this.chcCartaDeAceptacion);
            this.grpDocumentrosEntregados.Controls.Add(this.chcSeleccionDeEmpresas);
            this.grpDocumentrosEntregados.Controls.Add(this.chcEntrevistaPorCompetencias);
            this.grpDocumentrosEntregados.Controls.Add(this.chcCurriculumVitae);
            this.grpDocumentrosEntregados.Controls.Add(this.chcCartaCompromiso);
            this.grpDocumentrosEntregados.Controls.Add(this.chcSolicitudPracticasProfecionales);
            this.grpDocumentrosEntregados.Location = new System.Drawing.Point(12, 341);
            this.grpDocumentrosEntregados.Name = "grpDocumentrosEntregados";
            this.grpDocumentrosEntregados.Size = new System.Drawing.Size(856, 151);
            this.grpDocumentrosEntregados.TabIndex = 5;
            this.grpDocumentrosEntregados.TabStop = false;
            this.grpDocumentrosEntregados.Text = "Documentros Entregados";
            // 
            // chcSolicitudPracticasProfecionales
            // 
            this.chcSolicitudPracticasProfecionales.AutoSize = true;
            this.chcSolicitudPracticasProfecionales.Location = new System.Drawing.Point(9, 32);
            this.chcSolicitudPracticasProfecionales.Name = "chcSolicitudPracticasProfecionales";
            this.chcSolicitudPracticasProfecionales.Size = new System.Drawing.Size(235, 21);
            this.chcSolicitudPracticasProfecionales.TabIndex = 0;
            this.chcSolicitudPracticasProfecionales.Text = "Solicitud Prácticas Profecionales";
            this.chcSolicitudPracticasProfecionales.UseVisualStyleBackColor = true;
            // 
            // chcCartaCompromiso
            // 
            this.chcCartaCompromiso.AutoSize = true;
            this.chcCartaCompromiso.Location = new System.Drawing.Point(9, 59);
            this.chcCartaCompromiso.Name = "chcCartaCompromiso";
            this.chcCartaCompromiso.Size = new System.Drawing.Size(146, 21);
            this.chcCartaCompromiso.TabIndex = 1;
            this.chcCartaCompromiso.Text = "Carta Compromiso";
            this.chcCartaCompromiso.UseVisualStyleBackColor = true;
            // 
            // chcCurriculumVitae
            // 
            this.chcCurriculumVitae.AutoSize = true;
            this.chcCurriculumVitae.Location = new System.Drawing.Point(9, 86);
            this.chcCurriculumVitae.Name = "chcCurriculumVitae";
            this.chcCurriculumVitae.Size = new System.Drawing.Size(133, 21);
            this.chcCurriculumVitae.TabIndex = 2;
            this.chcCurriculumVitae.Text = "Curriculum Vitae";
            this.chcCurriculumVitae.UseVisualStyleBackColor = true;
            // 
            // chcCartaDeAceptacion
            // 
            this.chcCartaDeAceptacion.AutoSize = true;
            this.chcCartaDeAceptacion.Location = new System.Drawing.Point(346, 86);
            this.chcCartaDeAceptacion.Name = "chcCartaDeAceptacion";
            this.chcCartaDeAceptacion.Size = new System.Drawing.Size(160, 21);
            this.chcCartaDeAceptacion.TabIndex = 5;
            this.chcCartaDeAceptacion.Text = "Carta De Aceptación";
            this.chcCartaDeAceptacion.UseVisualStyleBackColor = true;
            // 
            // chcSeleccionDeEmpresas
            // 
            this.chcSeleccionDeEmpresas.AutoSize = true;
            this.chcSeleccionDeEmpresas.Location = new System.Drawing.Point(346, 59);
            this.chcSeleccionDeEmpresas.Name = "chcSeleccionDeEmpresas";
            this.chcSeleccionDeEmpresas.Size = new System.Drawing.Size(180, 21);
            this.chcSeleccionDeEmpresas.TabIndex = 4;
            this.chcSeleccionDeEmpresas.Text = "Selección De Empresas";
            this.chcSeleccionDeEmpresas.UseVisualStyleBackColor = true;
            // 
            // chcEntrevistaPorCompetencias
            // 
            this.chcEntrevistaPorCompetencias.AutoSize = true;
            this.chcEntrevistaPorCompetencias.Location = new System.Drawing.Point(346, 32);
            this.chcEntrevistaPorCompetencias.Name = "chcEntrevistaPorCompetencias";
            this.chcEntrevistaPorCompetencias.Size = new System.Drawing.Size(212, 21);
            this.chcEntrevistaPorCompetencias.TabIndex = 3;
            this.chcEntrevistaPorCompetencias.Text = "Entrevista Por Competencias";
            this.chcEntrevistaPorCompetencias.UseVisualStyleBackColor = true;
            // 
            // chcCartaDeLiberacion
            // 
            this.chcCartaDeLiberacion.AutoSize = true;
            this.chcCartaDeLiberacion.Location = new System.Drawing.Point(669, 86);
            this.chcCartaDeLiberacion.Name = "chcCartaDeLiberacion";
            this.chcCartaDeLiberacion.Size = new System.Drawing.Size(156, 21);
            this.chcCartaDeLiberacion.TabIndex = 8;
            this.chcCartaDeLiberacion.Text = "Carta De Liberación";
            this.chcCartaDeLiberacion.UseVisualStyleBackColor = true;
            // 
            // chcCartaDePresentacion
            // 
            this.chcCartaDePresentacion.AutoSize = true;
            this.chcCartaDePresentacion.Location = new System.Drawing.Point(669, 59);
            this.chcCartaDePresentacion.Name = "chcCartaDePresentacion";
            this.chcCartaDePresentacion.Size = new System.Drawing.Size(173, 21);
            this.chcCartaDePresentacion.TabIndex = 7;
            this.chcCartaDePresentacion.Text = "Carta De Presentación";
            this.chcCartaDePresentacion.UseVisualStyleBackColor = true;
            // 
            // chcSeguroGastosMedicos
            // 
            this.chcSeguroGastosMedicos.AutoSize = true;
            this.chcSeguroGastosMedicos.Location = new System.Drawing.Point(669, 32);
            this.chcSeguroGastosMedicos.Name = "chcSeguroGastosMedicos";
            this.chcSeguroGastosMedicos.Size = new System.Drawing.Size(181, 21);
            this.chcSeguroGastosMedicos.TabIndex = 6;
            this.chcSeguroGastosMedicos.Text = "Seguro Gastos Médicos";
            this.chcSeguroGastosMedicos.UseVisualStyleBackColor = true;
            // 
            // grpDatosEmpresa
            // 
            this.grpDatosEmpresa.Controls.Add(this.dttFechaTermino);
            this.grpDatosEmpresa.Controls.Add(this.dttFechaInicio);
            this.grpDatosEmpresa.Controls.Add(this.lblFechaTermino);
            this.grpDatosEmpresa.Controls.Add(this.lblFechaInicio);
            this.grpDatosEmpresa.Controls.Add(this.txtTelefonoMobilAsesor);
            this.grpDatosEmpresa.Controls.Add(this.lblTelefonoMobilAsesor);
            this.grpDatosEmpresa.Controls.Add(this.txtEmail);
            this.grpDatosEmpresa.Controls.Add(this.lblEmail);
            this.grpDatosEmpresa.Controls.Add(this.txtAsesor);
            this.grpDatosEmpresa.Controls.Add(this.lblAsesor);
            this.grpDatosEmpresa.Controls.Add(this.txtContacto);
            this.grpDatosEmpresa.Controls.Add(this.lblContacto);
            this.grpDatosEmpresa.Controls.Add(this.lstEmpresas);
            this.grpDatosEmpresa.Location = new System.Drawing.Point(12, 498);
            this.grpDatosEmpresa.Name = "grpDatosEmpresa";
            this.grpDatosEmpresa.Size = new System.Drawing.Size(856, 214);
            this.grpDatosEmpresa.TabIndex = 6;
            this.grpDatosEmpresa.TabStop = false;
            this.grpDatosEmpresa.Text = "Datos Empresa";
            // 
            // lstEmpresas
            // 
            this.lstEmpresas.FormattingEnabled = true;
            this.lstEmpresas.ItemHeight = 16;
            this.lstEmpresas.Items.AddRange(new object[] {
            "VW",
            "BMW",
            "Sysne",
            "GM",
            "Google",
            "MEXAbat",
            "AWS",
            "Benteler",
            "Safrán",
            "HYperX"});
            this.lstEmpresas.Location = new System.Drawing.Point(11, 35);
            this.lstEmpresas.Name = "lstEmpresas";
            this.lstEmpresas.Size = new System.Drawing.Size(120, 148);
            this.lstEmpresas.TabIndex = 1;
            // 
            // txtTelefonoMobilAsesor
            // 
            this.txtTelefonoMobilAsesor.Location = new System.Drawing.Point(363, 105);
            this.txtTelefonoMobilAsesor.Name = "txtTelefonoMobilAsesor";
            this.txtTelefonoMobilAsesor.Size = new System.Drawing.Size(479, 22);
            this.txtTelefonoMobilAsesor.TabIndex = 18;
            // 
            // lblTelefonoMobilAsesor
            // 
            this.lblTelefonoMobilAsesor.AutoSize = true;
            this.lblTelefonoMobilAsesor.Location = new System.Drawing.Point(190, 110);
            this.lblTelefonoMobilAsesor.Name = "lblTelefonoMobilAsesor";
            this.lblTelefonoMobilAsesor.Size = new System.Drawing.Size(152, 17);
            this.lblTelefonoMobilAsesor.TabIndex = 17;
            this.lblTelefonoMobilAsesor.Text = "Télefono Móbil asesor:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(363, 77);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(479, 22);
            this.txtEmail.TabIndex = 16;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(190, 82);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 17);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "Email:";
            // 
            // txtAsesor
            // 
            this.txtAsesor.Location = new System.Drawing.Point(363, 49);
            this.txtAsesor.Name = "txtAsesor";
            this.txtAsesor.Size = new System.Drawing.Size(479, 22);
            this.txtAsesor.TabIndex = 14;
            // 
            // lblAsesor
            // 
            this.lblAsesor.AutoSize = true;
            this.lblAsesor.Location = new System.Drawing.Point(190, 54);
            this.lblAsesor.Name = "lblAsesor";
            this.lblAsesor.Size = new System.Drawing.Size(56, 17);
            this.lblAsesor.TabIndex = 13;
            this.lblAsesor.Text = "Asesor:";
            // 
            // txtContacto
            // 
            this.txtContacto.Location = new System.Drawing.Point(363, 21);
            this.txtContacto.Name = "txtContacto";
            this.txtContacto.Size = new System.Drawing.Size(479, 22);
            this.txtContacto.TabIndex = 12;
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Location = new System.Drawing.Point(190, 26);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(68, 17);
            this.lblContacto.TabIndex = 11;
            this.lblContacto.Text = "Contacto:";
            // 
            // lblFechaTermino
            // 
            this.lblFechaTermino.AutoSize = true;
            this.lblFechaTermino.Location = new System.Drawing.Point(448, 166);
            this.lblFechaTermino.Name = "lblFechaTermino";
            this.lblFechaTermino.Size = new System.Drawing.Size(107, 17);
            this.lblFechaTermino.TabIndex = 20;
            this.lblFechaTermino.Text = "Fecha Termino:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(448, 138);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(87, 17);
            this.lblFechaInicio.TabIndex = 19;
            this.lblFechaInicio.Text = "Fecha Inicio:";
            // 
            // dttFechaInicio
            // 
            this.dttFechaInicio.Location = new System.Drawing.Point(586, 133);
            this.dttFechaInicio.Name = "dttFechaInicio";
            this.dttFechaInicio.Size = new System.Drawing.Size(256, 22);
            this.dttFechaInicio.TabIndex = 21;
            // 
            // dttFechaTermino
            // 
            this.dttFechaTermino.Location = new System.Drawing.Point(586, 161);
            this.dttFechaTermino.Name = "dttFechaTermino";
            this.dttFechaTermino.Size = new System.Drawing.Size(256, 22);
            this.dttFechaTermino.TabIndex = 22;
            // 
            // FrmAsignacionPracticaProfecional
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 737);
            this.Controls.Add(this.pctMiFoto);
            this.Controls.Add(this.grpDatosEmpresa);
            this.Controls.Add(this.grpDocumentrosEntregados);
            this.Controls.Add(this.grpDatosCarrera);
            this.Controls.Add(this.grpFotografia);
            this.Controls.Add(this.grpTipo);
            this.Controls.Add(this.grpGenero);
            this.Controls.Add(this.grpDatosPersonales);
            this.Name = "FrmAsignacionPracticaProfecional";
            this.Text = "AsignacionPráctica Profecional";
            this.grpDatosPersonales.ResumeLayout(false);
            this.grpDatosPersonales.PerformLayout();
            this.grpGenero.ResumeLayout(false);
            this.grpGenero.PerformLayout();
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctMiFoto)).EndInit();
            this.grpDatosCarrera.ResumeLayout(false);
            this.grpDatosCarrera.PerformLayout();
            this.grpDocumentrosEntregados.ResumeLayout(false);
            this.grpDocumentrosEntregados.PerformLayout();
            this.grpDatosEmpresa.ResumeLayout(false);
            this.grpDatosEmpresa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDatosPersonales;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lblTelefonoMobil;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblTelefonoFijo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblApellidoMaterno;
        private System.Windows.Forms.TextBox txtApellidoPaterno;
        private System.Windows.Forms.Label lblApellidoPaterno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNNombre;
        private System.Windows.Forms.GroupBox grpGenero;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.RadioButton rdbTipoE;
        private System.Windows.Forms.RadioButton rdbTipoN;
        private System.Windows.Forms.GroupBox grpFotografia;
        private System.Windows.Forms.PictureBox pctMiFoto;
        private System.Windows.Forms.GroupBox grpDatosCarrera;
        private System.Windows.Forms.CheckBox chcServivioSocialConcluido;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.ComboBox cmbSemestre;
        private System.Windows.Forms.ComboBox cmbCarrera;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblSemestre;
        private System.Windows.Forms.Label lblCarrera;
        private System.Windows.Forms.GroupBox grpDocumentrosEntregados;
        private System.Windows.Forms.CheckBox chcCartaDeLiberacion;
        private System.Windows.Forms.CheckBox chcCartaDePresentacion;
        private System.Windows.Forms.CheckBox chcSeguroGastosMedicos;
        private System.Windows.Forms.CheckBox chcCartaDeAceptacion;
        private System.Windows.Forms.CheckBox chcSeleccionDeEmpresas;
        private System.Windows.Forms.CheckBox chcEntrevistaPorCompetencias;
        private System.Windows.Forms.CheckBox chcCurriculumVitae;
        private System.Windows.Forms.CheckBox chcCartaCompromiso;
        private System.Windows.Forms.CheckBox chcSolicitudPracticasProfecionales;
        private System.Windows.Forms.GroupBox grpDatosEmpresa;
        private System.Windows.Forms.DateTimePicker dttFechaTermino;
        private System.Windows.Forms.DateTimePicker dttFechaInicio;
        private System.Windows.Forms.Label lblFechaTermino;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.TextBox txtTelefonoMobilAsesor;
        private System.Windows.Forms.Label lblTelefonoMobilAsesor;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtAsesor;
        private System.Windows.Forms.Label lblAsesor;
        private System.Windows.Forms.TextBox txtContacto;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.ListBox lstEmpresas;
    }
}

