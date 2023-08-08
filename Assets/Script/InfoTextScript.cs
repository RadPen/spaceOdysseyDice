using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoTextScript : MonoBehaviour
{
    public Text nameText;
    public Text priceText;
    public Text attackText;
    public Text defenceText;
    public Text moduleText;
    public static string nameShip = "���";
    public static int price = 0;
    public static int attack = 0;
    public static int defence = 0;
    public static string module = "���";

    void Start()
    {
    }

    void Update()
    {
        nameText.text = "��������:              " + nameShip;
        priceText.text = "����:                     " + price;
        attackText.text = "�����:                    " + attack;
        defenceText.text = "������:                 " + defence;
        moduleText.text = "������:                  " + module;
    }
}
