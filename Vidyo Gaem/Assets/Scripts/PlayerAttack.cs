using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    //varibles
    public float cooldown = 1;
    public float currentCooldown;

    //get objects
    public GameObject hitBox;

    // Start is called before the first frame update
    void Start()
    {
        currentCooldown = cooldown;
    }

    // Update is called once per frame
    void Update()
    {
        //calculate attack cooldown
        if (currentCooldown < cooldown)
        {
            currentCooldown += 1 * Time.deltaTime;
        }

        //spawn attack hitbox on left click
        if (Input.GetMouseButtonDown(0) && currentCooldown >= cooldown)
        {
            Instantiate(hitBox);
            currentCooldown = 0;
            Debug.Log("Input: Left Mouse Button");

            //mouse input test
            Vector3 mousePos = Input.mousePosition;
            {
                Debug.Log("Mouse X:" + mousePos.x);
                Debug.Log("Mouse Y:" + mousePos.y);
            }
        }
    }
}
