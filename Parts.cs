using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Parts : MonoBehaviour
{
    public GameObject[] _scrollViews;


    private void Start()
    {
        DisableAll();
    }

    public void DisableAll()
    {
        for (int i = 0; i < _scrollViews.Length; i++)
        {
            _scrollViews[i].SetActive(false);
        }
    }

    public void PartSelect(int _partIndex)
    {
        DisableAll();
        _scrollViews[_partIndex].SetActive(true);
    }
}
