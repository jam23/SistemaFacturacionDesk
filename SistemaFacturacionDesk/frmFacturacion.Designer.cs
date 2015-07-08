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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.rNC_CEDTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.nombreComercialTextBox = new System.Windows.Forms.TextBox();
            this.razonSocialTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.btnLimpiarCliente = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.idCondicionPagoComboBox = new System.Windows.Forms.ComboBox();
            this.comentarioTextBox = new System.Windows.Forms.TextBox();
            this.fechaRegistroDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.porcentajeDescuentoTextBox = new System.Windows.Forms.TextBox();
            this.iTBISTextBox = new System.Windows.Forms.TextBox();
            this.aRTICULOSDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAgregarArticulos = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
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
            idLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.Location = new System.Drawing.Point(127, 26);
            idLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(26, 17);
            idLabel.TabIndex = 32;
            idLabel.Text = "Id:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(fechaRegistroLabel);
            this.groupBox1.Controls.Add(this.fechaRegistroDateTimePicker);
            this.groupBox1.Controls.Add(idCondicionPagoLabel);
            this.groupBox1.Controls.Add(this.idCondicionPagoComboBox);
            this.groupBox1.Controls.Add(comentarioLabel);
            this.groupBox1.Controls.Add(this.comentarioTextBox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(952, 205);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información Factura";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregarArticulos);
            this.groupBox2.Controls.Add(this.aRTICULOSDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(16, 373);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(952, 263);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Articulos";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.idTextBox);
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
            this.groupBox4.Location = new System.Drawing.Point(16, 228);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(952, 137);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Datos Cliente";
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(161, 22);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(184, 23);
            this.idTextBox.TabIndex = 1;
            // 
            // rNC_CEDTextBox
            // 
            this.rNC_CEDTextBox.Location = new System.Drawing.Point(528, 22);
            this.rNC_CEDTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rNC_CEDTextBox.MaxLength = 11;
            this.rNC_CEDTextBox.Name = "rNC_CEDTextBox";
            this.rNC_CEDTextBox.ReadOnly = true;
            this.rNC_CEDTextBox.Size = new System.Drawing.Size(248, 23);
            this.rNC_CEDTextBox.TabIndex = 31;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.Location = new System.Drawing.Point(528, 54);
            this.telefonoTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.telefonoTextBox.MaxLength = 10;
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.ReadOnly = true;
            this.telefonoTextBox.Size = new System.Drawing.Size(248, 23);
            this.telefonoTextBox.TabIndex = 30;
            // 
            // nombreComercialTextBox
            // 
            this.nombreComercialTextBox.Location = new System.Drawing.Point(161, 54);
            this.nombreComercialTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombreComercialTextBox.Name = "nombreComercialTextBox";
            this.nombreComercialTextBox.ReadOnly = true;
            this.nombreComercialTextBox.Size = new System.Drawing.Size(263, 23);
            this.nombreComercialTextBox.TabIndex = 21;
            // 
            // razonSocialTextBox
            // 
            this.razonSocialTextBox.Location = new System.Drawing.Point(161, 89);
            this.razonSocialTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.razonSocialTextBox.Name = "razonSocialTextBox";
            this.razonSocialTextBox.ReadOnly = true;
            this.razonSocialTextBox.Size = new System.Drawing.Size(263, 23);
            this.razonSocialTextBox.TabIndex = 23;
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(528, 86);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.ReadOnly = true;
            this.emailTextBox.Size = new System.Drawing.Size(248, 23);
            this.emailTextBox.TabIndex = 26;
            // 
            // btnLimpiarCliente
            // 
            this.btnLimpiarCliente.Location = new System.Drawing.Point(801, 55);
            this.btnLimpiarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(127, 32);
            this.btnBuscarCliente.TabIndex = 19;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // idCondicionPagoLabel
            // 
            idCondicionPagoLabel.AutoSize = true;
            idCondicionPagoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idCondicionPagoLabel.Location = new System.Drawing.Point(17, 34);
            idCondicionPagoLabel.Name = "idCondicionPagoLabel";
            idCondicionPagoLabel.Size = new System.Drawing.Size(126, 17);
            idCondicionPagoLabel.TabIndex = 2;
            idCondicionPagoLabel.Text = "Condición Pago:";
            // 
            // idCondicionPagoComboBox
            // 
            this.idCondicionPagoComboBox.FormattingEnabled = true;
            this.idCondicionPagoComboBox.Location = new System.Drawing.Point(147, 31);
            this.idCondicionPagoComboBox.Name = "idCondicionPagoComboBox";
            this.idCondicionPagoComboBox.Size = new System.Drawing.Size(781, 24);
            this.idCondicionPagoComboBox.TabIndex = 3;
            this.idCondicionPagoComboBox.ValueMember = "id";
            // 
            // comentarioLabel
            // 
            comentarioLabel.AutoSize = true;
            comentarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            comentarioLabel.Location = new System.Drawing.Point(48, 92);
            comentarioLabel.Name = "comentarioLabel";
            comentarioLabel.Size = new System.Drawing.Size(95, 17);
            comentarioLabel.TabIndex = 14;
            comentarioLabel.Text = "Comentario:";
            // 
            // comentarioTextBox
            // 
            this.comentarioTextBox.Location = new System.Drawing.Point(147, 89);
            this.comentarioTextBox.Multiline = true;
            this.comentarioTextBox.Name = "comentarioTextBox";
            this.comentarioTextBox.Size = new System.Drawing.Size(781, 95);
            this.comentarioTextBox.TabIndex = 15;
            // 
            // fechaRegistroLabel
            // 
            fechaRegistroLabel.AutoSize = true;
            fechaRegistroLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaRegistroLabel.Location = new System.Drawing.Point(20, 65);
            fechaRegistroLabel.Name = "fechaRegistroLabel";
            fechaRegistroLabel.Size = new System.Drawing.Size(123, 17);
            fechaRegistroLabel.TabIndex = 15;
            fechaRegistroLabel.Text = "Fecha Registro:";
            // 
            // fechaRegistroDateTimePicker
            // 
            this.fechaRegistroDateTimePicker.Location = new System.Drawing.Point(147, 60);
            this.fechaRegistroDateTimePicker.Name = "fechaRegistroDateTimePicker";
            this.fechaRegistroDateTimePicker.Size = new System.Drawing.Size(781, 23);
            this.fechaRegistroDateTimePicker.TabIndex = 16;
            // 
            // porcentajeDescuentoLabel
            // 
            porcentajeDescuentoLabel.AutoSize = true;
            porcentajeDescuentoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            porcentajeDescuentoLabel.Location = new System.Drawing.Point(52, 719);
            porcentajeDescuentoLabel.Name = "porcentajeDescuentoLabel";
            porcentajeDescuentoLabel.Size = new System.Drawing.Size(173, 17);
            porcentajeDescuentoLabel.TabIndex = 12;
            porcentajeDescuentoLabel.Text = "Porcentaje Descuento:";
            // 
            // porcentajeDescuentoTextBox
            // 
            this.porcentajeDescuentoTextBox.Location = new System.Drawing.Point(229, 716);
            this.porcentajeDescuentoTextBox.Name = "porcentajeDescuentoTextBox";
            this.porcentajeDescuentoTextBox.Size = new System.Drawing.Size(608, 23);
            this.porcentajeDescuentoTextBox.TabIndex = 13;
            // 
            // iTBISLabel
            // 
            iTBISLabel.AutoSize = true;
            iTBISLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iTBISLabel.Location = new System.Drawing.Point(174, 693);
            iTBISLabel.Name = "iTBISLabel";
            iTBISLabel.Size = new System.Drawing.Size(51, 17);
            iTBISLabel.TabIndex = 14;
            iTBISLabel.Text = "ITBIS:";
            // 
            // iTBISTextBox
            // 
            this.iTBISTextBox.Location = new System.Drawing.Point(229, 690);
            this.iTBISTextBox.Name = "iTBISTextBox";
            this.iTBISTextBox.Size = new System.Drawing.Size(200, 23);
            this.iTBISTextBox.TabIndex = 15;
            // 
            // aRTICULOSDataGridView
            // 
            this.aRTICULOSDataGridView.AllowUserToAddRows = false;
            this.aRTICULOSDataGridView.AllowUserToDeleteRows = false;
            this.aRTICULOSDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.aRTICULOSDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.aRTICULOSDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.aRTICULOSDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.aRTICULOSDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.aRTICULOSDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.aRTICULOSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.aRTICULOSDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.aRTICULOSDataGridView.Location = new System.Drawing.Point(11, 23);
            this.aRTICULOSDataGridView.Name = "aRTICULOSDataGridView";
            this.aRTICULOSDataGridView.ReadOnly = true;
            this.aRTICULOSDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.aRTICULOSDataGridView.Size = new System.Drawing.Size(765, 103);
            this.aRTICULOSDataGridView.TabIndex = 2;
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
            // frmFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 753);
            this.Controls.Add(porcentajeDescuentoLabel);
            this.Controls.Add(this.porcentajeDescuentoTextBox);
            this.Controls.Add(iTBISLabel);
            this.Controls.Add(this.iTBISTextBox);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmFacturacion";
            this.Text = "Facturación de Articulos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFacturacion_FormClosed);
            this.Load += new System.EventHandler(this.frmFacturacion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aRTICULOSDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button btnLimpiarCliente;
        private System.Windows.Forms.ComboBox idCondicionPagoComboBox;
        private System.Windows.Forms.TextBox comentarioTextBox;
        private System.Windows.Forms.DateTimePicker fechaRegistroDateTimePicker;
        private System.Windows.Forms.TextBox porcentajeDescuentoTextBox;
        private System.Windows.Forms.TextBox iTBISTextBox;
        private System.Windows.Forms.Button btnAgregarArticulos;
        private System.Windows.Forms.DataGridView aRTICULOSDataGridView;

    }
}