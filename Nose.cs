﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Nose : MonoBehaviour
{
    GameObject _itemTemplate;
    GameObject _holder;
    Button _btn;
    [SerializeField] Transform _scroolView;
    public List<Sprite> _noses;


    private void Start()
    {
        PartCreator();
    }


    public void PartCreator()
    {
        _itemTemplate = _scroolView.GetChild(0).gameObject;

        for (int i = 0; i < _noses.Count; i++)
        {
            _holder = Instantiate(_itemTemplate, _scroolView);
            _holder.transform.GetChild(0).GetComponent<Image>().sprite = _noses[i];
            _btn = _holder.transform.GetChild(1).GetComponent<Button>();
            _btn.AddEventListener(i, SelectedCloth);
        }
        Destroy(_itemTemplate);
    }

    public void SelectedCloth(int _itemIndex)
    {
        Profile.Instance._avatarNose.GetComponent<Image>().sprite = _noses[_itemIndex];
        FindObjectOfType<AudioManager>().Play("Click");
    }
}
