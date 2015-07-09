namespace SistemaFacturacionDesk.Busquedas
{
    partial class frmBusquedaArticulo
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtFilterValue = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cATEGORIABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fACTURACIONDataSet = new SistemaFacturacionDesk.FACTURACIONDataSet();
            this.cLIENTESDataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioUnitarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aRTICULOSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aRTICULOSTableAdapter = new SistemaFacturacionDesk.FACTURACIONDataSetTableAdapters.ARTICULOSTableAdapter();
            this.tableAdapterManager = new SistemaFacturacionDesk.FACTURACIONDataSetTableAdapters.TableAdapterManager();
            this.cATEGORIATableAdapter = new SistemaFacturacionDesk.FACTURACIONDataSetTableAdapters.CATEGORIATableAdapter();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIABindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURACIONDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtFilterValue);
            this.groupBox3.Controls.Add(this.btnFiltrar);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(597, 78);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Filtros";
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Location = new System.Drawing.Point(77, 34);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.Size = new System.Drawing.Size(340, 23);
            this.txtFilterValue.TabIndex = 21;
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelar.Location = new System.Drawing.Point(638, 52);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 26);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(486, 29);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(73, 26);
            this.btnFiltrar.TabIndex = 19;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Buscar:";
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
            // cLIENTESDataGridView
            // 
            this.cLIENTESDataGridView.AllowUserToAddRows = false;
            this.cLIENTESDataGridView.AllowUserToDeleteRows = false;
            this.cLIENTESDataGridView.AutoGenerateColumns = false;
            this.cLIENTESDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.cLIENTESDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cLIENTESDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.costoUnitarioDataGridViewTextBoxColumn,
            this.precioUnitarioDataGridViewTextBoxColumn,
            this.stockDataGridViewTextBoxColumn});
            this.cLIENTESDataGridView.DataSource = this.aRTICULOSBindingSource;
            this.cLIENTESDataGridView.Location = new System.Drawing.Point(12, 126);
            this.cLIENTESDataGridView.Name = "cLIENTESDataGridView";
            this.cLIENTESDataGridView.ReadOnly = true;
            this.cLIENTESDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.cLIENTESDataGridView.Size = new System.Drawing.Size(759, 220);
            this.cLIENTESDataGridView.TabIndex = 25;
            this.cLIENTESDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cLIENTESDataGridView_CellDoubleClick);
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
            // costoUnitarioDataGridViewTextBoxColumn
            // 
            this.costoUnitarioDataGridViewTextBoxColumn.DataPropertyName = "costoUnitario";
            this.costoUnitarioDataGridViewTextBoxColumn.HeaderText = "Costo Unitario";
            this.costoUnitarioDataGridViewTextBoxColumn.Name = "costoUnitarioDataGridViewTextBoxColumn";
            this.costoUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // precioUnitarioDataGridViewTextBoxColumn
            // 
            this.precioUnitarioDataGridViewTextBoxColumn.DataPropertyName = "precioUnitario";
            this.precioUnitarioDataGridViewTextBoxColumn.HeaderText = "Precio Unitario";
            this.precioUnitarioDataGridViewTextBoxColumn.Name = "precioUnitarioDataGridViewTextBoxColumn";
            this.precioUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockDataGridViewTextBoxColumn
            // 
            this.stockDataGridViewTextBoxColumn.DataPropertyName = "stock";
            this.stockDataGridViewTextBoxColumn.HeaderText = "Stock";
            this.stockDataGridViewTextBoxColumn.Name = "stockDataGridViewTextBoxColumn";
            this.stockDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aRTICULOSBindingSource
            // 
            this.aRTICULOSBindingSource.AllowNew = false;
            this.aRTICULOSBindingSource.DataMember = "ARTICULOS";
            this.aRTICULOSBindingSource.DataSource = this.fACTURACIONDataSet;
            this.aRTICULOSBindingSource.Filter = "estado = \'A\'";
            // 
            // aRTICULOSTableAdapter
            // 
            this.aRTICULOSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ARTICULOSTableAdapter = this.aRTICULOSTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CATEGORIATableAdapter = null;
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
            // frmBusquedaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancelar;
            this.ClientSize = new System.Drawing.Size(781, 363);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.cLIENTESDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmBusquedaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBusquedaArticulo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBusquedaArticulo_FormClosing);
            this.Load += new System.EventHandler(this.frmBusquedaArticulo_Load);
            this.VisibleChanged += new System.EventHandler(this.frmBusquedaArticulo_VisibleChanged);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cATEGORIABindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fACTURACIONDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLIENTESDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtFilterValue;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.DataGridView cLIENTESDataGridView;
        private FACTURACIONDataSet fACTURACIONDataSet;
        private System.Windows.Forms.BindingSource aRTICULOSBindingSource;
        private FACTURACIONDataSetTableAdapters.ARTICULOSTableAdapter aRTICULOSTableAdapter;
        private FACTURACIONDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource cATEGORIABindingSource;
        private FACTURACIONDataSetTableAdapters.CATEGORIATableAdapter cATEGORIATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioUnitarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockDataGridViewTextBoxColumn;
    }
}