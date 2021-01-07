namespace Navegador_DCU
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.atras = new System.Windows.Forms.Button();
            this.delante = new System.Windows.Forms.Button();
            this.ir = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.inicio = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPestañaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitarPestañaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.direccion_text = new System.Windows.Forms.TextBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // atras
            // 
            this.atras.Location = new System.Drawing.Point(12, 31);
            this.atras.Name = "atras";
            this.atras.Size = new System.Drawing.Size(35, 23);
            this.atras.TabIndex = 0;
            this.atras.Text = "<";
            this.atras.UseVisualStyleBackColor = true;
            this.atras.Click += new System.EventHandler(this.button1_Click);
            // 
            // delante
            // 
            this.delante.Location = new System.Drawing.Point(53, 31);
            this.delante.Name = "delante";
            this.delante.Size = new System.Drawing.Size(37, 23);
            this.delante.TabIndex = 1;
            this.delante.Text = ">";
            this.delante.UseVisualStyleBackColor = true;
            this.delante.Click += new System.EventHandler(this.button2_Click);
            // 
            // ir
            // 
            this.ir.Location = new System.Drawing.Point(96, 31);
            this.ir.Name = "ir";
            this.ir.Size = new System.Drawing.Size(45, 23);
            this.ir.TabIndex = 2;
            this.ir.Text = "Ir";
            this.ir.UseVisualStyleBackColor = true;
            this.ir.Click += new System.EventHandler(this.button3_Click);
            // 
            // actualizar
            // 
            this.actualizar.Location = new System.Drawing.Point(147, 31);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(81, 23);
            this.actualizar.TabIndex = 3;
            this.actualizar.Text = "Actualizar";
            this.actualizar.UseVisualStyleBackColor = true;
            this.actualizar.Click += new System.EventHandler(this.button4_Click);
            // 
            // inicio
            // 
            this.inicio.Location = new System.Drawing.Point(234, 31);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(78, 23);
            this.inicio.TabIndex = 4;
            this.inicio.Text = "Inicio";
            this.inicio.UseVisualStyleBackColor = true;
            this.inicio.Click += new System.EventHandler(this.button5_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1165, 28);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarPestañaToolStripMenuItem,
            this.quitarPestañaToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.archivoToolStripMenuItem.Text = "Opciones";
            // 
            // agregarPestañaToolStripMenuItem
            // 
            this.agregarPestañaToolStripMenuItem.Name = "agregarPestañaToolStripMenuItem";
            this.agregarPestañaToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.agregarPestañaToolStripMenuItem.Text = "Agregar Pestaña";
            this.agregarPestañaToolStripMenuItem.Click += new System.EventHandler(this.agregarPestañaToolStripMenuItem_Click);
            // 
            // quitarPestañaToolStripMenuItem
            // 
            this.quitarPestañaToolStripMenuItem.Name = "quitarPestañaToolStripMenuItem";
            this.quitarPestañaToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.quitarPestañaToolStripMenuItem.Text = "Quitar Pestaña";
            this.quitarPestañaToolStripMenuItem.Click += new System.EventHandler(this.quitarPestañaToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(200, 26);
            this.infoToolStripMenuItem.Text = "Información";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 537);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1165, 26);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 18);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // direccion_text
            // 
            this.direccion_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.direccion_text.Location = new System.Drawing.Point(318, 33);
            this.direccion_text.Name = "direccion_text";
            this.direccion_text.Size = new System.Drawing.Size(835, 22);
            this.direccion_text.TabIndex = 9;
            this.direccion_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.direccion_text_KeyPress);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1144, 444);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 3);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(1138, 438);
            this.webBrowser1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(13, 61);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1152, 473);
            this.tabControl1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 563);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.direccion_text);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.inicio);
            this.Controls.Add(this.actualizar);
            this.Controls.Add(this.ir);
            this.Controls.Add(this.delante);
            this.Controls.Add(this.atras);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Navegador";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button atras;
        private System.Windows.Forms.Button delante;
        private System.Windows.Forms.Button ir;
        private System.Windows.Forms.Button actualizar;
        private System.Windows.Forms.Button inicio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarPestañaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitarPestañaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox direccion_text;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    }
}

