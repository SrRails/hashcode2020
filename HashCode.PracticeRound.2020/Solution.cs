//copyright Dani, Alvaro & Corrado
namespace HashCode.PracticeRound._2020
{
    public class Solution
    {
        public static Output Process1(Input input)
        {
            var result = new Output
            {
                OrderingPizzas = new int[input.NumberOfDifferentTypeOfPizza],
                TypeOfPizzas = 0
            };

            var slices = 0;
            for (var index = input.NumberOfDifferentTypeOfPizza-1; index > 0 ;index--)
            {
                var candidateSlices = slices + input.NumberOfSlices[index];
                if (candidateSlices > input.MaxSlicesToOrder)
                {
                    break;
                }
                else
                {
                    result.OrderingPizzas[result.TypeOfPizzas] = index;
                    slices = candidateSlices;
                    result.TypeOfPizzas++;
                }
            }

            return result;
        }

        public static Output Process2(Input input)
        {
            var result = new Output
            {
                OrderingPizzas = new int[input.NumberOfDifferentTypeOfPizza],
                TypeOfPizzas = 0
            };

            var slices = 0;
            for (var index = input.NumberOfDifferentTypeOfPizza - 1; index >= 0; index--)
            {
                var candidateSlices = slices + input.NumberOfSlices[index];
                if (candidateSlices > input.MaxSlicesToOrder)
                {
                    continue;
                }
                result.OrderingPizzas[result.TypeOfPizzas] = index;
                slices = candidateSlices;
                result.TypeOfPizzas++;
            }

            return result;
        }
    }
}