﻿namespace Examen
{
    partial class Form1
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
            this.PBancario = new System.Windows.Forms.Panel();
            this.GBdatosbancarios = new System.Windows.Forms.GroupBox();
            this.GBOperacion = new System.Windows.Forms.GroupBox();
            this.RBConsulta = new System.Windows.Forms.RadioButton();
            this.RBretiro = new System.Windows.Forms.RadioButton();
            this.RBDeposito = new System.Windows.Forms.RadioButton();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblFechaejecucion = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEdicion = new System.Windows.Forms.Button();
            this.GBdatospersonales = new System.Windows.Forms.GroupBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.GBSexo = new System.Windows.Forms.GroupBox();
            this.RBotro = new System.Windows.Forms.RadioButton();
            this.RBMasculino = new System.Windows.Forms.RadioButton();
            this.RBfemenino = new System.Windows.Forms.RadioButton();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.dateTimePickerNaciemiento = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEjecucion = new System.Windows.Forms.DateTimePicker();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.PBancario.SuspendLayout();
            this.GBdatosbancarios.SuspendLayout();
            this.GBOperacion.SuspendLayout();
            this.GBdatospersonales.SuspendLayout();
            this.GBSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // PBancario
            // 
            this.PBancario.Controls.Add(this.GBdatosbancarios);
            this.PBancario.Controls.Add(this.btnCancelar);
            this.PBancario.Controls.Add(this.btnEdicion);
            this.PBancario.Controls.Add(this.GBdatospersonales);
            this.PBancario.Location = new System.Drawing.Point(-2, -2);
            this.PBancario.Name = "PBancario";
            this.PBancario.Size = new System.Drawing.Size(804, 450);
            this.PBancario.TabIndex = 0;
            // 
            // GBdatosbancarios
            // 
            this.GBdatosbancarios.Controls.Add(this.dateTimePickerEjecucion);
            this.GBdatosbancarios.Controls.Add(this.GBOperacion);
            this.GBdatosbancarios.Controls.Add(this.btnLimpiar);
            this.GBdatosbancarios.Controls.Add(this.btnEjecutar);
            this.GBdatosbancarios.Controls.Add(this.txtSaldo);
            this.GBdatosbancarios.Controls.Add(this.txtCantidad);
            this.GBdatosbancarios.Controls.Add(this.lblSaldo);
            this.GBdatosbancarios.Controls.Add(this.lblFechaejecucion);
            this.GBdatosbancarios.Controls.Add(this.lblCantidad);
            this.GBdatosbancarios.Enabled = false;
            this.GBdatosbancarios.Location = new System.Drawing.Point(34, 243);
            this.GBdatosbancarios.Name = "GBdatosbancarios";
            this.GBdatosbancarios.Size = new System.Drawing.Size(598, 188);
            this.GBdatosbancarios.TabIndex = 3;
            this.GBdatosbancarios.TabStop = false;
            this.GBdatosbancarios.Text = "Datos Bancarios";
            // 
            // GBOperacion
            // 
            this.GBOperacion.Controls.Add(this.RBConsulta);
            this.GBOperacion.Controls.Add(this.RBretiro);
            this.GBOperacion.Controls.Add(this.RBDeposito);
            this.GBOperacion.Location = new System.Drawing.Point(22, 127);
            this.GBOperacion.Name = "GBOperacion";
            this.GBOperacion.Size = new System.Drawing.Size(303, 55);
            this.GBOperacion.TabIndex = 8;
            this.GBOperacion.TabStop = false;
            this.GBOperacion.Text = "Operacion";
            // 
            // RBConsulta
            // 
            this.RBConsulta.AutoSize = true;
            this.RBConsulta.Location = new System.Drawing.Point(200, 19);
            this.RBConsulta.Name = "RBConsulta";
            this.RBConsulta.Size = new System.Drawing.Size(66, 17);
            this.RBConsulta.TabIndex = 2;
            this.RBConsulta.TabStop = true;
            this.RBConsulta.Text = "Consulta";
            this.RBConsulta.UseVisualStyleBackColor = true;
            // 
            // RBretiro
            // 
            this.RBretiro.AutoSize = true;
            this.RBretiro.Location = new System.Drawing.Point(108, 19);
            this.RBretiro.Name = "RBretiro";
            this.RBretiro.Size = new System.Drawing.Size(53, 17);
            this.RBretiro.TabIndex = 1;
            this.RBretiro.TabStop = true;
            this.RBretiro.Text = "Retiro";
            this.RBretiro.UseVisualStyleBackColor = true;
            // 
            // RBDeposito
            // 
            this.RBDeposito.AutoSize = true;
            this.RBDeposito.Location = new System.Drawing.Point(11, 19);
            this.RBDeposito.Name = "RBDeposito";
            this.RBDeposito.Size = new System.Drawing.Size(67, 17);
            this.RBDeposito.TabIndex = 0;
            this.RBDeposito.TabStop = true;
            this.RBDeposito.Text = "Deposito";
            this.RBDeposito.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(387, 61);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 7;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Location = new System.Drawing.Point(387, 25);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(75, 23);
            this.btnEjecutar.TabIndex = 6;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            this.btnEjecutar.Click += new System.EventHandler(this.btnEjecutar_Click);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(76, 30);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(163, 20);
            this.txtCantidad.TabIndex = 3;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(19, 61);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblSaldo.TabIndex = 2;
            this.lblSaldo.Text = "Saldo:";
            this.lblSaldo.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblFechaejecucion
            // 
            this.lblFechaejecucion.AutoSize = true;
            this.lblFechaejecucion.Location = new System.Drawing.Point(17, 91);
            this.lblFechaejecucion.Name = "lblFechaejecucion";
            this.lblFechaejecucion.Size = new System.Drawing.Size(105, 13);
            this.lblFechaejecucion.TabIndex = 1;
            this.lblFechaejecucion.Text = "Fecha de Ejecucion:";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(17, 30);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 0;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(668, 85);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEdicion
            // 
            this.btnEdicion.Location = new System.Drawing.Point(668, 42);
            this.btnEdicion.Name = "btnEdicion";
            this.btnEdicion.Size = new System.Drawing.Size(75, 23);
            this.btnEdicion.TabIndex = 1;
            this.btnEdicion.Text = "Edicion";
            this.btnEdicion.UseVisualStyleBackColor = true;
            this.btnEdicion.Click += new System.EventHandler(this.btnEdicion_Click);
            // 
            // GBdatospersonales
            // 
            this.GBdatospersonales.Controls.Add(this.txtApellido);
            this.GBdatospersonales.Controls.Add(this.txtNombre);
            this.GBdatospersonales.Controls.Add(this.dateTimePickerNaciemiento);
            this.GBdatospersonales.Controls.Add(this.txtDireccion);
            this.GBdatospersonales.Controls.Add(this.lblDireccion);
            this.GBdatospersonales.Controls.Add(this.GBSexo);
            this.GBdatospersonales.Controls.Add(this.lblApellido);
            this.GBdatospersonales.Controls.Add(this.lblFechaNacimiento);
            this.GBdatospersonales.Controls.Add(this.lblNombre);
            this.GBdatospersonales.Enabled = false;
            this.GBdatospersonales.Location = new System.Drawing.Point(34, 33);
            this.GBdatospersonales.Name = "GBdatospersonales";
            this.GBdatospersonales.Size = new System.Drawing.Size(598, 204);
            this.GBdatospersonales.TabIndex = 0;
            this.GBdatospersonales.TabStop = false;
            this.GBdatospersonales.Text = "Datos Personales";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(446, 20);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(136, 119);
            this.txtDireccion.TabIndex = 5;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(384, 19);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 4;
            this.lblDireccion.Text = "Direccion:";
            // 
            // GBSexo
            // 
            this.GBSexo.Controls.Add(this.RBotro);
            this.GBSexo.Controls.Add(this.RBMasculino);
            this.GBSexo.Controls.Add(this.RBfemenino);
            this.GBSexo.Location = new System.Drawing.Point(10, 105);
            this.GBSexo.Name = "GBSexo";
            this.GBSexo.Size = new System.Drawing.Size(297, 69);
            this.GBSexo.TabIndex = 3;
            this.GBSexo.TabStop = false;
            this.GBSexo.Text = "Sexo";
            // 
            // RBotro
            // 
            this.RBotro.AutoSize = true;
            this.RBotro.Location = new System.Drawing.Point(198, 30);
            this.RBotro.Name = "RBotro";
            this.RBotro.Size = new System.Drawing.Size(45, 17);
            this.RBotro.TabIndex = 2;
            this.RBotro.TabStop = true;
            this.RBotro.Text = "Otro";
            this.RBotro.UseVisualStyleBackColor = true;
            // 
            // RBMasculino
            // 
            this.RBMasculino.AutoSize = true;
            this.RBMasculino.Location = new System.Drawing.Point(100, 30);
            this.RBMasculino.Name = "RBMasculino";
            this.RBMasculino.Size = new System.Drawing.Size(73, 17);
            this.RBMasculino.TabIndex = 1;
            this.RBMasculino.TabStop = true;
            this.RBMasculino.Text = "Masculino";
            this.RBMasculino.UseVisualStyleBackColor = true;
            // 
            // RBfemenino
            // 
            this.RBfemenino.AutoSize = true;
            this.RBfemenino.Location = new System.Drawing.Point(7, 30);
            this.RBfemenino.Name = "RBfemenino";
            this.RBfemenino.Size = new System.Drawing.Size(71, 17);
            this.RBfemenino.TabIndex = 0;
            this.RBfemenino.TabStop = true;
            this.RBfemenino.Text = "Femenino";
            this.RBfemenino.UseVisualStyleBackColor = true;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(7, 45);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(7, 76);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(111, 13);
            this.lblFechaNacimiento.TabIndex = 1;
            this.lblFechaNacimiento.Text = "Fecha de Nacimiento:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(7, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // dateTimePickerNaciemiento
            // 
            this.dateTimePickerNaciemiento.Location = new System.Drawing.Point(130, 76);
            this.dateTimePickerNaciemiento.Name = "dateTimePickerNaciemiento";
            this.dateTimePickerNaciemiento.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerNaciemiento.TabIndex = 6;
            // 
            // dateTimePickerEjecucion
            // 
            this.dateTimePickerEjecucion.Location = new System.Drawing.Point(125, 91);
            this.dateTimePickerEjecucion.Name = "dateTimePickerEjecucion";
            this.dateTimePickerEjecucion.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerEjecucion.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(76, 20);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(163, 20);
            this.txtNombre.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(76, 46);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(163, 20);
            this.txtApellido.TabIndex = 8;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Location = new System.Drawing.Point(76, 58);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.ReadOnly = true;
            this.txtSaldo.Size = new System.Drawing.Size(163, 20);
            this.txtSaldo.TabIndex = 4;
            this.txtSaldo.Text = "0";
            this.txtSaldo.TextChanged += new System.EventHandler(this.txtSaldo_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PBancario);
            this.Name = "Form1";
            this.Text = "Form1";
            this.PBancario.ResumeLayout(false);
            this.GBdatosbancarios.ResumeLayout(false);
            this.GBdatosbancarios.PerformLayout();
            this.GBOperacion.ResumeLayout(false);
            this.GBOperacion.PerformLayout();
            this.GBdatospersonales.ResumeLayout(false);
            this.GBdatospersonales.PerformLayout();
            this.GBSexo.ResumeLayout(false);
            this.GBSexo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PBancario;
        private System.Windows.Forms.GroupBox GBdatospersonales;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.GroupBox GBSexo;
        private System.Windows.Forms.RadioButton RBotro;
        private System.Windows.Forms.RadioButton RBMasculino;
        private System.Windows.Forms.RadioButton RBfemenino;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEdicion;
        private System.Windows.Forms.GroupBox GBdatosbancarios;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblFechaejecucion;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.GroupBox GBOperacion;
        private System.Windows.Forms.RadioButton RBConsulta;
        private System.Windows.Forms.RadioButton RBretiro;
        private System.Windows.Forms.RadioButton RBDeposito;
        private System.Windows.Forms.DateTimePicker dateTimePickerEjecucion;
        private System.Windows.Forms.DateTimePicker dateTimePickerNaciemiento;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtSaldo;
    }
}

