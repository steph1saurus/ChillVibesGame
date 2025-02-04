using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAcrossScreen : MonoBehaviour
{
    [SerializeField] private float speed = 2f;    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right *speed * Time.deltaTime);
    }
}
