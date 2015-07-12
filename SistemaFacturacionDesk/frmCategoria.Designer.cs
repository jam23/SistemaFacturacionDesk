namespace SistemaFacturacionDesk
{
    partial class frmCategoria
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
            System.Windows.Forms.Label estadoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoria));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cATEGORIADataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cATEGORIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fACTURACIONDataSet = new SistemaFacturacionDesk.FACTURACIONDataSet();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idLabel1 = new System.Windows.Forms.Label();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.estadoComboBox = new System.Windows.Forms.ComboBox();
            this.cATEGORIABindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cATEGORIABindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.cATEGORIATableAdapter = new SistemaFacturacionDesk.FACTURACIONDataSetTableAdapters.CATEGORIATableAdapter();
            this.tableAdapterManager = new SistemaFacturacionDesk.FACTURACIONDataSetTableAdapters.TableAdapterManager();
            idLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            estadoLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIADataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURACIONDataSet)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIABindingNavigator)).BeginInit();
            this.cATEGORIABindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.BackColor = System.Drawing.Color.Transparent;
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(98, 36);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(26, 17);
            idLabel.TabIndex = 0;
            idLabel.Text = "Id:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.BackColor = System.Drawing.Color.Transparent;
            descripcionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descripcionLabel.Location = new System.Drawing.Point(28, 65);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(98, 17);
            descripcionLabel.TabIndex = 2;
            descripcionLabel.Text = "Descripción:";
            // 
            // estadoLabel
            // 
            estadoLabel.AutoSize = true;
            estadoLabel.BackColor = System.Drawing.Color.Transparent;
            estadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            estadoLabel.Location = new System.Drawing.Point(62, 94);
            estadoLabel.Name = "estadoLabel";
            estadoLabel.Size = new System.Drawing.Size(63, 17);
            estadoLabel.TabIndex = 4;
            estadoLabel.Text = "Estado:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = global::SistemaFacturacionDesk.Properties.Resources.frmBackgroundImage;
            this.groupBox2.Controls.Add(this.cATEGORIADataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 289);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(598, 286);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Categorías";
            // 
            // cATEGORIADataGridView
            // 
            this.cATEGORIADataGridView.AllowUserToAddRows = false;
            this.cATEGORIADataGridView.AllowUserToDeleteRows = false;
            this.cATEGORIADataGridView.AllowUserToResizeColumns = false;
            this.cATEGORIADataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cATEGORIADataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.cATEGORIADataGridView.AutoGenerateColumns = false;
            this.cATEGORIADataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cATEGORIADataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.cATEGORIADataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cATEGORIADataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.cATEGORIADataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cATEGORIADataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn});
            this.cATEGORIADataGridView.DataSource = this.cATEGORIABindingSource;
            this.cATEGORIADataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.cATEGORIADataGridView.Location = new System.Drawing.Point(6, 22);
            this.cATEGORIADataGridView.Name = "cATEGORIADataGridView";
            this.cATEGORIADataGridView.ReadOnly = true;
            this.cATEGORIADataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cATEGORIADataGridView.Size = new System.Drawing.Size(586, 254);
            this.cATEGORIADataGridView.TabIndex = 1;
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
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cATEGORIABindingSource
            // 
            this.cATEGORIABindingSource.DataMember = "CATEGORIA";
            this.cATEGORIABindingSource.DataSource = this.fACTURACIONDataSet;
            // 
            // fACTURACIONDataSet
            // 
            this.fACTURACIONDataSet.DataSetName = "FACTURACIONDataSet";
            this.fACTURACIONDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox3
            // 
            this.groupBox3.BackgroundImage = global::SistemaFacturacionDesk.Properties.Resources.frmBackgroundImage;
            this.groupBox3.Controls.Add(this.txtDescripcion);
            this.groupBox3.Controls.Add(this.btnLimpiarFiltros);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 47);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(598, 70);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtros";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(104, 28);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(217, 23);
            this.txtDescripcion.TabIndex = 21;
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(469, 26);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(111, 26);
            this.btnLimpiarFiltros.TabIndex = 19;
            this.btnLimpiarFiltros.Text = "Limpiar Filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(349, 27);
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
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Descripción:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackgroundImage = global::SistemaFacturacionDesk.Properties.Resources.frmBackgroundImage;
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idLabel1);
            this.groupBox1.Controls.Add(descripcionLabel);
            this.groupBox1.Controls.Add(this.descripcionTextBox);
            this.groupBox1.Controls.Add(estadoLabel);
            this.groupBox1.Controls.Add(this.estadoComboBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(598, 150);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categoría";
            // 
            // idLabel1
            // 
            this.idLabel1.BackColor = System.Drawing.Color.Transparent;
            this.idLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cATEGORIABindingSource, "id", true));
            this.idLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idLabel1.Location = new System.Drawing.Point(131, 36);
            this.idLabel1.Name = "idLabel1";
            this.idLabel1.Size = new System.Drawing.Size(121, 23);
            this.idLabel1.TabIndex = 1;
            this.idLabel1.Text = "label2";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cATEGORIABindingSource, "descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(131, 62);
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(284, 23);
            this.descripcionTextBox.TabIndex = 3;
            // 
            // estadoComboBox
            // 
            this.estadoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cATEGORIABindingSource, "estado", true));
            this.estadoComboBox.DisplayMember = "Value";
            this.estadoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoComboBox.FormattingEnabled = true;
            this.estadoComboBox.Location = new System.Drawing.Point(131, 91);
            this.estadoComboBox.Name = "estadoComboBox";
            this.estadoComboBox.Size = new System.Drawing.Size(284, 24);
            this.estadoComboBox.TabIndex = 5;
            this.estadoComboBox.ValueMember = "Key";
            // 
            // cATEGORIABindingNavigator
            // 
            this.cATEGORIABindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cATEGORIABindingNavigator.BindingSource = this.cATEGORIABindingSource;
            this.cATEGORIABindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cATEGORIABindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cATEGORIABindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cATEGORIABindingNavigatorSaveItem});
            this.cATEGORIABindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cATEGORIABindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cATEGORIABindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cATEGORIABindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cATEGORIABindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cATEGORIABindingNavigator.Name = "cATEGORIABindingNavigator";
            this.cATEGORIABindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cATEGORIABindingNavigator.Size = new System.Drawing.Size(630, 25);
            this.cATEGORIABindingNavigator.TabIndex = 21;
            this.cATEGORIABindingNavigator.Text = "bindingNavigator1";
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
            // cATEGORIABindingNavigatorSaveItem
            // 
            this.cATEGORIABindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cATEGORIABindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cATEGORIABindingNavigatorSaveItem.Image")));
            this.cATEGORIABindingNavigatorSaveItem.Name = "cATEGORIABindingNavigatorSaveItem";
            this.cATEGORIABindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cATEGORIABindingNavigatorSaveItem.Text = "Save Data";
            this.cATEGORIABindingNavigatorSaveItem.Click += new System.EventHandler(this.cATEGORIABindingNavigatorSaveItem_Click);
            // 
            // cATEGORIATableAdapter
            // 
            this.cATEGORIATableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ARTICULOSTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORIATableAdapter = this.cATEGORIATableAdapter;
            this.tableAdapterManager.CLIENTESTableAdapter = null;
            this.tableAdapterManager.CONDICIONESPAGOTableAdapter = null;
            this.tableAdapterManager.DETALLE_FACTURATableAdapter = null;
            this.tableAdapterManager.FACTURASTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SistemaFacturacionDesk.FACTURACIONDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VENDEDORESTableAdapter = null;
            // 
            // frmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SistemaFacturacionDesk.Properties.Resources.frmBackgroundImage;
            this.ClientSize = new System.Drawing.Size(630, 595);
            this.Controls.Add(this.cATEGORIABindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCategoria";
            this.Text = "frmCategoria";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCategoria_FormClosed);
            this.Load += new System.EventHandler(this.frmCategoria_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIADataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURACIONDataSet)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIABindingNavigator)).EndInit();
            this.cATEGORIABindingNavigator.ResumeLayout(false);
            this.cATEGORIABindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView cATEGORIADataGridView;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private FACTURACIONDataSet fACTURACIONDataSet;
        private System.Windows.Forms.BindingSource cATEGORIABindingSource;
        private FACTURACIONDataSetTableAdapters.CATEGORIATableAdapter cATEGORIATableAdapter;
        private FACTURACIONDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cATEGORIABindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cATEGORIABindingNavigatorSaveItem;
        private System.Windows.Forms.Label idLabel1;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.ComboBox estadoComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;

    }
}