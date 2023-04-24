using UnityEngine;

[CreateAssetMenu(menuName = "Probabiliy Calculation")]
public class ProbabilityCalculation : ScriptableObject
{
    [SerializeField] private int _expressionId;
    public string Prefix;

    public float Calculate(float p1, float p2)
    {
        if (_expressionId == 0)
            return p1 / p2;
        else if (_expressionId == 1)
            return p2 / p1;
        else
            return p1 * p2;
    }
}