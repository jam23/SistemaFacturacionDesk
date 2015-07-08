namespace SistemaFacturacionDesk
{
    partial class frmVendedores
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label apellido1Label;
            System.Windows.Forms.Label apellido2Label;
            System.Windows.Forms.Label porcientoComisionLabel;
            System.Windows.Forms.Label contrasenaLabel;
            System.Windows.Forms.Label nombreUsuarioLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVendedores));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.vENDEDORESDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.porcientoComisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contrasenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isAdminDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nombreUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vENDEDORESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fACTURACIONDataSet = new SistemaFacturacionDesk.FACTURACIONDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.apellido1TextBox = new System.Windows.Forms.TextBox();
            this.apellido2TextBox = new System.Windows.Forms.TextBox();
            this.porcientoComisionTextBox = new System.Windows.Forms.TextBox();
            this.contrasenaTextBox = new System.Windows.Forms.TextBox();
            this.isAdminCheckBox = new System.Windows.Forms.CheckBox();
            this.nombreUsuarioTextBox = new System.Windows.Forms.TextBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.vENDEDORESBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.vENDEDORESBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.vENDEDORESTableAdapter = new SistemaFacturacionDesk.FACTURACIONDataSetTableAdapters.VENDEDORESTableAdapter();
            this.tableAdapterManager = new SistemaFacturacionDesk.FACTURACIONDataSetTableAdapters.TableAdapterManager();
            idLabel = new System.Windows.Forms.Label();
            nombresLabel = new System.Windows.Forms.Label();
            apellido1Label = new System.Windows.Forms.Label();
            apellido2Label = new System.Windows.Forms.Label();
            porcientoComisionLabel = new System.Windows.Forms.Label();
            contrasenaLabel = new System.Windows.Forms.Label();
            nombreUsuarioLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vENDEDORESDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDEDORESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURACIONDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vENDEDORESBindingNavigator)).BeginInit();
            this.vENDEDORESBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(118, 25);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(26, 17);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombresLabel.Location = new System.Drawing.Point(74, 54);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(77, 17);
            nombresLabel.TabIndex = 2;
            nombresLabel.Text = "Nombres:";
            // 
            // apellido1Label
            // 
            apellido1Label.AutoSize = true;
            apellido1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellido1Label.Location = new System.Drawing.Point(72, 83);
            apellido1Label.Name = "apellido1Label";
            apellido1Label.Size = new System.Drawing.Size(85, 17);
            apellido1Label.TabIndex = 4;
            apellido1Label.Text = "Apellido 1:";
            // 
            // apellido2Label
            // 
            apellido2Label.AutoSize = true;
            apellido2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellido2Label.Location = new System.Drawing.Point(353, 80);
            apellido2Label.Name = "apellido2Label";
            apellido2Label.Size = new System.Drawing.Size(85, 17);
            apellido2Label.TabIndex = 6;
            apellido2Label.Text = "Apellido 2:";
            // 
            // porcientoComisionLabel
            // 
            porcientoComisionLabel.AutoSize = true;
            porcientoComisionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            porcientoComisionLabel.Location = new System.Drawing.Point(47, 112);
            porcientoComisionLabel.Name = "porcientoComisionLabel";
            porcientoComisionLabel.Size = new System.Drawing.Size(108, 17);
            porcientoComisionLabel.TabIndex = 8;
            porcientoComisionLabel.Text = "(%) Comisión:";
            // 
            // contrasenaLabel
            // 
            contrasenaLabel.AutoSize = true;
            contrasenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contrasenaLabel.Location = new System.Drawing.Point(342, 163);
            contrasenaLabel.Name = "contrasenaLabel";
            contrasenaLabel.Size = new System.Drawing.Size(96, 17);
            contrasenaLabel.TabIndex = 10;
            contrasenaLabel.Text = "Contraseña:";
            // 
            // nombreUsuarioLabel
            // 
            nombreUsuarioLabel.AutoSize = true;
            nombreUsuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreUsuarioLabel.Location = new System.Drawing.Point(28, 165);
            nombreUsuarioLabel.Name = "nombreUsuarioLabel";
            nombreUsuarioLabel.Size = new System.Drawing.Size(130, 17);
            nombreUsuarioLabel.TabIndex = 14;
            nombreUsuarioLabel.Text = "Nombre Usuario:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estadoLabel.Location = new System.Drawing.Point(375, 116);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(63, 17);
            estadoLabel.TabIndex = 16;
            estadoLabel.Text = "Estado:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.vENDEDORESDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 377);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(970, 305);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vendedores";
            // 
            // vENDEDORESDataGridView
            // 
            this.vENDEDORESDataGridView.AllowUserToAddRows = false;
            this.vENDEDORESDataGridView.AllowUserToDeleteRows = false;
            this.vENDEDORESDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.vENDEDORESDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.vENDEDORESDataGridView.AutoGenerateColumns = false;
            this.vENDEDORESDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vENDEDORESDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.vENDEDORESDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.vENDEDORESDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.vENDEDORESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vENDEDORESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombresDataGridViewTextBoxColumn,
            this.apellido1DataGridViewTextBoxColumn,
            this.apellido2DataGridViewTextBoxColumn,
            this.porcientoComisionDataGridViewTextBoxColumn,
            this.contrasenaDataGridViewTextBoxColumn,
            this.isAdminDataGridViewCheckBoxColumn,
            this.nombreUsuarioDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.vENDEDORESDataGridView.DataSource = this.vENDEDORESBindingSource;
            this.vENDEDORESDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.vENDEDORESDataGridView.Location = new System.Drawing.Point(6, 29);
            this.vENDEDORESDataGridView.Name = "vENDEDORESDataGridView";
            this.vENDEDORESDataGridView.ReadOnly = true;
            this.vENDEDORESDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vENDEDORESDataGridView.Size = new System.Drawing.Size(951, 269);
            this.vENDEDORESDataGridView.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombresDataGridViewTextBoxColumn
            // 
            this.nombresDataGridViewTextBoxColumn.DataPropertyName = "nombres";
            this.nombresDataGridViewTextBoxColumn.HeaderText = "Nombres";
            this.nombresDataGridViewTextBoxColumn.Name = "nombresDataGridViewTextBoxColumn";
            this.nombresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellido1DataGridViewTextBoxColumn
            // 
            this.apellido1DataGridViewTextBoxColumn.DataPropertyName = "apellido1";
            this.apellido1DataGridViewTextBoxColumn.HeaderText = "Apellido 1";
            this.apellido1DataGridViewTextBoxColumn.Name = "apellido1DataGridViewTextBoxColumn";
            this.apellido1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellido2DataGridViewTextBoxColumn
            // 
            this.apellido2DataGridViewTextBoxColumn.DataPropertyName = "apellido2";
            this.apellido2DataGridViewTextBoxColumn.HeaderText = "Apellido 2";
            this.apellido2DataGridViewTextBoxColumn.Name = "apellido2DataGridViewTextBoxColumn";
            this.apellido2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // porcientoComisionDataGridViewTextBoxColumn
            // 
            this.porcientoComisionDataGridViewTextBoxColumn.DataPropertyName = "porcientoComision";
            this.porcientoComisionDataGridViewTextBoxColumn.HeaderText = " (%) Comision";
            this.porcientoComisionDataGridViewTextBoxColumn.Name = "porcientoComisionDataGridViewTextBoxColumn";
            this.porcientoComisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contrasenaDataGridViewTextBoxColumn
            // 
            this.contrasenaDataGridViewTextBoxColumn.DataPropertyName = "contrasena";
            this.contrasenaDataGridViewTextBoxColumn.HeaderText = "contrasena";
            this.contrasenaDataGridViewTextBoxColumn.Name = "contrasenaDataGridViewTextBoxColumn";
            this.contrasenaDataGridViewTextBoxColumn.ReadOnly = true;
            this.contrasenaDataGridViewTextBoxColumn.Visible = false;
            // 
            // isAdminDataGridViewCheckBoxColumn
            // 
            this.isAdminDataGridViewCheckBoxColumn.DataPropertyName = "IsAdmin";
            this.isAdminDataGridViewCheckBoxColumn.HeaderText = "Administrador";
            this.isAdminDataGridViewCheckBoxColumn.Name = "isAdminDataGridViewCheckBoxColumn";
            this.isAdminDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // nombreUsuarioDataGridViewTextBoxColumn
            // 
            this.nombreUsuarioDataGridViewTextBoxColumn.DataPropertyName = "nombreUsuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.HeaderText = "Nombre Usuario";
            this.nombreUsuarioDataGridViewTextBoxColumn.Name = "nombreUsuarioDataGridViewTextBoxColumn";
            this.nombreUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vENDEDORESBindingSource
            // 
            this.vENDEDORESBindingSource.DataMember = "VENDEDORES";
            this.vENDEDORESBindingSource.DataSource = this.fACTURACIONDataSet;
            // 
            // fACTURACIONDataSet
            // 
            this.fACTURACIONDataSet.DataSetName = "FACTURACIONDataSet";
            this.fACTURACIONDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idLabel1);
            this.groupBox1.Controls.Add(nombresLabel);
            this.groupBox1.Controls.Add(this.nombresTextBox);
            this.groupBox1.Controls.Add(apellido1Label);
            this.groupBox1.Controls.Add(this.apellido1TextBox);
            this.groupBox1.Controls.Add(apellido2Label);
            this.groupBox1.Controls.Add(this.apellido2TextBox);
            this.groupBox1.Controls.Add(porcientoComisionLabel);
            this.groupBox1.Controls.Add(this.porcientoComisionTextBox);
            this.groupBox1.Controls.Add(contrasenaLabel);
            this.groupBox1.Controls.Add(this.contrasenaTextBox);
            this.groupBox1.Controls.Add(this.isAdminCheckBox);
            this.groupBox1.Controls.Add(nombreUsuarioLabel);
            this.groupBox1.Controls.Add(this.nombreUsuarioTextBox);
            this.groupBox1.Controls.Add(estadoLabel);
            this.groupBox1.Controls.Add(this.estadoComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(694, 230);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vendedor";
            // 
            // idLabel1
            // 
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORESBindingSource, "id", true));
            this.idLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel1.Location = new System.Drawing.Point(161, 22);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(121, 23);
            this.idLabel1.TabIndex = 1;
            this.idLabel1.Text = "label2";
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORESBindingSource, "nombres", true));
            this.nombresTextBox.Location = new System.Drawing.Point(161, 51);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(451, 23);
            this.nombresTextBox.TabIndex = 3;
            // 
            // apellido1TextBox
            // 
            this.apellido1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORESBindingSource, "apellido1", true));
            this.apellido1TextBox.Location = new System.Drawing.Point(161, 80);
            this.apellido1TextBox.Name = "apellido1TextBox";
            this.apellido1TextBox.Size = new System.Drawing.Size(168, 23);
            this.apellido1TextBox.TabIndex = 5;
            // 
            // apellido2TextBox
            // 
            this.apellido2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORESBindingSource, "apellido2", true));
            this.apellido2TextBox.Location = new System.Drawing.Point(444, 77);
            this.apellido2TextBox.Name = "apellido2TextBox";
            this.apellido2TextBox.Size = new System.Drawing.Size(168, 23);
            this.apellido2TextBox.TabIndex = 7;
            // 
            // porcientoComisionTextBox
            // 
            this.porcientoComisionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORESBindingSource, "porcientoComision", true));
            this.porcientoComisionTextBox.Location = new System.Drawing.Point(161, 109);
            this.porcientoComisionTextBox.Name = "porcientoComisionTextBox";
            this.porcientoComisionTextBox.Size = new System.Drawing.Size(168, 23);
            this.porcientoComisionTextBox.TabIndex = 9;
            // 
            // contrasenaTextBox
            // 
            this.contrasenaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORESBindingSource, "contrasena", true));
            this.contrasenaTextBox.Enabled = false;
            this.contrasenaTextBox.Location = new System.Drawing.Point(444, 163);
            this.contrasenaTextBox.Name = "contrasenaTextBox";
            this.contrasenaTextBox.Size = new System.Drawing.Size(168, 23);
            this.contrasenaTextBox.TabIndex = 11;
            this.contrasenaTextBox.UseSystemPasswordChar = true;
            // 
            // isAdminCheckBox
            // 
            this.isAdminCheckBox.Checked = true;
            this.isAdminCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.isAdminCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.vENDEDORESBindingSource, "IsAdmin", true));
            this.isAdminCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isAdminCheckBox.Location = new System.Drawing.Point(161, 191);
            this.isAdminCheckBox.Name = "isAdminCheckBox";
            this.isAdminCheckBox.Size = new System.Drawing.Size(168, 24);
            this.isAdminCheckBox.TabIndex = 13;
            this.isAdminCheckBox.Text = "Administrador";
            this.isAdminCheckBox.UseVisualStyleBackColor = true;
            // 
            // nombreUsuarioTextBox
            // 
            this.nombreUsuarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.vENDEDORESBindingSource, "nombreUsuario", true));
            this.nombreUsuarioTextBox.Location = new System.Drawing.Point(161, 162);
            this.nombreUsuarioTextBox.Name = "nombreUsuarioTextBox";
            this.nombreUsuarioTextBox.Size = new System.Drawing.Size(168, 23);
            this.nombreUsuarioTextBox.TabIndex = 15;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.vENDEDORESBindingSource, "estado", true));
            this.estadoComboBox.DisplayMember = "Value";
            this.estadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Location = new System.Drawing.Point(444, 109);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(168, 24);
            this.estadoComboBox.TabIndex = 17;
            this.estadoComboBox.ValueMember = "Key";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtFilterValue);
            this.groupBox3.Controls.Add(this.btnLimpiarFiltros);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 43);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(957, 70);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtros";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(108, 28);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(504, 23);
            this.txtFilterValue.TabIndex = 21;
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(830, 22);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(111, 26);
            this.btnLimpiarFiltros.TabIndex = 19;
            this.btnLimpiarFiltros.Text = "Cancelar";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 26);
            this.button1.TabIndex = 19;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.fillByNombresApellidosUsuario);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Descripción:";
            // 
            // vENDEDORESBindingNavigator
            // 
            this.vENDEDORESBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.vENDEDORESBindingNavigator.BindingSource = this.vENDEDORESBindingSource;
            this.vENDEDORESBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.vENDEDORESBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.vENDEDORESBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.vENDEDORESBindingNavigatorSaveItem});
            this.vENDEDORESBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.vENDEDORESBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.vENDEDORESBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.vENDEDORESBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.vENDEDORESBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.vENDEDORESBindingNavigator.Name = "vENDEDORESBindingNavigator";
            this.vENDEDORESBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.vENDEDORESBindingNavigator.Size = new System.Drawing.Size(993, 25);
            this.vENDEDORESBindingNavigator.TabIndex = 25;
            this.vENDEDORESBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // vENDEDORESBindingNavigatorSaveItem
            // 
            this.vENDEDORESBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.vENDEDORESBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("vENDEDORESBindingNavigatorSaveItem.Image")));
            this.vENDEDORESBindingNavigatorSaveItem.Name = "vENDEDORESBindingNavigatorSaveItem";
            this.vENDEDORESBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.vENDEDORESBindingNavigatorSaveItem.Text = "Save Data";
            this.vENDEDORESBindingNavigatorSaveItem.Click += new System.EventHandler(this.vENDEDORESBindingNavigatorSaveItem_Click);
            // 
            // vENDEDORESTableAdapter
            // 
            this.vENDEDORESTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ARTICULOSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORIATableAdapter = null;
            this.tableAdapterManager.CLIENTESTableAdapter = null;
            this.tableAdapterManager.CONDICIONESPAGOTableAdapter = null;
            this.tableAdapterManager.DETALLE_FACTURATableAdapter = null;
            this.tableAdapterManager.FACTURASTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaFacturacionDesk.FACTURACIONDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDEDORESTableAdapter = this.vENDEDORESTableAdapter;
            // 
            // frmVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(993, 702);
            this.Controls.Add(this.vENDEDORESBindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVendedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Vendedores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmArticulos_FormClosed);
            this.Load += new System.EventHandler(this.frmVendedores_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vENDEDORESDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vENDEDORESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURACIONDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vENDEDORESBindingNavigator)).EndInit();
            this.vENDEDORESBindingNavigator.ResumeLayout(false);
            this.vENDEDORESBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView vENDEDORESDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private FACTURACIONDataSet fACTURACIONDataSet;
        private System.Windows.Forms.BindingSource vENDEDORESBindingSource;
        private FACTURACIONDataSetTableAdapters.VENDEDORESTableAdapter vENDEDORESTableAdapter;
        private FACTURACIONDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator vENDEDORESBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton vENDEDORESBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.TextBox apellido1TextBox;
        private System.Windows.Forms.TextBox apellido2TextBox;
        private System.Windows.Forms.TextBox porcientoComisionTextBox;
        private System.Windows.Forms.TextBox contrasenaTextBox;
        private System.Windows.Forms.CheckBox isAdminCheckBox;
        private System.Windows.Forms.TextBox nombreUsuarioTextBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn porcientoComisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isAdminDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
    }
}