namespace LaboratorioTP
{
    partial class frmAgregarEmpleado
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPhone = new TextBox();
            txtHome = new TextBox();
            txtName = new TextBox();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 143);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 13;
            label3.Text = "Telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 97);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 12;
            label2.Text = "Localidad:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 50);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 11;
            label1.Text = "Nombre y apellido:";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(184, 135);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(118, 23);
            txtPhone.TabIndex = 10;
            // 
            // txtHome
            // 
            txtHome.Location = new Point(184, 89);
            txtHome.Name = "txtHome";
            txtHome.Size = new Size(118, 23);
            txtHome.TabIndex = 9;
            // 
            // txtName
            // 
            txtName.Location = new Point(184, 47);
            txtName.Name = "txtName";
            txtName.Size = new Size(118, 23);
            txtName.TabIndex = 8;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(209, 216);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // frmAgregarEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(356, 274);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPhone);
            Controls.Add(txtHome);
            Controls.Add(txtName);
            Controls.Add(btnAgregar);
            Name = "frmAgregarEmpleado";
            Text = "Agregar empleado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtPhone;
        private TextBox txtHome;
        private TextBox txtName;
        private Button btnAgregar;
    }
}