namespace RepAlgorithm;
using System.Linq;
public class RepetitionAlgorithm{
    protected static Random Rnd {get; private set;} = new();
    private readonly RatioModifier modifierCallBack;
    public int GetIndex(CorrectTotalRatio[] input){
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
    public T GetItemValue<T>(InputValueGroup<T>[] input) => GetItem(input, GetIndex(IVG_To_CTR(input)));
    private static T GetItem<T>(InputValueGroup<T>[] input, int index) => input[index].Value;

    public static int GetLeastAccurateIndex(CorrectTotalRatio[] input) => Array.IndexOf(input, input.Min(value => value.Corrects / value.Total));

    public static T GetLeastAccurateItemValue<T>(InputValueGroup<T>[] input) => GetItem(input, GetLeastAccurateIndex(IVG_To_CTR(input)));

    private static CorrectTotalRatio[] IVG_To_CTR<T>(InputValueGroup<T>[] input) => (from e in input select e.Ratio).ToArray();

    public RepetitionAlgorithm(RatioModifier rmodifier){modifierCallBack = rmodifier;}
}
public delegate float RatioModifier(float input);