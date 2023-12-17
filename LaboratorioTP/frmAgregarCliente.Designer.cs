namespace LaboratorioTP
{
    partial class frmAgregarCliente
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
            button1 = new Button();
            txtName = new TextBox();
            txtHome = new TextBox();
            txtPhone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(230, 225);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(205, 56);
            txtName.Name = "txtName";
            txtName.Size = new Size(118, 23);
            txtName.TabIndex = 1;
            // 
            // txtHome
            // 
            txtHome.Location = new Point(205, 98);
            txtHome.Name = "txtHome";
            txtHome.Size = new Size(118, 23);
            txtHome.TabIndex = 2;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(205, 144);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(118, 23);
            txtPhone.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 59);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre y apellido:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 106);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 5;
            label2.Text = "Localidad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 152);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 6;
            label3.Text = "Telefono";
            // 
            // frmAgregarCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 295);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPhone);
            Controls.Add(txtHome);
            Controls.Add(txtName);
            Controls.Add(button1);
            Name = "frmAgregarCliente";
            Text = "Agregar cliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox txtName;
        private TextBox txtHome;
        private TextBox txtPhone;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}