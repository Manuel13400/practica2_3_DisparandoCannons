using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShoot : MonoBehaviour
{
    public GameObject bullet;
    public float launchSpeed = 500f;
    public bool activated = false;

    private void Update()
    {
        if (activated)
        {
            GameObject bulletCreated = Instantiate(bullet, transform.position, transform.rotation);
            bulletCreated.GetComponent<Rigidbody>().AddRelativeForce(new Vector3(0, launchSpeed, 0));
            activated = false;
        }
    }

}
