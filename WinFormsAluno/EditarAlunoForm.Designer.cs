namespace WinFormsAluno
{
    partial class EditarAluno
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
            txtAluno = new TextBox();
            txtNomeAluno = new TextBox();
            txtApelidoAluno = new TextBox();
            btnCancelar = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // txtAluno
            // 
            txtAluno.Enabled = false;
            txtAluno.Location = new Point(34, 55);
            txtAluno.Name = "txtAluno";
            txtAluno.Size = new Size(322, 23);
            txtAluno.TabIndex = 0;
            // 
            // txtNomeAluno
            // 
            txtNomeAluno.Location = new Point(34, 115);
            txtNomeAluno.Name = "txtNomeAluno";
            txtNomeAluno.Size = new Size(648, 23);
            txtNomeAluno.TabIndex = 1;
            // 
            // txtApelidoAluno
            // 
            txtApelidoAluno.Location = new Point(34, 173);
            txtApelidoAluno.Name = "txtApelidoAluno";
            txtApelidoAluno.Size = new Size(648, 23);
            txtApelidoAluno.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(607, 310);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 50);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(491, 310);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 50);
            btnGuardar.TabIndex = 4;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // EditarAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(755, 384);
            Controls.Add(btnGuardar);
            Controls.Add(btnCancelar);
            Controls.Add(txtApelidoAluno);
            Controls.Add(txtNomeAluno);
            Controls.Add(txtAluno);
            Name = "EditarAluno";
            Text = "EditarAlunoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAluno;
        private TextBox txtNomeAluno;
        private TextBox txtApelidoAluno;
        private Button btnCancelar;
        private Button btnGuardar;
    }
}