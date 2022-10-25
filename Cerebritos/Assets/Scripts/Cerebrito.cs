using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class Cerebrito : MonoBehaviour
{
    public int valor = 25;
    public AdministradorJuego administradorJuego; 

    void Start()
    {
        
    }

    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            administradorJuego.SumarPuntos(valor);
            Destroy(this.gameObject);
        }
    }

}
