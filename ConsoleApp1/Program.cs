namespace dias
{
    public class program
    {
        public static void Main()
        {
            int dia = 0;
            int mes = 0;
            int A = 0;

            double divisible = A % 4;

            Console.WriteLine("Ingrese el año.");
            A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el mes.");
            mes = Convert.ToInt32(Console.ReadLine());

            if (mes == 2)
            {
                Console.WriteLine("Ingrese el día.");
                dia = Convert.ToInt32(Console.ReadLine());
                if (dia > 29 && divisible == 0)
                {
                    Console.WriteLine("Este mes solo tiene 29 días.");
                }
                else
                {
                    if (dia > 28)
                    {
                        Console.WriteLine("Este mes solo tiene 28 días.");
                    }
                }
            }

            if (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                Console.WriteLine("Ingrese el día.");
                dia = Convert.ToInt32(Console.ReadLine());
                if (dia > 31)
                {
                    Console.WriteLine("Este mes solo tiene 31 días.");
                }
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                Console.WriteLine("Ingrese el día.");
                dia = Convert.ToInt32(Console.ReadLine());
                if (dia > 30)
                {
                    Console.WriteLine("este mes solo tiene 30 días.");
                }
            }

            DateTime mifecha = new DateTime(A, mes, dia);
            mifecha = mifecha.AddDays(1);
            Console.WriteLine(mifecha);
        }
    }

}
