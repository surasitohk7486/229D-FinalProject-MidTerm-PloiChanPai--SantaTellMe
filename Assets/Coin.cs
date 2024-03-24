using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour {

    Rigidbody rb;
    GameObject player;
    Vector3 playerdirection;
    float timestamp;
    public bool flytoplayer;
    int speed = 800;
	void Start () {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
    }
	void Update () {
        //if (flytoplayer && Movement.isMagnet)
        //{
        //    playerdirection = -(transform.position - player.transform.position).normalized;
        //    rb.velocity = new Vector3(playerdirection.x,playerdirection.y,playerdirection.z)*speed*Time.deltaTime;

        //
    //}
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("CoinMagnet"))
        {

            flytoplayer = true;
        }
        if (other.gameObject.tag.Equals("Player"))
        {
            Destroy(gameObject);
            //Movement.score += 1;
        }
    }
}
