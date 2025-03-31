namespace URP
{
    partial class MenuFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuFrm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administraciosTs = new System.Windows.Forms.ToolStripMenuItem();
            this.sociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviciosTs = new System.Windows.Forms.ToolStripMenuItem();
            this.pesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spinningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoTs = new System.Windows.Forms.ToolStripMenuItem();
            this.membresiasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesTs = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administraciosTs,
            this.serviciosTs,
            this.mantenimientoTs,
            this.clientesTs});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administraciosTs
            // 
            this.administraciosTs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sociosToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.usuariosToolStripMenuItem});
            this.administraciosTs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administraciosTs.Name = "administraciosTs";
            this.administraciosTs.Size = new System.Drawing.Size(189, 36);
            this.administraciosTs.Text = "Administracion";
            // 
            // sociosToolStripMenuItem
            // 
            this.sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            this.sociosToolStripMenuItem.Size = new System.Drawing.Size(270, 40);
            this.sociosToolStripMenuItem.Tag = "1";
            this.sociosToolStripMenuItem.Text = "Socios";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(270, 40);
            this.empleadosToolStripMenuItem.Tag = "1";
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(270, 40);
            this.usuariosToolStripMenuItem.Tag = "3";
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // serviciosTs
            // 
            this.serviciosTs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesasToolStripMenuItem,
            this.spinningToolStripMenuItem,
            this.pilatesToolStripMenuItem});
            this.serviciosTs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serviciosTs.Name = "serviciosTs";
            this.serviciosTs.Size = new System.Drawing.Size(123, 36);
            this.serviciosTs.Text = "Servicios";
            // 
            // pesasToolStripMenuItem
            // 
            this.pesasToolStripMenuItem.Name = "pesasToolStripMenuItem";
            this.pesasToolStripMenuItem.Size = new System.Drawing.Size(270, 40);
            this.pesasToolStripMenuItem.Tag = "4";
            this.pesasToolStripMenuItem.Text = "Vehiculos";
            this.pesasToolStripMenuItem.Click += new System.EventHandler(this.pesasToolStripMenuItem_Click);
            // 
            // spinningToolStripMenuItem
            // 
            this.spinningToolStripMenuItem.Name = "spinningToolStripMenuItem";
            this.spinningToolStripMenuItem.Size = new System.Drawing.Size(270, 40);
            this.spinningToolStripMenuItem.Tag = "5";
            this.spinningToolStripMenuItem.Text = "Venta";
            // 
            // pilatesToolStripMenuItem
            // 
            this.pilatesToolStripMenuItem.Name = "pilatesToolStripMenuItem";
            this.pilatesToolStripMenuItem.Size = new System.Drawing.Size(270, 40);
            this.pilatesToolStripMenuItem.Tag = "6";
            this.pilatesToolStripMenuItem.Text = "Alquiler";
            // 
            // mantenimientoTs
            // 
            this.mantenimientoTs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.membresiasToolStripMenuItem,
            this.lockersToolStripMenuItem,
            this.rToolStripMenuItem});
            this.mantenimientoTs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mantenimientoTs.Name = "mantenimientoTs";
            this.mantenimientoTs.Size = new System.Drawing.Size(195, 36);
            this.mantenimientoTs.Text = "Mantenimiento";
            // 
            // membresiasToolStripMenuItem
            // 
            this.membresiasToolStripMenuItem.Name = "membresiasToolStripMenuItem";
            this.membresiasToolStripMenuItem.Size = new System.Drawing.Size(280, 40);
            this.membresiasToolStripMenuItem.Tag = "8";
            this.membresiasToolStripMenuItem.Text = "Reparaciones";
            // 
            // lockersToolStripMenuItem
            // 
            this.lockersToolStripMenuItem.Name = "lockersToolStripMenuItem";
            this.lockersToolStripMenuItem.Size = new System.Drawing.Size(280, 40);
            this.lockersToolStripMenuItem.Tag = "9";
            this.lockersToolStripMenuItem.Text = "Garantias";            // 
            // rToolStripMenuItem
            // 
            this.rToolStripMenuItem.Name = "rToolStripMenuItem";
            this.rToolStripMenuItem.Size = new System.Drawing.Size(280, 40);
            this.rToolStripMenuItem.Tag = "10";
            this.rToolStripMenuItem.Text = "Rol de usuarios";
            this.rToolStripMenuItem.Click += new System.EventHandler(this.rToolStripMenuItem_Click);
            // 
            // clientesTs
            // 
            this.clientesTs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.bajaToolStripMenuItem,
            this.ventaToolStripMenuItem});
            this.clientesTs.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clientesTs.Name = "clientesTs";
            this.clientesTs.Size = new System.Drawing.Size(115, 36);
            this.clientesTs.Text = "Clientes";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(270, 40);
            this.altaToolStripMenuItem.Tag = "11";
            this.altaToolStripMenuItem.Text = "Facturas";
            // 
            // bajaToolStripMenuItem
            // 
            this.bajaToolStripMenuItem.Name = "bajaToolStripMenuItem";
            this.bajaToolStripMenuItem.Size = new System.Drawing.Size(270, 40);
            this.bajaToolStripMenuItem.Tag = "12";
            this.bajaToolStripMenuItem.Text = "Alquileres";
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(270, 40);
            this.ventaToolStripMenuItem.Tag = "13";
            this.ventaToolStripMenuItem.Text = "Ventas";
            // 
            // MenuFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(873, 518);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuFrm";
            this.Text = "Form2";            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administraciosTs;
        private System.Windows.Forms.ToolStripMenuItem sociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviciosTs;
        private System.Windows.Forms.ToolStripMenuItem pesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spinningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoTs;
        private System.Windows.Forms.ToolStripMenuItem membresiasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lockersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesTs;
        private System.Windows.Forms.ToolStripMenuItem rToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
    }
}