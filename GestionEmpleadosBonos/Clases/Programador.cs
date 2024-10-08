using System;

namespace GestionEmpleadosBonos
{
    public class Programador : Empleado
    {
        public Programador(string nombre, decimal salario) : base(nombre, salario) { }

        public override decimal CalcularBono()
        {
            return Salario * 0.10m; // 10% del salario
        }

        public override string MostrarInformacion()
        {
            return base.MostrarInformacion() + $"\nBono: {CalcularBono():C}\nTipo de empleado: Programador";
        }
    }

}
