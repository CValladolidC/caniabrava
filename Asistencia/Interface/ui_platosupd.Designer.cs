﻿namespace CaniaBrava.Interface
{
    partial class ui_platosupd
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
            this.lblid = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbcomedor = new System.Windows.Forms.ComboBox();
            this.lblmensaje = new System.Windows.Forms.Label();
            this.lblplato = new System.Windows.Forms.Label();
            this.toolstripform = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.txtplato = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblTipoServicio = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.toolstripform.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Enabled = false;
            this.lblid.Location = new System.Drawing.Point(387, 5);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(15, 13);
            this.lblid.TabIndex = 61;
            this.lblid.Text = "id";
            this.lblid.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Comedor";
            // 
            // cmbcomedor
            // 
            this.cmbcomedor.DisplayMember = "SELECCIONE TIPO ------>";
            this.cmbcomedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbcomedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcomedor.FormattingEnabled = true;
            this.cmbcomedor.Location = new System.Drawing.Point(131, 17);
            this.cmbcomedor.Name = "cmbcomedor";
            this.cmbcomedor.Size = new System.Drawing.Size(179, 20);
            this.cmbcomedor.TabIndex = 59;
            // 
            // lblmensaje
            // 
            this.lblmensaje.AutoSize = true;
            this.lblmensaje.BackColor = System.Drawing.Color.SpringGreen;
            this.lblmensaje.Location = new System.Drawing.Point(247, 268);
            this.lblmensaje.Name = "lblmensaje";
            this.lblmensaje.Size = new System.Drawing.Size(169, 13);
            this.lblmensaje.TabIndex = 58;
            this.lblmensaje.Text = "Registro Actualizado con Exito...!!!";
            this.lblmensaje.Visible = false;
            // 
            // lblplato
            // 
            this.lblplato.AutoSize = true;
            this.lblplato.Location = new System.Drawing.Point(29, 193);
            this.lblplato.Name = "lblplato";
            this.lblplato.Size = new System.Drawing.Size(86, 13);
            this.lblplato.TabIndex = 57;
            this.lblplato.Text = "Nombre de Plato";
            // 
            // toolstripform
            // 
            this.toolstripform.BackColor = System.Drawing.SystemColors.HighlightText;
            this.toolstripform.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolstripform.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.btnGuardar,
            this.toolStripSeparator1,
            this.btnSalir});
            this.toolstripform.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolstripform.Location = new System.Drawing.Point(0, 263);
            this.toolstripform.Name = "toolstripform";
            this.toolstripform.ShowItemToolTips = false;
            this.toolstripform.Size = new System.Drawing.Size(432, 25);
            this.toolstripform.TabIndex = 56;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::CaniaBrava.Properties.Resources.SAVE;
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 22);
            this.btnGuardar.Text = "Guardar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::CaniaBrava.Properties.Resources.CLOSE;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(49, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtplato
            // 
            this.txtplato.Location = new System.Drawing.Point(131, 186);
            this.txtplato.Name = "txtplato";
            this.txtplato.Size = new System.Drawing.Size(281, 20);
            this.txtplato.TabIndex = 55;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(131, 143);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(179, 20);
            this.txtcantidad.TabIndex = 54;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(29, 146);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 53;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblTipoServicio
            // 
            this.lblTipoServicio.AutoSize = true;
            this.lblTipoServicio.Location = new System.Drawing.Point(27, 99);
            this.lblTipoServicio.Name = "lblTipoServicio";
            this.lblTipoServicio.Size = new System.Drawing.Size(84, 13);
            this.lblTipoServicio.TabIndex = 52;
            this.lblTipoServicio.Text = "Tipo de Servicio";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(27, 62);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 51;
            this.lblFecha.Text = "Fecha";
            // 
            // cmbServicio
            // 
            this.cmbServicio.DisplayMember = "SELECCIONE TIPO ------>";
            this.cmbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(131, 97);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(179, 20);
            this.cmbServicio.TabIndex = 50;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(131, 55);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(100, 20);
            this.dtpFecha.TabIndex = 49;
            // 
            // ui_platosupd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 288);
            this.ControlBox = false;
            this.Controls.Add(this.lblid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbcomedor);
            this.Controls.Add(this.lblmensaje);
            this.Controls.Add(this.lblplato);
            this.Controls.Add(this.toolstripform);
            this.Controls.Add(this.txtplato);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblTipoServicio);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.cmbServicio);
            this.Controls.Add(this.dtpFecha);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ui_platosupd";
            this.Text = "Editar Platos";
            this.Load += new System.EventHandler(this.ui_platosupd_Load);
            this.toolstripform.ResumeLayout(false);
            this.toolstripform.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbcomedor;
        private System.Windows.Forms.Label lblmensaje;
        private System.Windows.Forms.Label lblplato;
        private System.Windows.Forms.ToolStrip toolstripform;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.TextBox txtplato;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblTipoServicio;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox cmbServicio;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}