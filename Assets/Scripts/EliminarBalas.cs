using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EliminarBalas : MonoBehaviour
{
    public GameObject[] balas;

    private void OnMouseDown()
    {
        balas = GameObject.FindGameObjectsWithTag("bullet");
        foreach (GameObject bala in balas)
        {
            Destroy(bala);
        }

        GameManager.ResetearBalas();
    }
}
