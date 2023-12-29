using AdventUtils;
using static AdventSolutions.Day2;

namespace AdventTests
{
    public class Day2Tests
    {
        [Test]
        public void TestInputPart1()
        {
            const string testInput = $"""
                                      Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green
                                      Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue
                                      Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red
                                      Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red
                                      Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green
                                      """;
            var result = SolvePart1(testInput);
            Assert.AreEqual(8, result);
        }

        [Test]
        public async Task RealInputPart1()
        {
            var input = await Input.GetInputAsync(2);
            var result = SolvePart1(input);
            Assert.AreEqual(1734, result);
        }

//         [Test]
//         public void TestInputPart2()
//         {
//             const string testInput = $"""
//                                       two1nine
//                                       eightwothree
//                                       abcone2threexyz
//                                       xtwone3four
//                                       4nineeightseven2
//                                       zoneight234
//                                       7pqrstsixteen;
//                                       """;
//
//             var result = SolvePart2(testInput);
//             Assert.AreEqual(281, result);
//         }
//
//         [Test]
//         public async Task RealInputPart2()
//         {
//             var input = await Input.GetInputAsync(1);
//             var result = SolvePart2(input);
//             Assert.AreEqual(55686, result);
//         }
    }
}