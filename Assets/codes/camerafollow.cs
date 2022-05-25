using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public GameObject target;
    public Vector3 mesafe;
    void Start()
    {
        
    }

   
    private void LateUpdate()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, target.transform.position + mesafe, Time.deltaTime);
    }
}
