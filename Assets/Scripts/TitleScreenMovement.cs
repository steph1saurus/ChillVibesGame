using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreenMovement : MonoBehaviour
{
    private Vector3 direction = Vector3.left;
    [SerializeField] private float speed = 5f;
   
    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction*speed * Time.deltaTime);
        if (transform.localPosition.x <=-20)
        {
            direction = Vector3.right;
        }
        
        else if (transform.localPosition.x >=20)
        {
            direction = Vector3.left;
        }
        
        
    }
}
