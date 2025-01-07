using System;
namespace ValidadordeCartoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char op = 'S';
            bool continua = true;
            while (continua)
            {
                string NumeroCartao;
                Console.Write("Digite o numero do Cartão:");
                NumeroCartao = Console.ReadLine();
                int[] numeros = new int[NumeroCartao.Length];
                for (int i = 0; i < NumeroCartao.Length; i++)
                {
                    numeros[i] = int.Parse(NumeroCartao[i].ToString());
                }
                identificarBandeira(numeros);
                bool pesquisa = true;
                while (pesquisa)
                {
                    Console.WriteLine("Deseja Realizar uma nova pesquisa? S ou N ");
                    op = char.Parse(Console.ReadLine());
                    switch (op)
                    {
                        case 'S':
                            pesquisa = false;
                            break;
                        case 's':
                            pesquisa = false;
                            break;
                        case 'n':
                            pesquisa = false;
                            continua = false;
                            break;
                        case 'N':
                            pesquisa= false;
                            continua = false;
                            break;
                        default:
                            Console.Write("Opção Invalida\n");
                            break;
                    }
                }
               
            }         
        }
        static public void identificarBandeira(int[] NumeroCartao)
        {
            int[] bandeiras = { 4, 51, 52, 53, 54, 55, 34, 37, 6011, 65, 36, 38, 35 };
            int primeiroDigito = 0, segundoDigito = 0, digitoFinal;
            primeiroDigito = NumeroCartao[0];
            segundoDigito = NumeroCartao[1];
            digitoFinal = primeiroDigito * 10 + segundoDigito;
            if (primeiroDigito == 4)
            {
                Console.Write("O cartao é: Visa");
            }
            else if (digitoFinal == 51 || digitoFinal == 52 || digitoFinal == 53 || digitoFinal == 54 || digitoFinal == 55)
            {
                Console.Write("O cartao é: Mastercard");
            }
            else if (digitoFinal == 34 || digitoFinal == 37)
            {
                Console.Write("O cartao é: American Express");
            }
            else if (digitoFinal == 60 || digitoFinal == 65)
            {
                Console.Write("O cartao é: Discover");
            }
            else if (digitoFinal == 36 || digitoFinal == 38)
            {
                Console.Write("O cartao é: Diners Club");
            }
            else if (digitoFinal == 35)
            {
                Console.Write("O cartao é: JCB");
            }
            else
            {
                Console.Write("\nBandeira nao Encontrada");
            }
            Console.Write("\n");
        }
    }
}
