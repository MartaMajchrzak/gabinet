using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guitest
{
   public class Pacjent
    {
       // public int nrPacjenta { get; set; }
        public  string imie { get; set; }
        public  string nazwisko { get; set; }
        public string PESEL { get; set; }
        public  string telefon { get; set; }
        public string eMail { get; set; }

        public string dataUrodzenia { get; set; } 
       
        public  string adresKorespondencyjny { get; set; }
        public  int IDpacjent { get; set; }
        public string FullInfo// kolejnosc wlasciwosci wg wierszy w bazie
        {
            get
            {  
                return $"{IDpacjent} {imie} {nazwisko} ({eMail}) "; //to zwraca przy wyszukiwaniu w list boxie
            }
         
         }
        public string NrTel
        {
            get { return telefon; }
            // Nrtelefonu to w klasie pacjent
            set
            {
                if (value.Length == 9)
                {
                    telefon = value;
                }
                else
                {
                    telefon = "000000000";
                }
            }

        }
       
    }
}
