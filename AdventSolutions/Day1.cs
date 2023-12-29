using System.Text;
using AdventUtils;

namespace AdventSolutions
{
    public static class Day1
    {
        public static int SolvePart1(string input)
        {
            var sum = 0;
            foreach (var line in input.ReadLines())
            {
                char? ch1 = line.First(char.IsDigit);
                char? ch2 = line.Last(char.IsDigit);
                sum += int.Parse($"{ch1}{ch2}");
            }
            return sum;
        }
        private static int FindFirstDigit(string line, IReadOnlyList<string> digits)
        {
            var buffer = new StringBuilder();
            foreach (var ch in line)
            {
                if (char.IsDigit(ch))
                    return int.Parse(ch.ToString());

                buffer.Append(ch);

                for (var j = 0; j < digits.Count; j++)
                {
                    if (buffer.ToString().EndsWith(digits[j]))
                        return j + 1;
                }

                if (buffer.Length > 5)
                    buffer = buffer.Remove(0, 1);
            }
            return -1;
        }

        public static int SolvePart2(string input)
        {
            var digits = new List<string> { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            var digitsBackward = digits.Select(digit => digit.Reverse()).ToList();
            var sum = 0;

            foreach (var line in input.ReadLines())
            {

                var digit1 = FindFirstDigit(line, digits);
                var digit2 = FindFirstDigit(line.Reverse(), digitsBackward);
                sum += int.Parse($"{digit1}{digit2}");
            }
            return sum;
        }
    }
}
