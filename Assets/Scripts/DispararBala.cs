using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararBala : MonoBehaviour
{
    // Valores para posicion en la que aparece la bala, hacia donde tiene que ir y el cañon
    public GameObject posicionInicial;
    public GameObject posicionFinal;
    public GameObject cannon;

    // Potencia del disparo
    static public float velocidadDisparo = 1500f;

    // Prefab de la bala
    public GameObject bullet;
    GameObject balaInstanciada;

    void Update()
    {
        // Si la bala esta a menos de cinco metros del cañon, este ultimo cambia de color a rojo. Una vez se aleja, vuelve a su color original
        int cerca = 5;
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

    // Instancia la bala y la dispara. Ademas, incrementa el numero de balas en la interfaz
    private void OnMouseDown()
    {
        balaInstanciada = Instantiate(bullet, posicionInicial.transform.position, Quaternion.identity);
        
        // Si se pulsa el boton de cambiar los valores de la bala, cambiara el color de esta. Por defecto, la bala es amarilla
        if (ValoresAleatorios.colorAleatorio == 1) { balaInstanciada.GetComponent<Renderer>().material.color = Color.yellow; }
        else if (ValoresAleatorios.colorAleatorio == 2) { balaInstanciada.GetComponent<Renderer>().material.color = Color.red; }
        else if (ValoresAleatorios.colorAleatorio == 3) { balaInstanciada.GetComponent<Renderer>().material.color = Color.blue; }
        else if (ValoresAleatorios.colorAleatorio == 4) { balaInstanciada.GetComponent<Renderer>().material.color = Color.green; }
        else if (ValoresAleatorios.colorAleatorio == 5) { balaInstanciada.GetComponent<Renderer>().material.color = Color.white; }
        
        
        Rigidbody rb = balaInstanciada.GetComponent<Rigidbody>();

        Vector3 direccion = posicionFinal.transform.position - posicionInicial.transform.position;
        rb.AddForce(direccion.normalized * velocidadDisparo);

        GameManager.IncNumBalas();
    }

}
