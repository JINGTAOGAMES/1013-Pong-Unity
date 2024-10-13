using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class p1 : MonoBehaviour
{
    public int speedy = 500;
    public Rigidbody2D RBB;
    public float speedY;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        speedY = Input.GetAxisRaw("Vertical") * speedy;
        RBB.velocity = new Vector2(0, speedY);

    }
}
