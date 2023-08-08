using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelationScript : MonoBehaviour
{
    int checkOneDis = 0;
    bool checkOneEna = false;
    public GameObject[] relat;

    void OnDisable()
    {
        if (checkOneDis == 0)
        {
            foreach (var r in relat)
            {
                r.GetComponent<RelationScript>().checkOneDis = r.GetComponent<RelationScript>().checkOneDis + 1;
                r.SetActive(false);
            }
            checkOneEna = true;
        }
    }

    void OnEnable()
    {
        if (checkOneEna)
        {
            checkOneEna = false;
            foreach (var r in relat)
            {
                r.GetComponent<RelationScript>().checkOneDis = r.GetComponent<RelationScript>().checkOneDis - 1;
                if (r.GetComponent<RelationScript>().checkOneDis == 0)
                    r.SetActive(true);
            }
        }
    }

    void Start()
    {
    }

    
    void Update()
    {
    }
}
