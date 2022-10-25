using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilemap : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D resultadoCorrecto)
    {
        resultadoCorrecto.gameObject.GetComponent<MovimientoResultadoCorrecto>().velocidadY *= -1;
    }
}
