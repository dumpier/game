﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Thrones.Controllers.Scenes.Booting
{
    public class BootingController : Thrones.Controllers.Controller
    {
        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("Home");
            }
        }
    }
}