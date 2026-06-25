namespace Oasis_Sports
{
    partial class FrmSeleccionIdioma
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
            btnConfirmar = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
           
            cmbIdiomas.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbIdiomas.Location = new Point(55, 105);
            cmbIdiomas.Name = "cmbIdiomas";
            cmbIdiomas.Size = new Size(270, 23);
            cmbIdiomas.TabIndex = 2;
             
            btnConfirmar.Location = new Point(126, 155);
            btnConfirmar.Name = "btnConfirmar";
            btnConfirmar.Size = new Size(120, 35);
            btnConfirmar.TabIndex = 3;
            btnConfirmar.Text = "Confirmar";
            btnConfirmar.Click += btnConfirmar_Click;
             
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(126, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 30);
            label1.TabIndex = 4;
            label1.Text = "Bienvenido";
           
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(87, 58);
            label2.Name = "label2";
            label2.Size = new Size(202, 30);
            label2.TabIndex = 5;
            label2.Text = "Selecciona el idioma";
          
            ClientSize = new Size(374, 211);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbIdiomas);
            Controls.Add(btnConfirmar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSeleccionIdioma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selección de idioma";
            Load += FrmSeleccionIdioma_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private ComboBox cmbIdiomas;
        private Button btnConfirmar;
        private Label label1;
        private Label label2;
    }
}