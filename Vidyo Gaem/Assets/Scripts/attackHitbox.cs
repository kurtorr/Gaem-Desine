using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackHitbox : MonoBehaviour
{
    //variables
    public float lifespan = 0.75f;
    public float damage = 40;
    float spearAngle;
    Vector3 mousePos;
    float dCX;
    float dCY;
    float dCT;

    //get objects
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        Destroy(gameObject, lifespan);
        //rotate based on mouse position
        mousePos = Input.mousePosition;
        {
            //get angle of mouse from screen centre
            dCX = mousePos.x - Screen.width / 2;
            dCY = mousePos.y - Screen.height / 2;
            dCT = Mathf.Abs(dCX) + Mathf.Abs(dCY);
            spearAngle = Mathf.Rad2Deg * Mathf.Atan(dCY / dCX)+90;
            //rotate
            transform.Rotate(0.0f, 0.0f, spearAngle, Space.Self); ;
            //log
            Debug.Log("Spear Angle:" + spearAngle);
            Debug.Log("Mouse X:" + mousePos.x);
            Debug.Log("Mouse Y:" + mousePos.y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        //move to player
        transform.position = new Vector3(player.transform.position.x + (transform.localScale.y/2 * dCX/dCT), player.transform.position.y + (transform.localScale.y/2 * dCY/dCT), player.transform.position.z);

    }
}
