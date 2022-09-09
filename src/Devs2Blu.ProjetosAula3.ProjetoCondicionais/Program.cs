using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula3.ProjetoCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio2e2();
        }
        static void Exercicio2e2()
        {
            int valor1, valor2, valor3, valor4;
            int menorValor = 99999999; 

        Console.WriteLine("Programa que verifica qual o menor valor entre quatro valores! \n\n");

            Console.WriteLine("Informe o Valor 1");
            string vl1STR = Console.ReadLine();
            Int32.TryParse(vl1STR, out valor1);

            Console.WriteLine("Informe o Valor 2");
            string vl2STR = Console.ReadLine();
            Int32.TryParse(vl2STR, out valor2);

            Console.WriteLine("Informe o Valor 3");
            string vl3STR = Console.ReadLine();
            Int32.TryParse(vl3STR, out valor3);

            Console.WriteLine("Informe o Valor 4");
            string vl4STR = Console.ReadLine();
            Int32.TryParse(vl4STR, out valor4);

            if(valor1 < menorValor)
            {
                menorValor = valor1;
            }
            if (valor2 < menorValor)
            {
                menorValor = valor2;
            }
            if (valor3 < menorValor)
            {
                menorValor = valor3;
            }
            if (valor4 < menorValor)
            {
                menorValor = valor4;
            }

            Console.WriteLine($"O Menor valor é {menorValor}");
            
        }


        static void Exercicio2()
        {
            int valor1, valor2, valor3, valor4;

            Console.WriteLine("Programa que verifica qual o menor valor entre quatro valores! \n\n");

            Console.WriteLine("Informe o Valor 1");
            string vl1STR = Console.ReadLine();
            Int32.TryParse(vl1STR, out valor1);

            Console.WriteLine("Informe o Valor 2");
            string vl2STR = Console.ReadLine();
            Int32.TryParse(vl2STR, out valor2);

            Console.WriteLine("Informe o Valor 3");
            string vl3STR = Console.ReadLine();
            Int32.TryParse(vl3STR, out valor3);

            Console.WriteLine("Informe o Valor 4");
            string vl4STR = Console.ReadLine();
            Int32.TryParse(vl4STR, out valor4);

            if (valor1 < valor2 &&
                valor1 < valor3 &&
                valor1 < valor4)
            {
                Console.WriteLine($"Valor 1 ({valor1}) é o menor!");
            }
            else if (valor2 < valor3 &&
                        valor2 < valor4)
            {
                Console.WriteLine($"Valor 2 ({valor2}) é o menor!");
            }
            else if (valor3 < valor4)
            {
                Console.WriteLine($"Valor 3 ({valor3}) é o menor!");
            }
            else
            {
                Console.WriteLine($"Valor 4 ({valor4}) é o menor!");
            }
        }
        
        static void Exercicio1()
        {
            int numero1, numero2;

            Console.WriteLine("***** | Mostra o Maior valor entre os números informados | ***** \n\n");

            Console.WriteLine("Informe o primeiro valor:");
            string vl1Str = Console.ReadLine();
            Int32.TryParse(vl1Str, out numero1);

            Console.WriteLine("Informe o primeiro valor:");
            string vl2Str = Console.ReadLine();
            Int32.TryParse(vl2Str, out numero2);

            if ( numero1 > numero2)
            {
                Console.WriteLine($"O primeiro valor é maior! ({numero1})");
            } else if(numero2 > numero1)
            {
                Console.WriteLine($"O segundo valor é maior! ({numero2})");
            } else
            {
                Console.WriteLine("Os dois números são iguais!");
            }

        }
        static void Exemplo1()
        {
            string textoSaida;
            string nomeCandidato;
            int idadeCandidato, notaCandidato;

            Console.WriteLine("|***** Bem vindo ao Programa SyssSchool *****| \n\n");

            Console.WriteLine("Informe o Nome do Candidato: ");
            nomeCandidato = Console.ReadLine();

            Console.WriteLine("Informe a Idade do Candidato: ");
            string idadeSTR = Console.ReadLine();

            if (idadeSTR.Equals(""))
            {
                Console.WriteLine("Valor inválido para idade!");
                return;
            }
            else
            {
                idadeCandidato = Int16.Parse(idadeSTR);
            }

            Console.WriteLine("Informe a Nota do Candidato: ");
            string notaSTR = Console.ReadLine();

            if (notaSTR.Equals(""))
            {
                Console.WriteLine("Valor inválido para nota!");
                return;
            }
            else
            {
                notaCandidato = Int16.Parse(notaSTR);
            }

            textoSaida = $"Candidato: {nomeCandidato}\n";
            textoSaida += $"Idade: {idadeCandidato}";

            if (idadeCandidato < 18)
            {
                textoSaida += "(Menor de idade)\n";
            }
            else
            {
                textoSaida += "(Maior de idade)\n";
            }

            textoSaida += $"Nota Final: {notaCandidato}\n";

            if (notaCandidato > 5)
            {
                textoSaida += @"******************
    ***APROVADO!!! ***
    ******************";
            }
            else
            {
                textoSaida += " | REPROVADO! :( |";
            }

            Console.WriteLine(textoSaida);
        }
    }
}
