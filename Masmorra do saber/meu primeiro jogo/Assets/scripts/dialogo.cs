using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogo : MonoBehaviour 
{
    public Sprite profile;
    public string[] speechtxt;
    public string actorName;  
    public LayerMask playerLayer;
    public float radious;


    private DialogueControl dc;
    bool onRadious;
    private void Start()
    {
        dc = FindObjectOfType<DialogueControl>();
    }
    private void FixedUpdate()
    {
        Interact();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onRadious)
        {
            dc.speech(profile,speechtxt,actorName);
        }
    }
    public void Interact()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, radious, playerLayer);
        if(hit != null)
        {
            onRadious = true; 
        }
        else
        {
            onRadious=false;
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radious);
    }
}
