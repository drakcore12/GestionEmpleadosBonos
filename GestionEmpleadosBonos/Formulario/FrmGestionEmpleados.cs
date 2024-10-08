using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionEmpleadosBonos
{
    public partial class FrmGestionEmpleados : Form
    {
        Empleado empleado;

        public FrmGestionEmpleados()
        {
            InitializeComponent();
        }

        private void btnCalcularBono_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos y que el salario sea válido
            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtSalario.Text) || cmbTipoEmpleado.SelectedItem == null)
            {
                MessageBox.Show("Por favor complete todos los campos y seleccione un tipo de empleado.");
                return;
            }

            // Validar que el salario sea un número válido
            if (!decimal.TryParse(txtSalario.Text, out decimal salario) || salario <= 0)
            {
                MessageBox.Show("El salario debe ser un número válido.");
                return;
            }

            // Crear el empleado según el tipo seleccionado
            string tipoEmpleado = cmbTipoEmpleado.SelectedItem.ToString();
            if (tipoEmpleado == "Gerente")
            {
                empleado = new Gerente(txtNombre.Text, salario);
            }
            else if (tipoEmpleado == "Programador")
            {
                empleado = new Programador(txtNombre.Text, salario);
            }

            // Calcular el bono
            MessageBox.Show($"Bono calculado: {empleado.CalcularBono():C}", "Cálculo Exitoso");
        }

        private void btnMostrarInfo_Click(object sender, EventArgs e)
        {
            // Verificar que el empleado haya sido creado
            if (empleado == null)
            {
                MessageBox.Show("Primero debe calcular el bono del empleado.");
                return;
            }

            // Mostrar la información del empleado
            MessageBox.Show(empleado.MostrarInformacion(), "Información del Empleado");
        }

        private void lblSalario_Click(object sender, EventArgs e)
        {

        }

        private void FrmGestionEmpleados_Load(object sender, EventArgs e)
        {

        }
    }
}