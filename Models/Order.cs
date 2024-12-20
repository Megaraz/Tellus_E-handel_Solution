﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models;
/// <summary>
/// Klass som representerar 1 post i tabellen Order
/// </summary>
public class Order
{
    public Order(bool ärSkickad, bool ärLevererad, bool ärBetald, DateTime tidVidBeställning, DateTime beräknadLeverans, int kundID, string? betalsystem = null, int id = -1, int ordernr = -1)
    {
        ID = id;
        Ordernr = ordernr;
        ÄrSkickad = ärSkickad;
        ÄrLevererad = ärLevererad;
        ÄrBetald = ärBetald;
        Betalsystem = betalsystem;
        TidVidBeställning = tidVidBeställning;
        BeräknadLeverans = beräknadLeverans;
        KundID = kundID;
    }
    /// <summary>
    /// Tom Constructor för att kunna användas i Generiska Repositoryn
    /// </summary>
    public Order()
    {

    }

    public int ID { get; set; } = -1;
    public int Ordernr { get; set; } = -1;
    public bool ÄrSkickad { get; set; }
    public bool ÄrLevererad { get; set; }
    public bool ÄrBetald { get; set; }
    public string? Betalsystem { get; set; }
    public DateTime TidVidBeställning { get; set; }
    public DateTime BeräknadLeverans { get; set; }
    public int KundID { get; set; }

    public override string ToString()
    {
        return $"ID: {ID}, Ordernr: {Ordernr}, ÄrSkickad: {ÄrSkickad}, ÄrLevererad: {ÄrLevererad}, ÄrBetald: {ÄrBetald}, Betalsystem: {Betalsystem}, TidVidBeställning: {TidVidBeställning}, BeräknadLeverans: {BeräknadLeverans}";
    }
}
