namespace CU_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MostrarMenu();


                if (Unidad.unidades != null)
                {
                    foreach (var conversion in Unidad.unidades)
                    {
                        Console.WriteLine($"{conversion.IdUnidad}: {conversion.NombreUnidad}");
                    }
                }
                Console.WriteLine("Ingrese la opcion deseada");
                int opcion = int.Parse(Console.ReadLine());
                if (!(opcion > 0 && opcion <= Unidad.unidades.Count))
                {
                    Console.WriteLine("Opcion invalida, intente de nuevo.");
                }
                else
                {
                    foreach (var conversion in Unidad.unidades[opcion - 1].conversiones)
                    {
                        Console.WriteLine($"{conversion.IdConversion}: {conversion.NombreConversion}");
                    }
                    Console.WriteLine("Seleccione la conversion deseada:");
                    int opcionConversion = RevisionNums();
                    if (!(opcionConversion >= 0 || opcionConversion < Unidad.unidades[opcion - 1].conversiones.Count))
                    {
                        Console.WriteLine("Opcion fuera de rango");
                    }
                    else
                    {
                        Console.WriteLine("Ingrese la cantidad que sea convertir:");
                        double cantidad = double.Parse(Console.ReadLine());
                        double resultado = cantidad * Unidad.unidades[opcion - 1].conversiones[opcionConversion - 1].FactorConversion + Unidad.unidades[opcion - 1].conversiones[opcionConversion - 1].Suma;
                        Console.WriteLine($"El resultado de la conversion es: {resultado}");
                    }


                }



                static void MostrarMenu()
                {
                    Console.WriteLine("============================================");
                    Console.WriteLine("========   CONVERSOR DE UNIDADES   =========");
                    Console.WriteLine("============================================\n");
                    Console.WriteLine("Opciones\n");

                }
                static int RevisionNums()
                {
                    while (true)
                    {
                        if (int.TryParse(Console.ReadLine(), out int numero))
                        {
                            return numero;
                        }
                        else
                        {
                            Console.WriteLine("Entrada invalida. Por favor ingrese un numero entero.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Se ha producido un error: {ex.Message}");
            }
        }
    }
}