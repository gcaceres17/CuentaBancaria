using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuentaBancaria
{
    public class Cuentacorriente : CuentasBancarias
    {
        const int LimiteExtraccion = 2;
        private string TipoCuenta { get; set; }

        public Cuentacorriente(string _titular, double _saldo, string _moneda, string _tipoCuenta)
            : base(_titular, _saldo, _moneda)
        {
            this.TipoCuenta = _tipoCuenta;
        }

        // Método para mostrar los detalles de la cuenta, incluyendo el límite de extracción y tipo de cuenta
        public new void MostrarDetalles()
        {
            base.MostrarDetalles();
            Console.WriteLine("Tipo de Cuenta: " + this.TipoCuenta);
        }

        // Método para consultar el saldo, heredado de la clase base
        public void ConsultarSaldo()
        {
            base.ObtenerSaldo();
        }

        // Método para retirar saldo, considerando el límite de extracción
        public void RetirarSaldo(double monto)
        {
            var cantExtraccion = 0;

            if (monto < SaldoProtegido && cantExtraccion <= LimiteExtraccion)
            {
                SaldoProtegido -= monto;
                cantExtraccion++;
                Console.WriteLine("Retiro exitoso. Saldo restante: " + SaldoProtegido);
                Console.WriteLine("cantExtraccion " + cantExtraccion);
            }
            else
            {
                Console.WriteLine("Saldo insuficiente para retirar este monto.");
            }
        }

    }

}
