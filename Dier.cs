using System;

public abstract class Dier
{
    public string Naam { get; set; }
    public int Gewicht { get; set; }
    public string Uitspraak { get; set; }
    public string Geluid { get; set; }

    public dier(string naam, int gewicht, string uitspraak, string geluid)
    {
        Naam = naam;
        Gewicht = gewicht;
        Uitspraak = uitspraak;
        Geluid = geluid;
    }

    public abstract string zeg();

    public override string ToString()
    {
        return Naam + " " + Gewicht + " " + Uitspraak + " " + Geluid;
    }
}

public class koe : Dier
{
    public koe(string naam, int gewicht, string uitspraak, string geluid) : base(naam, gewicht, uitspraak, geluid)
    {

    }

    public override string zeg()
    {
        return this.Uitspraak;
    }

    public override string ToString()
    {
        return Naam + " " + Gewicht + " " + Uitspraak + " " + Geluid;
    }
}

public class Slang : Dier
{
    public Slang(string naam, int gewicht, string uitspraak, string geluid) : base(naam, gewicht, uitspraak, geluid)
    {

    }

    public override string zeg()
    {
        return this.Uitspraak;
    }

    public override string ToString()
    {
        return Naam + " " + Gewicht + " " + Uitspraak + " " + Geluid;
    }
}

public class Varken : Dier
{
    public Varken(string naam, int gewicht, string uitspraak, string geluid) : base(naam, gewicht, uitspraak, geluid)
    {

    }

    public override string zeg()
    {
        return this.Uitspraak;
    }

    public override string ToString()
    {
        return Naam + " " + Gewicht + " " + Uitspraak + " " + Geluid;
    }
}
