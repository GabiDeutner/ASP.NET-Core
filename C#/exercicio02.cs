/*
Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. Caso seu valor seja maior ou igual a 5, 
escreva na tela "Nota suficiente para aprovação".
Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.
Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.
Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, exibir a n-ésima posição 
de uma lista.
*/


// Minha Resolução:

// primeiro desafio
int notaMedia = 5;

if (notaMedia >= 5) {
    Console.WriteLine("Nota suficiente para aprovação");
} else {
    Console.WriteLine("Nota insuficiente para aprovação");
}




// Segundo Desafio
// Criando uma lista de string
List<string> Linguagens = new List<string>();

// Adicionando elementos à lista
Linguagens.Add("C#");
Linguagens.Add("Java");
Linguagens.Add("JavaScript");

// Exibir o valor C#
Console.WriteLine(Linguagens[0]);





// Terceiro Desafio
// Escolhendo a enésima posição

// Criando uma lista de string
List<string> Linguagens = new List<string>();

// Adicionando elementos à lista
Linguagens.Add("C#");
Linguagens.Add("Java");
Linguagens.Add("JavaScript");

Console.WriteLine("Escolha uma posição: ");
string num = Console.ReadLine();
int n = int.Parse(num);
Console.WriteLine(Linguagens[n]);













// Resolução Alura

int media = 5;
if(media >= 5){
    Console.WriteLine("Nota suficiente para aprovação");
}


List<string> linguagens = {"C#", "Java", "JavaScript"};


Console.WriteLine(linguagens[0]);


int posicao = int(Console.read());
Console.WriteLine(lista[posicao]);