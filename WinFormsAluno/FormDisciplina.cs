using Biblioteca;

namespace WinFormsAluno
{
    public partial class FormDisciplina : Form
    {
        #region Atributos
        List<Disciplina> Disciplinas;

        int contaDisciplinas = 1;
        #endregion

        #region Método Construtor
        public FormDisciplina()
        {
            Disciplinas = Gravacao.LerDisciplinas();
            InitializeComponent();
            txtIdDisciplina.Text = contaDisciplinas.ToString();
            InitLista();
        }
        #endregion

        #region Métodos para Eventos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Disciplina novaDisciplina;

            if (ValidaForm())
            {
                novaDisciplina = new Disciplina
                {
                    Id = contaDisciplinas,
                    Nome = txtNomeDisciplina.Text,
                    Descrição = txtDescricaoDisciplina.Text,
                };

                Disciplinas.Add(novaDisciplina);
                contaDisciplinas++;
                Gravacao.GravarDisciplinas(Disciplinas);
                InitLista();
            }
            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            txtNomeDisciplina.Text = string.Empty;
            txtDescricaoDisciplina.Text = string.Empty;
            txtIdDisciplina.Text = contaDisciplinas.ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNomeDisciplina.Text = string.Empty;
            txtDescricaoDisciplina.Text = string.Empty;

        }

        private void btnApagaDisciplina_Click(object sender, EventArgs e)
        {
            Disciplina disciplinaAApagar = (Disciplina)listBoxDisciplina.SelectedItem;

            Disciplina apagada = null;

            if (disciplinaAApagar != null)
            {
                foreach (Disciplina disciplina in Disciplinas)
                {
                    if (disciplinaAApagar.Id == disciplina.Id)
                    {
                        apagada = disciplina;
                    }
                }

                if (apagada != null)
                {
                    DialogResult resposta;
                    resposta = MessageBox.Show($"Tem certeza que pretende apagar o {apagada.NomeDisciplina}",
                        "Apagar",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);

                    if (DialogResult.OK == resposta)
                    {
                        Disciplinas.Remove(apagada);
                        Gravacao.GravarDisciplinas(Disciplinas);
                        InitLista();

                    }
                }
            }
        }

        private void btnEditarDisciplina_Click(object sender, EventArgs e)
        {
            Disciplina disciplinaAEditar = (Disciplina)listBoxDisciplina.SelectedItem;
            Disciplina editada = null;

            if (disciplinaAEditar != null)
            {
                foreach (Disciplina disciplina in Disciplinas)
                {
                    if (disciplinaAEditar.Id == disciplina.Id)
                    {
                        editada = disciplina;
                    }
                }
                //abrir a nova form para editar
                EditarDisciplinaForm editarDisciplinaForm = new EditarDisciplinaForm(this, editada);
                editarDisciplinaForm.Show();
                Gravacao.GravarDisciplinas(Disciplinas);
            }
        }

        #endregion

        #region Outros Métodos
        public void InitLista()
        {
            listBoxDisciplina.DataSource = null;
            listBoxDisciplina.DataSource = Disciplinas;
            listBoxDisciplina.DisplayMember = "NomeDisciplina";
        }

        private bool ValidaForm() //Metodo auxiliar para fazer a validação
        {
            bool output = true;

            if (string.IsNullOrEmpty(txtNomeDisciplina.Text))
            {
                MessageBox.Show("Insira o nome da disciplina", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(txtDescricaoDisciplina.Text))
            {
                MessageBox.Show("Insira a descrição da disciplina", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            return output;

        }
        #endregion
    }
}
