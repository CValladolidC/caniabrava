﻿namespace CaniaBrava
{
    partial class ui_updprogramacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpFecfin = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFecini = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.cmbCencos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbTipoHorarios = new System.Windows.Forms.ComboBox();
            this.btnAddAll = new System.Windows.Forms.Button();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.listEmpleados = new System.Windows.Forms.ListBox();
            this.listTipoHorarios = new System.Windows.Forms.ListBox();
            this.txtIdProg = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCia = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbGerencia = new System.Windows.Forms.ComboBox();
            this.lblTotalEmpleados = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtpFecfin);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpFecini);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtProg);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(826, 55);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // dtpFecfin
            // 
            this.dtpFecfin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecfin.Location = new System.Drawing.Point(604, 19);
            this.dtpFecfin.Name = "dtpFecfin";
            this.dtpFecfin.Size = new System.Drawing.Size(97, 20);
            this.dtpFecfin.TabIndex = 5;
            this.dtpFecfin.ValueChanged += new System.EventHandler(this.dtpFecfin_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(533, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Final:";
            // 
            // dtpFecini
            // 
            this.dtpFecini.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecini.Location = new System.Drawing.Point(432, 19);
            this.dtpFecini.Name = "dtpFecini";
            this.dtpFecini.Size = new System.Drawing.Size(95, 20);
            this.dtpFecini.TabIndex = 3;
            this.dtpFecini.ValueChanged += new System.EventHandler(this.dtpFecini_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha Inicio:";
            // 
            // txtProg
            // 
            this.txtProg.Location = new System.Drawing.Point(88, 17);
            this.txtProg.Name = "txtProg";
            this.txtProg.ReadOnly = true;
            this.txtProg.Size = new System.Drawing.Size(261, 20);
            this.txtProg.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Programacion:";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::CaniaBrava.Properties.Resources.GUARDAR;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(683, 522);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 3;
            this.btnGuardar.Text = "       Grabar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(409, 300);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(34, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = ">";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.Location = new System.Drawing.Point(409, 345);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(34, 23);
            this.btnDel.TabIndex = 5;
            this.btnDel.Text = "<";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // cmbCencos
            // 
            this.cmbCencos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCencos.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCencos.FormattingEnabled = true;
            this.cmbCencos.Location = new System.Drawing.Point(67, 121);
            this.cmbCencos.Name = "cmbCencos";
            this.cmbCencos.Size = new System.Drawing.Size(336, 20);
            this.cmbCencos.TabIndex = 6;
            this.cmbCencos.SelectedIndexChanged += new System.EventHandler(this.cmbCencos_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Área:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(446, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Tipos de Horario:";
            // 
            // cmbTipoHorarios
            // 
            this.cmbTipoHorarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoHorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoHorarios.FormattingEnabled = true;
            this.cmbTipoHorarios.Location = new System.Drawing.Point(540, 121);
            this.cmbTipoHorarios.Name = "cmbTipoHorarios";
            this.cmbTipoHorarios.Size = new System.Drawing.Size(299, 20);
            this.cmbTipoHorarios.TabIndex = 9;
            this.cmbTipoHorarios.SelectedIndexChanged += new System.EventHandler(this.cmbTipoHorarios_SelectedIndexChanged);
            // 
            // btnAddAll
            // 
            this.btnAddAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAll.Location = new System.Drawing.Point(409, 253);
            this.btnAddAll.Name = "btnAddAll";
            this.btnAddAll.Size = new System.Drawing.Size(34, 23);
            this.btnAddAll.TabIndex = 10;
            this.btnAddAll.Text = ">>";
            this.btnAddAll.UseVisualStyleBackColor = true;
            this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
            // 
            // btnDelAll
            // 
            this.btnDelAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelAll.Location = new System.Drawing.Point(409, 392);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(34, 23);
            this.btnDelAll.TabIndex = 11;
            this.btnDelAll.Text = "<<";
            this.btnDelAll.UseVisualStyleBackColor = true;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // listEmpleados
            // 
            this.listEmpleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listEmpleados.ForeColor = System.Drawing.SystemColors.Highlight;
            this.listEmpleados.FormattingEnabled = true;
            this.listEmpleados.ItemHeight = 12;
            this.listEmpleados.Location = new System.Drawing.Point(13, 155);
            this.listEmpleados.Name = "listEmpleados";
            this.listEmpleados.Size = new System.Drawing.Size(390, 352);
            this.listEmpleados.TabIndex = 12;
            // 
            // listTipoHorarios
            // 
            this.listTipoHorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTipoHorarios.FormattingEnabled = true;
            this.listTipoHorarios.ItemHeight = 12;
            this.listTipoHorarios.Location = new System.Drawing.Point(449, 155);
            this.listTipoHorarios.Name = "listTipoHorarios";
            this.listTipoHorarios.Size = new System.Drawing.Size(390, 352);
            this.listTipoHorarios.TabIndex = 13;
            // 
            // txtIdProg
            // 
            this.txtIdProg.Location = new System.Drawing.Point(303, 524);
            this.txtIdProg.Name = "txtIdProg";
            this.txtIdProg.Size = new System.Drawing.Size(100, 20);
            this.txtIdProg.TabIndex = 14;
            this.txtIdProg.Text = "0";
            this.txtIdProg.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "Empresa:";
            // 
            // cmbCia
            // 
            this.cmbCia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCia.FormattingEnabled = true;
            this.cmbCia.Location = new System.Drawing.Point(67, 67);
            this.cmbCia.Name = "cmbCia";
            this.cmbCia.Size = new System.Drawing.Size(336, 20);
            this.cmbCia.TabIndex = 15;
            this.cmbCia.SelectedIndexChanged += new System.EventHandler(this.cmbCia_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Gerencia:";
            // 
            // cmbGerencia
            // 
            this.cmbGerencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGerencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbGerencia.FormattingEnabled = true;
            this.cmbGerencia.Location = new System.Drawing.Point(67, 94);
            this.cmbGerencia.Name = "cmbGerencia";
            this.cmbGerencia.Size = new System.Drawing.Size(336, 20);
            this.cmbGerencia.TabIndex = 17;
            this.cmbGerencia.SelectedIndexChanged += new System.EventHandler(this.cmbGerencia_SelectedIndexChanged);
            // 
            // lblTotalEmpleados
            // 
            this.lblTotalEmpleados.AutoSize = true;
            this.lblTotalEmpleados.Location = new System.Drawing.Point(12, 513);
            this.lblTotalEmpleados.Name = "lblTotalEmpleados";
            this.lblTotalEmpleados.Size = new System.Drawing.Size(55, 13);
            this.lblTotalEmpleados.TabIndex = 19;
            this.lblTotalEmpleados.Text = "0 registros";
            // 
            // btnSalir
            // 
            this.btnSalir.Image = global::CaniaBrava.Properties.Resources.CLOSE;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(764, 522);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 20;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ui_updprogramacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 557);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblTotalEmpleados);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbGerencia);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCia);
            this.Controls.Add(this.txtIdProg);
            this.Controls.Add(this.listTipoHorarios);
            this.Controls.Add(this.listEmpleados);
            this.Controls.Add(this.btnDelAll);
            this.Controls.Add(this.btnAddAll);
            this.Controls.Add(this.cmbTipoHorarios);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbCencos);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(867, 596);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(867, 596);
            this.Name = "ui_updprogramacion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalle de la Programacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpFecfin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFecini;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.ComboBox cmbCencos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbTipoHorarios;
        private System.Windows.Forms.Button btnAddAll;
        private System.Windows.Forms.Button btnDelAll;
        private System.Windows.Forms.ListBox listEmpleados;
        private System.Windows.Forms.ListBox listTipoHorarios;
        private System.Windows.Forms.TextBox txtIdProg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCia;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbGerencia;
        private System.Windows.Forms.Label lblTotalEmpleados;
        private System.Windows.Forms.Button btnSalir;
    }
}