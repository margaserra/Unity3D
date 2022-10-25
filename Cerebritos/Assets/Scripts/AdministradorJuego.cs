using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdministradorJuego : MonoBehaviour
{
    public int PuntosTotales { get { return puntosTotales; } }
    private int puntosTotales;

    public void SumarPuntos(int puntosASumar)
    {
        puntosTotales = puntosTotales + puntosASumar;
        Debug.Log(puntosTotales);
    }
}
