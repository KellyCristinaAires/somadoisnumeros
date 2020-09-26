using System;

namespace numeroseoperadores
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            int n2;
            int result;

            Console.Write("Digite o primeiro Numero: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo Numero: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
           
           result = n1+n2;
           Console.WriteLine("resultado de soma");
           Console.WriteLine(result);
           Console.WriteLine("pressione enter para sair!");
           Console.ReadKey();
        }
    }
}
