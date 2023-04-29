using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ControleCombate : MonoBehaviour 
{
    [Header("componentes")]
    public GameObject objdialogo;
    public Image enemyimage;
    public Text pergunta;
    public Text respostav;
    public Text respostaf1;
    public Text respostaf2;
    private int count;  


    public void combate(Sprite s, string p, string rv, string f1, string f2)
    {
        objdialogo.SetActive(true);
        enemyimage.sprite = s;
        pergunta.text = p;
        respostav.text = rv;
        respostaf1.text = f1; 
        respostaf2.text = f2;

    }

    public void Respostacerta()
    {
        objdialogo.SetActive(false);
        enemyimage.sprite = null;
        pergunta.text = null;
        respostav.text = null;
        respostaf1.text=null;
        respostaf2.text=null;
        count = 0;
    }
    public void RespostaErrada()
    {
        count++;
        if (count == 2)
        {
            SceneManager.LoadScene("MENU");  
        } 
    }
}
