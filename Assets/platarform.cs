using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class platarform : MonoBehaviour
{
    
   public Vector2 FinalPosition;
    public Vector2 StartPosition;
   
    public Vector2 target;
    void Start()
    {
        
    }
    private void Awake()
    {
        target = FinalPosition;
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, target) < 0.1f) {
        
            if(target == FinalPosition)
            {
                target = StartPosition;
               

            }
            else {
                target = FinalPosition;
            }
           
        
        
        }

        transform.position = Vector2.MoveTowards(transform.position, target, Time.deltaTime);

    }
}
