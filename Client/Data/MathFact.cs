using System.Text;

namespace MathFacts.Client.Data;

public class MathFact
{
    public int FirstNum { get; set; }
    public int SecondNum { get; set; }
    public string? Operator { get; set; }

    public MathFact()
    {
        this.FirstNum = int.MinValue;
        this.SecondNum = int.MinValue;
        this.Operator = string.Empty;
    }
}