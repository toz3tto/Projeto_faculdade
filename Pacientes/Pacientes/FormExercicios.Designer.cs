namespace Pacientes
{
    partial class FormExercicios
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
            txtExercicio = new TextBox();
            btnAdicionar = new Button();
            lstExercicios = new ListBox();
            btnGerarPDF = new Button();
            SuspendLayout();
            // 
            // txtExercicio
            // 
            txtExercicio.Location = new Point(31, 69);
            txtExercicio.Name = "txtExercicio";
            txtExercicio.Size = new Size(125, 27);
            txtExercicio.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            btnAdicionar.Location = new Point(162, 67);
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.Size = new Size(94, 29);
            btnAdicionar.TabIndex = 1;
            btnAdicionar.Text = "+";
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click_1;
            // 
            // lstExercicios
            // 
            lstExercicios.FormattingEnabled = true;
            lstExercicios.Location = new Point(31, 133);
            lstExercicios.Name = "lstExercicios";
            lstExercicios.Size = new Size(545, 124);
            lstExercicios.TabIndex = 2;
            // 
            // btnGerarPDF
            // 
            btnGerarPDF.Location = new Point(33, 272);
            btnGerarPDF.Name = "btnGerarPDF";
            btnGerarPDF.Size = new Size(94, 29);
            btnGerarPDF.TabIndex = 3;
            btnGerarPDF.Text = "PDF";
            btnGerarPDF.UseVisualStyleBackColor = true;
            btnGerarPDF.Click += btnGerarPDF_Click_1;
            // 
            // FormExercicios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGerarPDF);
            Controls.Add(lstExercicios);
            Controls.Add(btnAdicionar);
            Controls.Add(txtExercicio);
            Name = "FormExercicios";
            Text = "FormExercicios";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtExercicio;
        private Button btnAdicionar;
        private ListBox lstExercicios;
        private Button btnGerarPDF;
    }
}