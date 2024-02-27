/*
Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o resultado de suas quatro 
operações básicas (adição, subtração, divisão e multiplicação), utilizando interpolação de strings.
Criar uma lista de bandas vazia e adicionar suas bandas prediletas em seguida.
Utilizar a estrutura 'for' para mostrar todas as suas bandas preferidas, listadas na lista do exercício anterior, 
no console.
Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.
*/

// Primeiro exercício

void ExibirQuatroOperacoes(){

float a = 4;
float b = 8;

float soma = a + b;
float subtracao = a - b;
float divisao = a / b;
float multiplicacao = a * b;

Console.WriteLine($"a + b = {soma}");
Console.WriteLine($"a - b = {subtracao}");
Console.WriteLine($"a / b = {divisao}");
Console.WriteLine($"a * b = {multiplicacao}");
}

ExibirQuatroOperacoes();




// Segundo exercício

List<string> bandas = new List<string>();

bandas.Add("Lacuna Coil");
bandas.Add("Metallica");
bandas.Add("Tash Sultana");


// terceiro exercicio
for(int i = 0; i < bandas.Count; i++){
    Console.WriteLine(bandas[i]);
}


// Quarto exercicio

List<int> elementos = new List<int>();
int soma = 0;

elementos.Add(1);
elementos.Add(2);
elementos.Add(3);
elementos.Add(4);
elementos.Add(5);

foreach (int numero in numeros)
{
    soma = soma + numero;
}

Console.WriteLine($"A soma dos elementos da lista é: {soma}");
