namespace CU_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                while (true)
                {
                    MostrarMenu();


                    if (Unidad.unidades != null)
                    {
                        Console.WriteLine("========");
                        foreach (var conversion in Unidad.unidades)
                        {
                            Console.WriteLine($"{conversion.IdUnidad}: {conversion.NombreUnidad}");
                        }
                        Console.WriteLine("0: Salir");
                        Console.WriteLine("========\n");
                    }
                    Console.WriteLine("Ingrese la opcion deseada");
                    int opcion = int.Parse(Console.ReadLine());
                    if (!(opcion >= 0 && opcion <= Unidad.unidades.Count))
                    {
                        Console.WriteLine("Opcion invalida, intente de nuevo.");
                    }
                    else if (opcion == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("\nGracias. ¡Hasta luego!");
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        while (true)
                        {
                            Console.WriteLine("=======================================");
                            Console.WriteLine($"==========   {Unidad.unidades[opcion - 1].NombreUnidad}   ==========");
                            Console.WriteLine("=======================================\n");
                            foreach (var conversion in Unidad.unidades[opcion - 1].conversiones)
                            {
                                Console.WriteLine($"{conversion.IdConversion}: {conversion.NombreOrigen} a {conversion.NombreDestino}");
                            }
                            Console.WriteLine("0: Salir");
                            Console.WriteLine("\nSeleccione la conversion deseada:");
                            int opcionConversion = RevisionNums();
                            Console.Clear();
                            if (!(opcionConversion >= 0 && opcionConversion <= Unidad.unidades[opcion - 1].conversiones.Count))
                            {
                                Console.WriteLine("Opcion fuera de rango");
                                Console.WriteLine("Presione cualquier tecla para reintentar...");
                                Console.ReadKey();
                                Console.Clear();
                            }
                            else if (opcionConversion == 0)
                            {
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"Ingrese la cantidad en {Unidad.unidades[opcion - 1].conversiones[opcionConversion - 1].NombreOrigen} que sea convertir:");
                                double cantidad = double.Parse(Console.ReadLine());
                                double resultado = cantidad * Unidad.unidades[opcion - 1].conversiones[opcionConversion - 1].FactorConversion + Unidad.unidades[opcion - 1].conversiones[opcionConversion - 1].Suma;
                                Console.WriteLine("\n========");
                                Console.WriteLine($"{cantidad} {Unidad.unidades[opcion - 1].conversiones[opcionConversion - 1].NombreOrigen} esquivalen a {resultado} {Unidad.unidades[opcion - 1].conversiones[opcionConversion - 1].NombreDestino}");
                                Console.WriteLine("========\n");
                                Console.WriteLine("Presione cualquier tecla para continuar...");
                                Console.ReadKey();
                                Console.Clear();
                            }
                        }


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