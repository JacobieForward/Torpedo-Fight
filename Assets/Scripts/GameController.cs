using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : ScriptableObject {

    public static GameController instance;
    private GameObject controllerCluster;
    private static readonly object jailer = new object();

    public GameController() { }

    public static GameController getInstance()
    {
        lock (jailer)
        {
            if (instance == null)
            {
                instance = new GameController();
                Debug.Log("GameController instance was null See Trace: \n" + UnityEngine.StackTraceUtility.ExtractStackTrace());
            }
            return instance;
        }
    }

    private void Awake()
    {
        instance = this;
        controllerCluster = GameObject.FindGameObjectWithTag("GameController");
    }

    private TorpedoController torpedoController;

    public TorpedoController getTorpedoController()
    {
        return torpedoController;
    }

    private PlayerController playerControllerOne;

    public PlayerController getPlayerControllerOne()
    {
        return playerControllerOne;
    }

    private PlayerController playerControllerTwo;

    public PlayerController getPlayerControllerTwo()
    {
        return playerControllerTwo;
    }
}
