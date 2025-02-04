using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1f;
    public float target = 10f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3();

        if (transform.position.x < target)
        {
            move.x = 1;
        }
        move.Normalize();
        transform.position += move * Time.deltaTime * speed;
    }
}
