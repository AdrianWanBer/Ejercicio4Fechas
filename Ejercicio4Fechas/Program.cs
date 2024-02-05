namespace Ejercicio4Fechas
{
    class program
    {
        public static void Main(String[] args)
        {
            DateTime FechaActual = DateTime.Today;
            Console.WriteLine("Cual es tu fecha de nacimiento (dd/mm/yyyy):");
            string fechaNacimientoStr = Console.ReadLine();
            DateTime fechaNacimiento = DateTime.Parse(fechaNacimientoStr);


            int añosDiferencia = FechaActual.Year - fechaNacimiento.Year;
            int mesesDiferencia = FechaActual.Month - fechaNacimiento.Month;
            int diasDiferencia = FechaActual.Day - fechaNacimiento.Day;

            if (mesesDiferencia < 0 || diasDiferencia < 0)
            {
                mesesDiferencia = mesesDiferencia + 12;
                diasDiferencia = diasDiferencia + 31;
                añosDiferencia = añosDiferencia - 1;
            }

            Console.WriteLine($"Tienes {añosDiferencia} años, {mesesDiferencia} meses y {diasDiferencia} dias.");

        }
    } 
}
