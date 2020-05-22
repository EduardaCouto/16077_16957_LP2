using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Objects
{
    public class Recuperado : Pessoa
    {
        #region Variaveis
        int numRec;
        #endregion

        #region Propriedades
        public int NumRec { get => numRec; set => numRec = value; }
        #endregion

        #region Construtores
        ///<summary>
        ///Construtor default 
        /// </summary>
        public Recuperado()
        {
            this.NumRec = default(int);
        }

        ///<summary>
        /// Construtores
        /// </summary>
        ///<param name="numRec"></param>
        public Recuperado(int numRec)
        {
            this.NumRec = numRec;
        }
        #endregion


    }
}
