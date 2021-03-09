using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using UnityEngine;

public class PlayerModel : IObservable
{
    private static PlayerModel _instance;
    
    private int _score;
    private int _lifes;
    private List<IObserver> _observers;

    private PlayerModel()
    {
        _observers = new List<IObserver>();
        _score = 0;
        _lifes = 3;
    }

    public static PlayerModel GetInstance()
    {
        if (_instance == null)
        {
            _instance = new PlayerModel();
        }
        return _instance;
    }

    public int GetScore()
    {
        return _score;
    }

    public void SetScore(int score)
    {
        _score = score;
        notifyObservers();
    }
    
    public int GetLifes()
    {
        return _lifes;
    }

    public void SetLifes(int lives)
    {
        if (lives >= 0)
        {
            _lifes = lives;
        }
    }

    public void registerObserver(IObserver o)
    {
        _observers.Add(o);
        Debug.Log("Observer registered");
    }

    public void unregisterObserver(IObserver o)
    {
        _observers.Remove(o);
    }

    public void notifyObservers()
    {
        Debug.Log("Update !");
        foreach (IObserver o in _observers)
        {
            o.update();
        }
    }
}
