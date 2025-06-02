
public class Ingresso
{
    internal static int Value;

    public double PrimeiroDia { get; set; }
    public double SegundoDia { get; set; }
    public double TerceiroDia { get; set; }

    public double Total => PrimeiroDia + SegundoDia + TerceiroDia;
}




