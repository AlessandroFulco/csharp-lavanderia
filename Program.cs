/*
 * Una lavanderia è aperta 24 ore su 24 e permette ai clienti di servirsi autonomamente di 5 Lavatrici e 5 Asciugatrici.
    I clienti che usufruiscono delle macchine, possono effettuare diversi programmi di lavaggio e asciugatura 
    ognuno con un costo diverso (in gettoni) e di una specifica durata. Ogni gettone costa 0.50 centesimi di euro e ogni lavaggio 
    consuma detersivo e ammorbidente dai serbatoi della lavatrice. Ogni lavatrice può tenere fino ad un massimo di 1 litro di detersivo e 500ml di ammorbidente.
    I programmi di lavaggio hanno quindi queste caratteristiche
    Rinfrescante, costo di 2 gettoni, durata di 20 minuti, consumo di 20ml di detersivo e 5ml di ammorbidente.
    Rinnovante, costo di 3 gettoni, durata di 40 minuti, consumo di 40ml di detersivo e 10ml di ammorbidente.
    Sgrassante, costo di 4 gettoni, durata di 60 minuti, consumo di 60 ml di detersivo e 15ml di ammorbidente.
    Le asciugatrici invece hanno soltanto due programmi di asciugatura, rapido 2 gettoni e intenso 4 gettoni della durata di 30 minuti e 60 minuti rispettivamente.
    Si richiede di creare un sistema di controllo in grado di riportare lo stato della lavanderia, in particolare si vuole richiedere:
    1 - Lo stato generale di utilizzo delle macchine: un elenco di tutte le macchine 
        che semplicemente dica quali sono in funzione e quali non lo sono (in lavaggio / asciugatura oppure ferme)
    2 - Possa essere richiesto il dettaglio di una macchina: Tutte le informazioni relative alla macchina, nome del macchinario
        stato del macchinario (in funzione o no), tipo di lavaggio in corso, quantità di detersivo presente (se una lavatrice),
        durata del lavaggio, tempo rimanente alla fine del lavaggio.
    3 - l’attuale incasso generato dall’utilizzo delle macchine.
*/

//Lavanderia
//Lavatrici
//Asciugatrici
//Macchine          Stato
//Programmi         Gettoni | Durata 
// Rinfrescante     ConsumoDetersivo | ConsumoAmmorbidente
// Rinnovante       ConsumoDetersivo | ConsumoAmmorbidente
// Sgrassante       ConsumoDetersivo | ConsumoAmmorbidente
// Rapido           
// Intenso

using System.Diagnostics;

Lavanderia lavanderia1 = new Lavanderia();
Console.WriteLine("Benvenuto nella lavanderia");

bool on = true;

while (on)
{
    Console.WriteLine("Menu:");
    Console.WriteLine("1. Stato Macchine");
    Console.WriteLine("2. Stato di una macchina");
    Console.WriteLine("3. Totale incasso macchine");
    Console.WriteLine("4. Esci dall'applicazione");
    Console.WriteLine();

    int scelta = Convert.ToInt32(Console.ReadLine());

    switch (scelta)
    {
        //Stato Macchine
        case 1:
            List<Macchina> lista = lavanderia1.Lista;

            foreach (Macchina macchina in lista)
            {
                if (macchina.GetType().ToString() == "Lavatrice")
                    Console.WriteLine( "Lavatrice: \t" + macchina.StatoMacchinaInFunzione());
                else
                    Console.WriteLine( "Asciugatrice: \t" + macchina.StatoMacchinaInFunzione());

            }
            Console.WriteLine();
            break;

        case 2:
            //Stato singola machina
            Console.WriteLine("Controllo Stato Macchina");
            Console.Write("Inserisci il numero della macchina [1 - 5] per le lavatrici, [6 - 10] per le asciugatrici: ");
            int inputUtente = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(lavanderia1.StatoMacchina(inputUtente));
            Console.WriteLine();
            break;

        case 3:
            //Stampa totale incasso lavanderia
            Console.WriteLine("Sezione Incasso Lavanderia");
            Console.WriteLine("Totale incassi: " + lavanderia1.TotaleIncasso() + " euro");
            break;

        case 4:
            //esci dall'applicazione
            on = false;
            break;

        case 5:
            Console.WriteLine("Sezione Stampa Tutte le macchine");
            List<Macchina> stampaLista = lavanderia1.StampaMacchine();
            foreach (Macchina macchina in stampaLista)
            {
                Console.WriteLine(macchina.ToString());
            }
            break;

        default:
            Console.WriteLine("Opzione non esistente");
            break;


    }




}







////STATO MACCHINE, RICHIESTA 1




////STATO SINGOLA MACCHINA, RICHIESTA 2
//Console.WriteLine(lavanderia1.StatoMacchina(1));

////TOTALE INCASSO, RICHIESTA 3
//Console.WriteLine(lavanderia1.TotaleIncasso() + " euro");


