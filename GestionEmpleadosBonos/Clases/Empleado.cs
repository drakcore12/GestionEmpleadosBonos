using System;

namespace GestionEmpleadosBonos
{

    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public decimal Salario { get; set; }

        public Empleado(string nombre, decimal salario)
        {
            Nombre = nombre;
            Salario = salario;
        }

        public abstract decimal CalcularBono();

        public virtual string MostrarInformacion()
        {
            return $"Nombre: {Nombre}\nSalario: {Salario:C}";
        }
    }

}
