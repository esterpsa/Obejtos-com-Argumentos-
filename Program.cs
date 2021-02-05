using System;
using System.Collections.Generic;
using Objetos_com_Argumentos.classes;

namespace Objetos_com_Argumentos
{
    class Program
    {
        static void Main(string[] args)
        {
           
          //Criamos alguns produtos 
          Produto p1 = new Produto(1, "Kimono", 110f);
          Produto p2 = new Produto(2, "Luvas", 35f);
          Produto p3 = new Produto(3, "Bolsa", 50f);
          Produto p4 = new Produto(4, "Caneleiras", 70f);

          //Adicionamos eles ao carrinho 
          Carrinho carrinho = new Carrinho();
          carrinho.AdicionarProduto(p1);
          carrinho.AdicionarProduto(p2);
          carrinho.AdicionarProduto(p3);
          carrinho.AdicionarProduto(p4);

          //Mostramos nosso carrinho comnpleto: 
          carrinho.MostrarProduto();
          


          





        

        }
    }
}
