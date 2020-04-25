using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Business_Objects;

namespace Data_Layer
{
   public class Pessoas : Ficheiro
   {
        
        const string DATAFILE1 = "Pessoas.dat";
       
       
        private static List<Pessoa> listaPessoas;
        

        #region Construtores
        /// <summary>
        /// Construtor default
        /// </summary>
        static Pessoas()
        {
            listaPessoas = new List<Pessoa>();
            Pessoa a = new Pessoa();
            a.CarregaFicheiro();
        }
        #endregion

        #region Metodos
        protected override void EscreveFicheiro()
        {
            throw new NotImplementedException();
        }

        protected override void CarregaFicheiro()
        {
            throw new NotImplementedException();
        }
        #endregion
    }


}
