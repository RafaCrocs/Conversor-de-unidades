namespace CU_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            MostrarMenu();
        }

        static void MostrarMenu()
        {
            Console.WriteLine("============================================");
            Console.WriteLine("========   CONVERSOR DE UNIDADES   =========");
            Console.WriteLine("============================================\n");
            Console.WriteLine("Ingrese la unidad de origen");



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