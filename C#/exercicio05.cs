/*
Crie uma lista de inteiros utilizando o List<int> e utilize o for e o foreach para iterar sobre essa lista e exibir 
apenas os números pares.

No for, comece o índice em 0 e incremente a cada iteração. Defina a condição de continuação do loop 
como i < numeros.Count, ou seja, o loop continuará enquanto o valor de i for menor do que o número de elementos na lista. 
Acesse o valor de cada elemento utilizando a sintaxe numeros[i].

Já no foreach, ao invés de utilizar um loop for com um contador i e acessar os elementos da lista através do índice i, 
é utilizado o foreach para percorrer a lista e acessar diretamente cada elemento com a variável número. Em seguida, 
é verificado se o número é par utilizando o operador de módulo (%) e, caso seja, o número é impresso no console.

*/

List<int> numeros = new List<int>();

numeros.Add(1);
numeros.Add(2);
numeros.Add(3);
numeros.Add(4);
numeros.Add(5);

// usando o for

for (int i = 0; i < numeros.Count; i++)
{
    if (numeros[i] % 2 == 0) // Verifica se o número é par
    {
        Console.WriteLine(numeros[i]);
    }
}


// usando o foreach

foreach (int numero in numeros)
{
    if (numero % 2 == 0) {
        Console.WriteLine(numero);
    }
}



/*
Qual usar? for ou foreach?
Geralmente, é recomendado utilizar o foreach quando se deseja apenas iterar sobre os elementos de uma coleção, 
sem a necessidade de acessar um índice numérico específico. Isso torna o código mais legível e menos propenso a 
erros, além de ser mais simples de implementar.

Já o for é recomendado quando é necessário acessar elementos em posições específicas da coleção ou quando se deseja 
iterar utilizando um índice numérico específico.
*/