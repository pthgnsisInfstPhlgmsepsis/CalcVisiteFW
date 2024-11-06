using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 =========== CONCEITOS BÁSICOS DA PROGRAMAÇÃO ===============

 Este programa apresenta conceitos que são essenciais na produção de todo
 programa de computador, o que possibilita que você utilize todos os aplicativos que
 você mais usa diariamente, seja no computador, em um celular, uma televisão, etc.

 Esta é uma calculadora símples, que funciona apenas com texto, sem interfáce gráfica.
 Role para baixo e leia o resto dos comentários para descobrir pelo que cada linha
 deste código é responsável!

 Caso queira executar a calculadora, aperte a tecla F5.

 ============================================================
 */
namespace CalcVisiteFW
{
    internal class Program
    {
        /* ---- FUNÇÕES ----
         * Essas são funções: blocos de código reutilizáveis por todo o programa
         * que só são executadas quando chamadas. Neste caso, cada função executa
         * uma operação aritética. Os parâmetros (que estão entre parênteses) são
         * responsáveis pela entrada de dados na função. São eles quem serão, por exemplo,
         * somados, como é o caso da função Soma.
         *
         * O código de bloco que constitui a função processa os dados, e em seguida, os retorna
         * (por meio da palavra-chave return) para seja lá quem os chamou.
         */
        static int Soma(int a, int b) { return a + b; }

        static int Sub(int a, int b) { return a - b; }

        static int Mul(int a, int b) { return a * b; }

        static double Div(int a, int b) { return (double)a / b; }

        /* ---- A FUNÇÃO MAIN ----
         * Esta é a parte do código que será executada pelo programa.
         */
        static void Main(string[] args)
        {
            string ans = "s";

            while (ans.ToLower() != "n")
            {
                Console.Clear(); // Limpa a tela do console

                /* ---- VARIÁVEIS ----
                 * Estas são variáveis. Elas recebem um valor inicial e podem ser
                 * lidas, exibidas e/ou modificadas conforme a necessidade do
                 * programa.
                 * 
                 * Neste caso, as variáveis op (que representará a operação selecionada
                 * pelo usuário), a, e b, são inteiros que recebem 1 como seu valor inicial.
                 * 
                 * Toda variável tem um tipo, que varia de acordo com sua utilidade. Podem ser
                 * númericos, de texto, ou estruturas de dados mais complexas.
                 */
                int op = 1;
                int a = 1;
                int b = 1;

                Console.WriteLine("Seja Bem Vinde à Calculadora!"); // Console.WriteLine exibe texto à console

                /* ---- ENTRADA DE DADOS ----
                 * Aqui, o usuário digitará um valor para as variáveis a, b, e op,
                 * que será lido utilizando a função Console.ReadLine(). Como
                 * esta função retorna um valor do tipo texto, é necessário
                 * transformá-lo no tipo inteiro, e isto é feito utilizando a
                 * função int.Parse().
                 * 
                 * Estes valores serão utilizados como parâmetros para as nossas
                 * funções mais tarde.
                 */
                Console.WriteLine("Digite o primeiro número:");
                a = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o segundo número:");
                b = int.Parse(Console.ReadLine());

                Console.WriteLine("Escolha sua opção:");

                Console.WriteLine("[1] Adição\n[2] Subtração\n[3] Multiplicação\n[4] Divisão");

                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    /* ---- PROCESSAMENTO E SAÍDA DE DADOS ----
                     * Este é um bloco switch/case. Ele é responsável por comparar os valores de uma
                     * variável com outros, e apenas executa o caso que seja idêntico ao valor contido
                     * na variável. Isso é ideal para a nossa aplicação: caso o valor da variável op
                     * (que contém a operação escolhida) seja, por exemplo, 1, o caso 1 será executado.
                     * Com isso, a função Soma será chamada, com os números a e b como parâmetros. Em
                     * seguida, a etapa de saída de dados é realizada, exibindo estes valores ao usuário.
                     * Caso o valor não seja 1, isto é feito com todos os demais valores, até que um
                     * caso válido seja encontrado.
                     */
                    case 1: Console.WriteLine($"{a} + {b} = {Soma(a, b)}"); break;
                    case 2: Console.WriteLine($"{a} - {b} = {Sub(a, b)}"); break;
                    case 3: Console.WriteLine($"{a} × {b} = {Mul(a, b)}"); break;
                    case 4: Console.WriteLine($"{a} / {b} = {Div(a, b)}"); break;

                    // ... E caso nenhum caso seja válido, o código dentro do bloco default é executado 
                    default: Console.WriteLine("Opção inválida! >_<\'"); break;
                }

                Console.WriteLine("\nContinuar? (S/N)");
                ans = Console.ReadLine();
            }
            /* ---- ESTRUTURAS DE REPETIÇÃO ----
             * Quase todo programa utiliza pelo menos uma estrutura de reptição, que executa
             * um determinado código um certo número de vezes, indefinidamente ou com base 
             * em uma condição. Aqui, o bloco while (linha 50) verifica se a variável ans NÃO
             * é igual a "n", isto é, o usuário quer continuar executando a calculadora com novos números.
             * Neste caso, o código se repete, e isso acontece enquanto o valor da variável ans for igual a "n".
             * Isso significaria que o usuário quer parar de executar o programa, então o bloco de código não será
             * mais executado, encerrando o programa.
             */
        }
    }
}

// ~ Beatriz, 2°DS ;3
