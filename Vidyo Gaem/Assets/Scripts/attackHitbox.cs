using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attackHitbox : MonoBehaviour
{
    //variables
    public float lifespan = 0.75f;
    public float damage = 40;

    //get objects
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        Destroy(gameObject, lifespan);
    }

    // Update is called once per frame
    void Update()
    {
        //move to player
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y + transform.localScale.y/2, player.transform.position.z);
    }
}
