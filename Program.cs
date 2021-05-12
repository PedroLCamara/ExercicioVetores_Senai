using System;

namespace ExercicioForixiearai
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] embalagens=null;
            Console.WriteLine("Há quantas embalagens de pão de queijo na prateleira?");
            int quantidade_embalagens= int.Parse(Console.ReadLine());
            embalagens= new int [(quantidade_embalagens)];
            int num_embalagem= 1;
            foreach (var item in embalagens)
            {
                Console.WriteLine($"Há quantos pães de queijo na {num_embalagem}ª embalagem?");
                Console.ReadLine();
                Console.WriteLine();
                num_embalagem= num_embalagem+1;
            }
        }
    }
}
