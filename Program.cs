// See https://aka.ms/new-console-template for more information

namespace CuentaBancaria
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("Seleccione el tipo de cuenta:");
            Console.WriteLine("1. Caja de Ahorro");
            Console.WriteLine("2. Cuenta Corriente");
            Console.Write("Elija una opción (1/2): ");

            if (int.TryParse(Console.ReadLine(), out int opcionCuenta))
            {
                CuentasBancarias cuenta;

                switch (opcionCuenta)
                {
                    case 1:
                        cuenta = CrearCajaDeAhorro();
                        // Menú de opciones
                        while (true)
                        {
                            Console.WriteLine("\nMenú de opciones:");
                            Console.WriteLine("1. Cargar saldo");
                            Console.WriteLine("2. Retirar saldo");
                            Console.WriteLine("3. Salir");
                            Console.Write("Elija una opción (1/2/3): ");

                            if (int.TryParse(Console.ReadLine(), out int opcion))
                            {
                                switch (opcion)
                                {
                                    case 1:
                                        Console.Write("Ingrese el monto a cargar: ");
                                        if (double.TryParse(Console.ReadLine(), out double montoCargar))
                                        {
                                            cuenta.depositarSaldo(montoCargar);
                                            Console.WriteLine("Saldo cargado exitosamente.");
                                            Console.WriteLine("");
                                            cuenta.ObtenerSaldo();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Monto no válido.");
                                        }
                                        break;

                                    case 2:
                                        Console.Write("Ingrese el monto a retirar: ");
                                        if (double.TryParse(Console.ReadLine(), out double montoRetirar))
                                        {
                                            cuenta.retirarSaldo(montoRetirar);
                                            Console.WriteLine("");
                                            cuenta.ObtenerSaldo();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Monto no válido.");
                                        }
                                        break;

                                    case 3:
                                        Console.WriteLine("Saliendo del programa.");
                                        return;

                                    default:
                                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Opción no válida. Intente de nuevo.");
                            }
                        }
                        break;

                    case 2:
                        cuenta = CrearCuentaCorriente();
                        // Menú de opciones
                        while (true)
                        {
                            Console.WriteLine("\nMenú de opciones:");
                            Console.WriteLine("1. Cargar saldo");
                            Console.WriteLine("2. Retirar saldo");
                            Console.WriteLine("3. Salir");
                            Console.Write("Elija una opción (1/2/3): ");

                            if (int.TryParse(Console.ReadLine(), out int opcion))
                            {
                                switch (opcion)
                                {
                                    case 1:
                                        Console.Write("Ingrese el monto a cargar: ");
                                        if (double.TryParse(Console.ReadLine(), out double montoCargar))
                                        {
                                            cuenta.depositarSaldo(montoCargar);
                                            Console.WriteLine("Saldo cargado exitosamente.");
                                            Console.WriteLine("");
                                            cuenta.ObtenerSaldo();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Monto no válido.");
                                        }
                                        break;

                                    case 2:
                                        Console.Write("Ingrese el monto a retirar: ");
                                        if (double.TryParse(Console.ReadLine(), out double montoRetirar))
                                        {
                                            cuenta.retirarSaldo(montoRetirar);
                                            Console.WriteLine("");
                                            cuenta.ObtenerSaldo();
                                        }
                                        else
                                        {
                                            Console.WriteLine("Monto no válido.");
                                        }
                                        break;

                                    case 3:
                                        Console.WriteLine("Saliendo del programa.");
                                        return;

                                    default:
                                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Opción no válida. Intente de nuevo.");
                            }
                        }
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Saliendo del programa.");
                        return;
                }

                Console.WriteLine("Cuenta creada con éxito.");
                Console.WriteLine(" - - - - - - - - - - - - - - - - - - - - - - - - - - ");
                cuenta.MostrarDetalles();
                Console.WriteLine(" - - - - - - - - - - - - - - - - - - - - - - - - - - ");

            }
            else
            {
                Console.WriteLine("Opción no válida. Saliendo del programa.");
            }
        }

        static CuentasBancarias CrearCajaDeAhorro()
        {
            Console.WriteLine("Ingrese el titular:");
            string titular = Console.ReadLine();

            Console.WriteLine("Ingrese el saldo:");
            if (double.TryParse(Console.ReadLine(), out double saldo))
            {
                Console.WriteLine("Ingrese la moneda:");
                string moneda = Console.ReadLine();

               
                return new CajaDeAhorro(titular, saldo, moneda);
                
            }
            else
            {
                Console.WriteLine("El saldo debe ser un valor numérico válido. Saliendo del programa.");
            }

            return null;
        }

        static CuentasBancarias CrearCuentaCorriente()
        {
            Console.WriteLine("Ingrese el titular:");
            string titular = Console.ReadLine();

            Console.WriteLine("Ingrese el saldo:");
            if (double.TryParse(Console.ReadLine(), out double saldo))
            {
                Console.WriteLine("Ingrese la moneda:");
                string moneda = Console.ReadLine();

                return new Cuentacorriente(titular, saldo, moneda, "Cuenta Corriente");

            }
            else
            {
                Console.WriteLine("El saldo debe ser un valor numérico válido. Saliendo del programa.");
            }

            return null;


        }
    }
}

