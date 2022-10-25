using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoResultadoCorrecto : MonoBehaviour
{
    //[SerializeField]
    public float velocidadX;
    //[SerializeField]
    public float velocidadY;
    void Start()
    {
        float inicialX = Random.Range(0, 0);
        float inicialY = Random.Range(0, 0);

        if (inicialX == 0)
        {
            velocidadX *= -1;
        }
        if (inicialY == 0)
        {
            velocidadY *= -1;
        }
    }
    void Update()
    {
        transform.Translate(new Vector3(velocidadY, velocidadX) * Time.deltaTime);
    }

}
