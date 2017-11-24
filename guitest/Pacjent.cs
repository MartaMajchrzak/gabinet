using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guitest
{
   public class Pacjent
    {
        public int nrPacjenta { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Email { get; set; }
        public string nrPesel { get ; set; }
        public string Nrtelefonu { get; set; } 
        public string dataUrodzenia { get; set; } 
        public string Kod { get; set; }
        public string Ulica { get; set; }
        public int ID { get; set; }
        public string FullInfo// kolejnosc wlasciwosci wg wierszy w bazie
        {
            get
            {  
                return $"{ID} {Imie} {Nazwisko} ({Email}) "; //to zwraca przy wyszukiwaniu w list boxie
            }
         
         }
        public string NrTel
        {
            get { return Nrtelefonu; } // Nrtelefonu to w klasie pacjent
            set
            {
                if (value.Length == 9)
                {
                    Nrtelefonu = value;
                }
                else
                {
                    Nrtelefonu = "000000000";
                }
            }

        }
       /* public string NrPesel
        {
            get { return nrPesel; }
            set
            {
                if (value.Length == 11)
                    nrPesel = value;
                else
                {
                    nrPesel = "00000000000";
                }
            }

        }*/
    }
}
