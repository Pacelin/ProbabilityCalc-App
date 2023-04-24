using TMPro;
using UnityEngine;

public class ProbabilityCalculationContainer : MonoBehaviour
{
    [SerializeField] private string _title;
    [SerializeField] private string _inputPrefix1;
    [SerializeField] private string _inputPrefix2;
    [Space]
    [SerializeField] private TMP_InputField _firstInput;
    [SerializeField] private TMP_InputField _secondInput;
    [SerializeField] private TMP_Text _output;
    [Space]
    [SerializeField] private ProbabilityCalculation _calculation;

    private void Awake()
    {
        _output.text = "";
    }

    public void ValidateFirstInputProb() => _firstInput.ValidateProb();
    public void ValidateSecondInputProb() => _secondInput.ValidateProb();
    public void ValidateFirstInputMajor() => _firstInput.ValidateMajor();
    public void ValidateSecondInputMajor() => _secondInput.ValidateMajor();

    public void Calculate()
    {
        if (float.TryParse(_firstInput.text.Replace(".", ","), out var p1) &&
            float.TryParse(_secondInput.text.Replace(".", ","), out var p2))
        {
            var result = _calculation.Calculate(p1, p2);
            
            _output.text = _calculation.Prefix + result;

            History.Save(new HistoryRow(
                _title, _inputPrefix1, _inputPrefix2, _calculation.Prefix,
                p1, p2, result
            ));
        }
    }
}