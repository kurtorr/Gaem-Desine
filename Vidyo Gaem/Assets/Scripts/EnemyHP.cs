using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour
{
    //variables
    public float hpMax = 100;
    public float hp;

    //get objects
    public GameObject hpBar;
    public GameObject playerAttack;

    // Start is called before the first frame update
    void Start()
    {
        hp = hpMax;
    }

    //collision with player attack causes hp value to decrease
    void OnTriggerEnter2D(Collider2D col)
    {

        //
        if (col.gameObject.name == "spearHitbox(Clone)")
        {
            hp = hp - playerAttack.GetComponent<attackHitbox>().damage;
            Debug.Log("Enemy colision: Player Attack");
        }
    }

    // Update is called once per frame
    void Update()
    {

        //update hp bar
        hpBar.transform.localScale = new Vector3(hp*1.2f/hpMax, 0.15f, 1);
        hpBar.transform.position = new Vector3(this.transform.position.x + ((hp - hpMax) / 100 * 0.6f), this.transform.position.y + 0.7f, -0.11f);

        //kill enemy when hp <= 0
        if (hp <= 0)
        {
            Destroy(gameObject);
        }

    }
}
