using Biblioteca;

namespace WinFormsAluno
{
    public partial class EditarDisciplinaForm : Form
    {
        #region Atributos
        Disciplina _editada;
        FormDisciplina _form;
        #endregion

        #region Método Construtor
        public EditarDisciplinaForm(FormDisciplina form, Disciplina editada)
        {
            InitializeComponent();

            _editada = editada;
            _form = form;

            txtDisciplina.Text = _editada.ToString();
            txtNomeDisciplina.Text = _editada.Nome;
            txtDescricaoDisciplina.Text = _editada.Descrição;
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
                _editada.Nome = txtNomeDisciplina.Text;
                _editada.Descrição = txtDescricaoDisciplina.Text;
                _form.InitLista();
                this.Close();
            }
        }
        #endregion

        #region Outros Métodos
        private bool ValidaForm()
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
