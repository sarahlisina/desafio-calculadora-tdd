﻿
namespace Calculadora
{
    public class Calculadora
    {

        public static int Somar(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Subtrair(int num1, int num2)
        {
            return num1 - num2;
        }
        public static int Multiplicar(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Dividir(int num1, int num2)
        {
            try
            {
                return num1 / num2;
            }
            catch (Exception)
            {
                Console.WriteLine("Divisão não permitida");
                return 0;
            }
        }
    }
}
