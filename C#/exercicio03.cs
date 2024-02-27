/*
Chegou a hora de você seguir todos os passos realizados durante esta aula e criar um jogo com os conhecimentos adquiridos.

Neste jogo, o programa gera um número aleatório entre 1 e 100 e o usuário deve adivinhar qual é esse número. 
O programa utiliza o if-else e switch case para verificar se o número digitado pelo usuário é maior ou menor do 
que o número gerado pelo programa.

O programa também utiliza o conceito de laço de repetição do-while para permitir que o usuário faça várias tentativas 
até acertar o número. Quando o usuário acertar o número, o jogo acaba e o programa exibe uma mensagem indicando que o 
jogo acabou.
*/


Random aleatorio = new Random();
int numeroSecreto = aleatorio.Next(1, 101);

do {
    Console.Write("Digite um número entre 1 e 100: ");
    int chute = int.Parse(Console.ReadLine());

    if(chute == numeroSecreto) {
    Console.WriteLine("Parabéns! Você acertou o número.");
    break;
    } else if(chute < numeroSecreto) {
    Console.WriteLine("O número é maior.");
    } else {
    Console.WriteLine("O número é menor.");
    }

} while(true);

Console.WriteLine("O jogo acabou. Você acertou o número secreto!");