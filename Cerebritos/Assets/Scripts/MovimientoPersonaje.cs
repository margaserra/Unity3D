using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoPersonaje : MonoBehaviour
{
    float movimientoVertical;
    [SerializeField]
    float velocidadHorizontal = 0f;
    [SerializeField]
    float velocidadSalto = 0f;
    [SerializeField]
    float saltosMaximos;
    [SerializeField]
    LayerMask capaSuelo;

    Rigidbody2D rb2d;
    CapsuleCollider2D boxCollider;
    bool mirarDerecha = true;
    float saltosRestantes;


    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        boxCollider = GetComponent<CapsuleCollider2D>();
        saltosRestantes = saltosMaximos;
    }
    void Update()
    {
        ProcesarMovimiento();
        ProcesarSalto();
    }
    bool EstaEnSuelo()
    {
        RaycastHit2D raycastHit = Physics2D.BoxCast(boxCollider.bounds.center, new Vector2(boxCollider.bounds.size.y, boxCollider.bounds.size.x), 0f, Vector2.down, 0.2f, capaSuelo);
        return raycastHit.collider != null;
    }
    void ProcesarSalto()
    {
        if (EstaEnSuelo())
        {
            saltosRestantes = saltosMaximos;
        }
        if (Input.GetKeyDown(KeyCode.Space) && saltosRestantes > 0)
        {
            saltosRestantes--; //es igual --> saltosRestantes == saltosRestantes -1;
            rb2d.velocity = new Vector2(rb2d.velocity.x, 0f);
            rb2d.AddForce(Vector2.up * velocidadSalto, ForceMode2D.Impulse);
        }
    }
    private void ProcesarMovimiento()
    {
        float movimientoHorizontal = Input.GetAxis("Horizontal");

        rb2d.velocity = new Vector2(movimientoHorizontal * velocidadHorizontal, rb2d.velocity.y);
        GestionarOrientacion(movimientoHorizontal);
    }
    private void GestionarOrientacion(float movimientoX)
    {
        if ((mirarDerecha && movimientoX < 0) || (!mirarDerecha && movimientoX > 0 ))
        {
            mirarDerecha = !mirarDerecha;
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        }
    }
}
