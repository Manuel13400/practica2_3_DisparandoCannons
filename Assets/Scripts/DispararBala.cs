using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararBala : MonoBehaviour
{
    public GameObject posicionInicial;
    public GameObject posicionFinal;
    public GameObject cannon;

    public GameObject bullet;
    GameObject balaInstanciada;

    void Update()
    {
        int cerca = 10;
        if (balaInstanciada != null)
        {
            float distancia = Vector3.Distance(balaInstanciada.transform.position, cannon.transform.position);
            if (distancia <= cerca)
            {
                cannon.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                cannon.GetComponent<Renderer>().material.color = Color.white;
            }
        }
    }

    private void OnMouseDown()
    {
        balaInstanciada = Instantiate(bullet, posicionInicial.transform.position, Quaternion.identity);
        Rigidbody rb = balaInstanciada.GetComponent<Rigidbody>();

        Vector3 direccion = posicionFinal.transform.position - posicionInicial.transform.position;
        rb.AddForce(direccion.normalized * 1500f);

        GameManager.IncNumBalas();
    }

}
