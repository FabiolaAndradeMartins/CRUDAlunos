namespace WinFormsAluno
{
    public partial class FormPrincipal : Form
    {
        #region Método Construtor
        public FormPrincipal()
        {
            InitializeComponent();
        }
        #endregion

        #region Métodos para Eventos
        private void btnAluno_Click(object sender, EventArgs e)
        {
            FormAluno formAluno = new FormAluno();
            formAluno.ShowDialog();
        }

        private void btnDisciplina_Click(object sender, EventArgs e)
        {
            FormDisciplina formDisciplina = new FormDisciplina();
            formDisciplina.ShowDialog();
        }

        private void btnInscricoes_Click(object sender, EventArgs e)
        {
            FormInscricao form = new FormInscricao();
            form.ShowDialog();
        }
        #endregion

    }
}
