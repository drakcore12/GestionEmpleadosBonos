using System;

namespace GestionEmpleadosBonos
{
    public class Gerente : Empleado
    {
        public Gerente(string nombre, decimal salario) : base(nombre, salario) { }

        public override decimal CalcularBono()
        {
            return Salario * 0.20m; // 20% del salario
        }

        public override string MostrarInformacion()
        {
            return base.MostrarInformacion() + $"\nBono: {CalcularBono():C}\nTipo de empleado: Gerente";
        }
    }

}
