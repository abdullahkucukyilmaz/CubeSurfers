using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toplayici : MonoBehaviour
{
   public GameObject anaKup;
   public  int yukseklik;
    public GameObject elmas;
    public Text puan;
    public int puantext = 0;
    public ParticleSystem elmasef;
    void Start()
    {
       
       puan.text = "" + puantext;
    }

    
    void Update()
    {

     puan.text = " " + puantext;
        anaKup.transform.position = new Vector3(transform.position.x, yukseklik + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -yukseklik, 0);
        
    }
    public void YukseklikAzalt()
    {
        yukseklik--;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "topla" && other.gameObject.GetComponent<ToplanabilirKup>().GettoplandiMi() == false)
        {
            yukseklik += 1;
            other.gameObject.GetComponent<ToplanabilirKup>().ToplandiYap();
            other.gameObject.GetComponent<ToplanabilirKup>().IndexAyarla(yukseklik);
            other.gameObject.transform.parent = anaKup.transform;
           
        }
        if (other.gameObject.tag =="elmas")
        {
            other.gameObject.SetActive(false);
            puantext++;
            elmasef.Play();
           elmasef.transform.position=transform.position;
        }
       
    }
    

}