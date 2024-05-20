using FluentAssertions;
using Xunit;

namespace Code_Wars;

public class ReplaceWithAlphabetPosition
{
    private static string AlphabetPosition(string text)
    {
        var charCollection = new Dictionary<char, int>();
        var currentChar = 65;
        for(int i = 1; i <= 26; i++) {
            charCollection.Add((char)currentChar, i);
            currentChar++;
        }

        var resultArray = new List<int>();
        var textChars = text.ToUpper().ToCharArray();
        foreach(char letter in textChars) {
            if(charCollection.TryGetValue(letter, out var value)) resultArray.Add(value);
        }

        return String.Join(" ", resultArray);
    }
    
    [Fact]
    public void SampleTest()
    {
        AlphabetPosition("The sunset sets at twelve o' clock.").Should().Be("20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11");
        AlphabetPosition("The narwhal bacons at midnight.").Should().Be("20 8 5 14 1 18 23 8 1 12 2 1 3 15 14 19 1 20 13 9 4 14 9 7 8 20");
    }
}