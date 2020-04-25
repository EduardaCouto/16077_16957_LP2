using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Layer
{
    public abstract class Ficheiro
    {
        protected abstract void EscreveFicheiro();
        protected abstract void CarregaFicheiro();
    }
}
