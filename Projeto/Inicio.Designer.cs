namespace Projeto
{
    partial class Inicio
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
            inícioToolStripMenuItem = new ToolStripMenuItem();
            cadastroToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.ControlLight;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { inícioToolStripMenuItem, cadastroToolStripMenuItem, sobreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.RightToLeft = RightToLeft.No;
            menuStrip1.Size = new Size(186, 450);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // inícioToolStripMenuItem
            // 
            inícioToolStripMenuItem.Font = new Font("Arial", 9F);
            inícioToolStripMenuItem.Name = "inícioToolStripMenuItem";
            inícioToolStripMenuItem.Padding = new Padding(6, 0, 6, 50);
            inícioToolStripMenuItem.Size = new Size(173, 75);
            inícioToolStripMenuItem.Text = "Início";
            inícioToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            inícioToolStripMenuItem.Click += inícioToolStripMenuItem_Click;
            // 
            // cadastroToolStripMenuItem
            // 
            cadastroToolStripMenuItem.Font = new Font("Arial", 9F);
            cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            cadastroToolStripMenuItem.Padding = new Padding(6, 0, 6, 50);
            cadastroToolStripMenuItem.Size = new Size(173, 75);
            cadastroToolStripMenuItem.Text = "Cadastro";
            cadastroToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Font = new Font("Arial", 9F);
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Padding = new Padding(6, 0, 6, 50);
            sobreToolStripMenuItem.Size = new Size(173, 75);
            sobreToolStripMenuItem.Text = "Sobre";
            sobreToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            sobreToolStripMenuItem.Click += sobreToolStripMenuItem_Click;
            // 
            // Inicio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.ButtonFace;
            MainMenuStrip = menuStrip1;
            Name = "Inicio";
            Text = "Checkei";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem inícioToolStripMenuItem;
        private ToolStripMenuItem cadastroToolStripMenuItem;
    }
}
