using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ProjetoLDS
{
    public partial class Form1 : Form
    {
        View view;

        public Form1()
        {
            InitializeComponent();
        }

        public View View { get => view; set => view = value; }

        private void ProcurarBt_Click(object sender, EventArgs e)
        {
            view.ProcurarFicheiro(openFileDialog1, EnderecoFicheiroTxt);
        }

        private void InserirBt_Click(object sender, EventArgs e)
        {
            view.InserirFicheiroClick(sender, e, openFileDialog1, UnirFicheirosGridView, EnderecoFicheiroTxt);
        }

        private void UnirFicheirosGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            view.UnirFicheirosGrdViewCellContentClick(e, UnirFicheirosGridView);
        }

        private void ProcurarPastaBt_Click(object sender, EventArgs e)
        {
            view.ProcurarPastaClick(folderBrowserDialog1, EnderecoPastaDestinoTxt);
        }

        private string[] GetFiles()
        {
            string[] ficheiros = new string[UnirFicheirosGridView.Rows.Count];
            var i = 0;

            foreach (DataGridViewRow item in UnirFicheirosGridView.Rows)
            {
                ficheiros[i] = item.Cells["NomeFicheiro"].Value.ToString();
                i++;
            }

            return ficheiros;
        }

        private void ConcatenarFicheirosBt_Click(object sender, EventArgs e)
        {
            if (EnderecoPastaDestinoTxt.Text.Length < 1 || !Directory.Exists(EnderecoPastaDestinoTxt.Text))
            {
                MessageBox.Show("Deve introduzir a pasta de destino, antes de continuar.");
                return;
            }

            view.ConcatenarFicheirosClick(sender, e, GetFiles(), EnderecoPastaDestinoTxt);
        }

        private void EliminarBt_Click(object sender, EventArgs e)
        {
            if (EnderecoFicheiro2Txt.Text.Length < 1 || !File.Exists(EnderecoFicheiro2Txt.Text))
            {
                MessageBox.Show("Deve introduzir o ficheiro, antes de continuar.");
                return;
            }

            if (PaginasParaEliminarTxt.Text.Length == 0)
            {
                MessageBox.Show("Deve introduzir a(s) página(s) que pretende eliminar, antes de continuar.");
                return;
            }

            view.EliminarPaginasClick(sender, e, EnderecoFicheiro2Txt.Text, ParseStringToIntArray(PaginasParaEliminarTxt.Text));
        }

        private int[] ParseStringToIntArray(string input)
        {
            List<int> numbers = new List<int>();
            string[] parts = input.Split(new char[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string part in parts)
            {
                if (part.Contains("-"))
                {
                    string[] rangeParts = part.Split('-');
                    if (rangeParts.Length == 2 && int.TryParse(rangeParts[0], out int start) && int.TryParse(rangeParts[1], out int end))
                    {
                        for (int i = start; i <= end; i++)
                        {
                            numbers.Add(i);
                        }
                    }
                }
                else if (int.TryParse(part, out int number))
                {
                    numbers.Add(number);
                }
            }

            return numbers.ToArray();
        }

        private void Procurar2Bt_Click(object sender, EventArgs e)
        {
            view.ProcurarFicheiro(openFileDialog1, EnderecoFicheiro2Txt);
        }
    }
}