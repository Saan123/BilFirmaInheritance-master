namespace RecapNedarvning
{
    public interface IBil
    {
        string BilMærke { get; set; }
        int BilPrisExAfgift { get; }
        int KøbsÅr { get; }
        string RegisteringsnrNr { get; set; }

        int HalvÅrligEjerAfgift();
        int Registreringsafgift();
        int RækkeVidde();
        int TotalPris();
    }
}