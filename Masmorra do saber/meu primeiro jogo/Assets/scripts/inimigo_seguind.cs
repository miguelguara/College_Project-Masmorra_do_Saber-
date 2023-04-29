using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo_seguind : MonoBehaviour
{
    public float speed;
    public Animator an;
    private Transform alvo;
    public float area ;
    [SerializeField]
    private LayerMask player;

    // Start is called before the first frame update
    
    void Start()
    {
     alvo = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();   
    }

    // Update is called once per frame
    void Update()
    { Collider2D ar = Physics2D.OverlapCircle(transform.position, area, player);
        if(ar != null)
        {
           transform.position =  Vector2.MoveTowards(transform.position,alvo.position,speed * Time.deltaTime);
            an.SetBool("anda", true);

        }
        else
        {
            an.SetBool("anda", false);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, area);
    }
}
