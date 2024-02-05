namespace ejercicio3Date
{

    class Program
    {

        static void Main(string[] args)
        {
            Random random = new Random();

            DateTime fechaHoy = DateTime.Now;
            Console.WriteLine("FECHA NORMAL");
            Console.WriteLine(fechaHoy);
            int numeroRestaAños = random.Next(0, 4);

            DateTime fechaModificada = fechaHoy.AddDays(1).AddMonths(-24).AddYears(-numeroRestaAños);
            Console.WriteLine(" ");
            Console.WriteLine("FECHA MODIFICADA");
            Console.WriteLine(fechaModificada);

            Console.WriteLine(" ");
            Console.WriteLine("COMPARACION FECHAS");
            int comparacionFechas = fechaModificada.CompareTo(fechaHoy);
            if (comparacionFechas > 0)
            {
                Console.WriteLine("El hoy es mas pequeño");
            }
            else
            {
                Console.WriteLine("El hoy es mas grande");
            }

        }
    }
}