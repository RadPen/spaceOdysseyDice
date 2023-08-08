using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScript : MonoBehaviour
{
    public static GameObject shipPlayer;
    public static GameObject shipComputer;
    List<GameObject> Ubit = new List<GameObject>();
    public Text dicePlayer;
    public Text diceComputer;

    void Start()
    {
        
    }

    void Update()
    {
        if (shipPlayer != null && shipComputer != null)
        {
            int att = Random.Range(1, shipPlayer.GetComponent<ShipParameter>().attack);
            int deff = Random.Range(1, shipComputer.GetComponent<ShipParameter>().defense);
            dicePlayer.text = "" + att;
            diceComputer.text = "" + deff;
            if (att > deff)
                Ubit.Add(shipComputer);
            shipPlayer = null;
            shipComputer = null;
        }
    }
}
