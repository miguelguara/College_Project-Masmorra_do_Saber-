using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed;
    public Animator an;   

    // Update is called once per frame
    void Update()
    { 
        Vector3 movimento = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),0f);
        an.SetFloat("Horizontal", movimento.x);
        an.SetFloat("Vertical", movimento.y);
        an.SetFloat("Speed", movimento.magnitude); 

        transform.position = transform.position + movimento * speed * Time.deltaTime;

    }
}
