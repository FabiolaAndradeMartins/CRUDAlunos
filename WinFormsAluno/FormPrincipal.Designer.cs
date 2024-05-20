namespace WinFormsAluno
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            btnAluno = new Button();
            btnDisciplina = new Button();
            label1 = new Label();
            btnInscricoes = new Button();
            panel1 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnAluno
            // 
            btnAluno.BackColor = Color.Thistle;
            btnAluno.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAluno.Location = new Point(108, 299);
            btnAluno.Name = "btnAluno";
            btnAluno.Size = new Size(126, 47);
            btnAluno.TabIndex = 0;
            btnAluno.Text = "Aluno";
            btnAluno.UseVisualStyleBackColor = false;
            btnAluno.Click += btnAluno_Click;
            // 
            // btnDisciplina
            // 
            btnDisciplina.BackColor = Color.MistyRose;
            btnDisciplina.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDisciplina.Location = new Point(334, 299);
            btnDisciplina.Name = "btnDisciplina";
            btnDisciplina.Size = new Size(126, 47);
            btnDisciplina.TabIndex = 1;
            btnDisciplina.Text = "Disciplina";
            btnDisciplina.UseVisualStyleBackColor = false;
            btnDisciplina.Click += btnDisciplina_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 159);
            label1.Name = "label1";
            label1.Size = new Size(254, 21);
            label1.TabIndex = 2;
            label1.Text = "Escolha uma das opções abaixo:";
            // 
            // btnInscricoes
            // 
            btnInscricoes.BackColor = Color.PaleTurquoise;
            btnInscricoes.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInscricoes.Location = new Point(558, 299);
            btnInscricoes.Name = "btnInscricoes";
            btnInscricoes.Size = new Size(126, 47);
            btnInscricoes.TabIndex = 3;
            btnInscricoes.Text = "Inscrição";
            btnInscricoes.UseVisualStyleBackColor = false;
            btnInscricoes.Click += btnInscricoes_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top;
            panel1.BackColor = Color.FromArgb(255, 192, 128);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(1, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 68);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 192);
            label2.Location = new Point(164, 8);
            label2.Name = "label2";
            label2.Size = new Size(467, 25);
            label2.TabIndex = 0;
            label2.Text = "EducAção - Centro de Formação Profissional";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(456, 42);
            label3.Name = "label3";
            label3.Size = new Size(331, 17);
            label3.TabIndex = 5;
            label3.Text = "Há 24 anos garantindo sua formação com excelência.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(1, 436);
            label4.Name = "label4";
            label4.Size = new Size(357, 15);
            label4.TabIndex = 7;
            label4.Text = " Copyrights 2024. Todos os Direitos Reservados By Fabíola Martins";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(panel1);
            Controls.Add(btnInscricoes);
            Controls.Add(label1);
            Controls.Add(btnDisciplina);
            Controls.Add(btnAluno);
            DoubleBuffered = true;
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAluno;
        private Button btnDisciplina;
        private Label label1;
        private Button btnInscricoes;
        private Panel panel1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}