namespace Biblioteca
{
    public class Gravacao
    {
        public static void GravarDisciplinas(List<Disciplina> disciplinas)
        {
            string ficheiro = "ListaDisciplinas.txt";

            StreamWriter sw = new StreamWriter(ficheiro);

            if (!File.Exists(ficheiro))
            {
                sw = File.CreateText(ficheiro);
            }

            foreach (var disciplina in disciplinas)
            {
                string linha = $"{disciplina.Id};{disciplina.Nome};{disciplina.Descrição}";
                sw.WriteLine(linha);
            }

            sw.Close();



        }

        public static List<Disciplina> LerDisciplinas()
        {
            List<Disciplina> lista = new List<Disciplina>();
            string ficheiro = "ListaDisciplinas.txt";

            StreamReader sr;

            if (File.Exists(ficheiro))
            {
                sr = File.OpenText(ficheiro);

                string linha = "";

                while ((linha = sr.ReadLine()) != null)
                {
                    
                    var campos = linha.Split(';');

                    Disciplina disciplina = new Disciplina()
                    {
                        Id = int.Parse(campos[0]),
                        Nome = campos[1],
                        Descrição = campos[2]
                    };

                    lista.Add(disciplina);
                }

                sr.Close();
            }


            return lista;
        }

        public static void GravarAlunos(List<Aluno> alunos)
        {
            string ficheiro = "ListaAlunos.txt";

            StreamWriter sw = new StreamWriter(ficheiro);

            if (!File.Exists(ficheiro))
            {
                sw = File.CreateText(ficheiro);
            }

            foreach (var aluno in alunos)
            {
                string linha = $"{aluno.Id};{aluno.Nome};{aluno.Apelido}";
                sw.WriteLine(linha);
            }

            sw.Close();
        }

        public static List<Aluno> LerAlunos()
        {
            List<Aluno> lista = new List<Aluno>();
            string ficheiro = "ListaAlunos.txt";

            StreamReader sr;

            if (File.Exists(ficheiro))
            {
                sr = File.OpenText(ficheiro);

                string linha = "";

                while ((linha = sr.ReadLine()) != null)
                {
                    string[] campos = new string[2];

                    campos = linha.Split(';');

                    Aluno aluno = new Aluno()
                    {
                        Id = int.Parse(campos[0]),
                        Nome = campos[1],
                        Apelido = campos[2]
                    };

                    lista.Add(aluno);
                }

                sr.Close();
            }


            return lista;
        }
    }

}
