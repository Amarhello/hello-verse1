using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class enemy_controller : MonoBehaviour
{
    public float Speed = 5f;


    public float FOV = 10f;

    public int Hlt = 100;

    public int damage = 10;

    public Transform PlayerPosition;

    private void Awake()
    {
        PlayerPosition = GameObject.FindGameObjectWithTag("Player").transform;
       
    }


    void Start()
    {
    
    }

    // Update is called once per frame
    private void Update()
    { 
        if (Vector2.Distance(transform.position, PlayerPosition.position) < FOV) { 
        Vector2 direction = (PlayerPosition.position - transform.position).normalized; 
                transform.position += (Vector3)direction * Speed * Time.deltaTime;
        
        }
        
        
        
        
    }
}
