﻿/*
 * Matt Kirchoff
 * menu.cs
 * CIS452 Assignment 5
 * menu management
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(sceneName: "GameScene");
        }

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
