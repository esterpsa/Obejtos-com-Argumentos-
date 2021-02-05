using System;
using System.Collections.Generic;

namespace Objetos_com_Argumentos.classes
{
    public class Carrinho
    {
        
           //0 - Criamos uma propiedade para guardar o valor total do carrinho 
            public float ValorTotal {get; set;}

            //1 - Criamos uma lista que representará o nosso cartrinho 
            List<Produto> carrinho = new List<Produto>();

            //2 - Criamos o método que adiciona um produto ao carrinho, passando todo objeto como argumento
            public void AdicionarProduto(Produto produto){
                carrinho.Add(produto);
            }
            // 3 - criamos o método que remove um produto do carrinho
            public void RemoverProduto(Produto produto){
                carrinho.Remove(produto);
            }

            //4 - Podemos criar um método para listar os produtos que estão no carrinho 
            public void MostrarProduto()
            {
                if(carrinho != null)
                {
                    foreach(Produto p in carrinho)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"R$ {p.Preco.ToString("n2")} - {p.Nome}");
                        Console.ResetColor();
                        
                    }
                    MostrarTotal();
                }
            }

            //5 - Criamos um método para calcular o total da compra 
            public void MostrarTotal()
            {
                Console.ForegroundColor = ConsoleColor.Blue;

                if(carrinho != null)
                {
                    foreach(Produto p in carrinho)
                    {
                        ValorTotal += p.Preco;
                    }

                    Console.WriteLine($"Total do carrinho R$ {ValorTotal.ToString("n2")}");
                }else{
                    Console.WriteLine($"Total do carrinho R$ {ValorTotal.ToString("n2")}");
                    
                }

                Console.ResetColor();
            }
            //6 - Podemos alterar um determinado produto
            public void AlterarItem(int _codigo, Produto _novoProduto){
                carrinho.Find(x => x.Codigo == _codigo).Nome = _novoProduto.Nome;
                carrinho.Find(x => x.Codigo == _codigo).Preco = _novoProduto.Preco;
            }

    }
}