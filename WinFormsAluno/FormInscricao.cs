using Biblioteca;

namespace WinFormsAluno
{
    public partial class FormInscricao : Form
    {
        #region Atributos
        List<Aluno> _alunos;
        List<Disciplina> _disciplinas;
        List<Disciplina> _inscricoes;
        #endregion

        #region Método Construtor
        public FormInscricao()
        {
            InitializeComponent();
            _alunos = Gravacao.LerAlunos();
            _disciplinas = Gravacao.LerDisciplinas();
            InitListaAlunos();
            InitListaDisciplinas();
            InitListaInscricoes();
        }
        #endregion

        #region Métodos para Eventos
        private void btnAdicionarInscricao_Click(object sender, EventArgs e)
        {
            Aluno alunoSelecionado = (Aluno)listBoxAluno.SelectedItem;
            Disciplina discSelecionada = (Disciplina)listBoxDisciplina.SelectedItem;
            if (!alunoSelecionado.Disciplinas.Any(x => x.NomeDisciplina == discSelecionada.NomeDisciplina))
            {
                alunoSelecionado.Disciplinas.Add(discSelecionada);
            }

            InitListaInscricoes();
        }

        private void btnRemoverInscricao_Click(object sender, EventArgs e)
        {
            Disciplina discInscSelecionada = (Disciplina)listBoxInscricao.SelectedItem;
            Aluno alunoSelecionado = (Aluno)listBoxAluno.SelectedItem;
            alunoSelecionado.Disciplinas.Remove(discInscSelecionada);
            InitListaInscricoes();
        }
        #endregion

        #region Outros Métodos
        public void InitListaAlunos()
        {
            listBoxAluno.DataSource = null;
            listBoxAluno.DataSource = _alunos;
            listBoxAluno.DisplayMember = "NomeCompleto";
        }
        public void InitListaDisciplinas()
        {
            listBoxDisciplina.DataSource = null;
            listBoxDisciplina.DataSource = _disciplinas;
            listBoxDisciplina.DisplayMember = "NomeDisciplina";
        }
        public void InitListaInscricoes()
        {
            Aluno alunoSelecionado = (Aluno)listBoxAluno.SelectedItem;
            listBoxInscricao.DataSource = null;
            listBoxInscricao.DataSource = alunoSelecionado.Disciplinas;
            listBoxInscricao.DisplayMember = "NomeDisciplina";
        }
        #endregion

        private void listBoxAluno_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitListaInscricoes();
        }
    }
}
