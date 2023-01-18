using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    private float topBound = 30;
    private float lowerBound = -10;
    //** Create a float variable below that is set to the X value of when animals leave the screen and name it sideBounds**//
    private float sideBounds = 26;
    GameManager GameManagerScript;

    // Start is called before the first frame update

    void Start()
    {
        GameManagerScript = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBound)
        {
            Destroy(gameObject);  
        }
        else if (transform.position.z < lowerBound || transform.position.x > sideBounds || transform.position.x < -sideBounds)
            {
                //** Pass an integer in the method below that reduces your player's life **//
                GameManagerScript.UpdateLives(-1);
                Debug.Log("Game Over!");
                Destroy(gameObject);
            }
        
    }
}
