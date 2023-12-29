using AdventUtils;
using static AdventSolutions.Day1;

namespace AdventTests
{
    public class Day1Tests
    {
        [Test]
        public void TestInputPart1()
        {
            const string testInput = $"""
                                      1abc2
                                      pqr3stu8vwx
                                      a1b2c3d4e5f
                                      treb7uchet
                                      """;
            var result = SolvePart1(testInput);
            Assert.AreEqual(142, result);
        }

        [Test]
        public async Task RealInputPart1()
        {
            var input = await Input.GetInputAsync(1);
            var result = SolvePart1(input);
            Assert.AreEqual(55029, result);
        }

        [Test]
        public void TestInputPart2()
        {
            const string testInput = $"""
                                      two1nine
                                      eightwothree
                                      abcone2threexyz
                                      xtwone3four
                                      4nineeightseven2
                                      zoneight234
                                      7pqrstsixteen;
                                      """;

            var result = SolvePart2(testInput);
            Assert.AreEqual(281, result);
        }

        [Test]
        public async Task RealInputPart2()
        {
            var input = await Input.GetInputAsync(1);
            var result = SolvePart2(input);
            Assert.AreEqual(55686, result);
        }
    }
}