using System;

class Program
{
    static void Main()
    {
        char continuar;

        do
        {
            Console.WriteLine("Ingrese los datos del empleado:");

            // Datos del empleado
            Console.Write("Número de Cédula: ");
            string cedula = Console.ReadLine();

            Console.Write("Nombre del Empleado: ");
            string nombre = Console.ReadLine();

            Console.Write("Tipo de Empleado (1-Operario, 2-Técnico, 3-Profesional): ");
            int tipoEmpleado = int.Parse(Console.ReadLine());

            Console.Write("Cantidad de Horas Laboradas: ");
            double horasLaboradas = double.Parse(Console.ReadLine());

            Console.Write("Precio por Hora: ");
            double precioPorHora = double.Parse(Console.ReadLine());

            // Calcular salario ordinario
            double salarioOrdinario = horasLaboradas * precioPorHora;

            // Calcular aumento
            double aumento = CalcularAumento(tipoEmpleado, salarioOrdinario);

            // Calcular salario bruto
            double salarioBruto = salarioOrdinario + aumento;

            // Calcular deducción de ley (CCSS)
            double deduccionCCSS = salarioBruto * 0.0917;

            // Calcular salario neto
            double salarioNeto = salarioBruto - deduccionCCSS;

            // Mostrar resultados
            MostrarResultados(cedula, nombre, tipoEmpleado, precioPorHora, horasLaboradas, salarioOrdinario, aumento, salarioBruto, deduccionCCSS, salarioNeto);

            Console.Write("¿Desea ingresar otro empleado? (S/N): ");
            continuar = char.ToUpper(Console.ReadKey().KeyChar);

            Console.WriteLine("\n-----------------------------------------");

        } while (continuar == 'S');

        Console.WriteLine("Programa finalizado.");
    }

    static double CalcularAumento(int tipoEmpleado, double salarioOrdinario)
    {
        switch (tipoEmpleado)
        {
            case 1: // Operario
                return salarioOrdinario * 0.15;
            case 2: // Técnico
                return salarioOrdinario * 0.10;
            case 3: // Profesional
                return salarioOrdinario * 0.05;
            default:
                return 0;
        }
    }

    static void MostrarResultados(string cedula, string nombre, int tipoEmpleado, double precioPorHora, double horasLaboradas, double salarioOrdinario, double aumento, double salarioBruto, double deduccionCCSS, double salarioNeto)
    {
        Console.WriteLine("\nResultados para el empleado:");
        Console.WriteLine($"Cédula: {cedula}");
        Console.WriteLine($"Nombre Empleado: {nombre}");
        Console.WriteLine($"Tipo Empleado: {tipoEmpleado}");
        Console.WriteLine($"Salario por Hora: {precioPorHora:C}");
        Console.WriteLine($"Cantidad de Horas: {horasLaboradas}");
        Console.WriteLine($"Salario Ordinario: {salarioOrdinario:C}");
        Console.WriteLine($"Aumento: {aumento:C}");
        Console.WriteLine($"Salario Bruto: {salarioBruto:C}");
        Console.WriteLine($"Deducción CCSS: {deduccionCCSS:C}");
        Console.WriteLine($"Salario Neto: {salarioNeto:C}");
    }
}

