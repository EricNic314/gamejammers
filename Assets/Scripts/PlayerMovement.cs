using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 2.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool is_down_pressed;
        is_down_pressed = Input.GetKey(KeyCode.S);
        bool is_up_pressed;
        is_up_pressed = Input.GetKey(KeyCode.W);
        bool is_right_pressed;
        is_right_pressed = Input.GetKey(KeyCode.D);
        bool is_left_pressed;
        is_left_pressed = Input.GetKey(KeyCode.A);


        if (is_down_pressed)
        {
            transform.position = transform.position + new Vector3(0, -1 *moveSpeed, 0) *Time.deltaTime;
           
        }
        if (is_up_pressed)
        {
            transform.position = transform.position + new Vector3(0, 1 * moveSpeed, 0) * Time.deltaTime;
        }
        if(is_right_pressed)
        {
            transform.position = transform.position + new Vector3(1 * moveSpeed, 0 , 0) * Time.deltaTime;
        }
        if (is_left_pressed)
        {
            transform.position = transform.position + new Vector3(-1 * moveSpeed, 0, 0) * Time.deltaTime;
        }
    }
}
