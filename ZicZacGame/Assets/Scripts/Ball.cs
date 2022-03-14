using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public static Ball Instance;
    Vector3 direction;
    public float moveSpeed;
    public SpawnGround spawnGroundScript;
    public bool isFall;
    public float addSpeed;


    private void Awake()
    {
        Instance = this;

    }

    void Start()
    {
        direction = Vector3.forward;
        isFall = false;

    }

    
    void Update()
    {
        if(transform.position.y<= -1.0f)
        {
            isFall = true;
        }

        if(isFall == true)
        {
            return;  
        }

        if (Input.GetMouseButtonDown(0))
        {
            if(direction.x == 0)
            {
                direction = Vector3.left; 
            }
            else
            {
                direction = Vector3.forward;  

            }

            moveSpeed = moveSpeed += addSpeed * Time.deltaTime;
        }

        
    }

    private void FixedUpdate()
    {
        Vector3 Movement = direction * Time.deltaTime * moveSpeed;
        transform.position += Movement;
    }


    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Score.score++;
            collision.gameObject.AddComponent<Rigidbody>();
            spawnGroundScript.createGround();
            StartCoroutine(deleteTheGround(collision.gameObject));

        }
    }

    IEnumerator deleteTheGround(GameObject gameObject)
    {
        yield return new WaitForSeconds(3f);
        Destroy(gameObject);

    }
}
