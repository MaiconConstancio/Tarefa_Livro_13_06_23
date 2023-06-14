using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07AtividadesTer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tarefas passadas pelo Conrado

            TarefaLivroPagina77_Atividade01();
            TarefaLivroPagina81_Atividade02();
            TarefaLivroPagina84_Atividade03();
            TarefaLivroPagina87_Atividade03();
        }



        void TarefaLivroPagina77_Atividade01()
        {
            double numero;

            Console.WriteLine("Digite um número, (Pode conter virgulas)");
            Console.WriteLine("Se o numero for maior que 100, será SOMADO 150 ao RESULTADO.");
            numero = double.Parse(Console.ReadLine());

            if (numero > 100)
            {
                numero = numero + 150;
            }

            Console.WriteLine($"o valor é {numero}");

            Console.ReadKey(); ///FINAL
        }

        void TarefaLivroPagina81_Atividade02()
        {
            string nome = "";
            double nota;

            Console.WriteLine("Boa tarde, qual o seu nome?");
            nome = Console.ReadLine();

            Console.WriteLine("Qual a sua nota?");
            nota = double.Parse(Console.ReadLine());

            if (nota >= 6)
            {
                Console.WriteLine($"Meus parabéns {nome} você foi Aprovado.");
            }
            else
            {
                Console.WriteLine($"Lamento {nome}, mas você infelizmente foi Reprovado.");
            }

            Console.ReadKey(); ///FINAL
        }

        void TarefaLivroPagina84_Atividade03()
        {
            double media;
            double nota01 = 0;
            double nota02 = 0;



            Console.WriteLine("Boa tarde, a nota do PRIMEIRO aluno?");
            nota01 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a nota do SEGUNDO aluno?");
            nota02 = double.Parse(Console.ReadLine());

            media = (nota01 + nota02) / 2;

            if (media >= 6)
            {
                Console.WriteLine($"Parabéns sua média é {media}");
            }
            else
            {
                Console.WriteLine($"Infelizmente sua média é {media}");
            }

            Console.ReadKey(); ///FINAL
        }

        void TarefaLivroPagina87_Atividade03()
        {
            //double media;
            //double nota01 = 0;
            //double nota02 = 0;
            //double nota03 = 0;

            double nota01, nota02, nota03, media = 0;



            Console.WriteLine("Boa tarde, a nota do PRIMEIRO aluno?");
            nota01 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a nota do SEGUNDO aluno?");
            nota02 = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a nota do TERCEIRO aluno?");
            nota03 = double.Parse(Console.ReadLine());


            if (nota01 > nota02 && nota01 > nota03)
            {
                media = nota01;
            }
            else if (nota02 > nota01 && nota02 > nota03)
            {
                media = nota02;
            }
            else if (nota03 > nota02 && nota03 > nota01)
            {
                media = nota03;
            }

            Console.WriteLine($"A maior nota é {media}.");

            Console.ReadKey(); ///FINAL
        }

















        void AtividadeLivroPagina76()
        {

            double numero;

            //double e float são iguais, porém o float guarda mais casas depois da virgula, porém tem que usar o f = 0.1f

            Console.WriteLine("Digite um numero: ");
            numero = double.Parse(Console.ReadLine());

            if (numero > 10)
            {
                numero = numero * 0.1;
            }

            Console.WriteLine($"o valor é {numero}");

            Console.ReadKey(); ///FINAL

        }


        void AtividadeLivroPagina75()
        {
        
            //Pagina do livro 75
            
            //NOME: literal
            string nome;

            //leia PESSOA
            nome = Console.ReadLine();

            // escreva PESSOA
            Console.WriteLine(nome);

            Console.ReadKey(); ///FINAL

        }
    }
}
