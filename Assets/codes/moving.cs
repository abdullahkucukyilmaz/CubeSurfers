using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moving : MonoBehaviour
{
    [SerializeField]   private float forwardSpeed;
    [SerializeField]   private float rightleftSpeed;
    float zPosition;
    maincube mainn;
    void Start()
    {
        mainn = Object.FindObjectOfType<maincube>();
    }
  

    
    void Update()
    {
        if(mainn.SetMove())
        {
            zPosition = Input.GetAxis("Horizontal") * rightleftSpeed * Time.deltaTime;
            this.transform.Translate(zPosition, 0, forwardSpeed * Time.deltaTime);
            transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.Clamp(transform.position.z, -4.5f, 4.5f));

        }


    }
}
