namespace LaboratorioTP
{
    partial class frmAgregarVenta
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
            cmbCliente = new ComboBox();
            cmbEmpleado = new ComboBox();
            cmbServicio = new ComboBox();
            dtpFecha = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnAgregar = new Button();
            label4 = new Label();
            txtImporte = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // cmbCliente
            // 
            cmbCliente.FormattingEnabled = true;
            cmbCliente.Location = new Point(146, 67);
            cmbCliente.Name = "cmbCliente";
            cmbCliente.Size = new Size(121, 23);
            cmbCliente.TabIndex = 0;
            // 
            // cmbEmpleado
            // 
            cmbEmpleado.FormattingEnabled = true;
            cmbEmpleado.Location = new Point(146, 96);
            cmbEmpleado.Name = "cmbEmpleado";
            cmbEmpleado.Size = new Size(121, 23);
            cmbEmpleado.TabIndex = 1;
            // 
            // cmbServicio
            // 
            cmbServicio.FormattingEnabled = true;
            cmbServicio.Location = new Point(146, 125);
            cmbServicio.Name = "cmbServicio";
            cmbServicio.Size = new Size(121, 23);
            cmbServicio.TabIndex = 2;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(146, 154);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(200, 23);
            dtpFecha.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 68);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 4;
            label1.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 133);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 5;
            label2.Text = "Servicio:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 99);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 6;
            label3.Text = "Empleado:";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(146, 223);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(152, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar venta";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 160);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 8;
            label4.Text = "Fecha:";
            // 
            // txtImporte
            // 
            txtImporte.Location = new Point(146, 183);
            txtImporte.Name = "txtImporte";
            txtImporte.Size = new Size(100, 23);
            txtImporte.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 186);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 10;
            label5.Text = "Importe:";
            // 
            // frmAgregarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(416, 295);
            Controls.Add(label5);
            Controls.Add(txtImporte);
            Controls.Add(label4);
            Controls.Add(btnAgregar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dtpFecha);
            Controls.Add(cmbServicio);
            Controls.Add(cmbEmpleado);
            Controls.Add(cmbCliente);
            Name = "frmAgregarVenta";
            Text = "Agregar venta de servicio";
            Load += frmAgregarVenta_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbCliente;
        private ComboBox cmbEmpleado;
        private ComboBox cmbServicio;
        private DateTimePicker dtpFecha;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnAgregar;
        private Label label4;
        private TextBox txtImporte;
        private Label label5;
    }
}