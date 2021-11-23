
namespace Vista
{
    partial class frmContabilidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmContabilidad));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polizasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoTipoPólizaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoEncabezadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoTipoCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoTipoOperaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDePólizaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoCuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presupuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarEncabezadoPolizaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarPolizaDetalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.polizasToolStripMenuItem,
            this.presupuestosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // polizasToolStripMenuItem
            // 
            this.polizasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingresoTipoPólizaToolStripMenuItem,
            this.ingresoEncabezadoToolStripMenuItem,
            this.ingresoTipoCuentaToolStripMenuItem,
            this.ingresoTipoOperaciónToolStripMenuItem,
            this.detalleDePólizaToolStripMenuItem,
            this.ingresoCuentaToolStripMenuItem});
            this.polizasToolStripMenuItem.Name = "polizasToolStripMenuItem";
            this.polizasToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.polizasToolStripMenuItem.Text = "Polizas";
            // 
            // ingresoTipoPólizaToolStripMenuItem
            // 
            this.ingresoTipoPólizaToolStripMenuItem.Name = "ingresoTipoPólizaToolStripMenuItem";
            this.ingresoTipoPólizaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.ingresoTipoPólizaToolStripMenuItem.Text = "Ingreso Tipo Póliza";
            this.ingresoTipoPólizaToolStripMenuItem.Click += new System.EventHandler(this.ingresoTipoPólizaToolStripMenuItem_Click);
            // 
            // ingresoEncabezadoToolStripMenuItem
            // 
            this.ingresoEncabezadoToolStripMenuItem.Name = "ingresoEncabezadoToolStripMenuItem";
            this.ingresoEncabezadoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.ingresoEncabezadoToolStripMenuItem.Text = "Ingreso Encabezado";
            this.ingresoEncabezadoToolStripMenuItem.Click += new System.EventHandler(this.ingresoEncabezadoToolStripMenuItem_Click);
            // 
            // ingresoTipoCuentaToolStripMenuItem
            // 
            this.ingresoTipoCuentaToolStripMenuItem.Name = "ingresoTipoCuentaToolStripMenuItem";
            this.ingresoTipoCuentaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.ingresoTipoCuentaToolStripMenuItem.Text = "Ingreso Tipo Cuenta";
            this.ingresoTipoCuentaToolStripMenuItem.Click += new System.EventHandler(this.ingresoTipoCuentaToolStripMenuItem_Click);
            // 
            // ingresoTipoOperaciónToolStripMenuItem
            // 
            this.ingresoTipoOperaciónToolStripMenuItem.Name = "ingresoTipoOperaciónToolStripMenuItem";
            this.ingresoTipoOperaciónToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.ingresoTipoOperaciónToolStripMenuItem.Text = "Ingreso Tipo Operación";
            this.ingresoTipoOperaciónToolStripMenuItem.Click += new System.EventHandler(this.ingresoTipoOperaciónToolStripMenuItem_Click);
            // 
            // detalleDePólizaToolStripMenuItem
            // 
            this.detalleDePólizaToolStripMenuItem.Name = "detalleDePólizaToolStripMenuItem";
            this.detalleDePólizaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.detalleDePólizaToolStripMenuItem.Text = "Ingreso Póliza Detalle";
            this.detalleDePólizaToolStripMenuItem.Click += new System.EventHandler(this.detalleDePólizaToolStripMenuItem_Click);
            // 
            // ingresoCuentaToolStripMenuItem
            // 
            this.ingresoCuentaToolStripMenuItem.Name = "ingresoCuentaToolStripMenuItem";
            this.ingresoCuentaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.ingresoCuentaToolStripMenuItem.Text = "Ingreso Cuenta";
            this.ingresoCuentaToolStripMenuItem.Click += new System.EventHandler(this.ingresoCuentaToolStripMenuItem_Click);
            // 
            // presupuestosToolStripMenuItem
            // 
            this.presupuestosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem,
            this.modificarEncabezadoPolizaToolStripMenuItem,
            this.modificarPolizaDetalleToolStripMenuItem});
            this.presupuestosToolStripMenuItem.Name = "presupuestosToolStripMenuItem";
            this.presupuestosToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.presupuestosToolStripMenuItem.Text = "Edición";
            this.presupuestosToolStripMenuItem.Click += new System.EventHandler(this.presupuestosToolStripMenuItem_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(532, 4);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(76, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.modificarToolStripMenuItem.Text = "Modificar Cuenta";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // modificarEncabezadoPolizaToolStripMenuItem
            // 
            this.modificarEncabezadoPolizaToolStripMenuItem.Name = "modificarEncabezadoPolizaToolStripMenuItem";
            this.modificarEncabezadoPolizaToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.modificarEncabezadoPolizaToolStripMenuItem.Text = "Modificar Encabezado Poliza";
            this.modificarEncabezadoPolizaToolStripMenuItem.Click += new System.EventHandler(this.modificarEncabezadoPolizaToolStripMenuItem_Click);
            // 
            // modificarPolizaDetalleToolStripMenuItem
            // 
            this.modificarPolizaDetalleToolStripMenuItem.Name = "modificarPolizaDetalleToolStripMenuItem";
            this.modificarPolizaDetalleToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.modificarPolizaDetalleToolStripMenuItem.Text = "Modificar Poliza Detalle";
            this.modificarPolizaDetalleToolStripMenuItem.Click += new System.EventHandler(this.modificarPolizaDetalleToolStripMenuItem_Click);
            // 
            // frmContabilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(1444, 885);
            this.MinimumSize = new System.Drawing.Size(964, 592);
            this.Name = "frmContabilidad";
            this.Text = "Andrea Guerra 0901-18-858 Polizas Contables";
            this.Load += new System.EventHandler(this.frmContabilidad_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polizasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presupuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoTipoPólizaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoEncabezadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoTipoCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoTipoOperaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleDePólizaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoCuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarEncabezadoPolizaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarPolizaDetalleToolStripMenuItem;
    }
}