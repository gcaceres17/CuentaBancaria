namespace CuentaBancaria
{
    public class CajaDeAhorro : CuentasBancarias
    {
        // Constante para la tasa de interés (5%)
        private const double TasaInteres = 0.05;

        // Constructor de la clase CajaDeAhorro
        public CajaDeAhorro(string _titular, double _saldo, string _moneda)
            : base(_titular, _saldo, _moneda)
        {

        }

        // Método para retirar saldo, aplicando la tasa de interés constante
        public new void RetirarMonto(double monto)
        {
            // Calcular el monto con interés
            double montoConInteres = monto * (1 + TasaInteres);

            // Llamar al método de la clase base para realizar el retiro
            base.retirarSaldo(montoConInteres);

        }

        // Método para consultar el saldo, heredado de la clase base
        public void ConsultarSaldo()
        {
            base.ObtenerSaldo();
        }
    }
}
