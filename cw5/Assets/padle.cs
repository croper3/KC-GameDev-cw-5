using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class padle : MonoBehaviour
{
    Rigidbody2D RB;
    float playerinput;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void fixedUpdate()
    {
        playerinput = Input.GetAxis("Horizontal");
        RB.velocity =new Vector2(playerinput * speed,0);

    }
}
