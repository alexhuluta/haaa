using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUI_Script : MonoBehaviour
{
    public int temPoint;
    public int point;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = "Score: " + point;
    }
}
