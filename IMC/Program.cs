using System;

namespace IMC
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var CopyrightClass = new Copyright();
            CopyrightClass.Print();

            string Nome;
            double Altura = 0;
            double Peso = 0;
            double Calculo = 0;

            Console.WriteLine(">> Qual o seu nome: ");
            Nome = Console.ReadLine();

            Console.WriteLine(">> Insira a sua altura: ");
            Altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(">> Insira o seu peso: ");
            Peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine(">> Nome do Usuário: " + Nome);
            Console.WriteLine(">> Altura: " + Altura + "m");
            Console.WriteLine(">> Peso: " + Peso + "Kgs");
            Console.WriteLine();
            Calculo = Peso / (Altura * Altura);

            Console.WriteLine(">> O seu IMC é " + Calculo);

            if (Calculo < 17)
            {
                Console.WriteLine(">> Conclusão: Muito abaixo do peso");
            }
            else if (Calculo >= 17 && Calculo < 18.5)
            {
                Console.WriteLine(">> Conclusão: Abaixo do peso");
            }
            else if (Calculo >= 18.5 && Calculo < 25)
            {
                Console.WriteLine(">> Conclusão: Peso normal");
            }
            else if (Calculo >= 25 && Calculo < 30)
            {
                Console.WriteLine(">> Conclusão: Acima do peso");
            }
            else if (Calculo >= 30 && Calculo < 35)
            {
                Console.WriteLine(">> Conclusão: Obesidade Grau 1");
            }
            else if (Calculo >= 35 && Calculo < 40)
            {
                Console.WriteLine(">> Conclusão: Obesidade Grau 2");
            }
            else
            {
                Console.WriteLine("Conclusão: Obedidade Grau 3");
            }

            Console.WriteLine();
            Console.WriteLine(">> " + Nome + ", obrigado por participar do teste!");
            Console.ReadKey();
        }
    }
}
