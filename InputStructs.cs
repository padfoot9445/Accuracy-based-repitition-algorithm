namespace RepAlgorithm;
public struct CorrectTotalRatio
{
    public int Corrects {get; init;}
    public int Total {get; init;}
    public CorrectTotalRatio(int Corrects, int Total){this.Corrects = Corrects; this.Total = Total;}
}

public readonly struct InputValueGroup<T>{
    public T Value{ get; init; }
    public ICorrectTotalRatio Ratio{ get; init; }

    public InputValueGroup(T value, ICorrectTotalRatio ratio){ Value = value; Ratio = ratio; }
}