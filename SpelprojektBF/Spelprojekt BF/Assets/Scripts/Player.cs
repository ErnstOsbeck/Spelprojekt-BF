using UnityEngine;

public class Player : MonoBehaviour
{

    Vector3 move = new Vector3();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < 5)
        {
            move.x = 1;
        }
    }
}
