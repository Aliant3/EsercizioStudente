using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Esercitazione2.classes
{
    internal class Studente
    {
        public string? Nome { get; set; }
        public string? Cognome { get; set; }
        public double Voto { get; set; } = 0;

        public Studente() { }

        public Studente(string? nome, string? cognome, double voto)
        {
            Nome = nome;
            Cognome = cognome;
            Voto = voto;
        }

        public void VisualizzaDatiStudente()
        {
            Console.WriteLine("-------------------- *** -------------------");
            Console.WriteLine($" Lo studente: {Nome}  {Cognome}");
            Console.WriteLine($" Il cui voto è: {Voto}");
            Console.WriteLine("-------------------- *** -------------------");
        }

        public void InserisciStudente(List<Studente> Elenco,Studente objStu)
        {
            Elenco.Add(objStu);
            Console.WriteLine("Studente aggiunto con successo");
        }

        public void StampaStudenti(List<Studente> Elenco)
        {
            foreach (Studente stu in Elenco)
            {
                if (stu.GetType() == typeof(Studente))
                    stu.VisualizzaDatiStudente();
            }
        }

        public void ModificaDatiStudente(List<Studente> Elenco,Studente StudenteDaModificare, Studente StudenteModificato)
        {
            foreach (Studente stu in Elenco)
            { if (stu.Cognome.Equals(StudenteDaModificare.Cognome) && stu.Nome.Equals(StudenteDaModificare.Nome) && stu.Voto.Equals(StudenteDaModificare.Voto))
                    stu.Voto = StudenteDaModificare.Voto;
                stu.Cognome = StudenteModificato.Cognome;
                stu.Nome = StudenteModificato.Nome;
                        }
        }

        public void VisualizzaStudenteFiltrato(List<Studente> Elenco,double VotoMin, double VotoMax)
        {
            foreach (Studente stu in Elenco)
                if (stu.GetType() == typeof(Studente))
                {
                    if (stu.Voto >= VotoMin && stu.Voto <= VotoMax)
                    {

                        stu.VisualizzaDatiStudente();
                    }

                }
        }

        public void EliminaStudente(List<Studente> Elenco,Studente StudenteDaEliminare)
        {
            Studente elementoDaEliminare = null;

            foreach (Studente stu in Elenco)
            {
                if (stu.Nome.Equals(StudenteDaEliminare.Nome) && stu.Cognome.Equals(StudenteDaEliminare.Cognome) && stu.Voto == StudenteDaEliminare.Voto)
                {
                     elementoDaEliminare = stu;
                }
            }
            Elenco.Remove(elementoDaEliminare);
        }

    }
}
