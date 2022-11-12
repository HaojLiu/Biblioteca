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
        public DateTime annodipubblicazione;
        public string editore;
        public int numerodipagine;

        public string getAutore() { return autore; }
        public string getTitolo() { return titolo; }
        public DateTime getAnnodipubblicazione() { return annodipubblicazione; }
        public string getEditore() { return editore; }
        public int getNumerodipagine() { return numerodipagine; }

        public void setAutore(string autore) { this.autore = autore; }
        public void setTitolo(string titolo) { this.titolo = titolo; }
        public void setAnnodipubblicaizone(DateTime annodipubblicazione) { this.annodipubblicazione = annodipubblicazione; }
        public void setEditore(string editore) { this.editore = editore; }
        public void setNumedidipagine(int numerodipagine) { this.numerodipagine = numerodipagine; }


    }
}
