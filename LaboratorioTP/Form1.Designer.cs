namespace LaboratorioTP
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            sistemaToolStripMenuItem = new ToolStripMenuItem();
            acercaDeToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            clientesToolStripMenuItem = new ToolStripMenuItem();
            agregarNuevoClienteToolStripMenuItem = new ToolStripMenuItem();
            listarClientesToolStripMenuItem = new ToolStripMenuItem();
            buscarClienteToolStripMenuItem = new ToolStripMenuItem();
            ventasToolStripMenuItem = new ToolStripMenuItem();
            agregarVentaToolStripMenuItem = new ToolStripMenuItem();
            consultarVentaToolStripMenuItem = new ToolStripMenuItem();
            graficoDeVentasToolStripMenuItem = new ToolStripMenuItem();
            empleadosToolStripMenuItem = new ToolStripMenuItem();
            agregarNuevoEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            listarEmpleadosToolStripMenuItem = new ToolStripMenuItem();
            buscarEmpleadoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sistemaToolStripMenuItem, clientesToolStripMenuItem, ventasToolStripMenuItem, empleadosToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(480, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            sistemaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { acercaDeToolStripMenuItem, toolStripMenuItem1, salirToolStripMenuItem });
            sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            sistemaToolStripMenuItem.Size = new Size(60, 20);
            sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // acercaDeToolStripMenuItem
            // 
            acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            acercaDeToolStripMenuItem.Size = new Size(180, 22);
            acercaDeToolStripMenuItem.Text = "Acerca de..";
            acercaDeToolStripMenuItem.Click += acercaDeToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(177, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(180, 22);
            salirToolStripMenuItem.Text = "Salir..";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarNuevoClienteToolStripMenuItem, listarClientesToolStripMenuItem, buscarClienteToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(61, 20);
            clientesToolStripMenuItem.Text = "Clientes";
            // 
            // agregarNuevoClienteToolStripMenuItem
            // 
            agregarNuevoClienteToolStripMenuItem.Name = "agregarNuevoClienteToolStripMenuItem";
            agregarNuevoClienteToolStripMenuItem.Size = new Size(190, 22);
            agregarNuevoClienteToolStripMenuItem.Text = "Agregar nuevo cliente";
            agregarNuevoClienteToolStripMenuItem.Click += agregarNuevoClienteToolStripMenuItem_Click;
            // 
            // listarClientesToolStripMenuItem
            // 
            listarClientesToolStripMenuItem.Name = "listarClientesToolStripMenuItem";
            listarClientesToolStripMenuItem.Size = new Size(190, 22);
            listarClientesToolStripMenuItem.Text = "Listar clientes";
            listarClientesToolStripMenuItem.Click += listarClientesToolStripMenuItem_Click;
            // 
            // buscarClienteToolStripMenuItem
            // 
            buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            buscarClienteToolStripMenuItem.Size = new Size(190, 22);
            buscarClienteToolStripMenuItem.Text = "Buscar cliente";
            buscarClienteToolStripMenuItem.Click += buscarClienteToolStripMenuItem_Click;
            // 
            // ventasToolStripMenuItem
            // 
            ventasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarVentaToolStripMenuItem, consultarVentaToolStripMenuItem, graficoDeVentasToolStripMenuItem });
            ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
            ventasToolStripMenuItem.Size = new Size(53, 20);
            ventasToolStripMenuItem.Text = "Ventas";
            // 
            // agregarVentaToolStripMenuItem
            // 
            agregarVentaToolStripMenuItem.Name = "agregarVentaToolStripMenuItem";
            agregarVentaToolStripMenuItem.Size = new Size(165, 22);
            agregarVentaToolStripMenuItem.Text = "Agregar venta";
            agregarVentaToolStripMenuItem.Click += agregarVentaToolStripMenuItem_Click;
            // 
            // consultarVentaToolStripMenuItem
            // 
            consultarVentaToolStripMenuItem.Name = "consultarVentaToolStripMenuItem";
            consultarVentaToolStripMenuItem.Size = new Size(165, 22);
            consultarVentaToolStripMenuItem.Text = "Consultar venta";
            consultarVentaToolStripMenuItem.Click += consultarVentaToolStripMenuItem_Click;
            // 
            // graficoDeVentasToolStripMenuItem
            // 
            graficoDeVentasToolStripMenuItem.Name = "graficoDeVentasToolStripMenuItem";
            graficoDeVentasToolStripMenuItem.Size = new Size(165, 22);
            graficoDeVentasToolStripMenuItem.Text = "Grafico de ventas";
            graficoDeVentasToolStripMenuItem.Click += graficoDeVentasToolStripMenuItem_Click;
            // 
            // empleadosToolStripMenuItem
            // 
            empleadosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarNuevoEmpleadoToolStripMenuItem, listarEmpleadosToolStripMenuItem, buscarEmpleadoToolStripMenuItem });
            empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            empleadosToolStripMenuItem.Size = new Size(77, 20);
            empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // agregarNuevoEmpleadoToolStripMenuItem
            // 
            agregarNuevoEmpleadoToolStripMenuItem.Name = "agregarNuevoEmpleadoToolStripMenuItem";
            agregarNuevoEmpleadoToolStripMenuItem.Size = new Size(214, 22);
            agregarNuevoEmpleadoToolStripMenuItem.Text = "Agregar nuevo empleado..";
            agregarNuevoEmpleadoToolStripMenuItem.Click += agregarNuevoEmpleadoToolStripMenuItem_Click;
            // 
            // listarEmpleadosToolStripMenuItem
            // 
            listarEmpleadosToolStripMenuItem.Name = "listarEmpleadosToolStripMenuItem";
            listarEmpleadosToolStripMenuItem.Size = new Size(214, 22);
            listarEmpleadosToolStripMenuItem.Text = "Listar empleados";
            listarEmpleadosToolStripMenuItem.Click += listarEmpleadosToolStripMenuItem_Click;
            // 
            // buscarEmpleadoToolStripMenuItem
            // 
            buscarEmpleadoToolStripMenuItem.Name = "buscarEmpleadoToolStripMenuItem";
            buscarEmpleadoToolStripMenuItem.Size = new Size(214, 22);
            buscarEmpleadoToolStripMenuItem.Text = "Buscar empleado";
            buscarEmpleadoToolStripMenuItem.Click += buscarEmpleadoToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.globant_logo;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(480, 289);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Sistema de datos Globant";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sistemaToolStripMenuItem;
        private ToolStripMenuItem acercaDeToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem agregarNuevoClienteToolStripMenuItem;
        private ToolStripMenuItem listarClientesToolStripMenuItem;
        private ToolStripMenuItem buscarClienteToolStripMenuItem;
        private ToolStripMenuItem ventasToolStripMenuItem;
        private ToolStripMenuItem agregarVentaToolStripMenuItem;
        private ToolStripMenuItem consultarVentaToolStripMenuItem;
        private ToolStripMenuItem graficoDeVentasToolStripMenuItem;
        private ToolStripMenuItem empleadosToolStripMenuItem;
        private ToolStripMenuItem agregarNuevoEmpleadoToolStripMenuItem;
        private ToolStripMenuItem listarEmpleadosToolStripMenuItem;
        private ToolStripMenuItem buscarEmpleadoToolStripMenuItem;
    }
}