using Biblioteca;

namespace WinFormsAluno
{
    public partial class FormAluno : Form //Atributos
    {
        #region Atributos
        List<Aluno> Alunos;
        int contaAlunos = 1;
        #endregion

        #region Método Construtor
        public FormAluno() //Instanciar - aqui é o construtor
        {
            Alunos = new List<Aluno>();
            InitializeComponent();
            txtIdAluno.Text = contaAlunos.ToString();
        }
        #endregion

        #region Métodos para Eventos
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Aluno novoAluno;

            if (ValidaForm())
            {
                novoAluno = new Aluno
                {
                    Id = contaAlunos,
                    Nome = txtNomeAluno.Text,
                    Apelido = txtApelidoAluno.Text,
                };

                Alunos.Add(novoAluno);
                contaAlunos++;

                InitLista();
            }
            else
            {
                MessageBox.Show("Preencha corretamente os dados e tente novamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            txtNomeAluno.Text = string.Empty;
            txtApelidoAluno.Text = string.Empty;
            txtIdAluno.Text = contaAlunos.ToString();

            // Grava no arquivo
            Gravacao.GravarAlunos(Alunos);
        }
                
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNomeAluno.Text = string.Empty;
            txtApelidoAluno.Text = string.Empty;
        }

        private void btnApagaAluno_Click(object sender, EventArgs e)
        {
            Aluno alunoAApagar = (Aluno)listBoxAlunos.SelectedItem;

            Aluno apagado = null;

            if (alunoAApagar != null)
            {
                foreach (Aluno aluno in Alunos)
                {
                    if (alunoAApagar.Id == aluno.Id)
                    {
                        apagado = aluno;
                    }
                }

                if (apagado != null)
                {
                    DialogResult resposta;
                    resposta = MessageBox.Show($"Tem certeza que pretende apagar o {apagado.NomeCompleto}",
                        "Apagar",
                        MessageBoxButtons.OKCancel,
                        MessageBoxIcon.Question);

                    if (DialogResult.OK == resposta)
                    {
                        Alunos.Remove(apagado);
                        InitLista();

                        // Grava no arquivo
                        Gravacao.GravarAlunos(Alunos);
                    }
                }
            }
        }

        private void btnEditarAluno_Click(object sender, EventArgs e)
        {
            Aluno alunoAEditar = Alunos.First(x => x.Id == ((Aluno)listBoxAlunos.SelectedItem).Id);

            Aluno editado = null;

            if (alunoAEditar != null)
            {
                foreach (Aluno aluno in Alunos)
                {
                    if (alunoAEditar.Id == aluno.Id)
                    {
                        editado = aluno;
                    }
                }
                //abrir a nova form para editar
                EditarAluno editarAlunoForm = new EditarAluno(this, editado);
                editarAlunoForm.Show();

                // Grava no arquivo
                Gravacao.GravarAlunos(Alunos);
                InitLista();
            }
        }

        private void FormAluno_Load(object sender, EventArgs e)
        {
            Alunos = Gravacao.LerAlunos();
            contaAlunos = Alunos.Max(x => x.Id) + 1;
            txtIdAluno.Text = contaAlunos.ToString();
            InitLista();
        }
        #endregion

        #region Outros Métodos
        public void InitLista()
        {
            listBoxAlunos.DataSource = null;
            listBoxAlunos.DataSource = Alunos;
            listBoxAlunos.DisplayMember = "NomeCompleto";
        }

        private bool ValidaForm() //Metodo auxiliar para fazer a validação
        {
            bool output = true;

            if (string.IsNullOrEmpty(txtNomeAluno.Text))
            {
                MessageBox.Show("Insira o nome do aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            if (string.IsNullOrEmpty(txtApelidoAluno.Text))
            {
                MessageBox.Show("Insira o apelido do aluno", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                output = false;
            }

            return output;

        }
        #endregion
    }
}
