using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    private float bounces = 0.0f;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "BotomCollider")
        {
            Destroy(gameObject);
        }
        if(other.gameObject.name!="BottomCollider" && other.gameObject.tag!="Block")
        {
            bounces++;
            if(bounces >= 6)
            {
                Destroy(gameObject);
            }
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
