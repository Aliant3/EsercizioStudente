using Esercitazione2.classes;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization.Metadata;

namespace Esercitazione2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Studente stu = new Studente();
            List<Studente> elencoStu = new List<Studente>();
            bool insAbi = true;
           
            while (insAbi)
            {
                Console.WriteLine("Premi A per visualizzare la lista Studenti, premi B per inserire uno studente, premi C per stampare la lista, premi D per modificare i dati di uno studente, premi E per visualizzare uno studente, premi F per eliminare uno studente e premi Q per chiudere l'applicazione");
                string input=Console.ReadLine();
                switch (input.ToUpper())
                {
                    case "A":
                      stu.StampaStudenti(elencoStu);
                        break;
                    case "B":
                        Console.WriteLine("Inserisci il nome");
                        string nome=Console.ReadLine();
                        Console.WriteLine("Inserisci il cognome");
                        string cognome=Console.ReadLine();
                        Console.WriteLine("Inserisci il voto");
                        double voto = Convert.ToDouble(Console.ReadLine());
                        stu.InserisciStudente( elencoStu, new Studente(nome,cognome,voto));
                        break;
                    case "C":
                        Console.WriteLine(stu.StampaStudenti);
                        break;
                    case "D":
                        Console.WriteLine("Inserisci il nome dello studente che vuoi modificare");
                        nome = Console.ReadLine();
                        Console.WriteLine("Inserisci il cognome");
                        cognome = Console.ReadLine();
                        Console.WriteLine("Inserisci il voto");
                        voto = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Premi A per modificare il Nome, premi B per modificare il cognome e premi C per modificare il voto");
                        string input2=Console.ReadLine();
                        switch (input2.ToUpper())
                        {
                            case"A":
                              string nomeMod = Console.ReadLine();
                                break;
                            case "B":
                                string CognomeMod = Console.ReadLine();
                                break;
                            case "C":
                                double VotoMod = Convert.ToDouble(Console.ReadLine());
                                break;
                            case "D":
                                Console.Write("Parametro non valido");
                                break;
                        }
                        Console.WriteLine("Lo studente modificato è: " + stu.StampaStudenti);
                        break;
                    case "E":
                        Console.WriteLine("Inserisci il voto minimo");
                        double votoMin = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Inserisci il voto massimo");
                        double votoMax = Convert.ToDouble(Console.ReadLine());
                        stu.VisualizzaStudenteFiltrato(elencoStu, votoMin, votoMax);
                        break;
                    case "F":
                        Console.WriteLine("Inserisci il nome");
                        string nome1 = Console.ReadLine();
                        Console.WriteLine("Inserisci il cognome");
                        string cognome1 = Console.ReadLine();
                        Console.WriteLine("Inserisci il voto");
                        double voto1 = Convert.ToDouble(Console.ReadLine());
                        stu.EliminaStudente(elencoStu, new Studente(nome1, cognome1, voto1));
                        break;
                    case "Q":
                        insAbi = false;
                        break;
                    default:
                        Console.WriteLine("Inserimento non valido");
                        break;
                }


                }






            }


            }


        
    }
