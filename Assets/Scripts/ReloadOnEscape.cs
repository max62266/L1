﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReloadOnEscape : MonoBehaviour
{
    // Start is called before the first frame update
 
    // Update is called once per frame
    private void Update()
    {
      if(Input.GetKeyDown(KeyCode.Escape))  
      {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
      }
    }
}
