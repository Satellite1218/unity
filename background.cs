using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        //transform.position = new Vector2(3, 0);
    }

    void Move()
    {
        float speed = Time.deltaTime * 5f;
        Vector3 mpos = Input.mousePosition;
        
        if (Input.GetMouseButton(0))
        {
            if (mpos.x <= Screen.width / 2)
            {
                transform.Translate(Vector2.right * speed);
                Debug.Log("마우스 왼쪽");
            }
            else if (mpos.x >= Screen.width / 2)
            {   
                transform.Translate(-Vector2.right * speed);
                Debug.Log("마우스 오른쪽");
            }
        }
    }

    void ChangeR()
    {
        transform.position = new Vector2(25, 0);
    }

    void ChangeL()
    {
        transform.position = new Vector2(-25, 0);
    }
    
    // Update is called once per frame
    void Update()
    {
        Move();
        if (transform.position.x <= -35)
        {
            ChangeR();
        }
        else if (transform.position.x >= 35)
        {
            ChangeL();
        }
    }
}
