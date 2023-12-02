﻿namespace Tienda
{
    partial class FormDetallePedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDetallePedido));
            this.groupBoxDetallePedido = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxArticulos = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxCategorias = new System.Windows.Forms.ComboBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.timerHoraActual = new System.Windows.Forms.Timer(this.components);
            this.panelTimerTick = new System.Windows.Forms.Panel();
            this.labelHora = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.listViewPedidos = new System.Windows.Forms.ListView();
            this.Acciones = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CodigoPedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CantidadPedido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CodigoCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TipoPago = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PorcentajeDescuentoRecargoTipoPago = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PrecioFinal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBoxDetallePedido.SuspendLayout();
            this.panelTimerTick.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDetallePedido
            // 
            this.groupBoxDetallePedido.Controls.Add(this.label3);
            this.groupBoxDetallePedido.Controls.Add(this.comboBoxArticulos);
            this.groupBoxDetallePedido.Controls.Add(this.label7);
            this.groupBoxDetallePedido.Controls.Add(this.labelTotal);
            this.groupBoxDetallePedido.Controls.Add(this.textBoxCantidad);
            this.groupBoxDetallePedido.Controls.Add(this.label5);
            this.groupBoxDetallePedido.Controls.Add(this.label1);
            this.groupBoxDetallePedido.Controls.Add(this.comboBoxCategorias);
            this.groupBoxDetallePedido.Location = new System.Drawing.Point(13, 74);
            this.groupBoxDetallePedido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxDetallePedido.MaximumSize = new System.Drawing.Size(1198, 615);
            this.groupBoxDetallePedido.Name = "groupBoxDetallePedido";
            this.groupBoxDetallePedido.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBoxDetallePedido.Size = new System.Drawing.Size(1172, 141);
            this.groupBoxDetallePedido.TabIndex = 3;
            this.groupBoxDetallePedido.TabStop = false;
            this.groupBoxDetallePedido.Text = "Pedidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(592, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Selecciona Artículo :";
            // 
            // comboBoxArticulos
            // 
            this.comboBoxArticulos.BackColor = System.Drawing.Color.DarkSlateGray;
            this.comboBoxArticulos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxArticulos.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBoxArticulos.FormattingEnabled = true;
            this.comboBoxArticulos.Location = new System.Drawing.Point(656, 40);
            this.comboBoxArticulos.Name = "comboBoxArticulos";
            this.comboBoxArticulos.Size = new System.Drawing.Size(443, 23);
            this.comboBoxArticulos.TabIndex = 8;
            this.comboBoxArticulos.Text = "Pinche para elegir Artículo ...";
            this.comboBoxArticulos.SelectedIndexChanged += new System.EventHandler(this.comboBoxSelecArticulos_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(767, 94);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total Pedido/.€";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(961, 94);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(86, 18);
            this.labelTotal.TabIndex = 7;
            this.labelTotal.Text = "labelTotal";
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBoxCantidad.ForeColor = System.Drawing.SystemColors.Window;
            this.textBoxCantidad.Location = new System.Drawing.Point(478, 94);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(132, 23);
            this.textBoxCantidad.TabIndex = 7;
            this.textBoxCantidad.Text = "...";
            this.textBoxCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCantidad.Click += new System.EventHandler(this.textBoxCantidad_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(321, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Uds./Artículo :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecciona Categoría :";
            // 
            // comboBoxCategorias
            // 
            this.comboBoxCategorias.BackColor = System.Drawing.Color.DarkSlateGray;
            this.comboBoxCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxCategorias.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBoxCategorias.FormattingEnabled = true;
            this.comboBoxCategorias.Location = new System.Drawing.Point(119, 40);
            this.comboBoxCategorias.Name = "comboBoxCategorias";
            this.comboBoxCategorias.Size = new System.Drawing.Size(443, 23);
            this.comboBoxCategorias.TabIndex = 0;
            this.comboBoxCategorias.Text = "Pinche para elegir Categoría ...";
            this.comboBoxCategorias.SelectedIndexChanged += new System.EventHandler(this.ComboBoxCategorias_SelectedIndexChanged);
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(429, 44);
            this.labelFecha.MinimumSize = new System.Drawing.Size(300, 25);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(300, 25);
            this.labelFecha.TabIndex = 4;
            this.labelFecha.Text = "labelFecha";
            this.labelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(329, 37);
            this.label6.TabIndex = 5;
            this.label6.Text = "Registro de Pedidos";
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
            this.btnInicio.Location = new System.Drawing.Point(557, 587);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(117, 25);
            this.btnInicio.TabIndex = 8;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseCompatibleTextRendering = true;
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
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
            this.btnRegistrar.Location = new System.Drawing.Point(546, 221);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(163, 36);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar Pedido";
            this.btnRegistrar.UseCompatibleTextRendering = true;
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
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
            this.btnLimpiar.Location = new System.Drawing.Point(988, 221);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(145, 36);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseCompatibleTextRendering = true;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // timerHoraActual
            // 
            this.timerHoraActual.Tick += new System.EventHandler(this.timerHoraActual_Tick);
            // 
            // panelTimerTick
            // 
            this.panelTimerTick.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTimerTick.Controls.Add(this.labelHora);
            this.panelTimerTick.Controls.Add(this.pictureBox1);
            this.panelTimerTick.Location = new System.Drawing.Point(856, 7);
            this.panelTimerTick.Name = "panelTimerTick";
            this.panelTimerTick.Size = new System.Drawing.Size(328, 67);
            this.panelTimerTick.TabIndex = 12;
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(253, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAñadir.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAñadir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAñadir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAñadir.FlatAppearance.BorderSize = 0;
            this.btnAñadir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LawnGreen;
            this.btnAñadir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.btnAñadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAñadir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.ForeColor = System.Drawing.Color.LightCyan;
            this.btnAñadir.Location = new System.Drawing.Point(64, 221);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(145, 36);
            this.btnAñadir.TabIndex = 15;
            this.btnAñadir.Text = "Añadir Articulo";
            this.btnAñadir.UseCompatibleTextRendering = true;
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // listViewPedidos
            // 
            this.listViewPedidos.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.listViewPedidos.BackColor = System.Drawing.Color.Silver;
            this.listViewPedidos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Acciones,
            this.CodigoPedido,
            this.CantidadPedido,
            this.CodigoCliente,
            this.TipoPago,
            this.PorcentajeDescuentoRecargoTipoPago,
            this.PrecioFinal});
            this.listViewPedidos.FullRowSelect = true;
            this.listViewPedidos.GridLines = true;
            this.listViewPedidos.HideSelection = false;
            this.listViewPedidos.Location = new System.Drawing.Point(13, 305);
            this.listViewPedidos.Name = "listViewPedidos";
            this.listViewPedidos.Size = new System.Drawing.Size(1171, 237);
            this.listViewPedidos.TabIndex = 16;
            this.listViewPedidos.UseCompatibleStateImageBehavior = false;
            this.listViewPedidos.View = System.Windows.Forms.View.Details;
            this.listViewPedidos.VirtualMode = true;
            // 
            // Acciones
            // 
            this.Acciones.Text = "Acciones";
            this.Acciones.Width = 105;
            // 
            // CodigoPedido
            // 
            this.CodigoPedido.Text = "Cod. Pedido";
            this.CodigoPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CodigoPedido.Width = 105;
            // 
            // CantidadPedido
            // 
            this.CantidadPedido.Text = "Uds. / Pedido";
            this.CantidadPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CantidadPedido.Width = 120;
            // 
            // CodigoCliente
            // 
            this.CodigoCliente.Text = "Cod. Cliente";
            this.CodigoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CodigoCliente.Width = 105;
            // 
            // TipoPago
            // 
            this.TipoPago.Text = "Tipo de Pago";
            this.TipoPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TipoPago.Width = 280;
            // 
            // PorcentajeDescuentoRecargoTipoPago
            // 
            this.PorcentajeDescuentoRecargoTipoPago.Text = "Descuento o Recargo Aplicable - Tipo de Pago";
            this.PorcentajeDescuentoRecargoTipoPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PorcentajeDescuentoRecargoTipoPago.Width = 310;
            // 
            // PrecioFinal
            // 
            this.PrecioFinal.Text = "Precio Final / PVP .€";
            this.PrecioFinal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PrecioFinal.Width = 142;
            // 
            // FormDetallePedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1198, 615);
            this.Controls.Add(this.listViewPedidos);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.panelTimerTick);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.btnInicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBoxDetallePedido);
            this.Controls.Add(this.labelFecha);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(1597, 710);
            this.Name = "FormDetallePedido";
            this.Text = "FormDetallePedido";
            this.Activated += new System.EventHandler(this.FormDetallePedido_Load);
            this.Load += new System.EventHandler(this.FormDetallePedido_Load);
            this.groupBoxDetallePedido.ResumeLayout(false);
            this.groupBoxDetallePedido.PerformLayout();
            this.panelTimerTick.ResumeLayout(false);
            this.panelTimerTick.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxDetallePedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxCategorias;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Timer timerHoraActual;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTimerTick;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxArticulos;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.ListView listViewPedidos;
        private System.Windows.Forms.ColumnHeader Acciones;
        private System.Windows.Forms.ColumnHeader CodigoPedido;
        private System.Windows.Forms.ColumnHeader CantidadPedido;
        private System.Windows.Forms.ColumnHeader CodigoCliente;
        private System.Windows.Forms.ColumnHeader TipoPago;
        private System.Windows.Forms.ColumnHeader PorcentajeDescuentoRecargoTipoPago;
        private System.Windows.Forms.ColumnHeader PrecioFinal;
    }
}