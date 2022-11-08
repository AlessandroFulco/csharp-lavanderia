
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



public abstract class Macchina
{
    public string Marchio { get; set; }
    public bool Stato { get; set; }
    public string StampaStato { get; set; }
    public int RaccoglitoreGettoni { get; set; }
    public int TempoRestante { get; set; }
    public double Incasso { get; set; }
    public Programma ProgrammaCorrente { get; set; }

    

    public int SceltaProgramma(int min, int max)
    {
        Random random = new Random();
        int scelta = random.Next(min, max);

        return scelta;
    }

    public string StatoMacchina(Macchina macchina)
    {
        if (Stato == false)
            StampaStato = "Ferma";
        else
            StampaStato = "In esecuzione";
        TempoRestante = CalcoloTempoRestante();
        string stato = macchina.ToString();

        return stato;
    }
    public string StatoMacchinaInFunzione()
    {

        if (Stato == false)
            StampaStato = "Ferma";
        else
            StampaStato = "In esecuzione";

        string stampa = "Stato macchina: " + StampaStato;

        return stampa;
    }
    

    public int CalcoloTempoRestante()
    {
        Random random = new Random();
        TempoRestante = ProgrammaCorrente.Durata - random.Next(0, ProgrammaCorrente.Durata);

        return TempoRestante;
    }


    public double IncassoMacchina()
    {
        return Incasso = RaccoglitoreGettoni * 0.50;
    }


    public override string ToString()
    {
        if (Stato == false)
            StampaStato = "Ferma";
        else
            StampaStato = "In esecuzione";

        return  "Marchio: " + Marchio +
                ", stato: " + StampaStato +
                ", Gettoni incassati: " + RaccoglitoreGettoni + 
                ", " + ProgrammaCorrente +
                ", tempo restante: " + TempoRestante + " minuti";
    }
}


