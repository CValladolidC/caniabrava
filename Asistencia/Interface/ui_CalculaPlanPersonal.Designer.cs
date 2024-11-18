﻿namespace CaniaBrava
{
    partial class ui_CalculaPlanPersonal
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
            this.lblprocesando = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtFechaFin = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFechaIni = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMesSem = new System.Windows.Forms.MaskedTextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoCal = new System.Windows.Forms.ComboBox();
            this.cmbTipoPlan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbTipoTrabajador = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolstripform = new System.Windows.Forms.ToolStrip();
            this.btnActualizar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtFecFinPerLab = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBoxBuscar = new System.Windows.Forms.PictureBox();
            this.lblF2 = new System.Windows.Forms.Label();
            this.txtFecIniPerLab = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtNroDocIden = new System.Windows.Forms.TextBox();
            this.txtDocIdent = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodigoInterno = new System.Windows.Forms.TextBox();
            this.lblPeriodo = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolstripform.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblprocesando
            // 
            this.lblprocesando.AutoSize = true;
            this.lblprocesando.BackColor = System.Drawing.Color.Blue;
            this.lblprocesando.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblprocesando.ForeColor = System.Drawing.Color.White;
            this.lblprocesando.Location = new System.Drawing.Point(8, 265);
            this.lblprocesando.Name = "lblprocesando";
            this.lblprocesando.Size = new System.Drawing.Size(84, 15);
            this.lblprocesando.TabIndex = 8;
            this.lblprocesando.Text = "PROCESANDO";
            this.lblprocesando.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtFechaFin);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtFechaIni);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtMesSem);
            this.groupBox2.Controls.Add(this.lblUsuario);
            this.groupBox2.Location = new System.Drawing.Point(300, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 106);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // txtFechaFin
            // 
            this.txtFechaFin.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtFechaFin.Enabled = false;
            this.txtFechaFin.Location = new System.Drawing.Point(80, 71);
            this.txtFechaFin.Mask = "00/00/0000";
            this.txtFechaFin.Name = "txtFechaFin";
            this.txtFechaFin.Size = new System.Drawing.Size(88, 20);
            this.txtFechaFin.TabIndex = 2;
            this.txtFechaFin.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 98;
            this.label2.Text = "Fecha Fin :";
            // 
            // txtFechaIni
            // 
            this.txtFechaIni.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtFechaIni.Enabled = false;
            this.txtFechaIni.Location = new System.Drawing.Point(80, 45);
            this.txtFechaIni.Mask = "00/00/0000";
            this.txtFechaIni.Name = "txtFechaIni";
            this.txtFechaIni.Size = new System.Drawing.Size(88, 20);
            this.txtFechaIni.TabIndex = 1;
            this.txtFechaIni.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 97;
            this.label1.Text = "Fecha Inicio :";
            // 
            // txtMesSem
            // 
            this.txtMesSem.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtMesSem.Location = new System.Drawing.Point(80, 19);
            this.txtMesSem.Mask = "99/9999";
            this.txtMesSem.Name = "txtMesSem";
            this.txtMesSem.Size = new System.Drawing.Size(88, 20);
            this.txtMesSem.TabIndex = 0;
            this.txtMesSem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMesSem_KeyPress);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(13, 23);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(52, 13);
            this.lblUsuario.TabIndex = 96;
            this.lblUsuario.Text = "Periodo  :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cmbTipoCal);
            this.groupBox1.Controls.Add(this.cmbTipoPlan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbTipoTrabajador);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(8, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 106);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 92;
            this.label5.Text = "Tipo Calendario :";
            // 
            // cmbTipoCal
            // 
            this.cmbTipoCal.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cmbTipoCal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoCal.FormattingEnabled = true;
            this.cmbTipoCal.Location = new System.Drawing.Point(106, 70);
            this.cmbTipoCal.Name = "cmbTipoCal";
            this.cmbTipoCal.Size = new System.Drawing.Size(164, 21);
            this.cmbTipoCal.TabIndex = 2;
            this.cmbTipoCal.SelectedIndexChanged += new System.EventHandler(this.cmbTipoCal_SelectedIndexChanged);
            // 
            // cmbTipoPlan
            // 
            this.cmbTipoPlan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoPlan.FormattingEnabled = true;
            this.cmbTipoPlan.Location = new System.Drawing.Point(106, 42);
            this.cmbTipoPlan.Name = "cmbTipoPlan";
            this.cmbTipoPlan.Size = new System.Drawing.Size(164, 21);
            this.cmbTipoPlan.TabIndex = 1;
            this.cmbTipoPlan.SelectedIndexChanged += new System.EventHandler(this.cmbTipoPlan_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 90;
            this.label4.Text = "Tipo de Planilla  :";
            // 
            // cmbTipoTrabajador
            // 
            this.cmbTipoTrabajador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoTrabajador.FormattingEnabled = true;
            this.cmbTipoTrabajador.Location = new System.Drawing.Point(106, 15);
            this.cmbTipoTrabajador.Name = "cmbTipoTrabajador";
            this.cmbTipoTrabajador.Size = new System.Drawing.Size(164, 21);
            this.cmbTipoTrabajador.TabIndex = 0;
            this.cmbTipoTrabajador.SelectedIndexChanged += new System.EventHandler(this.cmbTipoTrabajador_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 88;
            this.label3.Text = "Tipo de Personal  :";
            // 
            // toolstripform
            // 
            this.toolstripform.BackColor = System.Drawing.SystemColors.HighlightText;
            this.toolstripform.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolstripform.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnActualizar,
            this.toolStripSeparator1,
            this.btnSalir});
            this.toolstripform.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolstripform.Location = new System.Drawing.Point(0, 310);
            this.toolstripform.Name = "toolstripform";
            this.toolstripform.ShowItemToolTips = false;
            this.toolstripform.Size = new System.Drawing.Size(529, 25);
            this.toolstripform.TabIndex = 9;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = global::CaniaBrava.Properties.Resources.refresh;
            this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(72, 22);
            this.btnActualizar.Text = "Procesar";
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtFecFinPerLab);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.pictureBoxBuscar);
            this.groupBox3.Controls.Add(this.lblF2);
            this.groupBox3.Controls.Add(this.txtFecIniPerLab);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.txtNombres);
            this.groupBox3.Controls.Add(this.txtNroDocIden);
            this.groupBox3.Controls.Add(this.txtDocIdent);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.txtCodigoInterno);
            this.groupBox3.Location = new System.Drawing.Point(8, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(512, 148);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Trabajador";
            // 
            // txtFecFinPerLab
            // 
            this.txtFecFinPerLab.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtFecFinPerLab.Enabled = false;
            this.txtFecFinPerLab.Location = new System.Drawing.Point(152, 118);
            this.txtFecFinPerLab.Mask = "00/00/0000";
            this.txtFecFinPerLab.Name = "txtFecFinPerLab";
            this.txtFecFinPerLab.Size = new System.Drawing.Size(141, 20);
            this.txtFecFinPerLab.TabIndex = 58;
            this.txtFecFinPerLab.ValidatingType = typeof(System.DateTime);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 121);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "F. Fin Periodo Laboral :";
            // 
            // pictureBoxBuscar
            // 
            this.pictureBoxBuscar.Image = global::CaniaBrava.Properties.Resources.LOCATE;
            this.pictureBoxBuscar.Location = new System.Drawing.Point(321, 17);
            this.pictureBoxBuscar.Name = "pictureBoxBuscar";
            this.pictureBoxBuscar.Size = new System.Drawing.Size(24, 21);
            this.pictureBoxBuscar.TabIndex = 55;
            this.pictureBoxBuscar.TabStop = false;
            // 
            // lblF2
            // 
            this.lblF2.AutoSize = true;
            this.lblF2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblF2.Location = new System.Drawing.Point(299, 21);
            this.lblF2.Name = "lblF2";
            this.lblF2.Size = new System.Drawing.Size(21, 13);
            this.lblF2.TabIndex = 54;
            this.lblF2.Text = "F2";
            // 
            // txtFecIniPerLab
            // 
            this.txtFecIniPerLab.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtFecIniPerLab.Enabled = false;
            this.txtFecIniPerLab.Location = new System.Drawing.Point(152, 92);
            this.txtFecIniPerLab.Mask = "00/00/0000";
            this.txtFecIniPerLab.Name = "txtFecIniPerLab";
            this.txtFecIniPerLab.Size = new System.Drawing.Size(141, 20);
            this.txtFecIniPerLab.TabIndex = 3;
            this.txtFecIniPerLab.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "F. Inicio Periodo Laboral :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Documento de Identidad :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Apellidos y Nombres :";
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNombres.Enabled = false;
            this.txtNombres.Location = new System.Drawing.Point(152, 41);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(345, 20);
            this.txtNombres.TabIndex = 1;
            // 
            // txtNroDocIden
            // 
            this.txtNroDocIden.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNroDocIden.Enabled = false;
            this.txtNroDocIden.Location = new System.Drawing.Point(299, 65);
            this.txtNroDocIden.Name = "txtNroDocIden";
            this.txtNroDocIden.Size = new System.Drawing.Size(198, 20);
            this.txtNroDocIden.TabIndex = 3;
            // 
            // txtDocIdent
            // 
            this.txtDocIdent.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDocIdent.Enabled = false;
            this.txtDocIdent.Location = new System.Drawing.Point(152, 66);
            this.txtDocIdent.Name = "txtDocIdent";
            this.txtDocIdent.Size = new System.Drawing.Size(141, 20);
            this.txtDocIdent.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Código Interno :";
            // 
            // txtCodigoInterno
            // 
            this.txtCodigoInterno.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCodigoInterno.Location = new System.Drawing.Point(152, 17);
            this.txtCodigoInterno.MaxLength = 5;
            this.txtCodigoInterno.Name = "txtCodigoInterno";
            this.txtCodigoInterno.ReadOnly = true;
            this.txtCodigoInterno.Size = new System.Drawing.Size(141, 20);
            this.txtCodigoInterno.TabIndex = 0;
            this.txtCodigoInterno.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodigoInterno_KeyDown);
            this.txtCodigoInterno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoInterno_KeyPress);
            // 
            // lblPeriodo
            // 
            this.lblPeriodo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblPeriodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeriodo.ForeColor = System.Drawing.Color.White;
            this.lblPeriodo.Location = new System.Drawing.Point(316, 265);
            this.lblPeriodo.Name = "lblPeriodo";
            this.lblPeriodo.Size = new System.Drawing.Size(204, 24);
            this.lblPeriodo.TabIndex = 86;
            this.lblPeriodo.Text = "Periodo Laboral Cerrado";
            this.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPeriodo.Visible = false;
            // 
            // ui_CalculaPlanPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(529, 335);
            this.ControlBox = false;
            this.Controls.Add(this.lblPeriodo);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lblprocesando);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolstripform);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ui_CalculaPlanPersonal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cálculo de Planilla";
            this.Load += new System.EventHandler(this.ui_CalculaPlanPersonal_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolstripform.ResumeLayout(false);
            this.toolstripform.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblprocesando;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox txtFechaFin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox txtFechaIni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtMesSem;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipoCal;
        private System.Windows.Forms.ComboBox cmbTipoPlan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbTipoTrabajador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStrip toolstripform;
        public System.Windows.Forms.ToolStripButton btnActualizar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBoxBuscar;
        private System.Windows.Forms.Label lblF2;
        private System.Windows.Forms.MaskedTextBox txtFecIniPerLab;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtNombres;
        public System.Windows.Forms.TextBox txtNroDocIden;
        public System.Windows.Forms.TextBox txtDocIdent;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtCodigoInterno;
        private System.Windows.Forms.MaskedTextBox txtFecFinPerLab;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPeriodo;
    }
}