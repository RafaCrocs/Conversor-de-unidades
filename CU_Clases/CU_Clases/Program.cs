namespace CU_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
            while (true)
            {

                if (Unidad.unidades != null)
                {
                    foreach (var conversion in Unidad.unidades)
                    {
                        Console.WriteLine($"{conversion.IdUnidad}: {conversion.NombreUnidad}");
                    }
                }
                int opcion = int.Parse(Console.ReadLine());
                if (!(opcion > 0 && opcion <= Unidad.unidades.Count))
                {
                    Console.WriteLine("Opcion invalida, intente de nuevo.");
                }
                else
                {
                    var seleccion = Unidad.unidades.Find(c => c.IdUnidad == opcion);
                    Console.WriteLine($"\nHa seleccionado la opcion: {seleccion.NombreUnidad}\n");
                    

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
}