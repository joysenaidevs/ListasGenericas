using System;
using System.Collections.Generic;

namespace ListasGenericas
{
    class Program
    {
        static void Main(string[] args)
        {
            //objeto de lista
            //lista de numeros
            
            //Lista de numeros

            List<int> numeros = new List<int>();
            numeros.Add(333); // inserindo valor na lista

            // var identifica automaticamente - posso colocar int também
            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }

            //fim lista numeros


            //lista de nomes
            List<string> nomes = new List<string>();
            nomes.Add("Joyce");
            nomes.Add("Isabela");

            //remove o item desejado
            nomes.Remove("Joyce");

            foreach (var itens in nomes)
            {
                Console.WriteLine(itens);
            }
            //fim item desejado
            

            //Console.WriteLine(nomes.Count); // Count conta quantos itens temos na lista

            //Constains : um booleano
            /*bool resposta = nomes.Contains("Joyce"); // retorna valor booleano

            if (resposta == true){
                    
                Console.WriteLine("Nome Encontrado");

            } */ 

            //fim
                
            // encontrar usando foreach e o if

            /* foreach (var lista in nomes)
            {
                Console.WriteLine(lista);

                if(lista == "Joyce"){
                    Console.WriteLine("Nome encontrado");
                }else{
                    Console.WriteLine("Nome não encontrado");
                }
            } */

            //fim

            //fim lista nomes
            
        }
    }
}
