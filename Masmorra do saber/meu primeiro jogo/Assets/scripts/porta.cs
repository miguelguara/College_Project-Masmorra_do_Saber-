using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class porta : MonoBehaviour
{

    public float raio;
    public LayerMask p;
    bool ir;
    public string nome_cena;

    // Update is called on
    void Update()
    {
        Passar();
        if (Input.GetKeyDown(KeyCode.Space) && ir == true)
        {
            SceneManager.LoadScene(nome_cena);
        } 
        
    }
    void Passar()
    {
        Collider2D c = Physics2D.OverlapCircle(transform.position, raio,p);
        if(c != null)
        {
            ir = true;
        }
        else
        {
            ir = false;
        }


    }
    private void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, raio);
    }
}
