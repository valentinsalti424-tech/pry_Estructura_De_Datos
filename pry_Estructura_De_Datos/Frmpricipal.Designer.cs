namespace pry_Estructura_De_Datos
{
    partial class Frmpricipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eLinialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pilaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lDCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enoLinialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arbolesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.graposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDEDatodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosDelDesarrolladorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mostratUnaTablaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.operecacionesEnBaseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasVariasConOperacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.eLinialesToolStripMenuItem,
            this.enoLinialesToolStripMenuItem,
            this.baseDEDatodToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(465, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosDelDesarrolladorToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // eLinialesToolStripMenuItem
            // 
            this.eLinialesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.colaToolStripMenuItem,
            this.pilaToolStripMenuItem,
            this.lsToolStripMenuItem,
            this.lDCToolStripMenuItem});
            this.eLinialesToolStripMenuItem.Name = "eLinialesToolStripMenuItem";
            this.eLinialesToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.eLinialesToolStripMenuItem.Text = "E.Liniales ";
            // 
            // colaToolStripMenuItem
            // 
            this.colaToolStripMenuItem.Name = "colaToolStripMenuItem";
            this.colaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colaToolStripMenuItem.Text = "cola";
            // 
            // pilaToolStripMenuItem
            // 
            this.pilaToolStripMenuItem.Name = "pilaToolStripMenuItem";
            this.pilaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.pilaToolStripMenuItem.Text = "pila";
            // 
            // lsToolStripMenuItem
            // 
            this.lsToolStripMenuItem.Name = "lsToolStripMenuItem";
            this.lsToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.lsToolStripMenuItem.Text = "Lista enlazada simple";
            this.lsToolStripMenuItem.Click += new System.EventHandler(this.lsToolStripMenuItem_Click);
            // 
            // lDCToolStripMenuItem
            // 
            this.lDCToolStripMenuItem.Name = "lDCToolStripMenuItem";
            this.lDCToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.lDCToolStripMenuItem.Text = "Lista doblamente enlazada";
            // 
            // enoLinialesToolStripMenuItem
            // 
            this.enoLinialesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arbolesToolStripMenuItem,
            this.graposToolStripMenuItem});
            this.enoLinialesToolStripMenuItem.Name = "enoLinialesToolStripMenuItem";
            this.enoLinialesToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.enoLinialesToolStripMenuItem.Text = "E.no.Liniales ";
            // 
            // arbolesToolStripMenuItem
            // 
            this.arbolesToolStripMenuItem.Name = "arbolesToolStripMenuItem";
            this.arbolesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.arbolesToolStripMenuItem.Text = "Arboles";
            // 
            // graposToolStripMenuItem
            // 
            this.graposToolStripMenuItem.Name = "graposToolStripMenuItem";
            this.graposToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.graposToolStripMenuItem.Text = "Grafos";
            // 
            // baseDEDatodToolStripMenuItem
            // 
            this.baseDEDatodToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostratUnaTablaToolStripMenuItem,
            this.consultaDeBaseDeDatosToolStripMenuItem,
            this.operecacionesEnBaseDeDatosToolStripMenuItem,
            this.consultasVariasConOperacionesToolStripMenuItem});
            this.baseDEDatodToolStripMenuItem.Name = "baseDEDatodToolStripMenuItem";
            this.baseDEDatodToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.baseDEDatodToolStripMenuItem.Text = "Basa De Datos";
            // 
            // datosDelDesarrolladorToolStripMenuItem
            // 
            this.datosDelDesarrolladorToolStripMenuItem.Name = "datosDelDesarrolladorToolStripMenuItem";
            this.datosDelDesarrolladorToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.datosDelDesarrolladorToolStripMenuItem.Text = "Datos del desarrollador";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // mostratUnaTablaToolStripMenuItem
            // 
            this.mostratUnaTablaToolStripMenuItem.Name = "mostratUnaTablaToolStripMenuItem";
            this.mostratUnaTablaToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.mostratUnaTablaToolStripMenuItem.Text = "Mostrat una tabla ";
            // 
            // consultaDeBaseDeDatosToolStripMenuItem
            // 
            this.consultaDeBaseDeDatosToolStripMenuItem.Name = "consultaDeBaseDeDatosToolStripMenuItem";
            this.consultaDeBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.consultaDeBaseDeDatosToolStripMenuItem.Text = "Consulta de base de datos ";
            // 
            // operecacionesEnBaseDeDatosToolStripMenuItem
            // 
            this.operecacionesEnBaseDeDatosToolStripMenuItem.Name = "operecacionesEnBaseDeDatosToolStripMenuItem";
            this.operecacionesEnBaseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.operecacionesEnBaseDeDatosToolStripMenuItem.Text = "Operecaciones en base de datos ";
            // 
            // consultasVariasConOperacionesToolStripMenuItem
            // 
            this.consultasVariasConOperacionesToolStripMenuItem.Name = "consultasVariasConOperacionesToolStripMenuItem";
            this.consultasVariasConOperacionesToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.consultasVariasConOperacionesToolStripMenuItem.Text = "Consultas varias con operaciones";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(465, 446);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Sistema";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eLinialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pilaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lDCToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enoLinialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arbolesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem graposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDEDatodToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosDelDesarrolladorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mostratUnaTablaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem operecacionesEnBaseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasVariasConOperacionesToolStripMenuItem;
    }
}

