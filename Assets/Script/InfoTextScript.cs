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
    public static string nameShip = "НЕТ";
    public static int price = 0;
    public static int attack = 0;
    public static int defence = 0;
    public static string module = "НЕТ";

    void Start()
    {
    }

    void Update()
    {
        nameText.text = "Название:              " + nameShip;
        priceText.text = "Цена:                     " + price;
        attackText.text = "Атака:                    " + attack;
        defenceText.text = "Защита:                 " + defence;
        moduleText.text = "Модуль:                  " + module;
    }
}
