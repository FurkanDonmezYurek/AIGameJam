using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MlBullet : MonoBehaviour
{
    public int damage;

    private void Start()
    {
        GameObject player = GameObject.Find("Target");
        transform.rotation = player.transform.rotation;
    }

    private void Update()
    {
        Destroy(this.gameObject, 1.5f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (
            other != null
            && other.tag != "Player"
            && other.GetComponent<Collider2D>().isTrigger != true
        )
        {
            Destroy(this.gameObject);
            if (other.transform.tag == "Enemy")
            {
                other.GetComponent<AI>().health -= damage;
            }
        }
    }
}

