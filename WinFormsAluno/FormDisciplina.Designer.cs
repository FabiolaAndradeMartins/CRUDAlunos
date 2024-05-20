namespace WinFormsAluno
{
    partial class FormDisciplina
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDisciplina));
            btnEditarDisciplina = new Button();
            btnApagaDisciplina = new Button();
            listBoxDisciplina = new ListBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            txtDescricaoDisciplina = new TextBox();
            txtNomeDisciplina = new TextBox();
            txtIdDisciplina = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnEditarDisciplina
            // 
            btnEditarDisciplina.BackColor = Color.Linen;
            btnEditarDisciplina.BackgroundImage = (Image)resources.GetObject("btnEditarDisciplina.BackgroundImage");
            btnEditarDisciplina.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditarDisciplina.Location = new Point(609, 339);
            btnEditarDisciplina.Name = "btnEditarDisciplina";
            btnEditarDisciplina.Size = new Size(169, 68);
            btnEditarDisciplina.TabIndex = 21;
            btnEditarDisciplina.Text = "Editar disciplina selecionada";
            btnEditarDisciplina.UseVisualStyleBackColor = false;
            btnEditarDisciplina.Click += btnEditarDisciplina_Click;
            // 
            // btnApagaDisciplina
            // 
            btnApagaDisciplina.BackColor = Color.Honeydew;
            btnApagaDisciplina.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnApagaDisciplina.Location = new Point(609, 247);
            btnApagaDisciplina.Name = "btnApagaDisciplina";
            btnApagaDisciplina.Size = new Size(169, 68);
            btnApagaDisciplina.TabIndex = 20;
            btnApagaDisciplina.Text = "Apagar disciplina selecionada";
            btnApagaDisciplina.UseVisualStyleBackColor = false;
            btnApagaDisciplina.Click += btnApagaDisciplina_Click;
            // 
            // listBoxDisciplina
            // 
            listBoxDisciplina.FormattingEnabled = true;
            listBoxDisciplina.ItemHeight = 15;
            listBoxDisciplina.Location = new Point(22, 298);
            listBoxDisciplina.Name = "listBoxDisciplina";
            listBoxDisciplina.Size = new Size(512, 109);
            listBoxDisciplina.TabIndex = 19;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.FromArgb(224, 224, 224);
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(342, 221);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(91, 35);
            btnCancelar.TabIndex = 18;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.FromArgb(224, 224, 224);
            btnGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(198, 221);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(88, 35);
            btnGuardar.TabIndex = 17;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtDescricaoDisciplina
            // 
            txtDescricaoDisciplina.Location = new Point(269, 156);
            txtDescricaoDisciplina.Name = "txtDescricaoDisciplina";
            txtDescricaoDisciplina.Size = new Size(386, 23);
            txtDescricaoDisciplina.TabIndex = 16;
            // 
            // txtNomeDisciplina
            // 
            txtNomeDisciplina.Location = new Point(242, 98);
            txtNomeDisciplina.Name = "txtNomeDisciplina";
            txtNomeDisciplina.Size = new Size(401, 23);
            txtNomeDisciplina.TabIndex = 15;
            // 
            // txtIdDisciplina
            // 
            txtIdDisciplina.Location = new Point(187, 44);
            txtIdDisciplina.Name = "txtIdDisciplina";
            txtIdDisciplina.Size = new Size(217, 23);
            txtIdDisciplina.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(72, 158);
            label3.Name = "label3";
            label3.Size = new Size(191, 21);
            label3.TabIndex = 13;
            label3.Text = "Descrição da Disciplina:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(72, 100);
            label2.Name = "label2";
            label2.Size = new Size(164, 21);
            label2.TabIndex = 12;
            label2.Text = "Nome da Disciplina:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(72, 46);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 11;
            label1.Text = "Id Disciplina:";
            // 
            // FormDisciplina
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnEditarDisciplina);
            Controls.Add(btnApagaDisciplina);
            Controls.Add(listBoxDisciplina);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtDescricaoDisciplina);
            Controls.Add(txtNomeDisciplina);
            Controls.Add(txtIdDisciplina);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormDisciplina";
            Text = "FormDisciplina";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEditarDisciplina;
        private Button btnApagaDisciplina;
        private ListBox listBoxDisciplina;
        private Button btnCancelar;
        private Button btnGuardar;
        private TextBox txtDescricaoDisciplina;
        private TextBox txtNomeDisciplina;
        private TextBox txtIdDisciplina;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}