using Biblioteca;

namespace WinFormsAluno
{
    public partial class FormInscricao : Form
    {
        #region Atributos
        List<Aluno> _alunos;
        List<Disciplina> _disciplinas;
        List<Inscricao> _inscricoes;
        #endregion

        #region Método Construtor
        public FormInscricao()
        {
            InitializeComponent();
            _alunos = Gravacao.LerAlunos();
            _disciplinas = Gravacao.LerDisciplinas();
            _inscricoes = Gravacao.LerInscricao();
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
            Inscricao inscricao = new Inscricao(alunoSelecionado, discSelecionada);            
            _inscricoes.Add(inscricao);
            Gravacao.GravarInscricao(_inscricoes);
            InitListaInscricoes();

        }
        private void btnRemoverInscricao_Click(object sender, EventArgs e)
        {
            Inscricao inscricao = ((Inscricao)listBoxInscricao.SelectedItem);            
            _inscricoes.Remove(inscricao);
            Gravacao.GravarInscricao(_inscricoes);
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
            listBoxInscricao.DataSource = null;
            listBoxInscricao.DataSource = _inscricoes;
            listBoxInscricao.DisplayMember = "NomeInscricao";
        }
        #endregion
    }
}
