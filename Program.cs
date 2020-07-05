using System;
using System.Collections.Generic;

namespace Aula23ListaObjeto
{
    class Program
    {
        static void Main(string[] args)
        {

            //Criando A Lista
            List<Produto> produtos = new List<Produto>();

            // Adicionando produtos através de instâncias com construtores
            produtos.Add(new Produto(1,"The Last of Us II", 299.90f));
            produtos.Add(new Produto(2,"CyberPunk 2077", 250.01f));
            produtos.Add(new Produto(3,"Counter Strike: Global Offensive", 29.90f));
            produtos.Add(new Produto(4,"Spider Man", 289.90f));
            produtos.Add(new Produto(5,"Call of Duty: Black Ops 2", 299.90f));

            //Ou adicionando através de instâncias básicas
            Produto battlefield = new Produto();
            battlefield.Codigo = 6;
            battlefield.Nome = "Battlefield 5";
            battlefield.Preco = 99.90f;

            produtos.Add(battlefield);


            foreach(Produto p in produtos){
                Console.WriteLine($" {p.Nome} - R$ {p.Preco} ");
            }

            //Removemos através do indice do array
            produtos.RemoveAt(0);

            //Removendo através da expressão Lambda e o método RemoveAll
            produtos.RemoveAll(x => x.Nome == "Spider Man");


            Console.WriteLine("\nLista Alterada: ");
            //Checamos a lista alterada com os produto removidos
            foreach(Produto p in produtos){
                Console.WriteLine($" {p.Nome} - R${p.Preco} ");
            }


        }
    }
}
