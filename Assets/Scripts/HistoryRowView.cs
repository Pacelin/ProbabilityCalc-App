using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HistoryRowView : MonoBehaviour
{
    [SerializeField] private TMP_Text _titleText;
    [SerializeField] private TMP_Text _inputText1;
    [SerializeField] private TMP_Text _inputText2;
    [SerializeField] private TMP_Text _outputText;

    public void Init(HistoryRow row)
    {
        _titleText.text = row.TitleRow;
        _inputText1.text = row.InputRow1;
        _inputText2.text = row.InputRow2;
        _outputText.text = row.OutputRow;
    }
}
