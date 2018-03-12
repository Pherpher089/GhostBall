﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DebugKeys : MonoBehaviour {

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F1))
        {
            int currScene = SceneManager.GetActiveScene().buildIndex;

            SceneManager.LoadScene(currScene);
        }
    }
}
