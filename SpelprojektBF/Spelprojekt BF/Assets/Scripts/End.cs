using UnityEngine;

public class End : MonoBehaviour
{
    public GameObject UI;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        UI.SetActive(true);
        
    }
}
