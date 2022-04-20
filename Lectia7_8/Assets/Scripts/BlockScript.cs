using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int healthPoint;
    public GameObject blockText;
    void Start()
    {
        healthPoint = Random.Range(1, 30);
    }

    // Update is called once per frame
    void Update()
    {
        blockText.GetComponent<Text>().text = healthPoint.ToString();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            healthPoint--;
        }
        
           if(healthPoint <= 0)
        {
            Destroy(gameObject);
        }
        
               
        
    }
}
