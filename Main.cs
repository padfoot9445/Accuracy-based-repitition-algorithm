namespace RepAlgorithm;

public class RepetitionAlgorithm{
    protected static Random Rnd {get; private set;} = new();
    private readonly RatioModifier modifierCallBack;
    public int GetIndex(ICorrectTotalRatio[] input){
       int len = input.Length;
       float[] inputRatioArray = new float[len];
       float total = 0;
       for(int i = 0; i < len; i++){
        float newValue = modifierCallBack(input[i].Total / input[i].Corrects);
        total += newValue;
        inputRatioArray[i] = newValue;
       }
       return Rnd.Next(Convert.ToInt32(total));
    }
    public T GetItemValue<T>(IInputValueGroup<T>[] input) => GetItem(input, GetIndex((ICorrectTotalRatio[])(from e in input select e.Ratio).ToArray()));
    public static T GetItem<T>(IInputValueGroup<T>[] input, int index) => input[index].Value;

    public RepetitionAlgorithm(RatioModifier rmodifier){modifierCallBack = rmodifier;}
}
public delegate float RatioModifier(float input);