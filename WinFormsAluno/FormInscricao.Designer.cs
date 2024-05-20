namespace WinFormsAluno
{
    partial class FormInscricao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInscricao));
            listBoxAluno = new ListBox();
            listBoxDisciplina = new ListBox();
            label1 = new Label();
            label2 = new Label();
            listBoxInscricao = new ListBox();
            label3 = new Label();
            btnAdicionarInscricao = new Button();
            btnRemoverInscricao = new Button();
            SuspendLayout();
            // 
            // listBoxAluno
            // 
            listBoxAluno.FormattingEnabled = true;
            listBoxAluno.ItemHeight = 15;
            listBoxAluno.Location = new Point(12, 27);
            listBoxAluno.Name = "listBoxAluno";
            listBoxAluno.Size = new Size(360, 169);
            listBoxAluno.TabIndex = 0;
            // 
            // listBoxDisciplina
            // 
            listBoxDisciplina.FormattingEnabled = true;
            listBoxDisciplina.ItemHeight = 15;
            listBoxDisciplina.Location = new Point(409, 27);
            listBoxDisciplina.Name = "listBoxDisciplina";
            listBoxDisciplina.Size = new Size(379, 169);
            listBoxDisciplina.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 3);
            label1.Name = "label1";
            label1.Size = new Size(125, 21);
            label1.TabIndex = 2;
            label1.Text = "Lista de Alunos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(409, 3);
            label2.Name = "label2";
            label2.Size = new Size(155, 21);
            label2.TabIndex = 3;
            label2.Text = "Lista de Disciplinas";
            // 
            // listBoxInscricao
            // 
            listBoxInscricao.FormattingEnabled = true;
            listBoxInscricao.ItemHeight = 15;
            listBoxInscricao.Location = new Point(12, 245);
            listBoxInscricao.Name = "listBoxInscricao";
            listBoxInscricao.Size = new Size(776, 154);
            listBoxInscricao.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 220);
            label3.Name = "label3";
            label3.Size = new Size(85, 21);
            label3.TabIndex = 5;
            label3.Text = "Inscrições";
            // 
            // btnAdicionarInscricao
            // 
            btnAdicionarInscricao.BackColor = Color.Honeydew;
            btnAdicionarInscricao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdicionarInscricao.Location = new Point(284, 202);
            btnAdicionarInscricao.Name = "btnAdicionarInscricao";
            btnAdicionarInscricao.Size = new Size(208, 33);
            btnAdicionarInscricao.TabIndex = 6;
            btnAdicionarInscricao.Text = "Adicionar Inscrição";
            btnAdicionarInscricao.UseVisualStyleBackColor = false;
            btnAdicionarInscricao.Click += btnAdicionarInscricao_Click;
            // 
            // btnRemoverInscricao
            // 
            btnRemoverInscricao.BackColor = Color.Linen;
            btnRemoverInscricao.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoverInscricao.Location = new Point(284, 405);
            btnRemoverInscricao.Name = "btnRemoverInscricao";
            btnRemoverInscricao.Size = new Size(208, 33);
            btnRemoverInscricao.TabIndex = 7;
            btnRemoverInscricao.Text = "Remover Inscrição";
            btnRemoverInscricao.UseVisualStyleBackColor = false;
            btnRemoverInscricao.Click += btnRemoverInscricao_Click;
            // 
            // FormInscricao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(btnRemoverInscricao);
            Controls.Add(btnAdicionarInscricao);
            Controls.Add(label3);
            Controls.Add(listBoxInscricao);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxDisciplina);
            Controls.Add(listBoxAluno);
            Name = "FormInscricao";
            Text = "FormInscicao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxAluno;
        private ListBox listBoxDisciplina;
        private Label label1;
        private Label label2;
        private ListBox listBoxInscricao;
        private Label label3;
        private Button btnAdicionarInscricao;
        private Button btnRemoverInscricao;
    }
}