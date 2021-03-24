using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício3
{
    class JogoDigital : Produto
    {
        public JogoDigital(double preco, string titulo, string _console) : base(preco, titulo)
        {
            this.console = console;
        }

        public string console { get; private set; }

        public override void InformarDescricao()
        {
            Console.WriteLine($"{titulo}");
        }
    }
}
