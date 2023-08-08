using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloneScripts : MonoBehaviour
{
    public GameObject cloneStarship;
    bool click;

    Vector3 startPos;

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            click = true;
            startPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            startPos.z = 0;
            ShopPointScript.coin = ShopPointScript.coin - cloneStarship.GetComponent<ShipParameter>().price;
        }
    }

    void Start()
    {

    }

    void Update()
    {
        if (click == true)
            Instantiate(cloneStarship, startPos, Quaternion.identity);
        click = false;
    }
}
