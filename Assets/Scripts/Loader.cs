using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour {

    private GameController gameController;

    private void Awake()
    {
        if (GameController.instance == null)
        {
            gameController = new GameController();
        }
    }
}
