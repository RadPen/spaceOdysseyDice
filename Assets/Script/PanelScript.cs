using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelScript : MonoBehaviour
{
    public static bool panelInfo = false;
    public static int panelBattle = 0;
    public static bool panelBattleCheck = false;
    public GameObject managerPanel;
    public GameObject battlePanel;
    public GameObject infoPanel;

    void Start()
    {
    }

    void Update()
    {
        if (!panelInfo)
            infoPanel.SetActive(false);
        if (panelInfo)
            infoPanel.SetActive(true);
        if (panelBattle == 0)
        {
            battlePanel.SetActive(false);
            managerPanel.SetActive(true);
            panelBattleCheck = false;
        }
        if (panelBattle == 1)
        {
            battlePanel.SetActive(true);
            managerPanel.SetActive(false);
            panelBattleCheck = true;
        }
        panelBattle = 2;
}
}
