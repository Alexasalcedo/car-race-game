using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Make public this script so other objects can access to it without a direct reference, but only this one can set it
    public static GameManager Instance { get; private set; }
    public InputController InputController { get; private set; }
    
    //Runs before start
    void Awake()
    {
        Instance = this;
        InputController = GetComponentInChildren<InputController>();
    }

    void Update()
    {
        
    }
}
