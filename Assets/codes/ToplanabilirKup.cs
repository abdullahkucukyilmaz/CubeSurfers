using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToplanabilirKup : MonoBehaviour
{
    bool toplandımi;
    int index;
    public Toplayici toplayicii;
    void Start()
    {
        toplandımi = false;
    }
    void Update()
    {
        if (toplandımi == true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }

        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Engel")
        {
            toplayicii.YukseklikAzalt();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
    public bool GettoplandiMi()
    {
        return toplandımi;
    }
    public void ToplandiYap()
    {
        toplandımi = true;
    }
    public void IndexAyarla(int index)
    {
        this.index = index;
    }
}