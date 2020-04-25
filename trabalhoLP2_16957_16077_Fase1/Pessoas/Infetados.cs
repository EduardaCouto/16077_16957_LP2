// -------------------------------------------------
// <copyright file="Pesssoa.cs" company="IPCA">
// </copyright>
// <summary>
//	LP2 - 2019-2020
// <desc>OOP, Construtores, Propriedades</desc>
// </summary>
//-------------------------------------------------


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pessoas
{
    public class Infetados
    {
        #region Estado

        char genero;
        int idade, contadorFemininos = 0, contadorMasculino = 0;

        #endregion

        #region
        /// <summary>
        /// Idade do infetado
        /// </summary>
        public string genero
        {
            get { return genero; }
            set
            {
                if (genero == 'M' || genero == 'm' || genero == 'F' || genero == 'f')
                {
                    if (genero == 'M' || genero == 'm')
                        contadorMasculino++;
                    else
                        contadorFemininos++;
                }
            }
        }
        public int idade
        {
            get { return idade; }
            set
            {
                if(idade < 0 || idade > 150)
                {
                    
                }
            }
        }
       
    

    }
}
