using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetActions : MonoBehaviour
{
    public int bulletNumber = 0;
    public bool rotationActivated = false;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("bullet"))
        {
            if (bulletNumber == 0)
            {
                GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
                bulletNumber = 1;
            }
            else if ( bulletNumber == 1)
            {
                rotationActivated = true;
                bulletNumber = 2;   
            }
            else if ( bulletNumber == 2)
            {
                Destroy(gameObject);
            }
        }
    }

    private void Update()
    {
        if (rotationActivated)
        {
            transform.Rotate((50 * Time.deltaTime) * 3, (50 * Time.deltaTime) * 3, (50 * Time.deltaTime) * 3);
        }
    }
}
