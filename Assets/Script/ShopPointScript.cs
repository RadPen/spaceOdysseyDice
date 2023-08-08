using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShopPointScript : MonoBehaviour
{
    public Text coinText;
    public static int coin = 1000;
    void Start()
    {
    }

    void Update()
    {
        coinText.text = "" + coin;
    }
}
