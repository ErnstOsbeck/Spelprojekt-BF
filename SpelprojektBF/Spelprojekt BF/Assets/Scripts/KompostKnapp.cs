using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class KompostKnapp : MonoBehaviour
{
    public Button kompostKnapp;
    public int skr�ptypKnapp;
    public Color r�ttF�rg;
    public Color felF�rg;
    public int skr�pTyp;
    



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Button knapp = kompostKnapp.GetComponent<Button>();
        knapp.onClick.AddListener(Klickadknapp);
        skr�pTyp = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().skr�pTyp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Klickadknapp()
    {
        if(skr�ptypKnapp == skr�pTyp)
        {
            ColorBlock cb1 = kompostKnapp.colors;
            cb1.normalColor = r�ttF�rg;
            cb1.highlightedColor = r�ttF�rg;
            cb1.pressedColor = r�ttF�rg;
            cb1.selectedColor = r�ttF�rg;
            cb1.disabledColor = r�ttF�rg;

            kompostKnapp.colors = cb1;
        }
        else
        {
            ColorBlock cb2 = kompostKnapp.colors;
            cb2.normalColor = felF�rg;
            cb2.highlightedColor = felF�rg;
            cb2.pressedColor = felF�rg;
            cb2.selectedColor = felF�rg;
            cb2.disabledColor = felF�rg;
            kompostKnapp.colors = cb2;
        }
    }
}
