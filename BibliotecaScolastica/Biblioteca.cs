using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaScolastica
{
    internal class Biblioteca
    {
        public string nome;
        public string indirizzo;
        public double orariodiapertura;
        public double orariodichiusura;
        public string[,] elencolibri = new string[1000,5]; //1000 libri, ognuno con 5 attributi
        private int indice = 0; //indice usato solo per matrice 
    }
}
