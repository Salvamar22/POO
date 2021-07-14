namespace Cafeteria21Abril
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPrecioPapa = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudCantidadPapa = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSubtotalPapa = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblSubtotalCarne = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.nudCantidadCarne = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.lblPrecioCarne = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblSubtotalPollo = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nudCantidadPollo = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.lblPrecioPollo = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblSubtotalVegetales = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.nudCantidadVegetales = new System.Windows.Forms.NumericUpDown();
            this.label19 = new System.Windows.Forms.Label();
            this.lblPrecioVegetales = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radEmpleado = new System.Windows.Forms.RadioButton();
            this.radEstudiante = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radTarjeta = new System.Windows.Forms.RadioButton();
            this.radEfectivo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.nudCantidadPapa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.nudCantidadCarne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.nudCantidadPollo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.nudCantidadVegetales)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(616, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblPrecioPapa
            // 
            this.lblPrecioPapa.Location = new System.Drawing.Point(12, 104);
            this.lblPrecioPapa.Name = "lblPrecioPapa";
            this.lblPrecioPapa.Size = new System.Drawing.Size(100, 23);
            this.lblPrecioPapa.TabIndex = 1;
            this.lblPrecioPapa.Text = "$0.00";
            this.lblPrecioPapa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cantidad:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudCantidadPapa
            // 
            this.nudCantidadPapa.Location = new System.Drawing.Point(12, 153);
            this.nudCantidadPapa.Name = "nudCantidadPapa";
            this.nudCantidadPapa.Size = new System.Drawing.Size(100, 20);
            this.nudCantidadPapa.TabIndex = 3;
            this.nudCantidadPapa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCantidadPapa.ValueChanged += new System.EventHandler(this.nudCantidadPapa_ValueChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Subtotal:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubtotalPapa
            // 
            this.lblSubtotalPapa.Location = new System.Drawing.Point(12, 199);
            this.lblSubtotalPapa.Name = "lblSubtotalPapa";
            this.lblSubtotalPapa.Size = new System.Drawing.Size(100, 23);
            this.lblSubtotalPapa.TabIndex = 5;
            this.lblSubtotalPapa.Text = "$0.00";
            this.lblSubtotalPapa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox2.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(118, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(177, 118);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.Location = new System.Drawing.Point(12, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(283, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Capeado de papa con queso";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.Location = new System.Drawing.Point(345, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Carne de res deshilada";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox3.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(451, 104);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(177, 118);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // lblSubtotalCarne
            // 
            this.lblSubtotalCarne.Location = new System.Drawing.Point(345, 199);
            this.lblSubtotalCarne.Name = "lblSubtotalCarne";
            this.lblSubtotalCarne.Size = new System.Drawing.Size(100, 23);
            this.lblSubtotalCarne.TabIndex = 12;
            this.lblSubtotalCarne.Text = "$0.00";
            this.lblSubtotalCarne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(345, 176);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 23);
            this.label8.TabIndex = 11;
            this.label8.Text = "Subtotal:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudCantidadCarne
            // 
            this.nudCantidadCarne.Location = new System.Drawing.Point(345, 153);
            this.nudCantidadCarne.Name = "nudCantidadCarne";
            this.nudCantidadCarne.Size = new System.Drawing.Size(100, 20);
            this.nudCantidadCarne.TabIndex = 10;
            this.nudCantidadCarne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCantidadCarne.ValueChanged += new System.EventHandler(this.nudCantidadCarne_ValueChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(345, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 23);
            this.label9.TabIndex = 9;
            this.label9.Text = "Cantidad:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrecioCarne
            // 
            this.lblPrecioCarne.Location = new System.Drawing.Point(345, 104);
            this.lblPrecioCarne.Name = "lblPrecioCarne";
            this.lblPrecioCarne.Size = new System.Drawing.Size(100, 23);
            this.lblPrecioCarne.TabIndex = 8;
            this.lblPrecioCarne.Text = "$0.00";
            this.lblPrecioCarne.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label11.Location = new System.Drawing.Point(12, 372);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(283, 23);
            this.label11.TabIndex = 21;
            this.label11.Text = "Alitas de pollo frito";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox4.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(118, 251);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(177, 118);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            // 
            // lblSubtotalPollo
            // 
            this.lblSubtotalPollo.Location = new System.Drawing.Point(12, 346);
            this.lblSubtotalPollo.Name = "lblSubtotalPollo";
            this.lblSubtotalPollo.Size = new System.Drawing.Size(100, 23);
            this.lblSubtotalPollo.TabIndex = 19;
            this.lblSubtotalPollo.Text = "$0.00";
            this.lblSubtotalPollo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(12, 323);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 18;
            this.label13.Text = "Subtotal:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudCantidadPollo
            // 
            this.nudCantidadPollo.Location = new System.Drawing.Point(12, 300);
            this.nudCantidadPollo.Name = "nudCantidadPollo";
            this.nudCantidadPollo.Size = new System.Drawing.Size(100, 20);
            this.nudCantidadPollo.TabIndex = 17;
            this.nudCantidadPollo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCantidadPollo.ValueChanged += new System.EventHandler(this.nudCantidadPollo_ValueChanged);
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(12, 274);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 16;
            this.label14.Text = "Cantidad:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrecioPollo
            // 
            this.lblPrecioPollo.Location = new System.Drawing.Point(12, 251);
            this.lblPrecioPollo.Name = "lblPrecioPollo";
            this.lblPrecioPollo.Size = new System.Drawing.Size(100, 23);
            this.lblPrecioPollo.TabIndex = 15;
            this.lblPrecioPollo.Text = "$0.00";
            this.lblPrecioPollo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label16.Location = new System.Drawing.Point(345, 372);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(283, 23);
            this.label16.TabIndex = 28;
            this.label16.Text = "Vegetales al ajillo";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.OrangeRed;
            this.pictureBox5.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(451, 251);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(177, 118);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 27;
            this.pictureBox5.TabStop = false;
            // 
            // lblSubtotalVegetales
            // 
            this.lblSubtotalVegetales.Location = new System.Drawing.Point(345, 346);
            this.lblSubtotalVegetales.Name = "lblSubtotalVegetales";
            this.lblSubtotalVegetales.Size = new System.Drawing.Size(100, 23);
            this.lblSubtotalVegetales.TabIndex = 26;
            this.lblSubtotalVegetales.Text = "$0.00";
            this.lblSubtotalVegetales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(345, 323);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 23);
            this.label18.TabIndex = 25;
            this.label18.Text = "Subtotal:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nudCantidadVegetales
            // 
            this.nudCantidadVegetales.Location = new System.Drawing.Point(345, 300);
            this.nudCantidadVegetales.Name = "nudCantidadVegetales";
            this.nudCantidadVegetales.Size = new System.Drawing.Size(100, 20);
            this.nudCantidadVegetales.TabIndex = 24;
            this.nudCantidadVegetales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCantidadVegetales.ValueChanged += new System.EventHandler(this.nudCantidadVegetales_ValueChanged);
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(345, 274);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(100, 23);
            this.label19.TabIndex = 23;
            this.label19.Text = "Cantidad:";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrecioVegetales
            // 
            this.lblPrecioVegetales.Location = new System.Drawing.Point(345, 251);
            this.lblPrecioVegetales.Name = "lblPrecioVegetales";
            this.lblPrecioVegetales.Size = new System.Drawing.Size(100, 23);
            this.lblPrecioVegetales.TabIndex = 22;
            this.lblPrecioVegetales.Text = "$0.00";
            this.lblPrecioVegetales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radEmpleado);
            this.groupBox1.Controls.Add(this.radEstudiante);
            this.groupBox1.Location = new System.Drawing.Point(12, 410);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 100);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de cliente:";
            // 
            // radEmpleado
            // 
            this.radEmpleado.Location = new System.Drawing.Point(18, 60);
            this.radEmpleado.Name = "radEmpleado";
            this.radEmpleado.Size = new System.Drawing.Size(104, 24);
            this.radEmpleado.TabIndex = 1;
            this.radEmpleado.Text = "Empleado";
            this.radEmpleado.UseVisualStyleBackColor = true;
            this.radEmpleado.CheckedChanged += new System.EventHandler(this.radEmpleado_CheckedChanged);
            // 
            // radEstudiante
            // 
            this.radEstudiante.Checked = true;
            this.radEstudiante.Location = new System.Drawing.Point(18, 30);
            this.radEstudiante.Name = "radEstudiante";
            this.radEstudiante.Size = new System.Drawing.Size(104, 24);
            this.radEstudiante.TabIndex = 0;
            this.radEstudiante.TabStop = true;
            this.radEstudiante.Text = "Estudiante";
            this.radEstudiante.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radTarjeta);
            this.groupBox2.Controls.Add(this.radEfectivo);
            this.groupBox2.Location = new System.Drawing.Point(146, 410);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(128, 100);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Forma de pago:";
            // 
            // radTarjeta
            // 
            this.radTarjeta.Location = new System.Drawing.Point(18, 60);
            this.radTarjeta.Name = "radTarjeta";
            this.radTarjeta.Size = new System.Drawing.Size(104, 24);
            this.radTarjeta.TabIndex = 1;
            this.radTarjeta.Text = "Tarjeta";
            this.radTarjeta.UseVisualStyleBackColor = true;
            // 
            // radEfectivo
            // 
            this.radEfectivo.Checked = true;
            this.radEfectivo.Location = new System.Drawing.Point(18, 30);
            this.radEfectivo.Name = "radEfectivo";
            this.radEfectivo.Size = new System.Drawing.Size(104, 24);
            this.radEfectivo.TabIndex = 0;
            this.radEfectivo.TabStop = true;
            this.radEfectivo.Text = "Efectivo";
            this.radEfectivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(280, 410);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 23);
            this.label1.TabIndex = 31;
            this.label1.Text = "Nombre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(351, 413);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(277, 20);
            this.txtCliente.TabIndex = 32;
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTotal.Location = new System.Drawing.Point(351, 452);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(277, 23);
            this.lblTotal.TabIndex = 33;
            this.lblTotal.Text = "Total: $0.00";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(280, 487);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(165, 23);
            this.btnLimpiar.TabIndex = 34;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.OrangeRed;
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.Location = new System.Drawing.Point(451, 487);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(177, 23);
            this.btnComprar.TabIndex = 35;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(640, 522);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.lblSubtotalVegetales);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.nudCantidadVegetales);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblPrecioVegetales);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.lblSubtotalPollo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.nudCantidadPollo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblPrecioPollo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblSubtotalCarne);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nudCantidadCarne);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblPrecioCarne);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblSubtotalPapa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudCantidadPapa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPrecioPapa);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenido a Cafeterías UCA";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.nudCantidadPapa)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.nudCantidadCarne)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.nudCantidadPollo)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.nudCantidadVegetales)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.Button btnLimpiar;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtCliente;

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radEfectivo;
        private System.Windows.Forms.RadioButton radTarjeta;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radEmpleado;
        private System.Windows.Forms.RadioButton radEstudiante;

        private System.Windows.Forms.Label lblPrecioCarne;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblSubtotalPollo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblPrecioPollo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblSubtotalVegetales;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblPrecioVegetales;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSubtotalCarne;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nudCantidadCarne;
        private System.Windows.Forms.NumericUpDown nudCantidadPollo;
        private System.Windows.Forms.NumericUpDown nudCantidadVegetales;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.PictureBox pictureBox2;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSubtotalPapa;

        private System.Windows.Forms.NumericUpDown nudCantidadPapa;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label lblPrecioPapa;

        private System.Windows.Forms.PictureBox pictureBox1;

        #endregion
    }
}