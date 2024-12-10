using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static public GameObject bullet_text;
    static int numBalas = 0;

    void Start()
    {
        bullet_text = GameObject.Find("Text red");
    }

    static public void ResetearBalas()
    {
        numBalas = 0;
        bullet_text.GetComponent<TMP_Text>().SetText(numBalas.ToString());
    }

    static public void IncNumBalas()
    {
        numBalas++;
        bullet_text.GetComponent<TMP_Text>().SetText(numBalas.ToString());
    }

    static public void DecNumBalas()
    {
        if (numBalas > 0)
        {
            numBalas--;
            bullet_text.GetComponent<TMP_Text>().SetText(numBalas.ToString());
        }
    }
}
