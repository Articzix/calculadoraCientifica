using System;

namespace CalculadoraCientifica
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Calculadora Científica");
                Console.WriteLine("Escolha uma operação:");
                Console.WriteLine("1. Adição");
                Console.WriteLine("2. Subtração");
                Console.WriteLine("3. Multiplicação");
                Console.WriteLine("4. Divisão");
                Console.WriteLine("5. Seno");
                Console.WriteLine("6. Cosseno");
                Console.WriteLine("7. Tangente");
                Console.WriteLine("8. Logaritmo");
                Console.WriteLine("9. Raiz Quadrada");
                Console.WriteLine("0. Sair");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                    case "2":
                    case "3":
                    case "4":
                        Console.WriteLine("Digite o primeiro número:");
                        double num1 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Digite o segundo número:");
                        double num2 = Convert.ToDouble(Console.ReadLine());

                        if (choice == "1") Console.WriteLine($"Resultado: {num1 + num2}");
                        if (choice == "2") Console.WriteLine($"Resultado: {num1 - num2}");
                        if (choice == "3") Console.WriteLine($"Resultado: {num1 * num2}");
                        if (choice == "4") Console.WriteLine(num2 != 0 ? $"Resultado: {num1 / num2}" : "Erro: Divisão por zero!");
                        break;

                    case "5":
                    case "6":
                    case "7":
                        Console.WriteLine("Digite um ângulo em graus:");
                        double angulo = Convert.ToDouble(Console.ReadLine());
                        double radianos = angulo * Math.PI / 180;

                        if (choice == "5") Console.WriteLine($"Resultado: {Math.Sin(radianos)}");
                        if (choice == "6") Console.WriteLine($"Resultado: {Math.Cos(radianos)}");
                        if (choice == "7") Console.WriteLine($"Resultado: {Math.Tan(radianos)}");
                        break;

                    case "8":
                        Console.WriteLine("Digite o número:");
                        double num = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Resultado: {Math.Log(num)}");
                        break;

                    case "9":
                        Console.WriteLine("Digite o número:");
                        double squareNum = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine($"Resultado: {Math.Sqrt(squareNum)}");
                        break;

                    case "0":
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
