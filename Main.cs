namespace RepAlgorithm;

public  class RepetitionAlgorithm{
    protected static readonly Random rnd = new();
    private RatioModifier modifierCallBack;
    public int GetIndex(ICorrectTotalRatio[] input){
       int len = input.Length;
       float[] inputRatioArray = new float[len];
       float total = 0;
       for(int i = 0; i < len; i++){
        float newValue = modifierCallBack(input[i].Total / input[i].Corrects);
        total += newValue;
        inputRatioArray[i] = newValue;
       }
       return rnd.Next(Convert.ToInt32(total));
    }
    public T GetValue<T>(IInputValueGroup<T>[] input) => input[GetIndex((ICorrectTotalRatio[])(from e in input select e.Ratio).ToArray())].Value;

    internal void GetIndex(CorrectTotalRatio[] f)
    {
        throw new NotImplementedException();
    }

    public RepetitionAlgorithm(RatioModifier rmodifier){modifierCallBack = rmodifier;}
}
public delegate float RatioModifier(float input);