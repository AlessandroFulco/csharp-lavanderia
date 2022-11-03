/*
 * Una lavanderia è aperta 24 ore su 24 e permette ai clienti di servizi autonomamente di 5 Lavatrici e 5 Asciugatrici.
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

// Lavanderia
    
    //metodi:
        // 1. lista che stampa quali macchine sono in funzione o no
        // 2. incasso generato dalle macchine

// Lavarici
    //caratteristiche:
        //marca = string
        //accesa = bool
        //tipoDiLavaggio = string
        //qtyDetersivo = int
        //qtyAmmorbidente = int
        //durataLavaggio = int
        //tempoRimanenteLavaggio = int

    // programmi di lavaggio:
        // 1.Rinfrescante   2gettoni, 20min, 20ml detersivo, 5ml ammorbidente
        // 2.Rinnovante     3gettoni, 40min, 40ml detersivo, 10ml ammorbidente 
        // 3.Sgrassante     4gettoni, 60min, 60ml detersivo, 15ml ammorbidente

// Asciugatrici
    //caratteristiche:
        //marca = string
        //accesa = bool
        //tipoDiAsciugatura = string
        //durataAsciugatura = int
        //tempoRimanenteAsciugatura = int

    // programmi di asciugatura:
        // 1.Rapido     2gettoni, 30min
        // 2.Intenso    3gettoni, 60min

//Inizializzazione lavanderia
Lavanderia lavanderia = new Lavanderia();


//PROGRAMMA PRINCIPALE
Console.WriteLine("Benvenuto nella Lavanderia.");

lavanderia.StampaElettrodomestici();

public class Elettrodomestico
{
    public bool Acceso { get; set; }
    public string Marca { get; set; }
    public string Programma { get; set; }
    public int DurataProgramma { get; set; }
    public int DurataRimanente { get; set; }
    public int QtyDetersivo { get; set; }
    public int QtyAmmorbidente { get; set; }

    public Elettrodomestico(bool acceso, string marca)
    {
        this.Acceso = acceso;
        this.Marca = marca;
    }
    public Elettrodomestico(bool acceso, string marca, int qtyDetersivo, int qtyAmmorbidente)
    {
        this.Acceso = false;
        this.Marca = marca;
        this.QtyDetersivo = qtyDetersivo;
        this.QtyAmmorbidente = qtyAmmorbidente;
    }
}

public class Lavanderia
{
    private Elettrodomestico[] elettrodomestici;
    public Lavanderia()
    {
        //lavatrici
        elettrodomestici = new Elettrodomestico[10];
        elettrodomestici[0] = new Elettrodomestico(false, "Samsung lavatrice", 1000, 500);
        elettrodomestici[1] = new Elettrodomestico(false, "Beko lavatrice", 1000, 500);
        elettrodomestici[2] = new Elettrodomestico(false, "Lg lavatrice", 1000, 500);
        elettrodomestici[3] = new Elettrodomestico(false, "Bosch lavatrice", 1000, 500);
        elettrodomestici[4] = new Elettrodomestico(false, "Bosch lavatrice", 1000, 500);

        //asciugatrici
        elettrodomestici[5] = new Elettrodomestico(false, "Solarex asciugatrice");
        elettrodomestici[6] = new Elettrodomestico(false, "Bosch asciugatrice");
        elettrodomestici[7] = new Elettrodomestico(false, "Aqualtis asciugatrice");
        elettrodomestici[8] = new Elettrodomestico(false, "Beko asciugatrice");
        elettrodomestici[9] = new Elettrodomestico(false, "Electrolux asciugatrice");
    }

    public void StampaElettrodomestici()
    {
        Console.WriteLine("----- elettrodomestici -------");

        for(int i = 0; i < elettrodomestici.Length; i++)
        {
            Console.WriteLine("{0} - {1}, {2}", (i + 1), elettrodomestici[i].Acceso, elettrodomestici[i].Marca);
        }
    }
    
}