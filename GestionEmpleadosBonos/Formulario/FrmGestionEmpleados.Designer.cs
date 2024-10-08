namespace GestionEmpleadosBonos
{
    partial class FrmGestionEmpleados
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbTipoEmpleado;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Button btnCalcularBono;
        private System.Windows.Forms.Button btnMostrarInfo;
        private System.Windows.Forms.Label lblTipoEmpleado;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblSalario;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            cmbTipoEmpleado = new ComboBox();
            txtNombre = new TextBox();
            txtSalario = new TextBox();
            btnCalcularBono = new Button();
            btnMostrarInfo = new Button();
            lblTipoEmpleado = new Label();
            lblNombre = new Label();
            lblSalario = new Label();
            panel1 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cmbTipoEmpleado
            // 
            cmbTipoEmpleado.FormattingEnabled = true;
            cmbTipoEmpleado.Items.AddRange(new object[] { "Gerente", "Programador" });
            cmbTipoEmpleado.Location = new Point(245, 128);
            cmbTipoEmpleado.Margin = new Padding(4, 5, 4, 5);
            cmbTipoEmpleado.Name = "cmbTipoEmpleado";
            cmbTipoEmpleado.Size = new Size(199, 28);
            cmbTipoEmpleado.TabIndex = 0;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(245, 190);
            txtNombre.Margin = new Padding(4, 5, 4, 5);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(199, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(245, 251);
            txtSalario.Margin = new Padding(4, 5, 4, 5);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(199, 27);
            txtSalario.TabIndex = 2;
            // 
            // btnCalcularBono
            // 
            btnCalcularBono.BackColor = SystemColors.InactiveCaption;
            btnCalcularBono.Location = new Point(69, 316);
            btnCalcularBono.Margin = new Padding(4, 5, 4, 5);
            btnCalcularBono.Name = "btnCalcularBono";
            btnCalcularBono.Size = new Size(133, 46);
            btnCalcularBono.TabIndex = 3;
            btnCalcularBono.Text = "Calcular Bono";
            btnCalcularBono.UseVisualStyleBackColor = false;
            btnCalcularBono.Click += btnCalcularBono_Click;
            // 
            // btnMostrarInfo
            // 
            btnMostrarInfo.BackColor = SystemColors.InactiveCaption;
            btnMostrarInfo.Location = new Point(287, 316);
            btnMostrarInfo.Margin = new Padding(4, 5, 4, 5);
            btnMostrarInfo.Name = "btnMostrarInfo";
            btnMostrarInfo.Size = new Size(157, 46);
            btnMostrarInfo.TabIndex = 4;
            btnMostrarInfo.Text = "Mostrar Información";
            btnMostrarInfo.UseVisualStyleBackColor = false;
            btnMostrarInfo.Click += btnMostrarInfo_Click;
            // 
            // lblTipoEmpleado
            // 
            lblTipoEmpleado.AutoSize = true;
            lblTipoEmpleado.Font = new Font("Cambria", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoEmpleado.Location = new Point(69, 131);
            lblTipoEmpleado.Margin = new Padding(4, 0, 4, 0);
            lblTipoEmpleado.Name = "lblTipoEmpleado";
            lblTipoEmpleado.Size = new Size(134, 17);
            lblTipoEmpleado.TabIndex = 5;
            lblTipoEmpleado.Text = "Tipo de Empleado";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Font = new Font("Cambria", 9F, FontStyle.Bold);
            lblNombre.Location = new Point(69, 193);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 17);
            lblNombre.TabIndex = 6;
            lblNombre.Text = "Nombre";
            // 
            // lblSalario
            // 
            lblSalario.AutoSize = true;
            lblSalario.Font = new Font("Cambria", 9F, FontStyle.Bold);
            lblSalario.Location = new Point(69, 254);
            lblSalario.Margin = new Padding(4, 0, 4, 0);
            lblSalario.Name = "lblSalario";
            lblSalario.Size = new Size(58, 17);
            lblSalario.TabIndex = 7;
            lblSalario.Text = "Salario";
            lblSalario.Click += lblSalario_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-10, -13);
            panel1.Name = "panel1";
            panel1.Size = new Size(560, 84);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cambria", 15F, FontStyle.Bold);
            label1.Location = new Point(67, 34);
            label1.Name = "label1";
            label1.Size = new Size(387, 30);
            label1.TabIndex = 0;
            label1.Text = "Gestión de Empleados con Bonos";
            // 
            // FrmGestionEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(530, 370);
            Controls.Add(panel1);
            Controls.Add(lblSalario);
            Controls.Add(lblNombre);
            Controls.Add(lblTipoEmpleado);
            Controls.Add(btnMostrarInfo);
            Controls.Add(btnCalcularBono);
            Controls.Add(txtSalario);
            Controls.Add(txtNombre);
            Controls.Add(cmbTipoEmpleado);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmGestionEmpleados";
            Text = "Gestión de Empleados";
            Load += FrmGestionEmpleados_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private Panel panel1;
        private Label label1;
    }
}

