using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float speed;
   // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("vertical");

        Vector3 movement = new Vector3 (horizontalInput,0.0f, verticalInput)* speed * Time.deltaTime;
    }
}
