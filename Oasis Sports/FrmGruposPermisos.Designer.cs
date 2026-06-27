namespace Oasis_Sports
{
    partial class FrmGruposPermisos
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
            textBox1 = new TextBox();
            label1 = new Label();
            lstPermisosDisponibles = new ListBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lstPermisosDelGrupo = new ListBox();
            btnAgregar = new Button();
            btnQuitar = new Button();
            btnGuardar = new Button();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(329, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(154, 29);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(171, 47);
            label1.Name = "label1";
            label1.Size = new Size(152, 21);
            label1.TabIndex = 1;
            label1.Text = "Nombre de grupo: ";
            // 
            // lstPermisosDisponibles
            // 
            lstPermisosDisponibles.FormattingEnabled = true;
            lstPermisosDisponibles.ItemHeight = 21;
            lstPermisosDisponibles.Location = new Point(30, 22);
            lstPermisosDisponibles.Name = "lstPermisosDisponibles";
            lstPermisosDisponibles.Size = new Size(182, 235);
            lstPermisosDisponibles.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lstPermisosDisponibles);
            groupBox1.Location = new Point(51, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(244, 276);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Permisos disponibles";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lstPermisosDelGrupo);
            groupBox2.Location = new Point(504, 103);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(240, 276);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Permisos del grupo";
            // 
            // lstPermisosDelGrupo
            // 
            lstPermisosDelGrupo.FormattingEnabled = true;
            lstPermisosDelGrupo.ItemHeight = 21;
            lstPermisosDelGrupo.Location = new Point(30, 22);
            lstPermisosDelGrupo.Name = "lstPermisosDelGrupo";
            lstPermisosDelGrupo.Size = new Size(182, 235);
            lstPermisosDelGrupo.TabIndex = 2;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(329, 141);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(153, 38);
            btnAgregar.TabIndex = 5;
            btnAgregar.Text = "AGREGAR";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnQuitar
            // 
            btnQuitar.Location = new Point(330, 198);
            btnQuitar.Name = "btnQuitar";
            btnQuitar.Size = new Size(153, 38);
            btnQuitar.TabIndex = 6;
            btnQuitar.Text = "QUITAR";
            btnQuitar.UseVisualStyleBackColor = true;
            btnQuitar.Click += btnQuitar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(329, 258);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(153, 38);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // button1
            // 
            button1.Location = new Point(329, 313);
            button1.Name = "button1";
            button1.Size = new Size(153, 38);
            button1.TabIndex = 8;
            button1.Text = "VOLVER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmGruposPermisos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnGuardar);
            Controls.Add(btnQuitar);
            Controls.Add(btnAgregar);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "FrmGruposPermisos";
            Text = "FrmGruposPermisos";
            Load += FrmGruposPermisos_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private ListBox lstPermisosDisponibles;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private ListBox lstPermisosDelGrupo;
        private Button btnAgregar;
        private Button btnQuitar;
        private Button btnGuardar;
        private Button button1;
    }
}