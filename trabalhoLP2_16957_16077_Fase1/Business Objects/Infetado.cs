using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Objects
{
    public enum Estado { IsolamentoEstavel, HospitalizadoEstavel, HospitalizadoCritico }
    public class Infetado : Pessoa
    {
        #region Estado
        
        public Estado estado;
        int numInf;
        #endregion

        #region Propriedades
        public int NumInf { get => numInf; set => numInf = value; }
        #endregion

        #region Construtores
        ///<summary>
        ///Construtor default 
        /// </summary>
        public Infetado()
        {
            this.NumInf = default(int);
        }

        ///<summary>
        /// Construtores
        /// </summary>
        ///<param name="numInf"></param>
        public Infetado(int numInf)
        {
            this.NumInf = numInf;
        }
        #endregion
    }
}
