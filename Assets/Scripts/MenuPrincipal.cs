﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void Jouer()
    {
        SceneManager.LoadScene(1);
    }
    public void Quitter()
    {
        Application.Quit();
    }
}
