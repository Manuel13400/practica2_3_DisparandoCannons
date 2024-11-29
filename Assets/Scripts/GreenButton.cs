using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenButton : MonoBehaviour
{
    public CannonShoot shootBullet;


    private void OnMouseDown()
    {
        GameObject c = GameObject.FindGameObjectWithTag("spawnPoint");
        shootBullet = c.GetComponent<CannonShoot>();
        shootBullet.activated = true;
    }

}