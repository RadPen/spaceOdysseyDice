using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScenesScript : MonoBehaviour
{
    public int sceneLevel;

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
            SceneManager.LoadScene(sceneLevel);
    }

    void Start()
    {
    }

    void Update()
    {
    }
}