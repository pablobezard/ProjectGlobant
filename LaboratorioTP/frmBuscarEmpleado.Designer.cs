namespace LaboratorioTP
{
    partial class frmBuscarEmpleado
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
            groupBox1 = new GroupBox();
            lblPhone = new TextBox();
            lblHome = new TextBox();
            lblNombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnBuscar = new Button();
            txtCodigo = new TextBox();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblPhone);
            groupBox1.Controls.Add(lblHome);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(53, 139);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(286, 245);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos Del Cliente";
            // 
            // lblPhone
            // 
            lblPhone.Location = new Point(125, 176);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(100, 23);
            lblPhone.TabIndex = 5;
            // 
            // lblHome
            // 
            lblHome.Location = new Point(114, 107);
            lblHome.Name = "lblHome";
            lblHome.Size = new Size(142, 23);
            lblHome.TabIndex = 4;
            // 
            // lblNombre
            // 
            lblNombre.Location = new Point(125, 45);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(100, 23);
            lblNombre.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(28, 184);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 2;
            label4.Text = "Phone:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 110);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 1;
            label3.Text = "Home:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 48);
            label2.Name = "label2";
            label2.Size = new Size(54, 15);
            label2.TabIndex = 0;
            label2.Text = "Nombre:";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(192, 72);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(167, 35);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 38);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 8;
            label1.Text = "Codigo de cliente: ";
            // 
            // frmBuscarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 450);
            Controls.Add(groupBox1);
            Controls.Add(btnBuscar);
            Controls.Add(txtCodigo);
            Controls.Add(label1);
            Name = "frmBuscarEmpleado";
            Text = "Buscar empleado";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox lblPhone;
        private TextBox lblHome;
        private TextBox lblNombre;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnBuscar;
        private TextBox txtCodigo;
        private Label label1;
    }
}