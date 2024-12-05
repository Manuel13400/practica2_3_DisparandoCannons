using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonBlueStats : MonoBehaviour
{
    public TMP_Text bullet_stats;
    public ButtonBlue button;

    void Update()
    {
        bullet_stats.SetText("Size: " +  button.randomSize + "\n\nStrenght: " + button.randomStrength + "\n\nColor:");
    }
}
