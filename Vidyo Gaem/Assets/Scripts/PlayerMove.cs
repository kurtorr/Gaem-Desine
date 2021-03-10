using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    //Variables 
    public float playerSpeed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector2(0, playerSpeed) * Time.deltaTime);
            Debug.Log("Input: W");
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector2(0, -playerSpeed) * Time.deltaTime);
            Debug.Log("Input: S");
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector2(playerSpeed, 0) * Time.deltaTime);
            Debug.Log("Input: D");
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector2(-playerSpeed, 0) * Time.deltaTime);
            Debug.Log("Input: A");
        }
    }
}
