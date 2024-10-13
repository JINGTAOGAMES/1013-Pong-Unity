using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p2 : MonoBehaviour
{
    // Start is called before the first frame update
    public int speedy = 6;
    public Rigidbody2D RBBB;
    public float speedY;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        speedY = Input.GetAxisRaw("Vertical(Number)") * speedy;
        RBBB.velocity = new Vector2(0, speedY);

    }
}
