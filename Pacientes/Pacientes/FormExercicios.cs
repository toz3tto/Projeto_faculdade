using iTextSharp.text;
using iTextSharp.text.pdf;

namespace Pacientes
{
    public partial class FormExercicios : Form
    {
        private List<string> listaExercicios;

        public FormExercicios()
        {
            InitializeComponent();
            listaExercicios = new List<string>();
        }  

        private void btnAdicionar_Click_1(object sender, EventArgs e)
        {
            string exercicio = txtExercicio.Text.Trim();

            if (!string.IsNullOrEmpty(exercicio))
            {
                listaExercicios.Add(exercicio);
                lstExercicios.Items.Add(exercicio);
                txtExercicio.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, insira um nome de exercício válido.");
            }
        }

        private void btnGerarPDF_Click_1(object sender, EventArgs e)
        {
            if (listaExercicios.Count == 0)
            {
                MessageBox.Show("Não há exercícios para gerar o PDF.");
                return;
            }

            // Defina o caminho para salvar o PDF
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "PDF Files (*.pdf)|*.pdf",
                Title = "Salvar Lista de Exercícios"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string caminhoArquivo = saveFileDialog.FileName;

                // Configuração do PDF
                Document doc = new Document();
                PdfWriter.GetInstance(doc, new FileStream(caminhoArquivo, FileMode.Create));

                doc.Open();
                doc.Add(new Paragraph("Lista de Exercícios"));
                doc.Add(new Paragraph(" ")); // Espaço em branco

                // Adicionar cada exercício no PDF
                foreach (string exercicio in listaExercicios)
                {
                    doc.Add(new Paragraph("- " + exercicio));
                }

                doc.Close();
                MessageBox.Show("PDF gerado com sucesso!");
            }
        }
    }
}
