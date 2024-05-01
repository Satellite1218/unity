using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("test");
    }

    // Update is called once per frame
    void Update()
    {
        float speed = Time.deltaTime * 7f;
        Vector3 mpos = Input.mousePosition;
        
        if (Input.GetMouseButton(0))
        {
            if (mpos.x <= Screen.width / 2)
            {
                transform.Translate(-Vector3.right * speed);
                Debug.Log("마우스 왼쪽");
            }
            else if (mpos.x >= Screen.width / 2)
            {   
                transform.Translate(Vector3.right * speed);
                Debug.Log("마우스 오른쪽");
            }
        }
    }
}
