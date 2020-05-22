using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Objects
{
    public class Morto : Pessoa
    {
        #region Variaveis
        int numMort;
        #endregion

        #region Propriedades
        public int NumMort { get => numMort; set => numMort = value;  }
        #endregion

        #region Construtores
        ///<summary>
        ///Construtor default 
        /// </summary>
        public Morto()
        {
            this.NumMort = default(int);
        }

        ///<summary>
        /// Construtores
        /// </summary>
        ///<param name="numMort"></param>
        public Morto(int numMort)
        {
            this.NumMort = numMort;
        }
        #endregion
    }
}
