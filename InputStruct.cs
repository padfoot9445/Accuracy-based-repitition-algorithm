namespace RepAlgorithm;
public struct CorrectTotalRatio : ICorrectTotalRatio
{
    public int Corrects {get; private set;}
    public int Total {get; private set;}
    public CorrectTotalRatio(int Corrects, int Total){this.Corrects = Corrects; this.Total = Total;}
}