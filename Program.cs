using System;
using System.Globalization;

namespace Course {
    class Program {
        static void Main(string[] args) {

            Estudante[] vect =  new Estudante[10];

            Console.Write("Quantos quartos serão alugados? ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 0; i < quartos; i++) {
                Console.WriteLine("Aluguel #"+(i + 1)+": ");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int qto = int.Parse(Console.ReadLine());
                Console.WriteLine();
                vect[qto] = new Estudante(nome, email);
            }

            Console.WriteLine("Quartos ocupados: ");
            for (int i = 0; i < 10; i++) {
                if (vect[i] != null) {
                    Console.WriteLine(i+": "+vect[i]);
                }
            }

        }
    }
}
