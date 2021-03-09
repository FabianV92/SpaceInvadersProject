using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour, IObserver
{
    [SerializeField]
    private Text _anzeige;

    // Start is called before the first frame update
    void Start()
    {
        PlayerModel.GetInstance().registerObserver(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void update()
    {
        _anzeige.text = PlayerModel.GetInstance().GetScore().ToString();
    }
}
