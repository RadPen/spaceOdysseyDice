using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveStarship : MonoBehaviour
{
    bool move;
    static Vector2 mousePos;
    static GameObject closest;
    public static bool checkCoin;

    public static void MoveShipPlayer(GameObject shipPlayer)
    {
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        shipPlayer.transform.position = mousePos;
        if (shipPlayer.GetComponent<GeneralShipScript>().move == false)
            OnMoveShipPlayer(shipPlayer);
    }

    static void OnMoveShipPlayer(GameObject shipPlayer)
    {
        FindClosestEnemy(shipPlayer);
        if (closest == null)
            checkCoin = false;
        shipPlayer.transform.position = new Vector2(closest.transform.position.x, closest.transform.position.y);
        GeneralShipScript.closestFinal = closest;
        closest.SetActive(false);
    }

    static void FindClosestEnemy(GameObject shipPlayer)
    {
        GameObject[] finish = GameObject.FindGameObjectsWithTag(GeneralShipScript.tegFind);
        float distance = Mathf.Infinity;
        Vector3 position = shipPlayer.transform.position;
        foreach (GameObject go in finish)
        {
            Vector3 diff = go.transform.position - position;
            float curDistance = diff.sqrMagnitude;
            if (curDistance < distance && go )
            {
                closest = go;
                distance = curDistance;
            }
        }
    }

    void Update()
    {
    }
}
