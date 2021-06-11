using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ruby : MonoBehaviour
{

    
    public SpriteRenderer ruby;
    public Rigidbody2D rigidbody;
    [Header("Balance Variable")]
    [SerializeField]
    private float jumpForce = 1;
    public float moveSpeed;
    public float MapSpeed;
    public int currentHP = 30;
    public int HP = 30;
    public float impulso = 2;
    private Vector2 posicioninicial;



    private float horizontal;
    private float vertical;
    private Vector3 direction;



    // Start is called before the first frame update
    void Start()
    {

        


    }

    // Update is called once per frame
    void Update()
    {
        
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        direction = new Vector3(horizontal, 0f, vertical);

        posicioninicial = transform.position;
        transform.position = new Vector2(transform.position.x + MapSpeed, transform.position.y);



        // D Right
        if (Input.GetKey(KeyCode.W))
        {
            
            //animator.SetBool("RunUp", false);
            //animator.SetBool("RunDown", false);
            
            transform.position = new Vector2(transform.position.x , transform.position.y + moveSpeed);

        }

        if (Input.GetKey(KeyCode.S))
        {

            //animator.SetBool("RunUp", false);
            //animator.SetBool("RunDown", false);

            transform.position = new Vector2(transform.position.x, transform.position.y - moveSpeed);

        }



        if (direction.magnitude == 0f)
        {
           
        }



        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody.AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
        }



    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Hazard"))
        {

            UnityEngine.SceneManagement.SceneManager.LoadScene(0);


        }








    }


}
