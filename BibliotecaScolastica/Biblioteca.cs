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

        public void AggiungiLibro(Libro libro)
        {
            elencolibri[indice, 0] = libro.autore;
            elencolibri[indice, 1] = libro.titolo;
            elencolibri[indice, 2] = libro.annodipublicazione.ToString();
            elencolibri[indice, 3] = libro.editore;
            elencolibri[indice, 4] = libro.numerodipagine.ToString();
        }

        public Libro RicercaLibro(string titolo)
        {
            Libro risultato = new Libro("", "", 0, "", 0);
            int indicelibro = 0;
            for (int i = 0; i < elencolibri.GetLength(0); i++)
            {
                if (elencolibri[i, 1] == titolo)
                {
                    indicelibro = i;
                }
            }
            risultato.autore = elencolibri[indicelibro, 0];
            risultato.titolo = elencolibri[indicelibro, 1];
            risultato.annodipublicazione = int.Parse(elencolibri[indicelibro, 2]);
            risultato.editore = elencolibri[indicelibro, 3];
            risultato.numerodipagine = int.Parse(elencolibri[indicelibro, 4]);

            return risultato;
        }

        public string CercaPerAutore(string autore)
        { //restituisce l'elenco dei titoli dei libri di un autore
            string result = "";
            for (int i = 0; i < elencolibri.GetLength(0); i++)
            {
                if (elencolibri[i, 0] == autore)
                {
                    result += elencolibri[i, 1];
                }
            }
            return result;
        }

        public int TotaleLibri()
        {
            int cont = 0;
            for (int i = 0; i < elencolibri.GetLength(0); i++)
            {
                if (elencolibri[i, 0] != null)
                {
                    cont++;
                }
            }
            return cont;
        }
    }
}
