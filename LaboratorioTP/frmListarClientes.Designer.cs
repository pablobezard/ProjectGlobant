namespace LaboratorioTP
{
    partial class frmListarClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListarClientes));
            pictureBox1 = new PictureBox();
            Grilla = new DataGridView();
            btnListar = new Button();
            btnExportar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Grilla).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, -114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(126, 633);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Grilla
            // 
            Grilla.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Grilla.Location = new Point(163, 24);
            Grilla.Name = "Grilla";
            Grilla.RowTemplate.Height = 25;
            Grilla.Size = new Size(443, 269);
            Grilla.TabIndex = 1;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(439, 330);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(105, 36);
            btnListar.TabIndex = 2;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // btnExportar
            // 
            btnExportar.Location = new Point(318, 330);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(115, 36);
            btnExportar.TabIndex = 3;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // frmListarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 400);
            Controls.Add(btnExportar);
            Controls.Add(btnListar);
            Controls.Add(Grilla);
            Controls.Add(pictureBox1);
            Name = "frmListarClientes";
            Text = "Listado de clientes";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Grilla).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private DataGridView Grilla;
        private Button btnListar;
        private Button btnExportar;
    }
}