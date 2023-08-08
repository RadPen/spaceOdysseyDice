using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoStarship : MonoBehaviour
{
    bool click;

    Vector3 startPos;

    void InfoPanelCall()
    {
        PanelScript.panelInfo = true;
        InfoTextScript.nameShip = this.GetComponent<ShipParameter>().nameship;
        InfoTextScript.price = this.GetComponent<ShipParameter>().price;
        InfoTextScript.attack = this.GetComponent<ShipParameter>().attack;
        InfoTextScript.defence = this.GetComponent<ShipParameter>().defense;
        if (this.GetComponent<ShipParameter>().module != null)
            InfoTextScript.module = "Да";
    }

    void OnMouseOver()
    {
            click = true;
    }

    void Start()
    {
    }

    void Update()
    {
        if (click)
            if (Input.GetMouseButtonDown(1))
            {
                InfoPanelCall();
            }
        if (Input.GetMouseButtonUp(1))
            PanelScript.panelInfo = false;
        click = false;
    }
}
