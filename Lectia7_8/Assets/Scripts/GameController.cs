using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject blockPrefab;
    public GUI_Script gui;
    Vector2 blockPos;
    int amount = 16;
    float xPos, screenX;
    public List<GameObject> blocks;//lista de tip GameObject unde vom stoca blocurile care trebuie eliminate
    void Start()
    {
        screenX = Vector2.Distance(Camera.main.ScreenToWorldPoint(new Vector2(0, 0)),
            Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0))) *0.5f;
        SpawnBlocks();

    }
    public void SpawnBlocks()
    {
        xPos = (Camera.main.transform.position.x - screenX);
        blockPos = new Vector3(xPos, 3f);
        blocks.Add(Instantiate(blockPrefab, blockPos, Quaternion.identity, transform));

        for(int i = 0; i < amount - 1; i++)
        {
            xPos += 1f;
            if(Random.Range(1, 100) >= 30)
            {
                blockPos = new Vector3(xPos, 3f);
                blocks.Add(Instantiate(blockPrefab, blockPos, Quaternion.identity, transform));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
