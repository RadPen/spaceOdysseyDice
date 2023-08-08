using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyScript : MonoBehaviour
{
    bool click;

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            click = true;
        }
    }

    void Start()
    {

    }

    void Update()
    {
        if (click == true)
        {
            PanelScript.panelBattle = 1;
        }
        click = false;
    }
}