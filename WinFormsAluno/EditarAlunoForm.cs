using Biblioteca;

namespace WinFormsAluno
{
    public partial class EditarAluno : Form
    {
        #region Atributos
        Aluno _editado;

        FormAluno _form;
        #endregion

        #region Método Construtor
        public EditarAluno(FormAluno form, Aluno editado)
        {
            InitializeComponent();

            _editado = editado;
            _form = form;

            txtAluno.Text = _editado.ToString();
            txtNomeAluno.Text = _editado.Nome;
            txtApelidoAluno.Text = _editado.Apelido;

        }
        #endregion

        #region Métodos para Eventos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidaForm())
            {
                _editado.Nome = txtNomeAluno.Text;
                _editado.Apelido = txtApelidoAluno.Text;
                _form.InitLista();
                this.Close();
            }
        }
        #endregion

        #region Outros Métodos 
        private bool ValidaForm()
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
