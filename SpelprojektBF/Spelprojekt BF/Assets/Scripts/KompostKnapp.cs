using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class KompostKnapp : MonoBehaviour
{
    public Button kompostKnapp;
    public int skräptypknapp;
    
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Button knapp = kompostKnapp.GetComponent<Button>();
        knapp.onClick.AddListener(Klickadknapp);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Klickadknapp()
    {
        Debug.Log("you have klickat på the knappen");
    }
}
