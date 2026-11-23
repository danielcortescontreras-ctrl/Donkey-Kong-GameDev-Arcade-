using UnityEngine;
using UnityEngine.InputSystem;

public class MovimentPersonatge : MonoBehaviour
{
    public Rigidbody2D rb;
    public CapsuleCollider2D Collider;
    int velocityX = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // S'han de cambiar els números per les variables de moviment
        // if(!(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.LeftArrow))) només hauria de canviar la variable al premer la tecla o soltar-la
        if (Collider.IsTouchingLayers(LayerMask.GetMask("Ground"))){
            if (Input.GetKey(KeyCode.RightArrow))
            {
                velocityX = 1; // Canviar les variables per un metode més eficient que no entri a memoria
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                velocityX = -1;
            }
            else if (!Input.anyKey) 
            {
                velocityX = 0;
            }
            
            if (Input.GetKey(KeyCode.Space)) 
            {
                rb.linearVelocity = new Vector2(rb.linearVelocityX, 8);
            }
        }
        /*
        if (Input.GetButton("Up")) //revisar possibles problemes amb Jump
        {
            //mirar si hi ha escalera
            //desactivar gravetat
            rb.linearVelocity = new Vector2(0, 1);
        }
        */
    }
    
    void FixedUpdate()
    {
        // S'han de cambiar els números per les variables de moviment
        rb.linearVelocity = new Vector2(8 * velocityX, rb.linearVelocityY);
        /*
        if (Input.GetButton("Up")) //revisar possibles problemes amb Jump
        {
            //mirar si hi ha escalera
            //desactivar gravetat
            rb.linearVelocity = new Vector2(0, 1);
        }
        */
    }
    
    
    /*
    public void right()
    {
        rb.linearVelocity = new Vector2(8, 0);
    }
    public void left()
    {
        rb.linearVelocity = new Vector2(-8, 0);
    }
    public void jump()
    {
        rb.linearVelocity = new Vector2(0, 12);
    }
    */
}
