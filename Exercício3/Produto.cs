using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício3
{
    class Produto
    {

        public double preco { get; protected set; }
        public string titulo { get; protected set; }

        public Produto(double preco, string titulo)
        {
            this.preco = preco;
            this.titulo = titulo;
        }

        public virtual void InformarDescricao()
        {
            Console.WriteLine("Item da Loja");
        }

        public virtual void InformarPreco()
        {
            Console.WriteLine($"{}");
            
        }
    }
}
