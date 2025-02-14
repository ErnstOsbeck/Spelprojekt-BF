using UnityEngine;

public class Playerv2 : MonoBehaviour
{
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
        var path = GetComponent<Path>();
        path.enabled = false;
    }
}
