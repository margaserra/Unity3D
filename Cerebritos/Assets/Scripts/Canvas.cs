using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Canvas : MonoBehaviour
{
    public AdministradorJuego administradorJuego;
    public TextMeshProUGUI puntos;
    internal Camera worldCamera;
    internal RenderMode renderMode;

    void Start()
    {
    }
    void Update()
    {
        puntos.text = administradorJuego.PuntosTotales.ToString();
    }
}
