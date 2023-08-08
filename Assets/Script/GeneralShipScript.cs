using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneralShipScript : MonoBehaviour
{
    public bool move;
    public static GameObject closestFinal;
    public static string tegFind;

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            closestFinal.SetActive(true);
            move = true;
        }
    }

    void OnMouseUp()
    {
        move = false;
    }

    void Start()
    {
        tegFind = "Finish" + this.GetComponent<ShipParameter>().size;
        MoveStarship.MoveShipPlayer(this.gameObject);
    }

    void Update()
    {
        if (move)
            MoveStarship.MoveShipPlayer(this.gameObject);
    }
}
