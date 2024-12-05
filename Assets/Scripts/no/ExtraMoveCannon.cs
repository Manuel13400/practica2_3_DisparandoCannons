using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraMoveCannon : MonoBehaviour
{
    GameObject cannon;
    public float speed = 3f;

    public void Start()
    {
        cannon = GameObject.FindGameObjectWithTag("cannon");
    }
    private void OnMouseDown()
    {
        if (CompareTag("moveLeft"))
        {
            cannon.transform.position -= new Vector3(speed, 0, 0);
        }
        else if (CompareTag("moveRight"))
        {
            cannon.transform.position += new Vector3(speed, 0, 0);
        }
    }
}
