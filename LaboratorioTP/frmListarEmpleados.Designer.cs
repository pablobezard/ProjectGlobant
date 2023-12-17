namespace LaboratorioTP
{
    partial class frmListarEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarEmpleados));
            btnExportar = new Button();
            btnListar = new Button();
            Grilla = new DataGridView();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Grilla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(310, 346);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(115, 36);
            btnExportar.TabIndex = 7;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(431, 346);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(105, 36);
            btnListar.TabIndex = 6;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // Grilla
            // 
            Grilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla.Location = new Point(155, 40);
            Grilla.Name = "Grilla";
            Grilla.RowTemplate.Height = 25;
            Grilla.Size = new Size(443, 269);
            Grilla.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(4, -98);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 633);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // frmListarEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(621, 450);
            Controls.Add(btnExportar);
            Controls.Add(btnListar);
            Controls.Add(Grilla);
            Controls.Add(pictureBox1);
            Name = "frmListarEmpleados";
            Text = "Listar empleados";
            ((System.ComponentModel.ISupportInitialize)Grilla).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnExportar;
        private Button btnListar;
        private DataGridView Grilla;
        private PictureBox pictureBox1;
    }
}