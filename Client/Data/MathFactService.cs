using System;
using System.Linq;
using System.Threading.Tasks;

namespace MathFacts.Client.Data;

public class MathFactService
{
    public Task<MathFact[]> GetMultiplyFacts()
    {
        return Task.FromResult(Enumerable.Range(1, 96).Select(index => new MathFact
        {
            FirstNum = Random.Shared.Next(1, 12),
            SecondNum = Random.Shared.Next(1, 12),
            Operator = "x"
        }).ToArray());
    }

    public Task<MathFact[]> GetAdditionFacts()
    {
        return Task.FromResult(Enumerable.Range(1, 96).Select(index => new MathFact
        {
            FirstNum = Random.Shared.Next(1, 20),
            SecondNum = Random.Shared.Next(1, 20),
            Operator = "+"
        }).ToArray());
    }

    public Task<MathFact[]> GetSubtractionFacts()
    {
        return Task.FromResult(Enumerable.Range(1, 96).Select(index => new MathFact
        {
            FirstNum = Random.Shared.Next(1, 20),
            SecondNum = Random.Shared.Next(1, 20),
            Operator = "-"
        }).ToArray());
    }
}