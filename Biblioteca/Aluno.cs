namespace Biblioteca
{
    public class Aluno
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Apelido { get; set;}

        public string NomeCompleto
        {
            get
            {
                return this.ToString();
            }
        }

        public override string ToString() //Polimorfismo - sobrepõe
        {
            return $"{Id} - {Nome} {Apelido}";
        }

        public List<Disciplina> Disciplinas { get; set; } = new List<Disciplina>();
    }
}
