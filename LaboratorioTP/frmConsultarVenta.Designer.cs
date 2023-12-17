namespace LaboratorioTP
{
    partial class frmConsultarVenta
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
            label4 = new Label();
            btnConsultar = new Button();
            dtpFecha = new DateTimePicker();
            label3 = new Label();
            cmbEmpleado = new ComboBox();
            Grilla = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Grilla).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 73);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 11;
            label4.Text = "Fecha:";
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(89, 401);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(157, 34);
            btnConsultar.TabIndex = 10;
            btnConsultar.Text = "Consultar ventas";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // dtpFecha
            // 
            dtpFecha.Location = new Point(116, 67);
            dtpFecha.Name = "dtpFecha";
            dtpFecha.Size = new Size(238, 23);
            dtpFecha.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 41);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 13;
            label3.Text = "Empleado:";
            // 
            // cmbEmpleado
            // 
            cmbEmpleado.FormattingEnabled = true;
            cmbEmpleado.Location = new Point(116, 38);
            cmbEmpleado.Name = "cmbEmpleado";
            cmbEmpleado.Size = new Size(121, 23);
            cmbEmpleado.TabIndex = 12;
            // 
            // Grilla
            // 
            Grilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla.Location = new Point(12, 108);
            Grilla.Name = "Grilla";
            Grilla.RowTemplate.Height = 25;
            Grilla.Size = new Size(575, 274);
            Grilla.TabIndex = 14;
            // 
            // frmConsultarVenta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 464);
            Controls.Add(Grilla);
            Controls.Add(label3);
            Controls.Add(cmbEmpleado);
            Controls.Add(label4);
            Controls.Add(btnConsultar);
            Controls.Add(dtpFecha);
            Name = "frmConsultarVenta";
            Text = "Consultar venta de servicio";
            Load += frmConsultarVenta_Load;
            ((System.ComponentModel.ISupportInitialize)Grilla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button btnConsultar;
        private DateTimePicker dtpFecha;
        private Label label3;
        private ComboBox cmbEmpleado;
        private DataGridView Grilla;
    }
}