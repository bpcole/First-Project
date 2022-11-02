using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobLogic : MonoBehaviour
{
    public float speed = 3f;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Chase();
    }
    private void Chase()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }
}
