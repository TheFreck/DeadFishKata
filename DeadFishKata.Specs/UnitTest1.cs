using Machine.Specifications;

namespace DeadFishKata.Specs
{
    public class When_Executing_Dead_Fish_Code
    {
        Establish context = () =>
        {
            inputs = new List<string>
            {
                "iiiiio",
                "dddddo",
                "iissso",
                "iiisdoioso",
            };
            expectations = new List<int[]>
            {
                new int[] {5},
                new int[] {-5},
                new int[] {256},
                new int[] {8,9,81}
            };
            outcomes = new List<int[]>();
        };

        Because of = () =>
        {
            for(var i=0; i<inputs.Count; i++)
            {
                outcomes.Add(DeadFish.Parse(inputs[i]));
            }
        };

        It Should_Return_Executed_Array = () =>
        {
            for (var i = 0; i < expectations.Count; i++)
            {
                for(var j=0; j < expectations[i].Length; j++)
                {
                    outcomes[i][j].ShouldEqual(expectations[i][j]);
                }
            }
        };

        private static List<string> inputs;
        private static List<int[]> expectations;
        private static List<int[]> outcomes;
    }
}