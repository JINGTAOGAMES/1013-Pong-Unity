using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BALL : MonoBehaviour
{
    public Rigidbody2D RB;
    public float speed = 10f;
    public logic Logic;
    public AudioSource hehe;
    // Start is called before the first frame update
    void Start()
    {
        Logic = GameObject.FindGameObjectWithTag("GameController").GetComponent<logic>();

        bool right = UnityEngine.Random.value >= 0.5;
        float Xvelocity = -1f;

        if (right == true ) {

            Xvelocity = 1f;

        }

        float Yvelocity = UnityEngine.Random.Range(-1,1) ;

        RB.velocity = new Vector2 (Xvelocity* speed, Yvelocity* speed);


    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.x < -10)
        {
            Logic.RightScore();
            Destroy(gameObject); ;

        }
        if (transform.position.x > 10)
        {
            Logic.LeftScore();
            Destroy(gameObject); ;

        }

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "wall") { 
        hehe.Play();
        }
    }



}

