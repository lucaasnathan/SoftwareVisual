using System;

namespace AULA03
{
    class Program
    {
        static int ConvertToint(string input)
        {
            //"2347"
            int output = 0;
            for(int i = input.Length - 1, j = 0; i >= 0; i--, j++)
            {
                if(input[i] < 48 || input [i] > 57)
                {
                    throw new Exception ("Erro! desconhecido");
                }
                 output += (input[i] - 48) * (int) Math.Pow(10,j);
            }
            return output;
        }
    
        static void Main(string[] args)
        {
            try
            {
            Console.WriteLine("Insira um numero: ");
            string input = Console.ReadLine();
            int numero = ConvertToint(input);
            Console.WriteLine("Seu numero eh "+ numero);
            }
            catch(Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
        }
    }
}
