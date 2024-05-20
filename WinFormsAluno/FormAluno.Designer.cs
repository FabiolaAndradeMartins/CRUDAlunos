namespace WinFormsAluno
{
    partial class FormAluno
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAluno));
            label1 = new Label();
            txtIdAluno = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtNomeAluno = new TextBox();
            txtApelidoAluno = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            listBoxAlunos = new ListBox();
            btnApagaAluno = new Button();
            btnEditarAluno = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(58, 49);
            label1.Name = "label1";
            label1.Size = new Size(100, 21);
            label1.TabIndex = 0;
            label1.Text = "Id de aluno:";
            // 
            // txtIdAluno
            // 
            txtIdAluno.Enabled = false;
            txtIdAluno.Location = new Point(210, 47);
            txtIdAluno.Name = "txtIdAluno";
            txtIdAluno.Size = new Size(188, 23);
            txtIdAluno.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(58, 93);
            label2.Name = "label2";
            label2.Size = new Size(133, 21);
            label2.TabIndex = 2;
            label2.Text = "Nome do aluno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(58, 136);
            label3.Name = "label3";
            label3.Size = new Size(146, 21);
            label3.TabIndex = 3;
            label3.Text = "Apelido do aluno:";
            // 
            // txtNomeAluno
            // 
            txtNomeAluno.Location = new Point(210, 95);
            txtNomeAluno.Name = "txtNomeAluno";
            txtNomeAluno.Size = new Size(272, 23);
            txtNomeAluno.TabIndex = 4;
            // 
            // txtApelidoAluno
            // 
            txtApelidoAluno.Location = new Point(210, 134);
            txtApelidoAluno.Name = "txtApelidoAluno";
            txtApelidoAluno.Size = new Size(272, 23);
            txtApelidoAluno.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(224, 224, 224);
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(378, 197);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(87, 38);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(224, 224, 224);
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(270, 197);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(90, 38);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // listBoxAlunos
            // 
            listBoxAlunos.FormattingEnabled = true;
            listBoxAlunos.ItemHeight = 15;
            listBoxAlunos.Location = new Point(12, 279);
            listBoxAlunos.Name = "listBoxAlunos";
            listBoxAlunos.Size = new Size(599, 109);
            listBoxAlunos.TabIndex = 8;
            // 
            // btnApagaAluno
            // 
            btnApagaAluno.BackColor = Color.Honeydew;
            btnApagaAluno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApagaAluno.Location = new Point(644, 271);
            btnApagaAluno.Name = "btnApagaAluno";
            btnApagaAluno.Size = new Size(170, 52);
            btnApagaAluno.TabIndex = 9;
            btnApagaAluno.Text = "Apagar aluno selecionado";
            btnApagaAluno.UseVisualStyleBackColor = false;
            btnApagaAluno.Click += btnApagaAluno_Click;
            // 
            // btnEditarAluno
            // 
            btnEditarAluno.BackColor = Color.Linen;
            btnEditarAluno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarAluno.Location = new Point(644, 329);
            btnEditarAluno.Name = "btnEditarAluno";
            btnEditarAluno.Size = new Size(170, 52);
            btnEditarAluno.TabIndex = 10;
            btnEditarAluno.Text = "Editar aluno selecionado";
            btnEditarAluno.UseVisualStyleBackColor = false;
            btnEditarAluno.Click += btnEditarAluno_Click;
            // 
            // FormAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(836, 414);
            Controls.Add(btnEditarAluno);
            Controls.Add(btnApagaAluno);
            Controls.Add(listBoxAlunos);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtApelidoAluno);
            Controls.Add(txtNomeAluno);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtIdAluno);
            Controls.Add(label1);
            Name = "FormAluno";
            Text = "Form1";
            Load += FormAluno_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIdAluno;
        private Label label2;
        private Label label3;
        private TextBox txtNomeAluno;
        private TextBox txtApelidoAluno;
        private Button btnCancelar;
        private Button btnGuardar;
        private ListBox listBoxAlunos;
        private Button btnApagaAluno;
        private Button btnEditarAluno;
    }
}
