using UnityEngine;
using TMPro;

public static class ProbExtension
{
    public static void ValidateProb(this TMP_InputField input)
    {
        if (float.TryParse(input.text, out var number))
        {
            var valid = Mathf.Clamp01(number);
            if (valid != number)
                input.text = valid.ToString();
        }
    }
    public static void ValidateMajor(this TMP_InputField input)
    {
        if (float.TryParse(input.text, out var number))
        {
            var valid = Mathf.Max(0, number);
            if (valid != number)
                input.text = valid.ToString();
        }
    }
}