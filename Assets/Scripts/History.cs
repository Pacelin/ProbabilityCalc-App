using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class History
{
    public static HistoryRow[] Rows => _rows.Reverse<HistoryRow>().ToArray();
    private static List<HistoryRow> _rows = new List<HistoryRow>();

    static History()
    {
        Load();
    }

    public static void Load()
    {
        _rows.Clear();
        for (int i = 0; ; i++)
        {
            if (!PlayerPrefs.HasKey("history_row_" + i)) break;

            var values = PlayerPrefs.GetString("history_row_" + i).Split("\n");
            _rows.Add(new HistoryRow(values[0], values[1], values[2], values[3]));
        }
    }

    public static void Save(HistoryRow row)
    {
        PlayerPrefs.SetString("history_row_" + _rows.Count,
            row.TitleRow + "\n" + row.InputRow1 + "\n" + row.InputRow2 + "\n" + row.OutputRow);
        
        _rows.Add(row);
    }
}

public record HistoryRow
{
    public readonly string TitleRow;
    public readonly string InputRow1;
    public readonly string InputRow2;
    public readonly string OutputRow;

    public HistoryRow(string title, string inputPrefix1, string inputPrefix2, string outputPrefix,
        float input1, float input2, float output)
    {
        TitleRow = title;
        InputRow1 = inputPrefix1 + input1;
        InputRow2 = inputPrefix2 + input2;
        OutputRow = outputPrefix + output;
    }

    public HistoryRow(string titleRow, string inputRow1, string inputRow2, string outputRow)
    {
        TitleRow = titleRow;
        InputRow1 = inputRow1;
        InputRow2 = inputRow2;
        OutputRow = outputRow;
    }
}
