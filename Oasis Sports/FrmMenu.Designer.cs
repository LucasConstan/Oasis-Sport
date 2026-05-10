namespace Oasis_Sports
{
    partial class FrmMenu
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
            menuStrip1 = new MenuStrip();
            uSUARIOToolStripMenuItem = new ToolStripMenuItem();
            lOGINToolStripMenuItem = new ToolStripMenuItem();
            sALIRToolStripMenuItem = new ToolStripMenuItem();
            label3 = new Label();
            lOGOUTToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { uSUARIOToolStripMenuItem, sALIRToolStripMenuItem });
            menuStrip1.Location = new Point(2, 2);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(796, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // uSUARIOToolStripMenuItem
            // 
            uSUARIOToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lOGINToolStripMenuItem, lOGOUTToolStripMenuItem });
            uSUARIOToolStripMenuItem.Font = new Font("Times New Roman", 10F);
            uSUARIOToolStripMenuItem.Name = "uSUARIOToolStripMenuItem";
            uSUARIOToolStripMenuItem.Size = new Size(78, 20);
            uSUARIOToolStripMenuItem.Text = "USUARIO";
            // 
            // lOGINToolStripMenuItem
            // 
            lOGINToolStripMenuItem.Name = "lOGINToolStripMenuItem";
            lOGINToolStripMenuItem.Size = new Size(180, 22);
            lOGINToolStripMenuItem.Text = "LOGIN";
            lOGINToolStripMenuItem.Click += lOGINToolStripMenuItem_Click;
            // 
            // sALIRToolStripMenuItem
            // 
            sALIRToolStripMenuItem.Font = new Font("Times New Roman", 10F);
            sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            sALIRToolStripMenuItem.Size = new Size(58, 20);
            sALIRToolStripMenuItem.Text = "SALIR";
            sALIRToolStripMenuItem.Click += sALIRToolStripMenuItem_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 40F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.ForestGreen;
            label3.Location = new Point(177, 210);
            label3.Name = "label3";
            label3.Size = new Size(398, 61);
            label3.TabIndex = 6;
            label3.Text = "OASIS SPORTS";
            // 
            // lOGOUTToolStripMenuItem
            // 
            lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            lOGOUTToolStripMenuItem.Size = new Size(180, 22);
            lOGOUTToolStripMenuItem.Text = "LOGOUT";
            lOGOUTToolStripMenuItem.Click += lOGOUTToolStripMenuItem_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu";
            Text = "FrmMenu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem uSUARIOToolStripMenuItem;
        private ToolStripMenuItem lOGINToolStripMenuItem;
        private ToolStripMenuItem sALIRToolStripMenuItem;
        private Label label3;
        private ToolStripMenuItem lOGOUTToolStripMenuItem;
    }
}