namespace WinFormsAluno
{
    partial class EditarDisciplinaForm
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
            btnCancelar = new Button();
            bntGuardar = new Button();
            txtDescricaoDisciplina = new TextBox();
            txtNomeDisciplina = new TextBox();
            txtDisciplina = new TextBox();
            SuspendLayout();
            // 
            // btnCancelar
            // 
            btnCancelar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancelar.Location = new Point(607, 347);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(88, 36);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // bntGuardar
            // 
            bntGuardar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntGuardar.Location = new Point(459, 347);
            bntGuardar.Name = "bntGuardar";
            bntGuardar.Size = new Size(92, 36);
            bntGuardar.TabIndex = 8;
            bntGuardar.Text = "Guardar";
            bntGuardar.UseVisualStyleBackColor = true;
            bntGuardar.Click += btnGuardar_Click;
            // 
            // txtDescricaoDisciplina
            // 
            txtDescricaoDisciplina.Location = new Point(106, 209);
            txtDescricaoDisciplina.Name = "txtDescricaoDisciplina";
            txtDescricaoDisciplina.Size = new Size(402, 23);
            txtDescricaoDisciplina.TabIndex = 7;
            // 
            // txtNomeDisciplina
            // 
            txtNomeDisciplina.Location = new Point(106, 134);
            txtNomeDisciplina.Name = "txtNomeDisciplina";
            txtNomeDisciplina.Size = new Size(402, 23);
            txtNomeDisciplina.TabIndex = 6;
            // 
            // txtDisciplina
            // 
            txtDisciplina.Location = new Point(106, 68);
            txtDisciplina.Name = "txtDisciplina";
            txtDisciplina.Size = new Size(163, 23);
            txtDisciplina.TabIndex = 5;
            // 
            // EditarDisciplinaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(bntGuardar);
            Controls.Add(txtDescricaoDisciplina);
            Controls.Add(txtNomeDisciplina);
            Controls.Add(txtDisciplina);
            Name = "EditarDisciplinaForm";
            Text = "EditarDisciplinaForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelar;
        private Button bntGuardar;
        private TextBox txtDescricaoDisciplina;
        private TextBox txtNomeDisciplina;
        private TextBox txtDisciplina;
    }
}