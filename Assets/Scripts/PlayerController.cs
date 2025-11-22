using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    /*private Rigidbody _rb;
    public float speed;

    public float minX = -25f;
    public float maxX = 25f;
    public float minZ = -20f;
    public float maxZ = 20f;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();

    }
    void Update()
    {
        Vector3 pos = transform.position;

        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        pos.z = Mathf.Clamp(pos.z, minZ, maxZ);

        transform.position = pos;


        if (Input.GetKey(KeyCode.W))
        {
            _rb.velocity = Vector3.forward.normalized * speed;
        }
        else if(Input.GetKey(KeyCode.S))
        {
            _rb.velocity = Vector3.back.normalized * speed;
        }
        else if(Input.GetKey(KeyCode.D))
        {
            _rb.velocity = Vector3.right.normalized * speed;
        }
        else if(Input.GetKey(KeyCode.A))
        {
            _rb.velocity = Vector3.left.normalized * speed;
        }
        else
        {
            _rb.velocity = Vector3.zero.normalized;
        }

       
    }*/
    private Rigidbody _rb;
    public float speed;

    public float minX = -25f;
    public float maxX = 25f;
    public float minZ = -20f;
    public float maxZ = 20f;

    public FixedJoystick joystick; 

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
       
        Vector3 pos = transform.position;
        pos.x = Mathf.Clamp(pos.x, minX, maxX);
        pos.z = Mathf.Clamp(pos.z, minZ, maxZ);
        transform.position = pos;

       
        float horizontal = joystick.Horizontal;
        float vertical = joystick.Vertical;

       
        Vector3 direction = new Vector3(horizontal, 0, vertical).normalized;

        _rb.velocity = direction * speed;

    }


}