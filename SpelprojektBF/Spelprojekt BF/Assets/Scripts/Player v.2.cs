using UnityEngine;

public class Playerv2 : MonoBehaviour
{
    public float speed = 1f;
    public float target = 10f;
    public GameObject UiObject;
    public int skräpTyp;

    void Start()
    {

    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        UiObject.SetActive(true);
    }
}
