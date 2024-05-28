using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesSis13
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Escreva a operação que deseja realizar: [/,*,-,+] ");
            string operacao = Console.ReadLine();

            Console.WriteLine("Escreva o numero: ");
            double n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Escreva o segundo numero: ");
            double n2 = double.Parse(Console.ReadLine());

            calculo(n1,n2,operacao);
            Console.ReadKey();
        }

        static void calculo(double v1,double v2,string operacao)
        {
            switch(operacao)
            {
                case "/"
                 
            
                    double resultado = n1/n2 ;
                    break;
    }
        }
}
}

