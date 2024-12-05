using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonRed : MonoBehaviour
{
    public List<GameObject> bulletList = new List<GameObject>();

    void Update()
    {
        foreach(GameObject b in GameObject.FindGameObjectsWithTag("bullet"))
        {
            if (!bulletList.Contains(b))
            {
                bulletList.Add(b);
            }
        }
    }

    private void OnMouseDown()
    {
        foreach (GameObject b in GameObject.FindGameObjectsWithTag("bullet"))
        {
            Destroy(b);
        }
    }
}
