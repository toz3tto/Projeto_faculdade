namespace Pacientes
{
    partial class Form_Principal
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
            btnCriarTreinos = new Button();
            btnCadastrarPacientes = new Button();
            SuspendLayout();
            // 
            // btnCriarTreinos
            // 
            btnCriarTreinos.Location = new Point(130, 86);
            btnCriarTreinos.Name = "btnCriarTreinos";
            btnCriarTreinos.Size = new Size(110, 96);
            btnCriarTreinos.TabIndex = 0;
            btnCriarTreinos.Text = "Criar Treino";
            btnCriarTreinos.UseVisualStyleBackColor = true;
            btnCriarTreinos.Click += btnCriarTreinos_Click;
            // 
            // btnCadastrarPacientes
            // 
            btnCadastrarPacientes.Location = new Point(353, 86);
            btnCadastrarPacientes.Name = "btnCadastrarPacientes";
            btnCadastrarPacientes.Size = new Size(110, 96);
            btnCadastrarPacientes.TabIndex = 1;
            btnCadastrarPacientes.Text = "Cadastrar Pacientes";
            btnCadastrarPacientes.UseVisualStyleBackColor = true;
            btnCadastrarPacientes.Click += btnCadastrarPacientes_Click;
            // 
            // Form_Principal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 303);
            Controls.Add(btnCadastrarPacientes);
            Controls.Add(btnCriarTreinos);
            Name = "Form_Principal";
            Text = "Form_Principal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCriarTreinos;
        private Button btnCadastrarPacientes;
    }
}