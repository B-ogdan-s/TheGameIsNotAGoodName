using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

[CreateAssetMenu(fileName = "InventoryPanelInfo", menuName = "InventoryPanelInfo")]
public class InventoryPanelInfo : ScriptableObject
{
    [SerializeField, ReadOnly] private List<InventoryInfo> _inventorysInfo;
    [SerializeField] private GameObject _prefabPanel;
    [SerializeField] private int _numPanel;

    private int _minNumPanel = 12;

    public GameObject PrefabPanel
    {
        get { return _prefabPanel; }
    }
    public int NumPanel
    {
        get { return _numPanel; }
        set
        {
            if(value > 0)
            {
                _numPanel = value;
            }
            else
            {
                _numPanel = _minNumPanel;
                Debug.Log("�� ��������� ����");
            }
        }
    }
}