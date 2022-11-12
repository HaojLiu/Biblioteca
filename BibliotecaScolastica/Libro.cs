using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaScolastica
{
    internal class Libro
    {
        public string autore;
        public string titolo;
        public int annodipubblicazione;
        public string editore;
        public int numerodipagine;

        public Libro(string autore, string titolo, int annodipubblicazione, string editore, int numerodipagine)
        {
            this.autore = autore;
            this.titolo = titolo;
            this.annodipubblicazione = annodipubblicazione;
            this.editore = editore;
            this.numerodipagine = numerodipagine;
        }

        public string getAutore() { return autore; }
        public string getTitolo() { return titolo; }
        public int getAnnodipubblicazione() { return annodipubblicazione; }
        public string getEditore() { return editore; }
        public int getNumerodipagine() { return numerodipagine; }

        public void setAutore(string autore) { this.autore = autore; }
        public void setTitolo(string titolo) { this.titolo = titolo; }
        public void setAnnodipubblicaizone(int annodipubblicazione) { this.annodipubblicazione = annodipubblicazione; }
        public void setEditore(string editore) { this.editore = editore; }
        public void setNumedidipagine(int numerodipagine) { this.numerodipagine = numerodipagine; }

        public string toString()
        {
            return "Autore:\t\t" + getAutore() + "\nTitolo:\t\t" + getTitolo() + "\nAnno di pubblicazione:\t" + getAnnodipubblicazione().ToString() +
                "\nEditore:\t\t" + getEditore() + "\nNumero di pagine:\t" + getNumerodipagine();
        }

        public string readingTime()
        {
            if (numerodipagine < 100)
                return "circa un'ora";
            else if (numerodipagine >= 100 || numerodipagine <= 200)
                return "circa 2 ore";
            else if (numerodipagine > 200)
                return "maggiore di 2 ore";
        }
    }
}
