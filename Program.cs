﻿/*
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

Console.WriteLine("Benvenuto nella lavanderia");


Lavanderia lavanderia1 = new Lavanderia();



////STATO MACCHINE, RICHIESTA 1
//List<Macchina> lista = lavanderia1.StatoMacchine();

//foreach (Macchina macchina in lista)
//{
//    Console.WriteLine(macchina.ToString());
//}


////STATO SINGOLA MACCHINA, RICHIESTA 2
//Console.WriteLine(lavanderia1.StatoMacchina(1));


public class Lavanderia
{
    public List<Macchina> Lista { get; set; }

    public Lavanderia()
    {
        Lista = new List<Macchina>();
        Lista.Add(new Lavatrice("Samsung"));
        Lista.Add(new Lavatrice("Indesit"));
        Lista.Add(new Lavatrice("Bosh"));
        Lista.Add(new Lavatrice("Beko"));
        Lista.Add(new Lavatrice("Lg"));
        Lista.Add(new Asciugatrice("Lg"));
        Lista.Add(new Asciugatrice("Solarex"));
        Lista.Add(new Asciugatrice("Bosch"));
        Lista.Add(new Asciugatrice("Siemens"));
        Lista.Add(new Asciugatrice("Electrolux"));
    }
    
    public List<Macchina> StatoMacchine()
    {
        List<Macchina> lista = new List<Macchina>();
        
        foreach(Macchina macchina in Lista)
        {
            lista.Add(macchina);
        }

        return lista;
    }

    public string StatoMacchina(int index)
    {
        List<Macchina> ListaMacchine = Lista;
        Macchina macchina = ListaMacchine[index - 1];
        string statoMacchina = macchina.StatoMacchina(macchina);
        return statoMacchina;
    }
    
}

