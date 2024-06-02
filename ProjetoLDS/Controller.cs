using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ProjetoLDS
{
    class Controller
    {
        IModel model;
        View view;

        public delegate void AtivacaoInterface(object origem);
        public event AtivacaoInterface AtivarInterface;

        public string[] Ficheiros { get; set; }
        public string PastaDestino { get; set; }
        public string FicheiroPdf { get; set; }
        public int[] PaginasEliminar { get; set; }

        public Controller(string[] nFicheiros, string nPastaDestino, string nFicheiroPdf, int[] nPaginasEliminar)
        {
            view = new View(model);
            model = new Model(view);

            //Ligar o evento da View ao método do Controller, de forma desacoplada porque a View não sabe quem responderá ao evento.
            view.ProcessarIntrodFicheiro += ProcessarIntrodFicheiro;

            Ficheiros = nFicheiros;
            PastaDestino = nPastaDestino;
            FicheiroPdf = nFicheiroPdf;
            PaginasEliminar = nPaginasEliminar;
        }

        public void IniciarPrograma()
        {
            view.AtivarInterface();
        }

        public void ProcessarIntrodFicheiro(object origem, EventArgs e)
        {
            model.IntroduzirFicheiro(origem, e);
        }

        public string ProcessarConcatFicheiros(object origem, EventArgs e)
        {
            return model.ConcatenarFicheiros(Ficheiros, PastaDestino);
        }

        public bool ProcessarEliminarPaginas(object origem, EventArgs e)
        {
            return model.EliminarPaginas(FicheiroPdf, PaginasEliminar);
        }
    }
}
