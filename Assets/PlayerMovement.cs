using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    private void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical"); 

        Vector3 move = new Vector3(x, 0, z);

        transform.Translate(move * Time.deltaTime * speed);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Pakyu");
        }
    }
}
