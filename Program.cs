using System;

namespace Ler_informacoes
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            int idade;
            float salario;
            string estado;
            Console.WriteLine("Digite o seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Digite a sua idade");
            idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o seu salário");
            salario = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite o seu Estado Civil");
            System.Console.WriteLine("s para solteiro(a), c para casado(a), v para viúvo(a), d para divorciado(a)");
            estado = Console.ReadLine();
            bool Condicao = true;
            while(Condicao == true)
            {
                if ((nome != "") && (idade > 0 && idade < 150) && (salario > 0) && (estado == "s" || estado == "c" || estado == "v" || estado == "d"))
                {
                    Console.WriteLine("Você digitou todas as informações corretamente");
                    Condicao = false;
                }else
                {
                    Console.WriteLine("Erro, você digitou as informações incorretamente");
                    Console.WriteLine("Digite o seu nome");
                    nome = Console.ReadLine();
                    Console.WriteLine("Digite a sua idade");
                    idade = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o seu salário");
                    salario = float.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o seu Estado Civil");
                    System.Console.WriteLine("s para solteiro(a), c para casado(a), v para viúvo(a), d para divorciado(a)");
                    estado = Console.ReadLine();
                }
            }
        }
    }
}
