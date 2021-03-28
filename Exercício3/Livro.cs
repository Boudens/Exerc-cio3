using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício3
{
    class Livro : Produto
    {
        public Livro(double preco, string titulo, string _autor) : base(preco, titulo)
        {
            this.autor = _autor;
        }

        public string autor { get; private set; }

        public override void InformarDescricao()
        {
            Console.WriteLine($"{titulo} escrito por {autor}");
        }
    }
}
