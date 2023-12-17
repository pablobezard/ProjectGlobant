namespace LaboratorioTP
{
    partial class frmGraficoVentas
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
            btnCalcular = new Button();
            btnImprimir = new Button();
            lblFechas = new Label();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(103, 344);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 1;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(226, 346);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(75, 23);
            btnImprimir.TabIndex = 2;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // lblFechas
            // 
            lblFechas.AutoSize = true;
            lblFechas.Location = new Point(72, 304);
            lblFechas.Name = "lblFechas";
            lblFechas.Size = new Size(43, 15);
            lblFechas.TabIndex = 3;
            lblFechas.Text = "Fechas";
            // 
            // frmGraficoVentas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 381);
            Controls.Add(lblFechas);
            Controls.Add(btnImprimir);
            Controls.Add(btnCalcular);
            Name = "frmGraficoVentas";
            Text = "Grafico de venta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCalcular;
        private Button btnImprimir;
        private Label lblFechas;
    }
}