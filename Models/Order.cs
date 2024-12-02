﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models;
public class Order
{
    public Order(int ordernr, bool ärSkickad, bool ärLevererad, bool ärBetald, DateTime tidVidBeställning, DateTime beräknadLeverans, int kund2KontaktID, string? betalsystem = null, int id = -1)
    {
        ID = id;
        Ordernr = ordernr;
        ÄrSkickad = ärSkickad;
        ÄrLevererad = ärLevererad;
        ÄrBetald = ärBetald;
        Betalsystem = betalsystem;
        TidVidBeställning = tidVidBeställning;
        BeräknadLeverans = beräknadLeverans;
        Kund2KontaktID = kund2KontaktID;
    }

    public Order()
    {

    }

    public int ID { get; set; } = -1;
    public int Ordernr { get; set; }
    public bool ÄrSkickad { get; set; }
    public bool ÄrLevererad { get; set; }
    public bool ÄrBetald { get; set; }
    public string? Betalsystem { get; set; }
    public DateTime TidVidBeställning { get; set; }
    public DateTime BeräknadLeverans { get; set; }
    public int Kund2KontaktID { get; set; }

    public override string ToString() =>
        $"ID: {ID}, Ordernr: {Ordernr}, ÄrSkickad: {ÄrSkickad}, ÄrLevererad: {ÄrLevererad}, ÄrBetald: {ÄrBetald}, TidVidBeställning: {TidVidBeställning}, BeräknadLeverans: {BeräknadLeverans}";
}
