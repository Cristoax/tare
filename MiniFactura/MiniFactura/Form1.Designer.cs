namespace MiniFactura
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoDelProducto = new System.Windows.Forms.TextBox();
            this.lblNombreDelProducto = new System.Windows.Forms.Label();
            this.txtNombreProducto = new System.Windows.Forms.TextBox();
            this.lblPrecioDelProducto = new System.Windows.Forms.Label();
            this.txtPrecioProducto = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtDesceutno = new System.Windows.Forms.TextBox();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.grpPorcentaje = new System.Windows.Forms.GroupBox();
            this.rb15 = new System.Windows.Forms.RadioButton();
            this.rb10 = new System.Windows.Forms.RadioButton();
            this.rb5 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb0 = new System.Windows.Forms.RadioButton();
            this.grpPorcentaje.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(134, 13);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(325, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "COMERCIAL \"EL AMARU\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo del producto :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCodigoDelProducto
            // 
            this.txtCodigoDelProducto.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCodigoDelProducto.Location = new System.Drawing.Point(198, 74);
            this.txtCodigoDelProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCodigoDelProducto.Multiline = true;
            this.txtCodigoDelProducto.Name = "txtCodigoDelProducto";
            this.txtCodigoDelProducto.Size = new System.Drawing.Size(142, 26);
            this.txtCodigoDelProducto.TabIndex = 2;
            this.txtCodigoDelProducto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblNombreDelProducto
            // 
            this.lblNombreDelProducto.AutoSize = true;
            this.lblNombreDelProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreDelProducto.Location = new System.Drawing.Point(44, 114);
            this.lblNombreDelProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreDelProducto.Name = "lblNombreDelProducto";
            this.lblNombreDelProducto.Size = new System.Drawing.Size(156, 18);
            this.lblNombreDelProducto.TabIndex = 3;
            this.lblNombreDelProducto.Text = "Nombre del producto :";
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.Location = new System.Drawing.Point(198, 114);
            this.txtNombreProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreProducto.Multiline = true;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(142, 26);
            this.txtNombreProducto.TabIndex = 4;
            // 
            // lblPrecioDelProducto
            // 
            this.lblPrecioDelProducto.AutoSize = true;
            this.lblPrecioDelProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioDelProducto.Location = new System.Drawing.Point(44, 151);
            this.lblPrecioDelProducto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioDelProducto.Name = "lblPrecioDelProducto";
            this.lblPrecioDelProducto.Size = new System.Drawing.Size(145, 18);
            this.lblPrecioDelProducto.TabIndex = 5;
            this.lblPrecioDelProducto.Text = "Precio del producto :";
            // 
            // txtPrecioProducto
            // 
            this.txtPrecioProducto.Location = new System.Drawing.Point(198, 151);
            this.txtPrecioProducto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrecioProducto.Multiline = true;
            this.txtPrecioProducto.Name = "txtPrecioProducto";
            this.txtPrecioProducto.Size = new System.Drawing.Size(142, 26);
            this.txtPrecioProducto.TabIndex = 6;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCantidad.Location = new System.Drawing.Point(44, 191);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(74, 18);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad :";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(198, 191);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCantidad.Multiline = true;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(125, 26);
            this.txtCantidad.TabIndex = 8;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(104, 229);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(170, 43);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.Location = new System.Drawing.Point(44, 315);
            this.lblSubtotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(85, 18);
            this.lblSubtotal.TabIndex = 10;
            this.lblSubtotal.Text = "Subtotal -->";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.Location = new System.Drawing.Point(44, 352);
            this.lblDescuento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(103, 18);
            this.lblDescuento.TabIndex = 11;
            this.lblDescuento.Text = "Descuento -->";
            // 
            // lblIva
            // 
            this.lblIva.AutoSize = true;
            this.lblIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.Location = new System.Drawing.Point(44, 392);
            this.lblIva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(52, 18);
            this.lblIva.TabIndex = 12;
            this.lblIva.Text = "IVA -->";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.Location = new System.Drawing.Point(44, 432);
            this.LblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(78, 18);
            this.LblTotal.TabIndex = 13;
            this.LblTotal.Text = "TOTAL -->";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(154, 308);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSubtotal.Multiline = true;
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(142, 26);
            this.txtSubtotal.TabIndex = 14;
            this.txtSubtotal.TextChanged += new System.EventHandler(this.txtSubtotal_TextChanged);
            // 
            // txtDesceutno
            // 
            this.txtDesceutno.Enabled = false;
            this.txtDesceutno.Location = new System.Drawing.Point(154, 345);
            this.txtDesceutno.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDesceutno.Multiline = true;
            this.txtDesceutno.Name = "txtDesceutno";
            this.txtDesceutno.Size = new System.Drawing.Size(142, 26);
            this.txtDesceutno.TabIndex = 15;
            // 
            // txtIva
            // 
            this.txtIva.Enabled = false;
            this.txtIva.Location = new System.Drawing.Point(154, 385);
            this.txtIva.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIva.Multiline = true;
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(142, 26);
            this.txtIva.TabIndex = 16;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(154, 432);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(142, 26);
            this.txtTotal.TabIndex = 17;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(369, 308);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(108, 43);
            this.btnCalcular.TabIndex = 18;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(369, 377);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(108, 43);
            this.btnLimpiar.TabIndex = 19;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrar.Location = new System.Drawing.Point(369, 445);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(108, 43);
            this.btnCerrar.TabIndex = 20;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // grpPorcentaje
            // 
            this.grpPorcentaje.Controls.Add(this.rb15);
            this.grpPorcentaje.Controls.Add(this.rb10);
            this.grpPorcentaje.Controls.Add(this.rb5);
            this.grpPorcentaje.Controls.Add(this.rb1);
            this.grpPorcentaje.Controls.Add(this.rb0);
            this.grpPorcentaje.Location = new System.Drawing.Point(364, 68);
            this.grpPorcentaje.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPorcentaje.Name = "grpPorcentaje";
            this.grpPorcentaje.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpPorcentaje.Size = new System.Drawing.Size(123, 198);
            this.grpPorcentaje.TabIndex = 21;
            this.grpPorcentaje.TabStop = false;
            this.grpPorcentaje.Text = "Descuento";
            // 
            // rb15
            // 
            this.rb15.AutoSize = true;
            this.rb15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb15.Location = new System.Drawing.Point(19, 170);
            this.rb15.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb15.Name = "rb15";
            this.rb15.Size = new System.Drawing.Size(59, 22);
            this.rb15.TabIndex = 4;
            this.rb15.TabStop = true;
            this.rb15.Text = "15 %";
            this.rb15.UseVisualStyleBackColor = true;
            // 
            // rb10
            // 
            this.rb10.AutoSize = true;
            this.rb10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb10.Location = new System.Drawing.Point(19, 137);
            this.rb10.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb10.Name = "rb10";
            this.rb10.Size = new System.Drawing.Size(59, 22);
            this.rb10.TabIndex = 3;
            this.rb10.TabStop = true;
            this.rb10.Text = "10 %";
            this.rb10.UseVisualStyleBackColor = true;
            // 
            // rb5
            // 
            this.rb5.AutoSize = true;
            this.rb5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb5.Location = new System.Drawing.Point(19, 102);
            this.rb5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb5.Name = "rb5";
            this.rb5.Size = new System.Drawing.Size(51, 22);
            this.rb5.TabIndex = 2;
            this.rb5.TabStop = true;
            this.rb5.Text = "5 %";
            this.rb5.UseVisualStyleBackColor = true;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1.Location = new System.Drawing.Point(19, 67);
            this.rb1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(51, 22);
            this.rb1.TabIndex = 1;
            this.rb1.TabStop = true;
            this.rb1.Text = "1 %";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb0
            // 
            this.rb0.AutoSize = true;
            this.rb0.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb0.Location = new System.Drawing.Point(19, 32);
            this.rb0.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rb0.Name = "rb0";
            this.rb0.Size = new System.Drawing.Size(51, 22);
            this.rb0.TabIndex = 0;
            this.rb0.TabStop = true;
            this.rb0.Text = "0 %";
            this.rb0.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(656, 552);
            this.Controls.Add(this.grpPorcentaje);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.txtDesceutno);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.lblIva);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.txtPrecioProducto);
            this.Controls.Add(this.lblPrecioDelProducto);
            this.Controls.Add(this.txtNombreProducto);
            this.Controls.Add(this.lblNombreDelProducto);
            this.Controls.Add(this.txtCodigoDelProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Mini Factura";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpPorcentaje.ResumeLayout(false);
            this.grpPorcentaje.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoDelProducto;
        private System.Windows.Forms.Label lblNombreDelProducto;
        private System.Windows.Forms.TextBox txtNombreProducto;
        private System.Windows.Forms.Label lblPrecioDelProducto;
        private System.Windows.Forms.TextBox txtPrecioProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtDesceutno;
        private System.Windows.Forms.TextBox txtIva;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.GroupBox grpPorcentaje;
        private System.Windows.Forms.RadioButton rb15;
        private System.Windows.Forms.RadioButton rb10;
        private System.Windows.Forms.RadioButton rb5;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb0;
    }
}

