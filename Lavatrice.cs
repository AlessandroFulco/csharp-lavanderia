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
//Macchine
//Programmi



public class Lavatrice : Macchina
{

    public int SerbatoioDetersivo { get; set; }
    public int SerbatoioAmmorbidente { get; set; }
    public List<ProgrammaLavatrice> Programmi { get; set; }

    public Lavatrice(string marchio)
    {
        Marchio = marchio;
        SerbatoioDetersivo = 1000;
        SerbatoioAmmorbidente = 500;
        RaccoglitoreGettoni = 0;

        Programmi = new List<ProgrammaLavatrice>();
        Programmi.Add(new ProgrammaLavatrice("Rinfrescante", 20, 2, 20, 5));
        Programmi.Add(new ProgrammaLavatrice("Rinnovante", 40, 3, 40, 10));
        Programmi.Add(new ProgrammaLavatrice("Rinfrescante", 60, 4, 60, 15));

        Random random = new Random();
        ProgrammaCorrente = Programmi[SceltaProgramma(0, Programmi.Count)];
        
    }




    public override string ToString()
    {
        return base.ToString() +
                "Detersivo rimasto: " + SerbatoioDetersivo +
                ", ammorbidente rimasto " + SerbatoioAmmorbidente;
    }
}


