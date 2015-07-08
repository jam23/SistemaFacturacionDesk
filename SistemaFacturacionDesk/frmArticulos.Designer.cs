namespace SistemaFacturacionDesk
{
    partial class frmArticulos
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
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label idCategoriaLabel;
            System.Windows.Forms.Label costoUnitarioLabel;
            System.Windows.Forms.Label precioUnitarioLabel;
            System.Windows.Forms.Label stockLabel;
            System.Windows.Forms.Label estadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmArticulos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.fACTURACIONDataSet = new SistemaFacturacionDesk.FACTURACIONDataSet();
            this.aRTICULOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aRTICULOSTableAdapter = new SistemaFacturacionDesk.FACTURACIONDataSetTableAdapters.ARTICULOSTableAdapter();
            this.tableAdapterManager = new SistemaFacturacionDesk.FACTURACIONDataSetTableAdapters.TableAdapterManager();
            this.cATEGORIATableAdapter = new SistemaFacturacionDesk.FACTURACIONDataSetTableAdapters.CATEGORIATableAdapter();
            this.aRTICULOSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.aRTICULOSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.aRTICULOSDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.idCategoriaComboBox = new System.Windows.Forms.ComboBox();
            this.cATEGORIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costoUnitarioTextBox = new System.Windows.Forms.TextBox();
            this.precioUnitarioTextBox = new System.Windows.Forms.TextBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idLabel2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.vendedoresTableAdapter1 = new SistemaFacturacionDesk.FACTURACIONDataSetTableAdapters.VENDEDORESTableAdapter();
            idLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            idCategoriaLabel = new System.Windows.Forms.Label();
            costoUnitarioLabel = new System.Windows.Forms.Label();
            precioUnitarioLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURACIONDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSBindingNavigator)).BeginInit();
            this.aRTICULOSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIABindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(100, 16);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(26, 17);
            idLabel.TabIndex = 2;
            idLabel.Text = "Id:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(28, 42);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(98, 17);
            descripcionLabel.TabIndex = 4;
            descripcionLabel.Text = "Descripcion:";
            // 
            // idCategoriaLabel
            // 
            idCategoriaLabel.AutoSize = true;
            idCategoriaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idCategoriaLabel.Location = new System.Drawing.Point(43, 68);
            idCategoriaLabel.Name = "idCategoriaLabel";
            idCategoriaLabel.Size = new System.Drawing.Size(83, 17);
            idCategoriaLabel.TabIndex = 6;
            idCategoriaLabel.Text = "Categoria:";
            // 
            // costoUnitarioLabel
            // 
            costoUnitarioLabel.AutoSize = true;
            costoUnitarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            costoUnitarioLabel.Location = new System.Drawing.Point(10, 95);
            costoUnitarioLabel.Name = "costoUnitarioLabel";
            costoUnitarioLabel.Size = new System.Drawing.Size(116, 17);
            costoUnitarioLabel.TabIndex = 8;
            costoUnitarioLabel.Text = "Costo Unitario:";
            // 
            // precioUnitarioLabel
            // 
            precioUnitarioLabel.AutoSize = true;
            precioUnitarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            precioUnitarioLabel.Location = new System.Drawing.Point(5, 121);
            precioUnitarioLabel.Name = "precioUnitarioLabel";
            precioUnitarioLabel.Size = new System.Drawing.Size(121, 17);
            precioUnitarioLabel.TabIndex = 10;
            precioUnitarioLabel.Text = "Precio Unitario:";
            // 
            // stockLabel
            // 
            stockLabel.AutoSize = true;
            stockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            stockLabel.Location = new System.Drawing.Point(73, 147);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(53, 17);
            stockLabel.TabIndex = 12;
            stockLabel.Text = "Stock:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estadoLabel.Location = new System.Drawing.Point(63, 173);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(63, 17);
            estadoLabel.TabIndex = 14;
            estadoLabel.Text = "Estado:";
            // 
            // fACTURACIONDataSet
            // 
            this.fACTURACIONDataSet.DataSetName = "FACTURACIONDataSet";
            this.fACTURACIONDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aRTICULOSBindingSource
            // 
            this.aRTICULOSBindingSource.DataMember = "ARTICULOS";
            this.aRTICULOSBindingSource.DataSource = this.fACTURACIONDataSet;
            // 
            // aRTICULOSTableAdapter
            // 
            this.aRTICULOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ARTICULOSTableAdapter = this.aRTICULOSTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORIATableAdapter = this.cATEGORIATableAdapter;
            this.tableAdapterManager.CLIENTESTableAdapter = null;
            this.tableAdapterManager.CONDICIONESPAGOTableAdapter = null;
            this.tableAdapterManager.DETALLE_FACTURATableAdapter = null;
            this.tableAdapterManager.FACTURASTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaFacturacionDesk.FACTURACIONDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDEDORESTableAdapter = null;
            // 
            // cATEGORIATableAdapter
            // 
            this.cATEGORIATableAdapter.ClearBeforeFill = true;
            // 
            // aRTICULOSBindingNavigator
            // 
            this.aRTICULOSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.aRTICULOSBindingNavigator.BindingSource = this.aRTICULOSBindingSource;
            this.aRTICULOSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.aRTICULOSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.aRTICULOSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.aRTICULOSBindingNavigatorSaveItem});
            this.aRTICULOSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.aRTICULOSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.aRTICULOSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.aRTICULOSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.aRTICULOSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.aRTICULOSBindingNavigator.Name = "aRTICULOSBindingNavigator";
            this.aRTICULOSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.aRTICULOSBindingNavigator.Size = new System.Drawing.Size(885, 25);
            this.aRTICULOSBindingNavigator.TabIndex = 0;
            this.aRTICULOSBindingNavigator.Text = "bindingNavigator1";
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
            // aRTICULOSBindingNavigatorSaveItem
            // 
            this.aRTICULOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.aRTICULOSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("aRTICULOSBindingNavigatorSaveItem.Image")));
            this.aRTICULOSBindingNavigatorSaveItem.Name = "aRTICULOSBindingNavigatorSaveItem";
            this.aRTICULOSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.aRTICULOSBindingNavigatorSaveItem.Text = "Save Data";
            this.aRTICULOSBindingNavigatorSaveItem.Click += new System.EventHandler(this.aRTICULOSBindingNavigatorSaveItem_Click);
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.aRTICULOSDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.aRTICULOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aRTICULOSDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.aRTICULOSDataGridView.DataSource = this.aRTICULOSBindingSource;
            this.aRTICULOSDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.aRTICULOSDataGridView.Location = new System.Drawing.Point(6, 44);
            this.aRTICULOSDataGridView.Name = "aRTICULOSDataGridView";
            this.aRTICULOSDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.aRTICULOSDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.aRTICULOSDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.aRTICULOSDataGridView.Size = new System.Drawing.Size(847, 254);
            this.aRTICULOSDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "descripcion";
            this.dataGridViewTextBoxColumn2.HeaderText = "Descripción";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idCategoria";
            this.dataGridViewTextBoxColumn3.HeaderText = "Categoría";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "costoUnitario";
            this.dataGridViewTextBoxColumn4.HeaderText = "Costo Unitario";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "precioUnitario";
            this.dataGridViewTextBoxColumn5.HeaderText = "Precio Unitario";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "stock";
            this.dataGridViewTextBoxColumn6.HeaderText = "Stock";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "estado";
            this.dataGridViewTextBoxColumn7.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRTICULOSBindingSource, "descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(130, 39);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(456, 23);
            this.descripcionTextBox.TabIndex = 5;
            // 
            // idCategoriaComboBox
            // 
            this.idCategoriaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.aRTICULOSBindingSource, "idCategoria", true));
            this.idCategoriaComboBox.DataSource = this.cATEGORIABindingSource;
            this.idCategoriaComboBox.DisplayMember = "descripcion";
            this.idCategoriaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.idCategoriaComboBox.FormattingEnabled = true;
            this.idCategoriaComboBox.Location = new System.Drawing.Point(130, 65);
            this.idCategoriaComboBox.Name = "idCategoriaComboBox";
            this.idCategoriaComboBox.Size = new System.Drawing.Size(456, 24);
            this.idCategoriaComboBox.TabIndex = 7;
            this.idCategoriaComboBox.ValueMember = "id";
            // 
            // cATEGORIABindingSource
            // 
            this.cATEGORIABindingSource.DataMember = "CATEGORIA";
            this.cATEGORIABindingSource.DataSource = this.fACTURACIONDataSet;
            // 
            // costoUnitarioTextBox
            // 
            this.costoUnitarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRTICULOSBindingSource, "costoUnitario", true));
            this.costoUnitarioTextBox.Location = new System.Drawing.Point(130, 92);
            this.costoUnitarioTextBox.Name = "costoUnitarioTextBox";
            this.costoUnitarioTextBox.Size = new System.Drawing.Size(456, 23);
            this.costoUnitarioTextBox.TabIndex = 9;
            // 
            // precioUnitarioTextBox
            // 
            this.precioUnitarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRTICULOSBindingSource, "precioUnitario", true));
            this.precioUnitarioTextBox.Location = new System.Drawing.Point(130, 118);
            this.precioUnitarioTextBox.Name = "precioUnitarioTextBox";
            this.precioUnitarioTextBox.Size = new System.Drawing.Size(456, 23);
            this.precioUnitarioTextBox.TabIndex = 11;
            // 
            // stockTextBox
            // 
            this.stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRTICULOSBindingSource, "stock", true));
            this.stockTextBox.Location = new System.Drawing.Point(130, 144);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(456, 23);
            this.stockTextBox.TabIndex = 13;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.aRTICULOSBindingSource, "estado", true));
            this.estadoComboBox.DisplayMember = "Value";
            this.estadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Location = new System.Drawing.Point(130, 170);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(456, 24);
            this.estadoComboBox.TabIndex = 15;
            this.estadoComboBox.ValueMember = "Key";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idLabel2);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.estadoComboBox);
            this.groupBox1.Controls.Add(estadoLabel);
            this.groupBox1.Controls.Add(descripcionLabel);
            this.groupBox1.Controls.Add(this.stockTextBox);
            this.groupBox1.Controls.Add(this.descripcionTextBox);
            this.groupBox1.Controls.Add(stockLabel);
            this.groupBox1.Controls.Add(idCategoriaLabel);
            this.groupBox1.Controls.Add(this.precioUnitarioTextBox);
            this.groupBox1.Controls.Add(this.idCategoriaComboBox);
            this.groupBox1.Controls.Add(precioUnitarioLabel);
            this.groupBox1.Controls.Add(costoUnitarioLabel);
            this.groupBox1.Controls.Add(this.costoUnitarioTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(11, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 208);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Articulo";
            // 
            // idLabel2
            // 
            this.idLabel2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aRTICULOSBindingSource, "id", true));
            this.idLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel2.Location = new System.Drawing.Point(127, 17);
            this.idLabel2.Name = "idLabel2";
            this.idLabel2.Size = new System.Drawing.Size(100, 23);
            this.idLabel2.TabIndex = 16;
            this.idLabel2.Text = "label1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.aRTICULOSDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(11, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(861, 305);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Articulos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(602, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 26);
            this.button1.TabIndex = 19;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.fillByDescripcion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(122, 28);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(405, 23);
            this.txtDescripcion.TabIndex = 21;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDescripcion);
            this.groupBox3.Controls.Add(this.btnLimpiarFiltros);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(11, 49);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(861, 70);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtros";
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(722, 26);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(111, 26);
            this.btnLimpiarFiltros.TabIndex = 19;
            this.btnLimpiarFiltros.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // vendedoresTableAdapter1
            // 
            this.vendedoresTableAdapter1.ClearBeforeFill = true;
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 666);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.aRTICULOSBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmArticulos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento Articulos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmArticulos_FormClosed);
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fACTURACIONDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSBindingNavigator)).EndInit();
            this.aRTICULOSBindingNavigator.ResumeLayout(false);
            this.aRTICULOSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIABindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FACTURACIONDataSet fACTURACIONDataSet;
        private System.Windows.Forms.BindingSource aRTICULOSBindingSource;
        private FACTURACIONDataSetTableAdapters.ARTICULOSTableAdapter aRTICULOSTableAdapter;
        private FACTURACIONDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator aRTICULOSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton aRTICULOSBindingNavigatorSaveItem;
        private FACTURACIONDataSetTableAdapters.CATEGORIATableAdapter cATEGORIATableAdapter;
        private System.Windows.Forms.DataGridView aRTICULOSDataGridView;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.ComboBox idCategoriaComboBox;
        private System.Windows.Forms.TextBox costoUnitarioTextBox;
        private System.Windows.Forms.TextBox precioUnitarioTextBox;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.BindingSource cATEGORIABindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
       
        private System.Windows.Forms.Label idLabel2;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private FACTURACIONDataSetTableAdapters.VENDEDORESTableAdapter vendedoresTableAdapter1;





























    }
}