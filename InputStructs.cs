namespace RepAlgorithm;
public struct CorrectTotalRatio
{
    public int Corrects {get; init;} //total corrects of the entire tree descending from that position
    public int Total {get; init;} //total amount of tries in the entire tree descending
    public CorrectTotalRatio(int Corrects, int Total){this.Corrects = Corrects; this.Total = Total;}
}

public readonly struct InputValueGroup<T>{
    public T Value{ get; init; }
    public CorrectTotalRatio Ratio{ get; init; }

    public InputValueGroup(T value, CorrectTotalRatio ratio){ Value = value; Ratio = ratio; }
}