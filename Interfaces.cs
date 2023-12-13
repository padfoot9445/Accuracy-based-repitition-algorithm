namespace RepAlgorithm;
public interface ICorrectTotalRatio{
    public int Corrects{get;}//total corrects of the entire tree descending from that position
    public int Total{get;}//total amount of tries in the entire tree descending
}

public interface IInputValueGroup<T>{
    public T Value{get;}
    public ICorrectTotalRatio Ratio{get;}
}