namespace Oasis_Sports
{
    partial class FrmGestionUsuarios
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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            label2 = new Label();
            txtContraseñaRepetida = new TextBox();
            label3 = new Label();
            btnAñadir = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(305, 0);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(577, 482);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(10, 15);
            label1.Name = "label1";
            label1.Size = new Size(107, 21);
            label1.TabIndex = 1;
            label1.Text = "USUARIO : ";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(12, 37);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(209, 29);
            txtUsuario.TabIndex = 2;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(12, 104);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(209, 29);
            txtContraseña.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkGreen;
            label2.Location = new Point(10, 82);
            label2.Name = "label2";
            label2.Size = new Size(149, 21);
            label2.TabIndex = 3;
            label2.Text = "CONTRASEÑA : ";
            // 
            // txtContraseñaRepetida
            // 
            txtContraseñaRepetida.Location = new Point(10, 170);
            txtContraseñaRepetida.Name = "txtContraseñaRepetida";
            txtContraseñaRepetida.PasswordChar = '*';
            txtContraseñaRepetida.Size = new Size(211, 29);
            txtContraseñaRepetida.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(8, 148);
            label3.Name = "label3";
            label3.Size = new Size(227, 21);
            label3.TabIndex = 5;
            label3.Text = "REPETIR CONTRASEÑA: ";
            // 
            // btnAñadir
            // 
            btnAñadir.BackColor = Color.White;
            btnAñadir.ForeColor = Color.DarkGreen;
            btnAñadir.Location = new Point(12, 229);
            btnAñadir.Name = "btnAñadir";
            btnAñadir.Size = new Size(209, 35);
            btnAñadir.TabIndex = 7;
            btnAñadir.Text = "AÑADIR";
            btnAñadir.UseVisualStyleBackColor = false;
            btnAñadir.Click += btnAñadir_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = Color.White;
            btnModificar.ForeColor = Color.DarkGreen;
            btnModificar.Location = new Point(12, 285);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(209, 35);
            btnModificar.TabIndex = 8;
            btnModificar.Text = "MODIFICAR";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.White;
            btnEliminar.ForeColor = Color.DarkGreen;
            btnEliminar.Location = new Point(12, 339);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(209, 35);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.ForeColor = Color.DarkGreen;
            button1.Location = new Point(12, 392);
            button1.Name = "button1";
            button1.Size = new Size(209, 35);
            button1.TabIndex = 10;
            button1.Text = "VOLVER";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FrmGestionUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(881, 482);
            Controls.Add(button1);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAñadir);
            Controls.Add(txtContraseñaRepetida);
            Controls.Add(label3);
            Controls.Add(txtContraseña);
            Controls.Add(label2);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Name = "FrmGestionUsuarios";
            Text = "FrmGestionUsuarios";
            Load += FrmGestionUsuarios_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Label label2;
        private TextBox txtContraseñaRepetida;
        private Label label3;
        private Button btnAñadir;
        private Button btnModificar;
        private Button btnEliminar;
        private Button button1;
    }
}