namespace Calculadora
{
    internal class Program
    {
        enum Menu { Soma = 1, Subtracao, Multiplicacao, Divisao, Exponenciacao, RaizQuadrada, Sair }
        static void Main(string[] args)
        {
            Console.WriteLine("Bem - vindo á calculadora!");
            while (true)
            {
                Console.WriteLine("\nEscolha uma operação:");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Exponenciação");
                Console.WriteLine("6 - Raiz Quadrada");
                Console.WriteLine("7 - Sair");
                int opcao = Convert.ToInt32(Console.ReadLine());
                if (opcao == (int)Menu.Sair)
                {
                    Console.WriteLine("Saindo da calculadora. Até logo!");
                    break;
                   
                }
                switch (opcao)
                {
                    case (int)Menu.Soma:
                        Soma();
                        break;
                    case (int)Menu.Subtracao:
                        Subtracao();
                        break;
                    case (int)Menu.Multiplicacao:
                        Multiplicacao();
                        break;
                    case (int)Menu.Divisao:
                        Divisao();
                        break;
                    case (int)Menu.Exponenciacao:
                        Exponenciacao();
                        break;
                    case (int)Menu.RaizQuadrada:
                        RaizQuadrada();
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }
            }






        }

        static void Soma()
        {
            Console.WriteLine("Bem - vindo á calculadora de Soma!");
            Console.WriteLine("\nDigite o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int resultado = num1 + num2;

            Console.WriteLine($"Resultado da soma: {resultado}");


        }

        static void Subtracao()
        {
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int resultado = num1 - num2;

            Console.WriteLine($"Resultado da subtração: {resultado}");
        }

        static void Multiplicacao()
        {
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int resultado = num1 * num2;

            Console.WriteLine($"Resultado da multiplicação: {resultado}");
        }

        static void Divisao()
        {
            Console.WriteLine("Digite o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo número: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            if (num2 == 0)
            {
                Console.WriteLine("Divisão por zero não é permitida.");
                return;
            }
            int resultado = num1 / num2;

            Console.WriteLine($"Resultado da divisão: {resultado}");

        }

        static void Exponenciacao()
        {
            Console.WriteLine("Digite a base: ");
            int baseNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o expoente: ");
            int expoente = Convert.ToInt32(Console.ReadLine());
            double resultado = Math.Pow(baseNum, expoente);

            Console.WriteLine($"Resultado da exponenciação: {resultado}");
        }

        static void RaizQuadrada()
        {
            Console.WriteLine("Digite o número: ");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("Raiz quadrada de número negativo não é permitida.");
                return;
            }
            double resultado = Math.Sqrt(num);

            Console.WriteLine($"Resultado da raiz quadrada: {resultado}");  
            
        }


    }
}