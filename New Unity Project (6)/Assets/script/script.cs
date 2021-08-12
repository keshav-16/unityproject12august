using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public float xspd = 0.1f;
    public float yspd = 0.1f;
    public float zspd = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetKey(KeyCode.H))
        {
             MoveLeft();
        }
        if (Input.GetKey(KeyCode.G))
        {
            MoveUp();
        }
        if (Input.GetKey(KeyCode.F))
        {
             MoveRight();
        }
        if (Input.GetKey(KeyCode.D))
        {
             MoveDown();
        }
        if (Input.GetKey(KeyCode.S))
        {
             MoveBackAround();
        }
        if (Input.GetKey(KeyCode.A))
        {
             MoveAround();
        }
    }

    public void MoveLeft()
    {
        transform.position -= new Vector3(xspd, 0, 0);
    }

    public void MoveRight()
    {
        transform.position += new Vector3(xspd, 0, 0);
    }

    public void MoveUp()
    {
        transform.position += new Vector3(0, yspd, 0);
    }

    public void MoveDown()
    {
        transform.position -= new Vector3(0, yspd, 0);
    }

    public void MoveAround()
    {
        transform.position += new Vector3(0 , 0, zspd);
    }

    public void MoveBackAround()
    {
        transform.position -= new Vector3(0, 0, zspd);
    }

  
}
