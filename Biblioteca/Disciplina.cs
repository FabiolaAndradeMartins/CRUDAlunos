namespace Biblioteca
{
    public class Disciplina
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Descrição { get; set; }

        public string NomeDisciplina
        {
            get
            {
                return $"{Id} {Nome} {Descrição}";
            }
        }
    }
   
}
