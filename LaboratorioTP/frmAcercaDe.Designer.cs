namespace LaboratorioTP
{
    partial class frmAcercaDe
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._20230411_183550__1_;
            pictureBox1.Location = new Point(-63, -65);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(338, 574);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(329, 156);
            label1.Name = "label1";
            label1.Size = new Size(178, 15);
            label1.TabIndex = 1;
            label1.Text = "Desarrollador: Pablo Ariel Bezard";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(329, 193);
            label2.Name = "label2";
            label2.Size = new Size(194, 15);
            label2.TabIndex = 2;
            label2.Text = "Materia: Practica Profesionalizante I";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(379, 239);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 3;
            label3.Text = "DNI: 39544794";
            // 
            // frmAcercaDe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(548, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "frmAcercaDe";
            Text = "Acerca del desarrollador";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}