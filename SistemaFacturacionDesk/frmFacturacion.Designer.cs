namespace SistemaFacturacionDesk
{
    partial class frmFacturacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label nombreComercialLabel;
            System.Windows.Forms.Label razonSocialLabel;
            System.Windows.Forms.Label rNC_CEDLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label idCondicionPagoLabel;
            System.Windows.Forms.Label comentarioLabel;
            System.Windows.Forms.Label fechaRegistroLabel;
            System.Windows.Forms.Label porcentajeDescuentoLabel;
            System.Windows.Forms.Label iTBISLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label label3;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fechaRegistroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idCondicionPagoComboBox = new System.Windows.Forms.ComboBox();
            this.cONDICIONESPAGOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fACTURACIONDataSet = new SistemaFacturacionDesk.FACTURACIONDataSet();
            this.comentarioTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemoverArticulo = new System.Windows.Forms.Button();
            this.btnAgregarArticulos = new System.Windows.Forms.Button();
            this.aRTICULOSDataGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.idTextBoxCliente = new System.Windows.Forms.TextBox();
            this.rNC_CEDTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.nombreComercialTextBox = new System.Windows.Forms.TextBox();
            this.razonSocialTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.btnLimpiarCliente = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtPorcentajeDescuento = new System.Windows.Forms.TextBox();
            this.txtPorcentajeITBIS = new System.Windows.Forms.TextBox();
            this.cONDICIONESPAGOTableAdapter = new SistemaFacturacionDesk.FACTURACIONDataSetTableAdapters.CONDICIONESPAGOTableAdapter();
            this.txtTotalBruto = new System.Windows.Forms.TextBox();
            this.txtTotalNeto = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDescuento = new System.Windows.Forms.TextBox();
            this.txtITBIS = new System.Windows.Forms.TextBox();
            this.btnGuardarFactura = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            telefonoLabel = new System.Windows.Forms.Label();
            nombreComercialLabel = new System.Windows.Forms.Label();
            razonSocialLabel = new System.Windows.Forms.Label();
            rNC_CEDLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            idCondicionPagoLabel = new System.Windows.Forms.Label();
            comentarioLabel = new System.Windows.Forms.Label();
            fechaRegistroLabel = new System.Windows.Forms.Label();
            porcentajeDescuentoLabel = new System.Windows.Forms.Label();
            iTBISLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cONDICIONESPAGOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURACIONDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSDataGridView)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.BackColor = System.Drawing.Color.Transparent;
            telefonoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonoLabel.Location = new System.Drawing.Point(443, 58);
            telefonoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(77, 17);
            telefonoLabel.TabIndex = 28;
            telefonoLabel.Text = "Teléfono:";
            // 
            // nombreComercialLabel
            // 
            nombreComercialLabel.AutoSize = true;
            nombreComercialLabel.BackColor = System.Drawing.Color.Transparent;
            nombreComercialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreComercialLabel.Location = new System.Drawing.Point(8, 59);
            nombreComercialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nombreComercialLabel.Name = "nombreComercialLabel";
            nombreComercialLabel.Size = new System.Drawing.Size(145, 17);
            nombreComercialLabel.TabIndex = 20;
            nombreComercialLabel.Text = "Nombre Comercial:";
            // 
            // razonSocialLabel
            // 
            razonSocialLabel.AutoSize = true;
            razonSocialLabel.BackColor = System.Drawing.Color.Transparent;
            razonSocialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            razonSocialLabel.Location = new System.Drawing.Point(45, 95);
            razonSocialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            razonSocialLabel.Name = "razonSocialLabel";
            razonSocialLabel.Size = new System.Drawing.Size(108, 17);
            razonSocialLabel.TabIndex = 22;
            razonSocialLabel.Text = "Razón Social:";
            // 
            // rNC_CEDLabel
            // 
            rNC_CEDLabel.AutoSize = true;
            rNC_CEDLabel.BackColor = System.Drawing.Color.Transparent;
            rNC_CEDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rNC_CEDLabel.Location = new System.Drawing.Point(439, 26);
            rNC_CEDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            rNC_CEDLabel.Name = "rNC_CEDLabel";
            rNC_CEDLabel.Size = new System.Drawing.Size(81, 17);
            rNC_CEDLabel.TabIndex = 24;
            rNC_CEDLabel.Text = "RNC/CED:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.BackColor = System.Drawing.Color.Transparent;
            emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(468, 87);
            emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(52, 17);
            emailLabel.TabIndex = 25;
            emailLabel.Text = "Email:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.BackColor = System.Drawing.Color.Transparent;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(127, 26);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(26, 17);
            idLabel.TabIndex = 32;
            idLabel.Text = "Id:";
            // 
            // idCondicionPagoLabel
            // 
            idCondicionPagoLabel.AutoSize = true;
            idCondicionPagoLabel.BackColor = System.Drawing.Color.Transparent;
            idCondicionPagoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idCondicionPagoLabel.Location = new System.Drawing.Point(15, 56);
            idCondicionPagoLabel.Name = "idCondicionPagoLabel";
            idCondicionPagoLabel.Size = new System.Drawing.Size(126, 17);
            idCondicionPagoLabel.TabIndex = 2;
            idCondicionPagoLabel.Text = "Condición Pago:";
            // 
            // comentarioLabel
            // 
            comentarioLabel.AutoSize = true;
            comentarioLabel.BackColor = System.Drawing.Color.Transparent;
            comentarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comentarioLabel.Location = new System.Drawing.Point(46, 114);
            comentarioLabel.Name = "comentarioLabel";
            comentarioLabel.Size = new System.Drawing.Size(95, 17);
            comentarioLabel.TabIndex = 14;
            comentarioLabel.Text = "Comentario:";
            // 
            // fechaRegistroLabel
            // 
            fechaRegistroLabel.AutoSize = true;
            fechaRegistroLabel.BackColor = System.Drawing.Color.Transparent;
            fechaRegistroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaRegistroLabel.Location = new System.Drawing.Point(18, 87);
            fechaRegistroLabel.Name = "fechaRegistroLabel";
            fechaRegistroLabel.Size = new System.Drawing.Size(123, 17);
            fechaRegistroLabel.TabIndex = 15;
            fechaRegistroLabel.Text = "Fecha Registro:";
            // 
            // porcentajeDescuentoLabel
            // 
            porcentajeDescuentoLabel.AutoSize = true;
            porcentajeDescuentoLabel.BackColor = System.Drawing.Color.Transparent;
            porcentajeDescuentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            porcentajeDescuentoLabel.Location = new System.Drawing.Point(288, 20);
            porcentajeDescuentoLabel.Name = "porcentajeDescuentoLabel";
            porcentajeDescuentoLabel.Size = new System.Drawing.Size(120, 17);
            porcentajeDescuentoLabel.TabIndex = 12;
            porcentajeDescuentoLabel.Text = "(%) Descuento:";
            // 
            // iTBISLabel
            // 
            iTBISLabel.AutoSize = true;
            iTBISLabel.BackColor = System.Drawing.Color.Transparent;
            iTBISLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iTBISLabel.Location = new System.Drawing.Point(555, 20);
            iTBISLabel.Name = "iTBISLabel";
            iTBISLabel.Size = new System.Drawing.Size(51, 17);
            iTBISLabel.TabIndex = 14;
            iTBISLabel.Text = "ITBIS:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(52, 20);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(89, 17);
            label1.TabIndex = 14;
            label1.Text = "Total Bruto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(753, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(50, 17);
            label2.TabIndex = 14;
            label2.Text = "Total:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(fechaRegistroLabel);
            this.groupBox1.Controls.Add(this.fechaRegistroDateTimePicker);
            this.groupBox1.Controls.Add(idCondicionPagoLabel);
            this.groupBox1.Controls.Add(this.idCondicionPagoComboBox);
            this.groupBox1.Controls.Add(comentarioLabel);
            this.groupBox1.Controls.Add(label3);
            this.groupBox1.Controls.Add(this.comentarioTextBox);
            this.groupBox1.Controls.Add(this.txtVendedor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(952, 197);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Factura";
            // 
            // fechaRegistroDateTimePicker
            // 
            this.fechaRegistroDateTimePicker.Location = new System.Drawing.Point(147, 85);
            this.fechaRegistroDateTimePicker.Name = "fechaRegistroDateTimePicker";
            this.fechaRegistroDateTimePicker.Size = new System.Drawing.Size(781, 23);
            this.fechaRegistroDateTimePicker.TabIndex = 16;
            // 
            // idCondicionPagoComboBox
            // 
            this.idCondicionPagoComboBox.DataSource = this.cONDICIONESPAGOBindingSource;
            this.idCondicionPagoComboBox.DisplayMember = "descripcion";
            this.idCondicionPagoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idCondicionPagoComboBox.FormattingEnabled = true;
            this.idCondicionPagoComboBox.Location = new System.Drawing.Point(147, 56);
            this.idCondicionPagoComboBox.Name = "idCondicionPagoComboBox";
            this.idCondicionPagoComboBox.Size = new System.Drawing.Size(781, 24);
            this.idCondicionPagoComboBox.TabIndex = 3;
            this.idCondicionPagoComboBox.ValueMember = "id";
            // 
            // cONDICIONESPAGOBindingSource
            // 
            this.cONDICIONESPAGOBindingSource.AllowNew = false;
            this.cONDICIONESPAGOBindingSource.DataMember = "CONDICIONESPAGO";
            this.cONDICIONESPAGOBindingSource.DataSource = this.fACTURACIONDataSet;
            this.cONDICIONESPAGOBindingSource.Filter = "estado = \'A\'";
            this.cONDICIONESPAGOBindingSource.Sort = "descripcion asc";
            // 
            // fACTURACIONDataSet
            // 
            this.fACTURACIONDataSet.DataSetName = "FACTURACIONDataSet";
            this.fACTURACIONDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comentarioTextBox
            // 
            this.comentarioTextBox.Location = new System.Drawing.Point(147, 114);
            this.comentarioTextBox.Multiline = true;
            this.comentarioTextBox.Name = "comentarioTextBox";
            this.comentarioTextBox.Size = new System.Drawing.Size(781, 70);
            this.comentarioTextBox.TabIndex = 15;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.btnRemoverArticulo);
            this.groupBox2.Controls.Add(this.btnAgregarArticulos);
            this.groupBox2.Controls.Add(this.aRTICULOSDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(16, 365);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(952, 185);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Artículos Facturados";
            // 
            // btnRemoverArticulo
            // 
            this.btnRemoverArticulo.Location = new System.Drawing.Point(801, 58);
            this.btnRemoverArticulo.Name = "btnRemoverArticulo";
            this.btnRemoverArticulo.Size = new System.Drawing.Size(127, 29);
            this.btnRemoverArticulo.TabIndex = 3;
            this.btnRemoverArticulo.Text = "Remover Articulo";
            this.btnRemoverArticulo.UseVisualStyleBackColor = true;
            this.btnRemoverArticulo.Click += new System.EventHandler(this.btnRemoverArticulo_Click);
            // 
            // btnAgregarArticulos
            // 
            this.btnAgregarArticulos.Location = new System.Drawing.Point(801, 23);
            this.btnAgregarArticulos.Name = "btnAgregarArticulos";
            this.btnAgregarArticulos.Size = new System.Drawing.Size(127, 29);
            this.btnAgregarArticulos.TabIndex = 3;
            this.btnAgregarArticulos.Text = "Agregar Articulo";
            this.btnAgregarArticulos.UseVisualStyleBackColor = true;
            this.btnAgregarArticulos.Click += new System.EventHandler(this.btnAgregarArticulos_Click);
            // 
            // aRTICULOSDataGridView
            // 
            this.aRTICULOSDataGridView.AllowUserToAddRows = false;
            this.aRTICULOSDataGridView.AllowUserToDeleteRows = false;
            this.aRTICULOSDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.aRTICULOSDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.aRTICULOSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.aRTICULOSDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.aRTICULOSDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.aRTICULOSDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.aRTICULOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aRTICULOSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descripcion,
            this.categoria,
            this.precioUnitario,
            this.cantidadArticulo,
            this.importe});
            this.aRTICULOSDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.aRTICULOSDataGridView.Location = new System.Drawing.Point(11, 23);
            this.aRTICULOSDataGridView.MultiSelect = false;
            this.aRTICULOSDataGridView.Name = "aRTICULOSDataGridView";
            this.aRTICULOSDataGridView.ReadOnly = true;
            this.aRTICULOSDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.aRTICULOSDataGridView.Size = new System.Drawing.Size(765, 150);
            this.aRTICULOSDataGridView.TabIndex = 2;
            this.aRTICULOSDataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.aRTICULOSDataGridView_RowsAdded);
            this.aRTICULOSDataGridView.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.aRTICULOSDataGridView_RowsRemoved);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.FillWeight = 24.16525F;
            this.id.HeaderText = "Id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.DataPropertyName = "descripcion";
            this.descripcion.FillWeight = 91.36623F;
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // categoria
            // 
            this.categoria.DataPropertyName = "categoria";
            this.categoria.FillWeight = 74.50547F;
            this.categoria.HeaderText = "Categoría";
            this.categoria.Name = "categoria";
            this.categoria.ReadOnly = true;
            // 
            // precioUnitario
            // 
            this.precioUnitario.DataPropertyName = "precioUnitario";
            this.precioUnitario.FillWeight = 68.68232F;
            this.precioUnitario.HeaderText = "P. Unitario";
            this.precioUnitario.Name = "precioUnitario";
            this.precioUnitario.ReadOnly = true;
            this.precioUnitario.ToolTipText = "Precio Unitario";
            // 
            // cantidadArticulo
            // 
            this.cantidadArticulo.DataPropertyName = "cantidadArticulo";
            this.cantidadArticulo.FillWeight = 82.64745F;
            this.cantidadArticulo.HeaderText = "Cant. Artículos";
            this.cantidadArticulo.Name = "cantidadArticulo";
            this.cantidadArticulo.ReadOnly = true;
            this.cantidadArticulo.ToolTipText = "Cantidad de Artículos";
            // 
            // importe
            // 
            this.importe.DataPropertyName = "importe";
            this.importe.FillWeight = 54.06468F;
            this.importe.HeaderText = "Importe";
            this.importe.Name = "importe";
            this.importe.ReadOnly = true;
            // 
            // groupBox4
            // 
            this.groupBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox4.BackgroundImage")));
            this.groupBox4.Controls.Add(this.idTextBoxCliente);
            this.groupBox4.Controls.Add(idLabel);
            this.groupBox4.Controls.Add(this.rNC_CEDTextBox);
            this.groupBox4.Controls.Add(this.telefonoTextBox);
            this.groupBox4.Controls.Add(telefonoLabel);
            this.groupBox4.Controls.Add(nombreComercialLabel);
            this.groupBox4.Controls.Add(this.nombreComercialTextBox);
            this.groupBox4.Controls.Add(razonSocialLabel);
            this.groupBox4.Controls.Add(this.razonSocialTextBox);
            this.groupBox4.Controls.Add(rNC_CEDLabel);
            this.groupBox4.Controls.Add(emailLabel);
            this.groupBox4.Controls.Add(this.emailTextBox);
            this.groupBox4.Controls.Add(this.btnLimpiarCliente);
            this.groupBox4.Controls.Add(this.btnBuscarCliente);
            this.groupBox4.Location = new System.Drawing.Point(16, 220);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(952, 137);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos Cliente";
            // 
            // idTextBoxCliente
            // 
            this.idTextBoxCliente.Location = new System.Drawing.Point(161, 22);
            this.idTextBoxCliente.Margin = new System.Windows.Forms.Padding(4);
            this.idTextBoxCliente.Name = "idTextBoxCliente";
            this.idTextBoxCliente.ReadOnly = true;
            this.idTextBoxCliente.Size = new System.Drawing.Size(184, 23);
            this.idTextBoxCliente.TabIndex = 1;
            // 
            // rNC_CEDTextBox
            // 
            this.rNC_CEDTextBox.Location = new System.Drawing.Point(528, 22);
            this.rNC_CEDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.rNC_CEDTextBox.MaxLength = 11;
            this.rNC_CEDTextBox.Name = "rNC_CEDTextBox";
            this.rNC_CEDTextBox.ReadOnly = true;
            this.rNC_CEDTextBox.Size = new System.Drawing.Size(248, 23);
            this.rNC_CEDTextBox.TabIndex = 31;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.Location = new System.Drawing.Point(528, 54);
            this.telefonoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.telefonoTextBox.MaxLength = 10;
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.ReadOnly = true;
            this.telefonoTextBox.Size = new System.Drawing.Size(248, 23);
            this.telefonoTextBox.TabIndex = 30;
            // 
            // nombreComercialTextBox
            // 
            this.nombreComercialTextBox.Location = new System.Drawing.Point(161, 54);
            this.nombreComercialTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nombreComercialTextBox.Name = "nombreComercialTextBox";
            this.nombreComercialTextBox.ReadOnly = true;
            this.nombreComercialTextBox.Size = new System.Drawing.Size(263, 23);
            this.nombreComercialTextBox.TabIndex = 21;
            // 
            // razonSocialTextBox
            // 
            this.razonSocialTextBox.Location = new System.Drawing.Point(161, 89);
            this.razonSocialTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.razonSocialTextBox.Name = "razonSocialTextBox";
            this.razonSocialTextBox.ReadOnly = true;
            this.razonSocialTextBox.Size = new System.Drawing.Size(263, 23);
            this.razonSocialTextBox.TabIndex = 23;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(528, 86);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(248, 23);
            this.emailTextBox.TabIndex = 26;
            // 
            // btnLimpiarCliente
            // 
            this.btnLimpiarCliente.Location = new System.Drawing.Point(801, 55);
            this.btnLimpiarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiarCliente.Name = "btnLimpiarCliente";
            this.btnLimpiarCliente.Size = new System.Drawing.Size(127, 32);
            this.btnLimpiarCliente.TabIndex = 19;
            this.btnLimpiarCliente.Text = "Limpiar";
            this.btnLimpiarCliente.UseVisualStyleBackColor = true;
            this.btnLimpiarCliente.Click += new System.EventHandler(this.btnLimpiarCliente_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(801, 18);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(127, 32);
            this.btnBuscarCliente.TabIndex = 19;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // txtPorcentajeDescuento
            // 
            this.txtPorcentajeDescuento.Location = new System.Drawing.Point(291, 40);
            this.txtPorcentajeDescuento.MaxLength = 3;
            this.txtPorcentajeDescuento.Name = "txtPorcentajeDescuento";
            this.txtPorcentajeDescuento.Size = new System.Drawing.Size(76, 23);
            this.txtPorcentajeDescuento.TabIndex = 13;
            this.txtPorcentajeDescuento.Text = "0";
            this.txtPorcentajeDescuento.TextChanged += new System.EventHandler(this.Recalcular_TextChanged);
            // 
            // txtPorcentajeITBIS
            // 
            this.txtPorcentajeITBIS.Location = new System.Drawing.Point(558, 40);
            this.txtPorcentajeITBIS.Name = "txtPorcentajeITBIS";
            this.txtPorcentajeITBIS.ReadOnly = true;
            this.txtPorcentajeITBIS.Size = new System.Drawing.Size(65, 23);
            this.txtPorcentajeITBIS.TabIndex = 15;
            this.txtPorcentajeITBIS.Text = "18";
            this.txtPorcentajeITBIS.TextChanged += new System.EventHandler(this.Recalcular_TextChanged);
            // 
            // cONDICIONESPAGOTableAdapter
            // 
            this.cONDICIONESPAGOTableAdapter.ClearBeforeFill = true;
            // 
            // txtTotalBruto
            // 
            this.txtTotalBruto.Location = new System.Drawing.Point(55, 40);
            this.txtTotalBruto.Name = "txtTotalBruto";
            this.txtTotalBruto.ReadOnly = true;
            this.txtTotalBruto.Size = new System.Drawing.Size(133, 23);
            this.txtTotalBruto.TabIndex = 15;
            this.txtTotalBruto.Text = "0";
            // 
            // txtTotalNeto
            // 
            this.txtTotalNeto.Location = new System.Drawing.Point(756, 40);
            this.txtTotalNeto.Name = "txtTotalNeto";
            this.txtTotalNeto.ReadOnly = true;
            this.txtTotalNeto.Size = new System.Drawing.Size(133, 23);
            this.txtTotalNeto.TabIndex = 15;
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(porcentajeDescuentoLabel);
            this.groupBox3.Controls.Add(this.txtDescuento);
            this.groupBox3.Controls.Add(this.txtPorcentajeDescuento);
            this.groupBox3.Controls.Add(this.txtITBIS);
            this.groupBox3.Controls.Add(this.txtPorcentajeITBIS);
            this.groupBox3.Controls.Add(label1);
            this.groupBox3.Controls.Add(this.txtTotalNeto);
            this.groupBox3.Controls.Add(label2);
            this.groupBox3.Controls.Add(this.txtTotalBruto);
            this.groupBox3.Controls.Add(iTBISLabel);
            this.groupBox3.Location = new System.Drawing.Point(16, 557);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(950, 108);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Totales";
            // 
            // txtDescuento
            // 
            this.txtDescuento.Location = new System.Drawing.Point(291, 69);
            this.txtDescuento.Name = "txtDescuento";
            this.txtDescuento.ReadOnly = true;
            this.txtDescuento.Size = new System.Drawing.Size(108, 23);
            this.txtDescuento.TabIndex = 13;
            // 
            // txtITBIS
            // 
            this.txtITBIS.Location = new System.Drawing.Point(558, 69);
            this.txtITBIS.Name = "txtITBIS";
            this.txtITBIS.ReadOnly = true;
            this.txtITBIS.Size = new System.Drawing.Size(113, 23);
            this.txtITBIS.TabIndex = 15;
            // 
            // btnGuardarFactura
            // 
            this.btnGuardarFactura.Location = new System.Drawing.Point(18, 683);
            this.btnGuardarFactura.Name = "btnGuardarFactura";
            this.btnGuardarFactura.Size = new System.Drawing.Size(127, 29);
            this.btnGuardarFactura.TabIndex = 3;
            this.btnGuardarFactura.Text = "Guardar Factura";
            this.btnGuardarFactura.UseVisualStyleBackColor = true;
            this.btnGuardarFactura.Click += new System.EventHandler(this.btnGuardarFactura_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(163, 683);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar Factura";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnGuardarFactura_Click);
            // 
            // txtVendedor
            // 
            this.txtVendedor.Location = new System.Drawing.Point(147, 24);
            this.txtVendedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.ReadOnly = true;
            this.txtVendedor.Size = new System.Drawing.Size(504, 23);
            this.txtVendedor.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(58, 26);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(83, 17);
            label3.TabIndex = 20;
            label3.Text = "Vendedor:";
            // 
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(978, 722);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGuardarFactura);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFacturacion";
            this.Text = "Facturación de Articulos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFacturacion_FormClosed);
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cONDICIONESPAGOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURACIONDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSDataGridView)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox rNC_CEDTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox nombreComercialTextBox;
        private System.Windows.Forms.TextBox razonSocialTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox idTextBoxCliente;
        private System.Windows.Forms.Button btnLimpiarCliente;
        private System.Windows.Forms.ComboBox idCondicionPagoComboBox;
        private System.Windows.Forms.TextBox comentarioTextBox;
        private System.Windows.Forms.DateTimePicker fechaRegistroDateTimePicker;
        private System.Windows.Forms.TextBox txtPorcentajeDescuento;
        private System.Windows.Forms.TextBox txtPorcentajeITBIS;
        private System.Windows.Forms.Button btnAgregarArticulos;
        private System.Windows.Forms.DataGridView aRTICULOSDataGridView;
        private System.Windows.Forms.Button btnRemoverArticulo;
        private FACTURACIONDataSet fACTURACIONDataSet;
        private System.Windows.Forms.BindingSource cONDICIONESPAGOBindingSource;
        private FACTURACIONDataSetTableAdapters.CONDICIONESPAGOTableAdapter cONDICIONESPAGOTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn importe;
        private System.Windows.Forms.TextBox txtTotalBruto;
        private System.Windows.Forms.TextBox txtTotalNeto;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDescuento;
        private System.Windows.Forms.TextBox txtITBIS;
        private System.Windows.Forms.Button btnGuardarFactura;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtVendedor;

    }
}