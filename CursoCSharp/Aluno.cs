namespace CursoCSharp
{
    public class Aluno
    {
        private double _notaFinal;
        public string NomeAluno { get; set; }
        public string Situacao { get; private set; }
        public double Nota1 { get; private set; }
        public double Nota2 { get; private set; }
        public double Nota3 { get; private set; }
        public double Nota4 { get; private set; }
        public double MediaFinal { get; private set; }

        public Aluno(string nome, double nota1, double nota2, double nota3, double nota4)
        {
            NomeAluno = nome;
            Nota1 = nota1;
            Nota2 = nota2;
            Nota3 = nota3;
            Nota4 = nota4;

            MediaFinal = NotaFinal();
            Situacao = VerSituacao();
        }

        private double NotaFinal()
        {
            double soma = (Nota1 + Nota2 + Nota3 + Nota4) / 4;
            _notaFinal = soma;
            return _notaFinal;
        }

        private string VerSituacao()
        {
            string situacao;

            if (_notaFinal >= 6)
            {
                situacao = "Aprovado";
            }
            else
            {
                situacao = "Reprovado";
            }
            return situacao;
        }

    }


}
