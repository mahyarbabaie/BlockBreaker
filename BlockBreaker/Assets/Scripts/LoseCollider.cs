﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour {

    public LevelManager levelManager;

    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Brick.breakableCount = 0;
        levelManager = GameObject.FindObjectOfType<LevelManager>();
        levelManager.LoadLevel("Lose");
    }

}
