using System.Globalization;

namespace CursoCSharp
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Quantos alunos gostaria de calcular a média final? ");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                Aluno[] vect = new Aluno[n];

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Nome do Aluno: ");
                    string nome = Console.ReadLine();
                    Console.Write("Nota 1: ");
                    double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Nota 2: ");
                    double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Nota 3: ");
                    double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Nota 4: ");
                    double n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Aluno pessoa = new Aluno(nome, n1, n2, n3, n4);
                    vect[i] = pessoa;
                }

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Nome: {vect[i].NomeAluno}, Media final: {vect[i].MediaFinal.ToString("F2", CultureInfo.InvariantCulture)}, Situação: {vect[i].Situacao}");
                }
            }
            else
            {
                Console.WriteLine("Operação Inválida, por favor tente novamente!!!");
            }
        }
    }
}