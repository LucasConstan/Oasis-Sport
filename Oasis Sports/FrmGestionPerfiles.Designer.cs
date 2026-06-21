namespace Oasis_Sports
{
    partial class FrmGestionPerfiles
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
            treeView1 = new TreeView();
            label1 = new Label();
            cmbUsuarios = new ComboBox();
            label2 = new Label();
            btnAgregar = new Button();
            btnQuitar = new Button();
            lstDisponibles = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // treeView1
            // 
            treeView1.Location = new Point(316, 53);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(465, 379);
            treeView1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(316, 18);
            label1.Name = "label1";
            label1.Size = new Size(189, 21);
            label1.TabIndex = 1;
            label1.Text = "PERMISOS ACTIVOS";
            // 
            // cmbUsuarios
            // 
            cmbUsuarios.FormattingEnabled = true;
            cmbUsuarios.Location = new Point(34, 77);
            cmbUsuarios.Name = "cmbUsuarios";
            cmbUsuarios.Size = new Size(195, 29);
            cmbUsuarios.TabIndex = 2;
            cmbUsuarios.SelectedIndexChanged += cmbUsuarios_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 53);
            label2.Name = "label2";
            label2.Size = new Size(76, 21);
            label2.TabIndex = 3;
            label2.Text = "Usuarios";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(32, 330);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(192, 43);
            btnAgregar.TabIndex = 4;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(32, 379);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(192, 43);
            btnQuitar.TabIndex = 5;
            btnQuitar.Text = "QUITAR";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // lstDisponibles
            // 
            lstDisponibles.FormattingEnabled = true;
            lstDisponibles.ItemHeight = 21;
            lstDisponibles.Location = new Point(32, 130);
            lstDisponibles.Name = "lstDisponibles";
            lstDisponibles.Size = new Size(197, 172);
            lstDisponibles.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(32, 428);
            button1.Name = "button1";
            button1.Size = new Size(192, 43);
            button1.TabIndex = 7;
            button1.Text = "VOLVER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmGestionPerfiles
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 494);
            Controls.Add(button1);
            Controls.Add(lstDisponibles);
            Controls.Add(btnQuitar);
            Controls.Add(btnAgregar);
            Controls.Add(label2);
            Controls.Add(cmbUsuarios);
            Controls.Add(label1);
            Controls.Add(treeView1);
            Name = "FrmGestionPerfiles";
            Text = "FrmGestionPerfiles";
            Load += FrmGestionPerfiles_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeView1;
        private Label label1;
        private ComboBox cmbUsuarios;
        private Label label2;
        private Button btnAgregar;
        private Button btnQuitar;
        private ListBox lstDisponibles;
        private Button button1;
    }
}