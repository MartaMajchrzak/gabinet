using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper; // Dapper pozwala na pobieranie danych z bazy danych i zapełnianie danych w modelu obiektowym.
//Następująca metoda pobiera wszystkie rekordy z tabeli pacjent, przechowuje je w pamięci i zwraca kolekcję.
using System.Data;
using System.Data.SqlClient;

namespace guitest
{
    public class DataAccess // zawiera  wyszukiwanie i rejestrowanie pacjentow 
    { //tworzymy metode
        public List <Pacjent> GetPeople (string Nazwisko)
        {  
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("tablicaPacjent")))//pobierz cnn string z
                //helpera dla bazy danych o nazwie: tablica pacjent
            {
                //rozmawiamy z sql

                var output = connection.Query<Pacjent>($"Select * from tablicaPacjent where nazwisko = '{Nazwisko}'").ToList();  //dbo
               return output;
            } //query chcemy dane z bazy, chcemy liste pacjenta, <pacjent>- typ danych
        }

        public void ZarejestrujPacjenta(string Imie, string Nazwisko, string adresEmail, string nrTel, string numerPesel, string Dataur, string ulica)
        {// 
           
            
            using (IDbConnection connection = new SqlConnection(Helper.CnnVal("bazaGabinetuStomatologicznego")))
            {//
                connection.Open();
                
             List<Pacjent> pacjenci = new List<Pacjent>();
             pacjenci.Add(new Pacjent{ imie = Imie, nazwisko = Nazwisko, eMail = adresEmail, telefon = nrTel,  PESEL= numerPesel, dataUrodzenia=Dataur, adresKorespondencyjny=ulica });
             connection.Execute("dbo.tablicaPacjent @imie, @nazwisko, @PESEL, @telefon, @eMail, @dataUrodzenia, @adresKorespondencyjny", pacjenci); //dodaje te parametry do bazy danych, parametry z klasy pacjent

            }
        }
        
    }
}
