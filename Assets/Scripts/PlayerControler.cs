using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [Header("Parametros de movimiento"), Space]
    [Tooltip("Velocidad de movimiento")]
    public float speed;

    //Referencia al valor del input axis horizontal
    private float h;
    
    //Referencia al valor del input axis vertical
    private float v;

    //Vector de movimientos
    private Vector2 movement;

    [Header("Limite de pantalla"), Space]
    [Tooltip("Limite de movimiento en el eje X")]
    public float xLimit;

    [Tooltip("Limite de movimiento en el eje Y")]
    public float yLimit;

    //Referencias
    //Referencia al rigidbody 2D
    private Rigidbody2D rb2d;

    private void Awake(){

        rb2d = GetComponent<Rigidbody2D>();

    }


    // Start is called before the first frame update
    void Start()
    {

        #region Axis
        //recuperamos los valores de los axis horizontal y vertical
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Movement();
    }

    /// <summary>
    /// Metodo que se encargara de realizar el movimiento del jugador
    /// </summary>
    private void Movement()
    {

        //recuperamos los valores de los axis horizontal y vertical
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");

        //Generamos un vector de movimiento y lo normalizamos
        movement = new Vector2(h, v).normalized;

        //Aplicamos el movimiento sobre el jugador
        rb2d.MovePosition((Vector2)transform.position + movement * speed * Time.deltaTime);

        //Ponemos un limite de hasta donde pueda ir la nave
        {

         

        }   
            
    }
}
