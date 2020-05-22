using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Objects
{

    public class Pessoa
        
    {
        ///<summary>
        ///Descreve uma pessoa
        /// </summary>
        #region Atributos
        char genero;
        string nome;
        int idade, nmrUtente, concelho;
         
        #endregion

        #region Propriedades

        public string Nome { get => nome; set => nome = value; }
        
        public char Genero { get => genero; set => genero = value; }

        public int Concelho { get => concelho; set => concelho = value; }

        public int Idade
        {
            get { return idade; }
            set
            {
                if (idade < 0 || idade > 150)
                {
                    idade = value;
                }
            }
        }
        public int NmrUtente
        {
            get { return nmrUtente; }
            set
            {
                if ((value.ToString()).Length == 9)
                {
                    nmrUtente = value;
                }
            }
        }
        
        #endregion

        #region Construtores
        ///<summary>
        ///Construtor default 
        /// </summary>
        public Pessoa()
        {
            this.Nome = default(string);
            this.Genero = default(char);
            this.Idade = default(int);
            this.NmrUtente = default(int);
            this.Concelho = default(int);
          
        }
        
        ///<summary>
        /// Construtores de valores vindos do exterior
        /// </summary>
        ///<param name="genero"></param> 
        ///<param name="idade"></param>
        ///<param name="nmrUtente"></param>
        ///<param name="nome"></param>
        ///<param name="concelho"></param>
        ///<param name="tipoCaso"></param>
        public Pessoa(char genero, int idade, int nmrUtente, int concelho, int tipoCaso, string nome)
        { 
        this.Nome = nome;
        this.Genero = genero;
        this.Idade = idade;
        this.NmrUtente = nmrUtente;
        this.Concelho = concelho;
        
        }
        #endregion
    }
}
/*
 if (genero == 'M' || genero == 'm' || genero == 'F' || genero == 'f')
 {
 if (genero == 'M' || genero == 'm')
 contadorMasculino++;
 else
 contadorFemininos++;
 }
*/
