using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EN_SAN : MonoBehaviour
{
   public float speed;
   private Transform P;
    public LayerMask play;
    public float ar;


    void Start()
    {
        P = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D collider = Physics2D.OverlapCircle(transform.position,ar,play);
        if(collider != null)
        {
            transform.position = Vector2.MoveTowards(transform.position,P.position,speed*Time.deltaTime);
        }
        
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, ar);
    }
}
