namespace Oasis_Sports
{
    partial class FrmIdiomas
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cmbIdiomas = new ComboBox();
            lstClaves = new ListBox();
            txtClave = new TextBox();
            txtTexto = new TextBox();
            txtNuevoIdioma = new TextBox();
            btnGuardar = new Button();
            btnNuevoIdioma = new Button();
            btnCambiarIdioma = new Button();
            btnRegistrarClaves = new Button();
            lblIdiomaActivo = new Label();
            lblClaves = new Label();
            lblClave = new Label();
            lblTexto = new Label();
            lblNuevoIdioma = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // cmbIdiomas
            // 
            cmbIdiomas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIdiomas.Location = new Point(20, 38);
            cmbIdiomas.Name = "cmbIdiomas";
            cmbIdiomas.Size = new Size(200, 29);
            cmbIdiomas.TabIndex = 5;
            // 
            // lstClaves
            // 
            lstClaves.ItemHeight = 21;
            lstClaves.Location = new Point(20, 85);
            lstClaves.Name = "lstClaves";
            lstClaves.Size = new Size(270, 235);
            lstClaves.TabIndex = 7;
            lstClaves.SelectedIndexChanged += lstClaves_SelectedIndexChanged;
            // 
            // txtClave
            // 
            txtClave.Location = new Point(310, 85);
            txtClave.Name = "txtClave";
            txtClave.ReadOnly = true;
            txtClave.Size = new Size(340, 29);
            txtClave.TabIndex = 8;
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(310, 135);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(340, 29);
            txtTexto.TabIndex = 9;
            // 
            // txtNuevoIdioma
            // 
            txtNuevoIdioma.Location = new Point(20, 380);
            txtNuevoIdioma.Name = "txtNuevoIdioma";
            txtNuevoIdioma.Size = new Size(190, 29);
            txtNuevoIdioma.TabIndex = 12;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(310, 175);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(180, 30);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar traducción";
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevoIdioma
            // 
            btnNuevoIdioma.Location = new Point(220, 377);
            btnNuevoIdioma.Name = "btnNuevoIdioma";
            btnNuevoIdioma.Size = new Size(130, 30);
            btnNuevoIdioma.TabIndex = 13;
            btnNuevoIdioma.Text = "Crear idioma";
            btnNuevoIdioma.Click += btnNuevoIdioma_Click;
            // 
            // btnCambiarIdioma
            // 
            btnCambiarIdioma.Location = new Point(230, 36);
            btnCambiarIdioma.Name = "btnCambiarIdioma";
            btnCambiarIdioma.Size = new Size(190, 28);
            btnCambiarIdioma.TabIndex = 6;
            btnCambiarIdioma.Text = "Aplicar idioma a la app";
            btnCambiarIdioma.Click += btnCambiarIdioma_Click;
            // 
            // btnRegistrarClaves
            // 
            btnRegistrarClaves.Location = new Point(310, 220);
            btnRegistrarClaves.Name = "btnRegistrarClaves";
            btnRegistrarClaves.Size = new Size(279, 30);
            btnRegistrarClaves.TabIndex = 11;
            btnRegistrarClaves.Text = "Auto-registrar claves de Login";
            btnRegistrarClaves.Click += btnRegistrarClaves_Click;
            // 
            // lblIdiomaActivo
            // 
            lblIdiomaActivo.Location = new Point(0, 0);
            lblIdiomaActivo.Name = "lblIdiomaActivo";
            lblIdiomaActivo.Size = new Size(100, 23);
            lblIdiomaActivo.TabIndex = 0;
            // 
            // lblClaves
            // 
            lblClaves.Location = new Point(0, 0);
            lblClaves.Name = "lblClaves";
            lblClaves.Size = new Size(100, 23);
            lblClaves.TabIndex = 1;
            // 
            // lblClave
            // 
            lblClave.Location = new Point(0, 0);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(100, 23);
            lblClave.TabIndex = 2;
            // 
            // lblTexto
            // 
            lblTexto.Location = new Point(0, 0);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(100, 23);
            lblTexto.TabIndex = 3;
            // 
            // lblNuevoIdioma
            // 
            lblNuevoIdioma.Location = new Point(0, 0);
            lblNuevoIdioma.Name = "lblNuevoIdioma";
            lblNuevoIdioma.Size = new Size(100, 23);
            lblNuevoIdioma.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(491, 343);
            button1.Name = "button1";
            button1.Size = new Size(98, 38);
            button1.TabIndex = 14;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FrmIdiomas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(700, 470);
            Controls.Add(lstClaves);
            Controls.Add(lblIdiomaActivo);
            Controls.Add(lblClaves);
            Controls.Add(lblClave);
            Controls.Add(lblTexto);
            Controls.Add(lblNuevoIdioma);
            Controls.Add(cmbIdiomas);
            Controls.Add(btnCambiarIdioma);
            Controls.Add(txtClave);
            Controls.Add(txtTexto);
            Controls.Add(btnGuardar);
            Controls.Add(btnRegistrarClaves);
            Controls.Add(txtNuevoIdioma);
            Controls.Add(btnNuevoIdioma);
            Controls.Add(button1);
            Name = "FrmIdiomas";
            Text = "Gestión de Idiomas";
            FormClosing += FrmIdiomas_FormClosing;
            Load += FrmIdiomas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        // ── Declaración de controles ───────────────────────────────────────────
        private ComboBox cmbIdiomas;
        private ListBox lstClaves;
        private TextBox txtClave;
        private TextBox txtTexto;
        private TextBox txtNuevoIdioma;
        private Button btnGuardar;
        private Button btnNuevoIdioma;
        private Button btnCambiarIdioma;
        private Button btnRegistrarClaves;
        private Label lblIdiomaActivo;
        private Label lblClaves;
        private Label lblClave;
        private Label lblTexto;
        private Label lblNuevoIdioma;
        private Button button1;
    }
}
