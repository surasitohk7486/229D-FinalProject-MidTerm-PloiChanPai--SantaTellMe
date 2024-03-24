using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMagnet : MonoBehaviour
{
    public bool flytoplayer;
    private float speed = 1500;
    Rigidbody rb;
    GameObject player;
    Vector3 playerDirection;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (flytoplayer && Magnet.isMagnet)
        {
            playerDirection = -(transform.position - player.transform.position).normalized;
            rb.velocity = new Vector3(playerDirection.x, playerDirection.y, playerDirection.z) * speed * Time.deltaTime;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Equals("MagnetArea"))
        {
            flytoplayer = true;
        }
        if (other.tag == "Player")
        {
          Destroy(gameObject);
        }
    }
}
