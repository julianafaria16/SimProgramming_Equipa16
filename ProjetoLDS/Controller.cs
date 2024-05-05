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
        Model model;
        View view;

        public delegate void AtivacaoInterface(object origem);
        public event AtivacaoInterface AtivarInterface;

        public Controller()
        {
            view = new View(model);
            model = new Model(view);

            //Ligar o evento da View ao método do Controller, de foram desacoplada
            //porque a View não sabe quem responderá ao evento.
            view.ProcessarIntrodFicheiro += ProcessarIntrodFicheiro;
            //view.PrecisoDeFormas += model.SolicitarListaFormas;
        }

        public void IniciarPrograma()
        {
            view.AtivarInterface();
        }

        public void ProcessarIntrodFicheiro(object origem, EventArgs e)
        {
            // Implementar...
            model.IntroduzirFicheiro(origem, e);
        }

    }
}
