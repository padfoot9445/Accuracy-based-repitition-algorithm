namespace Program;
using RepAlgorithm;
public static class Program{
    public static void Main(string[] args){
        RepetitionAlgorithm e = new(x => x*x);
        var f = new CorrectTotalRatio[]{new(1, 5), new(4, 5), new(5, 5)};
        e.GetIndex(f);
    }
}