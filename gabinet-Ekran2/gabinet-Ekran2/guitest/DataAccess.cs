using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper; // Dapper pozwala na pobieranie danych z bazy danych i zapełnianie danych w modelu obiektowym.
//Następująca metoda pobiera wszystkie rekordy z tabeli pacjent, przechowuje je w pamięci i zwraca kolekcję.
using System.Data;

namespace guitest
{
    public class DataAccess // zawiera  wyszukiwanie i rejestrowanie pacjentow 
    { //tworzymy metode
        public List <Pacjent> GetPeople (string nazwisko)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("NazwaBazy")))//pobierz cnn string z
                //helpera dla bazy danych o nazwie: 
            {
                //rozmawiamy z sql

                var output = connection.Query<Pacjent>("dbo.Pacjenci_GetByLastName @Nazwisko", new { Nazwisko = nazwisko }).ToList(); //dbo
                 //var- zamiana listy w zmienna output
              // to jest z bazy danych jakas procedura ALTER PROCEDURE, trzeba stworzyc procedure w sql w bazie danych
                //wywolaj procceddure dbo....i wrzuc do klasy pacjent
                return output;
            } //query chcemy dane z bazy, chcemy liste pacjenta, <pacjent>- typ danych
        }

        public void ZarejestrujPacjenta(string imie, string nazwisko, string adresEmail, string nrTel, string numerPesel, string Dataur, string ulica, string kod)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("NazwaBazy")))
            {
                
             List<Pacjent> pacjenci = new List<Pacjent>();
             pacjenci.Add(new Pacjent{ Imie = imie, Nazwisko = nazwisko, Email = adresEmail, Nrtelefonu = nrTel,  nrPesel= numerPesel, dataUrodzenia=Dataur, Ulica=ulica, Kod=kod  });
             connection.Execute("nazwa procedury @parametry imie...", pacjenci); //dodaje te parametry do bazy danych, parametry z klasy pacjent
// procedura z bazy danych dodajaca pacjentow
            }
        }
        // tu utworzymy metode zapisz pacjenta 
        /*public void ZapiszPacjenta(string rozpoznanie, string zabieg, string leki, string zazywaneleki, string zalecenia, string kodchoroby)
         *  using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("NazwaBazy")))
            {
                
             List<Pacjent> pacjenci = new List<Pacjent>();
             pacjenci.Add(new Pacjent{  });
             connection.Execute("nazwa procedury @parametry imie...", pacjenci); //dodaje te parametry do bazy danych, parametry z klasy pacjent
// procedura z bazy danych dodajaca pacjentow
            }
         * 
         */
    }
}
