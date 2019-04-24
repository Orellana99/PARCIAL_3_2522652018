namespace Parcial3
{
    partial class Form2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vnetana1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventana1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventana2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vnetana1ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(580, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vnetana1ToolStripMenuItem
            // 
            this.vnetana1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventana1ToolStripMenuItem,
            this.ventana2ToolStripMenuItem});
            this.vnetana1ToolStripMenuItem.Name = "vnetana1ToolStripMenuItem";
            this.vnetana1ToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.vnetana1ToolStripMenuItem.Text = "Menú";
            this.vnetana1ToolStripMenuItem.Click += new System.EventHandler(this.vnetana1ToolStripMenuItem_Click);
            // 
            // ventana1ToolStripMenuItem
            // 
            this.ventana1ToolStripMenuItem.Name = "ventana1ToolStripMenuItem";
            this.ventana1ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ventana1ToolStripMenuItem.Text = "Ventana1";
            // 
            // ventana2ToolStripMenuItem
            // 
            this.ventana2ToolStripMenuItem.Name = "ventana2ToolStripMenuItem";
            this.ventana2ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ventana2ToolStripMenuItem.Text = "Ventana 2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 309);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vnetana1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventana1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventana2ToolStripMenuItem;

    }
}