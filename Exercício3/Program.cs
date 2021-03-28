using System;

namespace Exercício3
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto jogoNier = new JogoDigital(250, "Nier", "PS5");
            Produto jogoNba = new JogoDigital(300, "NBA 2K21", "PC");
            Produto livro1 = new Livro(20, "Crepúsculo dos ídolos", "Nietzsche");
            Produto livro2 = new Livro(25, "O processo", "Franz Kafka");

            Produto[] produtos = { jogoNier, jogoNba, livro1, livro2 };

            foreach (Produto item in produtos)
            {
                item.InformarDescricao();
                item.InformarPreco();
                Console.WriteLine("-------------");
                Console.ReadLine();
            }
        }
    }
}
