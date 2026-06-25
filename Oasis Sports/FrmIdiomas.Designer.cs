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
            btnVolver = new Button();
            lblIdioma = new Label();
            SuspendLayout();
          
            cmbIdiomas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIdiomas.Location = new Point(20, 92);
            cmbIdiomas.Name = "cmbIdiomas";
            cmbIdiomas.Size = new Size(200, 29);
            cmbIdiomas.TabIndex = 5;
           
            lstClaves.ItemHeight = 21;
            lstClaves.Location = new Point(422, 92);
            lstClaves.Name = "lstClaves";
            lstClaves.Size = new Size(270, 361);
            lstClaves.TabIndex = 7;
            lstClaves.SelectedIndexChanged += lstClaves_SelectedIndexChanged;
            
            txtClave.Location = new Point(20, 145);
            txtClave.Name = "txtClave";
            txtClave.ReadOnly = true;
            txtClave.Size = new Size(340, 29);
            txtClave.TabIndex = 8;
            
            txtTexto.Location = new Point(20, 195);
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(340, 29);
            txtTexto.TabIndex = 9;
           
            txtNuevoIdioma.Location = new Point(20, 335);
            txtNuevoIdioma.Name = "txtNuevoIdioma";
            txtNuevoIdioma.Size = new Size(190, 29);
            txtNuevoIdioma.TabIndex = 12;
             
            btnGuardar.Location = new Point(20, 239);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(180, 30);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar traducción";
            btnGuardar.Click += btnGuardar_Click;
            
            btnNuevoIdioma.Location = new Point(220, 332);
            btnNuevoIdioma.Name = "btnNuevoIdioma";
            btnNuevoIdioma.Size = new Size(130, 30);
            btnNuevoIdioma.TabIndex = 13;
            btnNuevoIdioma.Text = "Crear idioma";
            btnNuevoIdioma.Click += btnNuevoIdioma_Click;
            
            btnCambiarIdioma.Location = new Point(226, 91);
            btnCambiarIdioma.Name = "btnCambiarIdioma";
            btnCambiarIdioma.Size = new Size(190, 28);
            btnCambiarIdioma.TabIndex = 6;
            btnCambiarIdioma.Text = "Aplicar idioma a la app";
            btnCambiarIdioma.Click += btnCambiarIdioma_Click;
           
            btnRegistrarClaves.Location = new Point(20, 288);
            btnRegistrarClaves.Name = "btnRegistrarClaves";
            btnRegistrarClaves.Size = new Size(279, 30);
            btnRegistrarClaves.TabIndex = 11;
            btnRegistrarClaves.Text = "Registrar claves";
            btnRegistrarClaves.Click += btnRegistrarClaves_Click;
          
            lblIdiomaActivo.Location = new Point(0, 0);
            lblIdiomaActivo.Name = "lblIdiomaActivo";
            lblIdiomaActivo.Size = new Size(100, 23);
            lblIdiomaActivo.TabIndex = 0;
           
            lblClaves.Location = new Point(0, 0);
            lblClaves.Name = "lblClaves";
            lblClaves.Size = new Size(100, 23);
            lblClaves.TabIndex = 1;
          
            lblClave.Location = new Point(0, 0);
            lblClave.Name = "lblClave";
            lblClave.Size = new Size(100, 23);
            lblClave.TabIndex = 2;
             
            lblTexto.Location = new Point(0, 0);
            lblTexto.Name = "lblTexto";
            lblTexto.Size = new Size(100, 23);
            lblTexto.TabIndex = 3;
           
            lblNuevoIdioma.Location = new Point(0, 0);
            lblNuevoIdioma.Name = "lblNuevoIdioma";
            lblNuevoIdioma.Size = new Size(100, 23);
            lblNuevoIdioma.TabIndex = 4;
            
            btnVolver.Location = new Point(20, 405);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(98, 38);
            btnVolver.TabIndex = 14;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += button1_Click;
           
            lblIdioma.AutoSize = true;
            lblIdioma.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblIdioma.Location = new Point(247, 25);
            lblIdioma.Name = "lblIdioma";
            lblIdioma.Size = new Size(197, 27);
            lblIdioma.TabIndex = 15;
            lblIdioma.Text = "Gestion de Idiomas";
             
            AutoScaleDimensions = new SizeF(7F, 15F);
            ClientSize = new Size(700, 470);
            Controls.Add(lblIdioma);
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
            Controls.Add(btnVolver);
            Name = "FrmIdiomas";
            Text = "Gestión de Idiomas";
            FormClosing += FrmIdiomas_FormClosing;
            Load += FrmIdiomas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

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
        private Button btnVolver;
        private Label lblIdioma;
    }
}
