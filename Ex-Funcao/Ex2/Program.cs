using System;

namespace Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
           ImprimirDataHora ();
        }
        static void ImprimirDataHora (){
            DateTime dia = DateTime.Today;
            Console.WriteLine (dia.DayOfWeek);
        }
    }
}
