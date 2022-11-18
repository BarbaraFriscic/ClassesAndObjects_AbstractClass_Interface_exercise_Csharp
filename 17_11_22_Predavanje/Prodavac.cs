using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_11_22_Predavanje
{
    public interface IProdaja
    {
        string UvjeriKupca();
        string Prodaj(int vrijednost);
    }
    internal abstract class Prodavac
    {
        protected string ime;
        protected string prezime;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }

        public Prodavac(string ime, string prezime)
        {
            this.Ime = ime;
            this.Prezime = prezime;
        }
        string PunoImeProdavaca()
        {
            return $"{Ime} {Prezime}";
        }
    }
    class AgentZaNekretnine : Prodavac, IProdaja
        
    {
        protected double ukupnaProdaja;
        protected double zaradenaProvizija;
        protected double postotakProvizije;

        public double UkupnaProdaja
        {
            get { return ukupnaProdaja; }
            set { ukupnaProdaja = value; }
        }

        public double ZaradenaProvizija
        {
            get { return zaradenaProvizija; }
            set { zaradenaProvizija = value; }
        }
        public double PostotakProvizije
        {
            get { return postotakProvizije; }
            set { postotakProvizije = value; }
        }
        public AgentZaNekretnine(string ime, string prezime, double postotakProvizije)  :base(ime, prezime)
        {
            this.PostotakProvizije = postotakProvizije;
            ZaradenaProvizija = 0;
        }

        public string UvjeriKupca()
        {
            return $"\n {Ime} kaže: Ova nekretnina će za 10 godina vrijediti duplo više. \n Bit će vam žao ako propustite ovakvu priliku! \n";
        }
        public string Prodaj(int vrijednostKuce)
        {
            UkupnaProdaja += vrijednostKuce;
            ZaradenaProvizija = UkupnaProdaja * postotakProvizije;

            return $"\n {Ime} je prodala nekretnina u vrijednosti: {UkupnaProdaja:C}. \n Njena ukupna provizija iznosi: {ZaradenaProvizija:C}. \n";
        }
    }
    class TrgovackiPutnik : Prodavac, IProdaja
    {
        protected int brojProdanihPaketa;

        public int BrojProdanihPaketa
        {
            get { return brojProdanihPaketa;}
            set { brojProdanihPaketa = value; }
        }
       public  TrgovackiPutnik(string ime, string prezime) :base(ime, prezime)
        {
            BrojProdanihPaketa = 0;
        }
        public string UvjeriKupca()
        {
            return $"\n {Ime} kaže: Želite li kupiti naš proizvod? \n Cijena? Prava sitnica! \n";
        }
        public string Prodaj(int brojProdanihPaketa)
        {
            BrojProdanihPaketa += brojProdanihPaketa;

            return $"\n {Ime} je ukupno prodao {BrojProdanihPaketa} paketa. \n";
        }
    }
}
