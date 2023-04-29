using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigo : MonoBehaviour
{
    public Sprite Sprite;
    public string perg;
    public string rv;
    public string rf1;
    public string rf2;
    public LayerMask playerlayer;
    public float radious; 
    public GameObject enemy;

    private ControleCombate cc;

    private void Start()
    {
         cc = FindObjectOfType<ControleCombate>();
    }

    // Update is called once per frame
    void Update()
    {
        RaiodeCombate();  
    }

    void RaiodeCombate()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, radious, playerlayer);
        if(hit != null)
        {
            cc.combate(Sprite,perg,rv,rf1,rf2);
            Destroy(enemy);
        }
    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, radious); 
    }

}
