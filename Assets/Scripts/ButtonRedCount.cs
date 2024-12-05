using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ButtonRedCount : MonoBehaviour
{
    public TMP_Text bullet_text;
    void Update()
    {
        GameObject[] Bullets = GameObject.FindGameObjectsWithTag("bullet");
        int cuenta = Bullets.Length;
        bullet_text.SetText(cuenta.ToString());
    }
}
