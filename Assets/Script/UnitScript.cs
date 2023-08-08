using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitScript : MonoBehaviour
{

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
            if (PanelScript.panelBattleCheck)
                GameScript.shipComputer = this.gameObject;
    }

    void OnMouseUp()
    {

    }

    void Start()
    {

    }

    void Update()
    {

    }
}