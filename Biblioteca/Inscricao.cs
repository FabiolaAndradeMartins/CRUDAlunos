namespace Biblioteca
{
    public class Inscricao
    {
        public int IdAluno { get; set; }
        public int IdDisciplina { get; set; }

        public string NomeAluno { get; set; }
        public string NomeDisciplina { get; set; }

        public string NomeInscricao { get => $"{IdAluno} {NomeAluno} - {IdDisciplina} {NomeDisciplina}";}

        public Inscricao(Aluno aluno, Disciplina disciplina)
        {
            IdAluno = aluno.Id;
            NomeAluno = aluno.Nome;
            IdDisciplina = disciplina.Id;
            NomeDisciplina = disciplina.Nome;
        }
    }
}
