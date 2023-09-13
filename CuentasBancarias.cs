using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class CuentasBancarias
{
    private string Titular { get; set; }
    private double Saldo { get; set; }
    private string Moneda { get; set; }

    public CuentasBancarias(string _titular, double _saldo, string _moneda)
    {
        this.Titular = _titular;
        this.Saldo = _saldo;
        this.Moneda = _moneda;
    }

    // Método para mostrar los detalles de la cuenta
    public void MostrarDetalles()
    {
        Console.WriteLine("Titular: " + this.Titular);
        Console.WriteLine("Saldo: " + this.Saldo);
        Console.WriteLine("Moneda: " + this.Moneda);
    }

    public void ObtenerSaldo()
    {
        Console.WriteLine("Su saldo actual es de: " +  this.Saldo);
    }

    public void depositarSaldo(double nuevoSaldo)
    {
        Saldo = Saldo + nuevoSaldo;
    }

    public void retirarSaldo (double monto)
    {
        if(monto < Saldo)
        {
            Saldo = Saldo - monto;
            Console.WriteLine("Saldo retirado exitosamente.");
        }
        else
        {
            Console.WriteLine("El monto que intenta retirar supera su saldo disponible: ");
        }
    }

    protected double SaldoProtegido
    {
        get { return Saldo; }
        set { Saldo = value; }
    }
}
