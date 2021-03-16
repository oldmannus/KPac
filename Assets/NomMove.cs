using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NomMove : MonoBehaviour
{ 
    public float BallSpeed = 1.0f;
    public KeyCode up, down, left, right;


    Collider _collider; 

    // Start is called before the first frame update
    void Start()
    {
        _collider = GetComponent<Collider>();
        Debug.LogError("HIII");
    }

    // Update is called once per frame
    void Update()
    {
        float deltax = 0;
        float deltay = 0;
        float deltaz = 0;

        if (Input.GetKey(down))
        {
            deltaz = -Time.deltaTime * BallSpeed;
        }
        if (Input.GetKey(up))
        {
            deltaz = Time.deltaTime * BallSpeed;
        }
        if (Input.GetKey(left))
        {
            deltax = -Time.deltaTime * BallSpeed;
        }
        if (Input.GetKey(right))
        {
            deltax = Time.deltaTime * BallSpeed;
        }



        _collider.transform.Translate(new Vector3(deltax, deltay, deltaz));

    }
}
