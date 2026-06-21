namespace Oasis_Sports
{
    partial class FrmBitacora
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
            dgvBitacora = new DataGridView();
            txtUsuario = new TextBox();
            cmbCriticidad = new ComboBox();
            dtpDesde = new DateTimePicker();
            dtpHasta = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBitacora).BeginInit();
            SuspendLayout();
            // 
            // dgvBitacora
            // 
            dgvBitacora.AllowUserToAddRows = false;
            dgvBitacora.BackgroundColor = Color.DarkGreen;
            dgvBitacora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBitacora.Location = new Point(316, 12);
            dgvBitacora.Name = "dgvBitacora";
            dgvBitacora.ReadOnly = true;
            dgvBitacora.Size = new Size(708, 504);
            dgvBitacora.TabIndex = 0;
            dgvBitacora.CellContentClick += dgvBitacora_CellContentClick;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(133, 76);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(157, 29);
            txtUsuario.TabIndex = 1;
            // 
            // cmbCriticidad
            // 
            cmbCriticidad.FormattingEnabled = true;
            cmbCriticidad.Location = new Point(133, 110);
            cmbCriticidad.Name = "cmbCriticidad";
            cmbCriticidad.Size = new Size(157, 29);
            cmbCriticidad.TabIndex = 2;
            // 
            // dtpDesde
            // 
            dtpDesde.Location = new Point(133, 145);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(157, 29);
            dtpDesde.TabIndex = 3;
            // 
            // dtpHasta
            // 
            dtpHasta.Location = new Point(133, 180);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(157, 29);
            dtpHasta.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(53, 239);
            button1.Name = "button1";
            button1.Size = new Size(186, 32);
            button1.TabIndex = 5;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(53, 279);
            button2.Name = "button2";
            button2.Size = new Size(186, 32);
            button2.TabIndex = 6;
            button2.Text = "Limpiar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(53, 33);
            label1.Name = "label1";
            label1.Size = new Size(157, 21);
            label1.TabIndex = 7;
            label1.Text = "Bitacora de eventos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 84);
            label2.Name = "label2";
            label2.Size = new Size(68, 21);
            label2.TabIndex = 8;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 145);
            label3.Name = "label3";
            label3.Size = new Size(57, 21);
            label3.TabIndex = 9;
            label3.Text = "Desde";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 183);
            label4.Name = "label4";
            label4.Size = new Size(52, 21);
            label4.TabIndex = 10;
            label4.Text = "Hasta";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 114);
            label5.Name = "label5";
            label5.Size = new Size(83, 21);
            label5.TabIndex = 11;
            label5.Text = "Criticidad";
            label5.Click += label5_Click;
            // 
            // button3
            // 
            button3.Location = new Point(53, 320);
            button3.Name = "button3";
            button3.Size = new Size(186, 32);
            button3.TabIndex = 12;
            button3.Text = "Volver";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // FrmBitacora
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 537);
            Controls.Add(button3);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dtpHasta);
            Controls.Add(dtpDesde);
            Controls.Add(cmbCriticidad);
            Controls.Add(txtUsuario);
            Controls.Add(dgvBitacora);
            Name = "FrmBitacora";
            Text = "FrmBitacora";
            Load += FrmBitacora_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvBitacora).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvBitacora;
        private TextBox txtUsuario;
        private ComboBox cmbCriticidad;
        private DateTimePicker dtpDesde;
        private DateTimePicker dtpHasta;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button3;
    }
}