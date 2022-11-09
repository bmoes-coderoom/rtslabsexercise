using System;

namespace RTS;

public class RtsExercise
{
    public static Dictionary<string, int> aboveBelow(int[]? list, int compareValue)
    {
        var aboveBelowDict = new Dictionary<string, int>
        {
            { "above", 0 },
            { "below", 0 }
        };
        foreach (var num in list ?? Array.Empty<int>())
        {
            if (num > compareValue)
            {
                aboveBelowDict["above"] += 1;
            }
            else if (num < compareValue)
            {
                aboveBelowDict["below"] += 1;
            }
        }

        return aboveBelowDict;
    }

    public static string stringRotation(string input, int rotationAmt)
    {
        if (string.IsNullOrEmpty(input)
            || string.IsNullOrWhiteSpace(input)
            || rotationAmt < 1) return input;
        int clockWiseRotation = input.Length - rotationAmt;
        // get end of string and put it in the front
        // then read remainder of string from beginning and put in the back
        return string.Concat(input.AsSpan(clockWiseRotation, input.Length - clockWiseRotation), input.AsSpan(0, clockWiseRotation));
    }
}