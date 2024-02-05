namespace ejercicio3Date
{
    /// <summary>
    /// Clase principal del programa 
    /// msm - 050224
    /// </summary>
    class Program
    {
        /// <summary>
        /// Metodo que contiene el procedimiento de la aplicacion
        /// msm - 050224
        /// </summary>
        /// <param name="args"></param>
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