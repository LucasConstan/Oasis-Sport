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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            menuStrip1 = new MenuStrip();
            uSUARIOToolStripMenuItem = new ToolStripMenuItem();
            lOGINToolStripMenuItem = new ToolStripMenuItem();
            lOGOUTToolStripMenuItem = new ToolStripMenuItem();
            bitacoraToolStripMenuItem = new ToolStripMenuItem();
            bITACORAToolStripMenuItem1 = new ToolStripMenuItem();
            gESTIONDEUSUARIOSToolStripMenuItem = new ToolStripMenuItem();
            gESTIONDEPERFILESToolStripMenuItem = new ToolStripMenuItem();
            gESTIONDERESERVASToolStripMenuItem = new ToolStripMenuItem();
            sALIRToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { uSUARIOToolStripMenuItem, bitacoraToolStripMenuItem, gESTIONDERESERVASToolStripMenuItem, sALIRToolStripMenuItem });
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
            lOGINToolStripMenuItem.Size = new Size(130, 22);
            lOGINToolStripMenuItem.Text = "LOGIN";
            lOGINToolStripMenuItem.Click += lOGINToolStripMenuItem_Click;
            // 
            // lOGOUTToolStripMenuItem
            // 
            lOGOUTToolStripMenuItem.Name = "lOGOUTToolStripMenuItem";
            lOGOUTToolStripMenuItem.Size = new Size(130, 22);
            lOGOUTToolStripMenuItem.Text = "LOGOUT";
            lOGOUTToolStripMenuItem.Click += lOGOUTToolStripMenuItem_Click;
            // 
            // bitacoraToolStripMenuItem
            // 
            bitacoraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bITACORAToolStripMenuItem1, gESTIONDEUSUARIOSToolStripMenuItem, gESTIONDEPERFILESToolStripMenuItem });
            bitacoraToolStripMenuItem.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bitacoraToolStripMenuItem.Name = "bitacoraToolStripMenuItem";
            bitacoraToolStripMenuItem.Size = new Size(63, 20);
            bitacoraToolStripMenuItem.Text = "ADMIN";
            bitacoraToolStripMenuItem.Visible = false;
            bitacoraToolStripMenuItem.Click += bitacoraToolStripMenuItem_Click;
            bitacoraToolStripMenuItem.VisibleChanged += bitacoraToolStripMenuItem_VisibleChanged;
            // 
            // bITACORAToolStripMenuItem1
            // 
            bITACORAToolStripMenuItem1.Name = "bITACORAToolStripMenuItem1";
            bITACORAToolStripMenuItem1.Size = new Size(214, 22);
            bITACORAToolStripMenuItem1.Text = "BITACORA DE EVENTOS";
            bITACORAToolStripMenuItem1.Click += bITACORAToolStripMenuItem1_Click;
            // 
            // gESTIONDEUSUARIOSToolStripMenuItem
            // 
            gESTIONDEUSUARIOSToolStripMenuItem.Name = "gESTIONDEUSUARIOSToolStripMenuItem";
            gESTIONDEUSUARIOSToolStripMenuItem.Size = new Size(214, 22);
            gESTIONDEUSUARIOSToolStripMenuItem.Text = "GESTION DE USUARIOS";
            gESTIONDEUSUARIOSToolStripMenuItem.Click += gESTIONDEUSUARIOSToolStripMenuItem_Click;
            // 
            // gESTIONDEPERFILESToolStripMenuItem
            // 
            gESTIONDEPERFILESToolStripMenuItem.Name = "gESTIONDEPERFILESToolStripMenuItem";
            gESTIONDEPERFILESToolStripMenuItem.Size = new Size(214, 22);
            gESTIONDEPERFILESToolStripMenuItem.Text = "GESTION DE PERFILES";
            gESTIONDEPERFILESToolStripMenuItem.Click += gESTIONDEPERFILESToolStripMenuItem_Click;
            // 
            // gESTIONDERESERVASToolStripMenuItem
            // 
            gESTIONDERESERVASToolStripMenuItem.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gESTIONDERESERVASToolStripMenuItem.Name = "gESTIONDERESERVASToolStripMenuItem";
            gESTIONDERESERVASToolStripMenuItem.Size = new Size(149, 20);
            gESTIONDERESERVASToolStripMenuItem.Text = "GESTION DE RESERVAS";
            gESTIONDERESERVASToolStripMenuItem.Visible = false;
            // 
            // sALIRToolStripMenuItem
            // 
            sALIRToolStripMenuItem.Font = new Font("Times New Roman", 10F);
            sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            sALIRToolStripMenuItem.Size = new Size(58, 20);
            sALIRToolStripMenuItem.Text = "SALIR";
            sALIRToolStripMenuItem.Click += sALIRToolStripMenuItem_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmMenu";
            Text = "FrmMenu";
            Load += FrmMenu_Load;
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
        private ToolStripMenuItem lOGOUTToolStripMenuItem;
        private ToolStripMenuItem bitacoraToolStripMenuItem;
        private ToolStripMenuItem bITACORAToolStripMenuItem1;
        private ToolStripMenuItem gESTIONDEUSUARIOSToolStripMenuItem;
        private ToolStripMenuItem gESTIONDEPERFILESToolStripMenuItem;
        private ToolStripMenuItem gESTIONDERESERVASToolStripMenuItem;
    }
}