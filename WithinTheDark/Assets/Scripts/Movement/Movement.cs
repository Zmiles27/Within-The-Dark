using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float mouseX;
    public float sensitivity = 5.0f;

    public int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        transform.position = new Vector3(83, 14, 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Translate(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 10;        
        }
        else
        {
            speed = 5;
        }

        mouseX += Input.GetAxis("Mouse X") * sensitivity;
        transform.eulerAngles = new Vector3(0, mouseX, 0);
    }
}
