namespace SistemaFacturacionDesk
{
    partial class frmCondicionesPago
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
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label cantidadDiasLabel;
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCondicionesPago));
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.aRTICULOSDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDiasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cONDICIONESPAGOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fACTURACIONDataSet = new SistemaFacturacionDesk.FACTURACIONDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.cantidadDiasTextBox = new System.Windows.Forms.TextBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cONDICIONESPAGOBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cONDICIONESPAGOBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cONDICIONESPAGOTableAdapter = new SistemaFacturacionDesk.FACTURACIONDataSetTableAdapters.CONDICIONESPAGOTableAdapter();
            this.tableAdapterManager = new SistemaFacturacionDesk.FACTURACIONDataSetTableAdapters.TableAdapterManager();
            descripcionLabel = new System.Windows.Forms.Label();
            cantidadDiasLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONDICIONESPAGOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURACIONDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cONDICIONESPAGOBindingNavigator)).BeginInit();
            this.cONDICIONESPAGOBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.BackColor = System.Drawing.Color.Transparent;
            descripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(34, 50);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(90, 17);
            descripcionLabel.TabIndex = 2;
            descripcionLabel.Text = "Descripion:";
            // 
            // cantidadDiasLabel
            // 
            cantidadDiasLabel.AutoSize = true;
            cantidadDiasLabel.BackColor = System.Drawing.Color.Transparent;
            cantidadDiasLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cantidadDiasLabel.Location = new System.Drawing.Point(10, 76);
            cantidadDiasLabel.Name = "cantidadDiasLabel";
            cantidadDiasLabel.Size = new System.Drawing.Size(114, 17);
            cantidadDiasLabel.TabIndex = 4;
            cantidadDiasLabel.Text = "Cantidad Días:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.BackColor = System.Drawing.Color.Transparent;
            estadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estadoLabel.Location = new System.Drawing.Point(61, 102);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(63, 17);
            estadoLabel.TabIndex = 6;
            estadoLabel.Text = "Estado:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.BackColor = System.Drawing.Color.Transparent;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(95, 26);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(26, 17);
            idLabel.TabIndex = 7;
            idLabel.Text = "Id:";
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(700, 24);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(111, 26);
            this.btnLimpiarFiltros.TabIndex = 19;
            this.btnLimpiarFiltros.Text = "Cancelar";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // aRTICULOSDataGridView
            // 
            this.aRTICULOSDataGridView.AllowUserToAddRows = false;
            this.aRTICULOSDataGridView.AllowUserToDeleteRows = false;
            this.aRTICULOSDataGridView.AllowUserToResizeColumns = false;
            this.aRTICULOSDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.aRTICULOSDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.aRTICULOSDataGridView.AutoGenerateColumns = false;
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
            this.idDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.cantidadDiasDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.aRTICULOSDataGridView.DataSource = this.cONDICIONESPAGOBindingSource;
            this.aRTICULOSDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.aRTICULOSDataGridView.Location = new System.Drawing.Point(6, 29);
            this.aRTICULOSDataGridView.Name = "aRTICULOSDataGridView";
            this.aRTICULOSDataGridView.ReadOnly = true;
            this.aRTICULOSDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.aRTICULOSDataGridView.Size = new System.Drawing.Size(841, 269);
            this.aRTICULOSDataGridView.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadDiasDataGridViewTextBoxColumn
            // 
            this.cantidadDiasDataGridViewTextBoxColumn.DataPropertyName = "cantidadDias";
            this.cantidadDiasDataGridViewTextBoxColumn.HeaderText = "Cantidad Días";
            this.cantidadDiasDataGridViewTextBoxColumn.Name = "cantidadDiasDataGridViewTextBoxColumn";
            this.cantidadDiasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cONDICIONESPAGOBindingSource
            // 
            this.cONDICIONESPAGOBindingSource.DataMember = "CONDICIONESPAGO";
            this.cONDICIONESPAGOBindingSource.DataSource = this.fACTURACIONDataSet;
            // 
            // fACTURACIONDataSet
            // 
            this.fACTURACIONDataSet.DataSetName = "FACTURACIONDataSet";
            this.fACTURACIONDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.aRTICULOSDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(17, 287);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(853, 305);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Condiciones de Pago";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idLabel1);
            this.groupBox1.Controls.Add(descripcionLabel);
            this.groupBox1.Controls.Add(this.descripcionTextBox);
            this.groupBox1.Controls.Add(cantidadDiasLabel);
            this.groupBox1.Controls.Add(this.cantidadDiasTextBox);
            this.groupBox1.Controls.Add(estadoLabel);
            this.groupBox1.Controls.Add(this.estadoComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 148);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Condición de Pago";
            // 
            // idLabel1
            // 
            this.idLabel1.BackColor = System.Drawing.Color.Transparent;
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cONDICIONESPAGOBindingSource, "id", true));
            this.idLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel1.Location = new System.Drawing.Point(127, 28);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(100, 23);
            this.idLabel1.TabIndex = 8;
            this.idLabel1.Text = "label2";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cONDICIONESPAGOBindingSource, "descripcion", true));
            this.descripcionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionTextBox.Location = new System.Drawing.Point(130, 50);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(401, 23);
            this.descripcionTextBox.TabIndex = 3;
            // 
            // cantidadDiasTextBox
            // 
            this.cantidadDiasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cONDICIONESPAGOBindingSource, "cantidadDias", true));
            this.cantidadDiasTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadDiasTextBox.Location = new System.Drawing.Point(130, 75);
            this.cantidadDiasTextBox.Name = "cantidadDiasTextBox";
            this.cantidadDiasTextBox.Size = new System.Drawing.Size(401, 23);
            this.cantidadDiasTextBox.TabIndex = 5;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cONDICIONESPAGOBindingSource, "estado", true));
            this.estadoComboBox.DisplayMember = "Value";
            this.estadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Location = new System.Drawing.Point(130, 100);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(401, 24);
            this.estadoComboBox.TabIndex = 7;
            this.estadoComboBox.ValueMember = "Key";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(107, 29);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(405, 23);
            this.txtDescripcion.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 26);
            this.button1.TabIndex = 19;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.fillByDescripcion);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Descripción:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox3.BackgroundImage")));
            this.groupBox3.Controls.Add(this.txtDescripcion);
            this.groupBox3.Controls.Add(this.btnLimpiarFiltros);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(17, 45);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(853, 70);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtros";
            // 
            // cONDICIONESPAGOBindingNavigator
            // 
            this.cONDICIONESPAGOBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cONDICIONESPAGOBindingNavigator.BindingSource = this.cONDICIONESPAGOBindingSource;
            this.cONDICIONESPAGOBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cONDICIONESPAGOBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cONDICIONESPAGOBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cONDICIONESPAGOBindingNavigatorSaveItem});
            this.cONDICIONESPAGOBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cONDICIONESPAGOBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cONDICIONESPAGOBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cONDICIONESPAGOBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cONDICIONESPAGOBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cONDICIONESPAGOBindingNavigator.Name = "cONDICIONESPAGOBindingNavigator";
            this.cONDICIONESPAGOBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cONDICIONESPAGOBindingNavigator.Size = new System.Drawing.Size(889, 25);
            this.cONDICIONESPAGOBindingNavigator.TabIndex = 22;
            this.cONDICIONESPAGOBindingNavigator.Text = "bindingNavigator1";
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
            // cONDICIONESPAGOBindingNavigatorSaveItem
            // 
            this.cONDICIONESPAGOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cONDICIONESPAGOBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cONDICIONESPAGOBindingNavigatorSaveItem.Image")));
            this.cONDICIONESPAGOBindingNavigatorSaveItem.Name = "cONDICIONESPAGOBindingNavigatorSaveItem";
            this.cONDICIONESPAGOBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cONDICIONESPAGOBindingNavigatorSaveItem.Text = "Save Data";
            this.cONDICIONESPAGOBindingNavigatorSaveItem.Click += new System.EventHandler(this.cONDICIONESPAGOBindingNavigatorSaveItem_Click);
            // 
            // cONDICIONESPAGOTableAdapter
            // 
            this.cONDICIONESPAGOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ARTICULOSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORIATableAdapter = null;
            this.tableAdapterManager.CLIENTESTableAdapter = null;
            this.tableAdapterManager.CONDICIONESPAGOTableAdapter = this.cONDICIONESPAGOTableAdapter;
            this.tableAdapterManager.DETALLE_FACTURATableAdapter = null;
            this.tableAdapterManager.FACTURASTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaFacturacionDesk.FACTURACIONDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDEDORESTableAdapter = null;
            // 
            // frmCondicionesPago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(889, 611);
            this.Controls.Add(this.cONDICIONESPAGOBindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCondicionesPago";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Condiciones Pago";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCondicionesPago_FormClosed);
            this.Load += new System.EventHandler(this.frmCondicionesPago_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONDICIONESPAGOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURACIONDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cONDICIONESPAGOBindingNavigator)).EndInit();
            this.cONDICIONESPAGOBindingNavigator.ResumeLayout(false);
            this.cONDICIONESPAGOBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.DataGridView aRTICULOSDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private FACTURACIONDataSet fACTURACIONDataSet;
        private System.Windows.Forms.BindingSource cONDICIONESPAGOBindingSource;
        private FACTURACIONDataSetTableAdapters.CONDICIONESPAGOTableAdapter cONDICIONESPAGOTableAdapter;
        private FACTURACIONDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cONDICIONESPAGOBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cONDICIONESPAGOBindingNavigatorSaveItem;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox cantidadDiasTextBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDiasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;


    }
}