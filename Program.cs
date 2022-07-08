using System;

namespace ModuleWeek {
    class Program {
        static void Main(String[] args) {
            /*  Ex 2 - Abstração calculadora. */
            Console.WriteLine("Digite a operação desejada (+, -, ÷, *): ");
            String operacao = Console.ReadLine();
            Console.WriteLine("Digite o primeiro valor: ");
            String valor1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo valor: ");
            String valor2 = Console.ReadLine();
            double resultado = 0;
            try {
                switch (operacao) {
                    case "+":
                        resultado = Convert.ToDouble(valor1) + Convert.ToDouble(valor2);
                        break;
                    case "-":
                        resultado = Convert.ToDouble(valor1) - Convert.ToDouble(valor2);
                        break;
                    case "*":
                        resultado = Convert.ToDouble(valor1) * Convert.ToDouble(valor2);
                        break;
                    case "/":
                        resultado = Convert.ToDouble(valor1) / Convert.ToDouble(valor2);
                        break;
                    default:
                        Console.WriteLine("Operação inválida!");
                        break;
                }
                Console.WriteLine("Resultado: " + resultado);
            }
            catch (Exception e) {
                Console.WriteLine("Erro: " + e.Message);
            }
        }
    }
}
