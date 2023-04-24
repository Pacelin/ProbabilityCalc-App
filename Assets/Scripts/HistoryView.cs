using UnityEngine;

public class HistoryView : MonoBehaviour
{
    [SerializeField] private HistoryRowView _prefab;
    [SerializeField] private RectTransform _container;

    private void Awake()
    {
        var rows = History.Rows;

        foreach (var row in rows)
        {
            var obj = Instantiate(_prefab, Vector3.zero, Quaternion.identity, _container);
            obj.Init(row);
        }
    }
}
