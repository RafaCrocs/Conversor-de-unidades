using System;

namespace ConversorDeUnidades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Conversor de Unidades\n------------------------");
                    Console.WriteLine("Elija la opcion deseada\n");
                    Console.WriteLine("1. Temperatura\n2. Distancia\n3. Potencias\n4. Salir\n");
                    int op = RevisionOp(1, 4);
                    switch (op)
                    {
                        case 1:
                            Temperatura();
                            break;
                        case 2:
                            Distancia();
                            break;
                        case 3:
                            Potencia();
                            break;
                        case 4:
                            Console.WriteLine("Adios!!");
                            return;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ha ocurrido un error: {ex.Message}");
            }
        }
        static int RevisionOp(int a, int b)
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int opcion))
                {
                    if (opcion >= a && opcion <= b)
                    {
                        return opcion;
                    }
                    else
                    {
                        Console.WriteLine("Opcion fuera de rango...Intente nuevamente");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada invalida. Por favor ingrese un numero entero.");
                }
            }

        }
        static double RevisionNums()
        {
            while (true)
            {
                if (double.TryParse(Console.ReadLine(), out double numero))
                {
                    return numero;
                }
                else
                {
                    Console.WriteLine("Entrada invalida. Por favor ingrese un numero entero.");
                }
            }
        }
        static void RevisionBinario(string dato1)
        {
            bool a = true;
            while (a)
            {
                string binario = Console.ReadLine()!;
                char[] asd = binario.ToCharArray();
                for (int i = 0; i < asd.Length; i++)
                {
                    if (asd[i] != '0' && asd[i] != '1')
                    {
                        Console.WriteLine("El numero ingresado no es Binario. Intente nuevamente.");
                        break;
                    }
                    else if (i == asd.Length - 1)
                    {
                        double decimal1 = Convert.ToInt32(binario, 2);
                        Console.WriteLine($"---\n{binario} en Binario es {decimal1} en {dato1}.\n---");
                        Console.WriteLine("Gracias...");
                        Console.WriteLine("ENTER para continuar");
                        Console.ReadLine();
                        Console.Clear();
                        a = false;
                    }
                }
            }
        }
        static void Revisionoctal(string dato1)
        {
            bool a = true;
            while (a)
            {
                string octal = Console.ReadLine()!;
                char[] asd = octal.ToCharArray();
                for (int i = 0; i < asd.Length; i++)
                {
                    if (asd[i] < '0' || asd[i] > '7')
                    {
                        Console.WriteLine("El numero ingresado no es Octal. Intente nuevamente.");
                        break;
                    }
                    else if (i == asd.Length - 1)
                    {
                        double decimal1 = Convert.ToInt32(octal, 8);
                        Console.WriteLine($"---\n{octal} en Octal es {decimal1} en {dato1}.\n---");
                        Console.WriteLine("Gracias...");
                        Console.WriteLine("ENTER para continuar");
                        Console.ReadLine();
                        Console.Clear();
                        a = false;
                    }
                }
            }
        }
        static void Temperatura()
            {
                Console.Clear();
                Console.WriteLine("------------------------");
                Console.WriteLine($"{"Menu",13}");
                Console.WriteLine("------------------------");
                Console.WriteLine("1. Celsius a Fahrenheit\n2. Celsius a Kelvin\n3. Fahrenheit a Celsius\n4. Fahrenheit a Kelvin\n5. Kelvin a Celcius\n6. kelvin a Fahrenheit\n7. Regresar\n-------------------------");
                int op = RevisionOp(1, 7);
                double celsius;
                double fahrenheit;
                double kelvin;
                double result;
                Console.Clear();
                switch (op)
                {
                    case 1:
                        Console.Write("Ingrese la cantidad en Celsius: ");
                        celsius = RevisionNums();
                        result = (1.8 * celsius) + 32;
                        Console.WriteLine($"---\n{celsius} C equivalen a {result} Fahrenheit.\n---");
                        break;
                    case 2:
                        Console.Write("Ingrese la cantidad en Celsius: ");
                        celsius = RevisionNums();
                        result = celsius + 273.15;
                        Console.WriteLine($"---\n{celsius} C equivalen a {result} Kelvin.\n---");
                        break;
                    case 3:
                        Console.Write("Ingrese la cantidad en Fahrenheit: ");
                        fahrenheit = RevisionNums();
                        result = (fahrenheit - 32) / 1.8;
                        Console.WriteLine($"---\n{fahrenheit} F equivalen a {result} Celsius.\n---");
                        break;
                    case 4:
                        Console.Write("Ingrese la cantidad en Fahrenheit: ");
                        fahrenheit = RevisionNums();
                        result = (fahrenheit - 32) / 1.8 + 273.15;
                        Console.WriteLine($"---\n{fahrenheit} F equivalen a {result} Kelvin.\n---");
                        break;
                    case 5:
                        Console.Write("Ingrese la cantidad en Kelvin: ");
                        kelvin = RevisionNums();
                        result = kelvin - 273.15;
                        Console.WriteLine($"---\n{kelvin} K equivalen a {result} Celsius.\n---");
                        break;
                    case 6:
                        Console.Write("Ingrese la cantidad en Kelvin: ");
                        kelvin = RevisionNums();
                        result = (kelvin - 273.15) * 1.8 + 32;
                        Console.WriteLine($"---\n{kelvin} K equivalen a {result} Fahrenheit.\n---");
                        break;
                    case 7:
                        return;
                }
                Console.WriteLine("Gracias...");
                Console.WriteLine("ENTER para continuar");
                Console.ReadLine();
                Console.Clear();

        }
        static void Distancia()
            {
                Console.Clear();
                Console.WriteLine("------------------------");
                Console.WriteLine($"{"Menu",13}");
                Console.WriteLine("------------------------");
                Console.WriteLine("Elija la conversion deseada\n");
                Console.WriteLine("1. Metros a Centimetros\n2. Metros a Kilometros\n3. Kilometros a Centimetros\n4. Kilometros a Metros\n5. Centimetros a Kilometros\n6. Centimetros a Metros\n7. Regresar\n-------------------------");
                int op = RevisionOp(1, 7);
                double metros;
                double centimetros;
                double kilometros;
                double result;
                Console.Clear();
                switch (op)
                {
                    case 1:
                        Console.Write("Ingrese la cantidad en Metros: ");
                        metros = RevisionNums();
                        result = metros * 100;
                        Console.WriteLine($"---\n{metros}m equivalen a {result}cm.\n---");
                        break;
                    case 2:
                        Console.Write("Ingrese la cantidad en Metros: ");
                        metros = RevisionNums();
                        result = metros / 1000;
                        Console.WriteLine($"---\n{metros}m equivalen a {result}km.\n---");
                        break;
                    case 3:
                        Console.Write("Ingrese la cantidad en Kilometros: ");
                        kilometros = RevisionNums();
                        result = kilometros * 100000;
                        Console.WriteLine($"---\n{kilometros}km equivalen a {result}cm.\n---");
                        break;
                    case 4:
                        Console.Write("Ingrese la cantidad en Kilometros: ");
                        kilometros = RevisionNums();
                        result = kilometros * 1000;
                        Console.WriteLine($"---\n{kilometros}km equivalen a {result}m.\n---");
                        break;
                    case 5:
                        Console.Write("Ingrese la cantidad en Centimetros: ");
                        centimetros = RevisionNums();
                        result = centimetros / 100000;
                        Console.WriteLine($"---\n{centimetros}cm equivalen a {result}km.\n---");
                        break;
                    case 6:
                        Console.Write("Ingrese la cantidad en Centimetros: ");
                        centimetros = RevisionNums();
                        result = centimetros / 100;
                        Console.WriteLine($"---\n{centimetros}cm equivalen a {result}m.\n---");
                        break;
                    case 7:
                        return;
                }
                Console.WriteLine("Gracias...");
                Console.WriteLine("ENTER para continuar");
                Console.ReadLine();
                Console.Clear();
            }
        static void Potencia()
            {
                Console.Clear();
                Console.WriteLine("------------------------");
                Console.WriteLine($"{"Menu",13}");
                Console.WriteLine("------------------------");
                Console.WriteLine("Elija la conversion deseada\n");
                Console.WriteLine("1. Decimal a Binario\n2. Decimal a Octal\n3. Binario a Decimal\n4. Binario a Octal\n5. Octal a Decimal\n6. Octal a Binario\n7. Regresar\n");
                int op = RevisionOp(1, 7);
                int decimal1;
                string result;
                Console.Clear();
                switch (op)
                {
                    case 1:
                        Console.Write("Ingrese el numero Decimal: ");
                        decimal1 = (int)RevisionNums();
                        result = Convert.ToString(decimal1, 2);
                        Console.WriteLine($"---\n{decimal1} en Decimal es {result} en Binario.\n---");
                        Console.WriteLine("Gracias...");
                        Console.WriteLine("ENTER para continuar");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Write("Ingrese el numero Decimal: ");
                        decimal1 = (int)RevisionNums();
                        result = Convert.ToString(decimal1, 8);
                        Console.WriteLine($"---\n{decimal1} en Decimal es {result} en Octal.\n---");
                        Console.WriteLine("Gracias...");
                        Console.WriteLine("ENTER para continuar");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Write("Ingrese el numero Binario: ");
                        RevisionBinario("Decimal");
                        break;
                    case 4:
                        Console.Write("Ingrese el numero Binario: ");
                        RevisionBinario("Octal");
                        break;
                    case 5:
                        Console.Write("Ingrese el numero Octal: ");
                        Revisionoctal("Decimal");
                        break;
                    case 6:
                        Console.Write("Ingrese el numero Octal: ");
                        Revisionoctal("Binario");
                    break;
                    case 7:
                        return;
                }
            }
    }
}
