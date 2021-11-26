using System;
using System.Collections.Generic;

namespace Exercicio02{
    public class Program    {

        public static void Main(string[] args)        {
//for (int i = 0; i < 10; i++)
//Console.WriteLine($"o valor de i é {i}");

// while (true)
// Console.WriteLine("mensagem do loop infinito")      ;

/*int contador = 0;
while (contador < 5){
    Console.WriteLine($"o contador while é {contador}");
    contador++;
    }*/

/*do {
    Console.WriteLine($"o contador do while é {contador}");
    contador++;
} while(contador < 10);*/

List<String> listaNomes = new();
listaNomes.Add("Paulo Ponciano");
listaNomes.Add("Jefferson");
listaNomes.Add("Rubens");
listaNomes.Add("Marcos");
listaNomes.Add("Luciane");
listaNomes.Add("Mais um monte de nomes aleatórios");
foreach(String nome in listaNomes)
Console.WriteLine($"o elemento da lista é {nome}");

try{
Console.WriteLine("digite um número");
int numero = Convert.ToInt32(Console.ReadLine());
}
catch (Exception ex){
Console.WriteLine($"erro {ex.Message}");
}



}
}
}   