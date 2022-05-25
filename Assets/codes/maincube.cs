using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maincube : MonoBehaviour
{
     public Animator anim;
    public Animator animhappy;
    int score;
    bool carptý = true;
    string scoret = "Engel";
     Toplayici toplayicii;
    bool move;
    int scoree;
    public bool carptý1 = false;
    void Start()
    {
        move = true;
        anim.GetComponent<Animator>();
        toplayicii =Object.FindObjectOfType<Toplayici>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Engel" && carptý1)
        {
            move = false;
            animhappy.SetBool("happy", true);
            transform.Rotate(0, 180, 0);

            scoree = toplayicii.yukseklik * 2;
            Debug.Log(scoree.ToString());

        }
        if (other.gameObject.tag =="Engel"&& carptý)
        {
            anim.SetBool("dead1",true);
            move = false;
        }
        if (other.gameObject.tag == "scoregiris")
        {
            carptý = false;
            carptý1 = true;

        }
        
            
            
            scoret =scoret+score.ToString();
        
    }
    public bool SetMove()
    {
        return move;
    }
}
