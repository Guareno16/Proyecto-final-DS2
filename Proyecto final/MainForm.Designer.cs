
namespace Proyecto_final
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.detalleDeVuelosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirNuevoVueloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.añadirNueboClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detalleDeTicketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservarNuevoTicketToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detalleDeVuelosToolStripMenuItem,
            this.detalleDeClientesToolStripMenuItem,
            this.detalleDeTicketsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(942, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // detalleDeVuelosToolStripMenuItem
            // 
            this.detalleDeVuelosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirNuevoVueloToolStripMenuItem});
            this.detalleDeVuelosToolStripMenuItem.Name = "detalleDeVuelosToolStripMenuItem";
            this.detalleDeVuelosToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.detalleDeVuelosToolStripMenuItem.Text = "Detalle de vuelos";
            // 
            // añadirNuevoVueloToolStripMenuItem
            // 
            this.añadirNuevoVueloToolStripMenuItem.Name = "añadirNuevoVueloToolStripMenuItem";
            this.añadirNuevoVueloToolStripMenuItem.Size = new System.Drawing.Size(225, 22);
            this.añadirNuevoVueloToolStripMenuItem.Text = "Añadir Informacion de vuelo";
            this.añadirNuevoVueloToolStripMenuItem.Click += new System.EventHandler(this.añadirNuevoVueloToolStripMenuItem_Click);
            // 
            // detalleDeClientesToolStripMenuItem
            // 
            this.detalleDeClientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.añadirNueboClienteToolStripMenuItem,
            this.buscarClienteToolStripMenuItem});
            this.detalleDeClientesToolStripMenuItem.Name = "detalleDeClientesToolStripMenuItem";
            this.detalleDeClientesToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.detalleDeClientesToolStripMenuItem.Text = "Detalle de clientes";
            // 
            // añadirNueboClienteToolStripMenuItem
            // 
            this.añadirNueboClienteToolStripMenuItem.Name = "añadirNueboClienteToolStripMenuItem";
            this.añadirNueboClienteToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.añadirNueboClienteToolStripMenuItem.Text = "Añadir nuevo cliente";
            this.añadirNueboClienteToolStripMenuItem.Click += new System.EventHandler(this.añadirNueboClienteToolStripMenuItem_Click);
            // 
            // buscarClienteToolStripMenuItem
            // 
            this.buscarClienteToolStripMenuItem.Name = "buscarClienteToolStripMenuItem";
            this.buscarClienteToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.buscarClienteToolStripMenuItem.Text = "Buscar Cliente";
            this.buscarClienteToolStripMenuItem.Click += new System.EventHandler(this.buscarClienteToolStripMenuItem_Click);
            // 
            // detalleDeTicketsToolStripMenuItem
            // 
            this.detalleDeTicketsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservarNuevoTicketToolStripMenuItem});
            this.detalleDeTicketsToolStripMenuItem.Name = "detalleDeTicketsToolStripMenuItem";
            this.detalleDeTicketsToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.detalleDeTicketsToolStripMenuItem.Text = "Detalle de Tickets";
            // 
            // reservarNuevoTicketToolStripMenuItem
            // 
            this.reservarNuevoTicketToolStripMenuItem.Name = "reservarNuevoTicketToolStripMenuItem";
            this.reservarNuevoTicketToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.reservarNuevoTicketToolStripMenuItem.Text = "Reservar Nuevo Ticket";
            this.reservarNuevoTicketToolStripMenuItem.Click += new System.EventHandler(this.reservarNuevoTicketToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(942, 565);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem detalleDeVuelosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirNuevoVueloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem añadirNueboClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detalleDeTicketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservarNuevoTicketToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}