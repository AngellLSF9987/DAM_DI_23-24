﻿namespace Tienda
{
    partial class FormAltaArticulo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAltaArticulo));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.labelFecha = new System.Windows.Forms.Label();
            this.labelHora = new System.Windows.Forms.Label();
            this.panelTimerTick = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerHoraActual = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNombreArticulo = new System.Windows.Forms.TextBox();
            this.comboBoxSelectCategoria = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.labelCantidadArticulo = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DataGridViewArticulos = new System.Windows.Forms.DataGridView();
            this.CodigoArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExistenciasArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panelTimerTick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Altas Artículos";
            // 
            // btnInicio
            // 
            this.btnInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInicio.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnInicio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.btnInicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInicio.ForeColor = System.Drawing.Color.LightCyan;
            this.btnInicio.Location = new System.Drawing.Point(1030, 566);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(145, 37);
            this.btnInicio.TabIndex = 1;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseCompatibleTextRendering = true;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(430, 53);
            this.labelFecha.MinimumSize = new System.Drawing.Size(300, 25);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(300, 25);
            this.labelFecha.TabIndex = 14;
            this.labelFecha.Text = "labelFecha";
            this.labelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelHora.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelHora.Location = new System.Drawing.Point(12, 22);
            this.labelHora.MinimumSize = new System.Drawing.Size(230, 25);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(230, 25);
            this.labelHora.TabIndex = 13;
            this.labelHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTimerTick
            // 
            this.panelTimerTick.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTimerTick.Controls.Add(this.labelHora);
            this.panelTimerTick.Controls.Add(this.pictureBox1);
            this.panelTimerTick.Location = new System.Drawing.Point(853, 16);
            this.panelTimerTick.Name = "panelTimerTick";
            this.panelTimerTick.Size = new System.Drawing.Size(328, 67);
            this.panelTimerTick.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tienda.Properties.Resources.logoComGreen;
            this.pictureBox1.Location = new System.Drawing.Point(253, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // timerHoraActual
            // 
            this.timerHoraActual.Tick += new System.EventHandler(this.timerHoraActual_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 18);
            this.label3.TabIndex = 16;
            this.label3.Text = "Nombre Articulo :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(344, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 18);
            this.label4.TabIndex = 17;
            this.label4.Text = "Categoria Articulo :";
            // 
            // textBoxNombreArticulo
            // 
            this.textBoxNombreArticulo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxNombreArticulo.ForeColor = System.Drawing.Color.White;
            this.textBoxNombreArticulo.Location = new System.Drawing.Point(28, 144);
            this.textBoxNombreArticulo.Name = "textBoxNombreArticulo";
            this.textBoxNombreArticulo.Size = new System.Drawing.Size(296, 23);
            this.textBoxNombreArticulo.TabIndex = 30;
            this.textBoxNombreArticulo.Text = "Escriba aquí el Nombre del Nuevo Artículo ...";
            this.textBoxNombreArticulo.Click += new System.EventHandler(this.textBoxNombreArticulo_TextChanged);
            // 
            // comboBoxSelectCategoria
            // 
            this.comboBoxSelectCategoria.BackColor = System.Drawing.Color.DarkSlateGray;
            this.comboBoxSelectCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxSelectCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxSelectCategoria.ForeColor = System.Drawing.Color.White;
            this.comboBoxSelectCategoria.FormattingEnabled = true;
            this.comboBoxSelectCategoria.Items.AddRange(new object[] {
            "Colección Smartphones",
            "Colección PCs Sobremesa",
            "Colección PCs Portátiles"});
            this.comboBoxSelectCategoria.Location = new System.Drawing.Point(347, 144);
            this.comboBoxSelectCategoria.Name = "comboBoxSelectCategoria";
            this.comboBoxSelectCategoria.Size = new System.Drawing.Size(276, 23);
            this.comboBoxSelectCategoria.TabIndex = 21;
            this.comboBoxSelectCategoria.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelectCategoria_SelectedIndexChanged);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRegistrar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.LightCyan;
            this.btnRegistrar.Location = new System.Drawing.Point(27, 566);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(145, 37);
            this.btnRegistrar.TabIndex = 24;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseCompatibleTextRendering = true;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // labelCantidadArticulo
            // 
            this.labelCantidadArticulo.AutoSize = true;
            this.labelCantidadArticulo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCantidadArticulo.Location = new System.Drawing.Point(643, 111);
            this.labelCantidadArticulo.Name = "labelCantidadArticulo";
            this.labelCantidadArticulo.Size = new System.Drawing.Size(208, 18);
            this.labelCantidadArticulo.TabIndex = 27;
            this.labelCantidadArticulo.Text = "Cantidad (Uds./Articulo) :";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxCantidad.ForeColor = System.Drawing.Color.White;
            this.textBoxCantidad.Location = new System.Drawing.Point(646, 144);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(205, 23);
            this.textBoxCantidad.TabIndex = 0;
            this.textBoxCantidad.Text = "Define Cantidad Disponible ...";
            this.textBoxCantidad.Click += new System.EventHandler(this.textBoxCantidad_TextChanged);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpiar.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.LightCyan;
            this.btnLimpiar.Location = new System.Drawing.Point(205, 566);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(145, 37);
            this.btnLimpiar.TabIndex = 31;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseCompatibleTextRendering = true;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.BackColor = System.Drawing.Color.DarkSlateGray;
            this.labelTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTotal.Location = new System.Drawing.Point(870, 147);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(2, 20);
            this.labelTotal.TabIndex = 26;
            this.labelTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(867, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 18);
            this.label6.TabIndex = 19;
            this.label6.Text = "Precio (Ud./€) :";
            // 
            // DataGridViewArticulos
            // 
            this.DataGridViewArticulos.AllowUserToAddRows = false;
            this.DataGridViewArticulos.AllowUserToDeleteRows = false;
            this.DataGridViewArticulos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DataGridViewArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataGridViewArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoArticulo,
            this.NombreArticulo,
            this.Categoria,
            this.PrecioArticulo,
            this.ExistenciasArticulo,
            this.Editar,
            this.Eliminar});
            this.DataGridViewArticulos.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DataGridViewArticulos.Location = new System.Drawing.Point(28, 173);
            this.DataGridViewArticulos.Name = "DataGridViewArticulos";
            this.DataGridViewArticulos.Size = new System.Drawing.Size(1153, 387);
            this.DataGridViewArticulos.TabIndex = 32;
            // 
            // CodigoArticulo
            // 
            this.CodigoArticulo.DataPropertyName = "CodigoArticulo";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Format = "N0";
            dataGridViewCellStyle1.NullValue = "null";
            this.CodigoArticulo.DefaultCellStyle = dataGridViewCellStyle1;
            this.CodigoArticulo.HeaderText = "Cod. Articulo";
            this.CodigoArticulo.Name = "CodigoArticulo";
            this.CodigoArticulo.ReadOnly = true;
            // 
            // NombreArticulo
            // 
            this.NombreArticulo.DataPropertyName = "NombreArticulo";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.NullValue = "null";
            this.NombreArticulo.DefaultCellStyle = dataGridViewCellStyle2;
            this.NombreArticulo.HeaderText = "Nombre Artículo";
            this.NombreArticulo.Name = "NombreArticulo";
            this.NombreArticulo.ReadOnly = true;
            this.NombreArticulo.Width = 280;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "null";
            this.Categoria.DefaultCellStyle = dataGridViewCellStyle3;
            this.Categoria.HeaderText = "Categoría";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 270;
            // 
            // PrecioArticulo
            // 
            this.PrecioArticulo.DataPropertyName = "PrecioArticulo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = "0,00";
            this.PrecioArticulo.DefaultCellStyle = dataGridViewCellStyle4;
            this.PrecioArticulo.HeaderText = "PVP Ud./€";
            this.PrecioArticulo.Name = "PrecioArticulo";
            this.PrecioArticulo.ReadOnly = true;
            this.PrecioArticulo.Width = 110;
            // 
            // ExistenciasArticulo
            // 
            this.ExistenciasArticulo.DataPropertyName = "ExistenciasArticulo";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Format = "N0";
            dataGridViewCellStyle5.NullValue = "0";
            this.ExistenciasArticulo.DefaultCellStyle = dataGridViewCellStyle5;
            this.ExistenciasArticulo.HeaderText = "Stock - Existencias";
            this.ExistenciasArticulo.Name = "ExistenciasArticulo";
            this.ExistenciasArticulo.ReadOnly = true;
            this.ExistenciasArticulo.Width = 149;
            // 
            // Editar
            // 
            this.Editar.DataPropertyName = "Editar";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle6.NullValue")));
            this.Editar.DefaultCellStyle = dataGridViewCellStyle6;
            this.Editar.HeaderText = "Editar";
            this.Editar.Image = global::Tienda.Properties.Resources.editVer;
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            // 
            // Eliminar
            // 
            this.Eliminar.DataPropertyName = "Eliminar";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = ((object)(resources.GetObject("dataGridViewCellStyle7.NullValue")));
            this.Eliminar.DefaultCellStyle = dataGridViewCellStyle7;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::Tienda.Properties.Resources.deleRoj;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            // 
            // FormAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1198, 615);
            this.Controls.Add(this.DataGridViewArticulos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.labelCantidadArticulo);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.comboBoxSelectCategoria);
            this.Controls.Add(this.textBoxNombreArticulo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.panelTimerTick);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(1198, 615);
            this.MinimumSize = new System.Drawing.Size(650, 400);
            this.Name = "FormAltaArticulo";
            this.Text = "AltaArticulo";
            this.Load += new System.EventHandler(this.FormAltaArticulo_Load);
            this.panelTimerTick.ResumeLayout(false);
            this.panelTimerTick.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Panel panelTimerTick;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerHoraActual;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNombreArticulo;
        private System.Windows.Forms.ComboBox comboBoxSelectCategoria;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label labelCantidadArticulo;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView DataGridViewArticulos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExistenciasArticulo;
        private System.Windows.Forms.DataGridViewImageColumn Editar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}