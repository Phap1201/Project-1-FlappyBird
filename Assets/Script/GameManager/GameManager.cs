using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int _Score;
    private void Awake()
    {
       if(instance == null)
            instance = this;
    }
    private void Start()
    {
        _Score = 0;
    }
    public void AddScore(int score)
    {
        this._Score +=score;
        Debug.Log ("Score:"+ _Score);
    }    

}
