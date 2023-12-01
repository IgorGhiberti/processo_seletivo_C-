# processo_seletivo_CSharp
Desafio envolvendo vetor, laço de repetição (for) e estrutura de condição (if). 

## Segue o descritivo do desafio:

Em um determinado colégio, está sendo realizado um levantamento para saber a taxa de eficiência de uma turma, alguns alunos são selecionados por vez, para gerar uma média por amostragem, abaixo temos algumas amostras de exemplo e seus respectivos percentuais de eficiência, veja:

|Amostra | Eficiência/Alunos acima da média|
|---------|--------------------------------|
|{50,50,70,80,100}         |40%                               |
|{100,95,90,80,7,60,50}         |57,143%                                |
|{70,90,80}         |33,333%                                |
|{70,90,81}         |66,667%                                |
|{10,99,98,97,96,95,94,93,91}         |55,556%                                |

Exemplificando como foi calculada a média da primeira linha da tabela:

{50,50,70,80,100} = 50+50+70+80+100 = 350/5 = 70 é a média

Crie um projeto de qualquer tipo no Visual Studio e monte um algoritmo em C#/JavaScript ou Typescript que receba uma amostra e retorne a eficiência/porcentual de alunos acima da média.

## Minha linha de raciocínio
Primeiramente, eu quis dividir o problema em problemas menores, então tentei interpretar como funcionava o calculo da eficiência. Percebi que ele era feito através de uma regra de três, onde, no primeiro exemplo, de 5 alunos, 2 estavam acima da média, isso representa 40% do todo. 

Depois de entender como funcionava a conta, comecei a pensar no código. A amostra seria um vetor (array, list etc), eu precisaria de uma variável acumuladora (alunosAcimaDaMedia), um índice para percorrer o array e a média dos alunos (mediaAmostra).

Após isso definido, criei um for onde o índice percorria a amostra e um if onde, caso o índice da amostra possuísse um valor maior do que a média, ele acrescentasse na variável acumuladora 1. 

Por fim, criei a variável eficiencia, que recebia a quantidade de alunos acima da média e fazia * 100 e dividia pelo tamanho da amostra. Depois foi só printar essa variável na tela console.

