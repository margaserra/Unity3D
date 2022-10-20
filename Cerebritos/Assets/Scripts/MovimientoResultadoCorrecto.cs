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
        int inicialX = Random.Range(0, 2);
        int inicialY = Random.Range(0, 2);

        if(inicialX == 0)
        {
            velocidadX *= -1;
        }
        if (inicialY == 0)
        {
            velocidadY *= -1;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(velocidadY, velocidadX) * Time.deltaTime);
    }
}
