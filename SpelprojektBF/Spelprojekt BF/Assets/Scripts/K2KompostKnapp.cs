using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class K2KompostKnapp : MonoBehaviour
{
    public Button k2kompostKnapp;
    public int skräptypKnapp;
    public Color rättFärg;
    public Color felFärg;
    public int skräpTyp;




    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Button knapp = k2kompostKnapp.GetComponent<Button>();
        knapp.onClick.AddListener(Klickadknapp);
        skräpTyp = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().skräpTyp;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Klickadknapp()
    {
        if (skräptypKnapp == skräpTyp)
        {
            ColorBlock cb1 = k2kompostKnapp.colors;
            cb1.normalColor = rättFärg;
            cb1.highlightedColor = rättFärg;
            cb1.pressedColor = rättFärg;
            cb1.selectedColor = rättFärg;
            cb1.disabledColor = rättFärg;

            k2kompostKnapp.colors = cb1;
        }
        else
        {
            ColorBlock cb2 = k2kompostKnapp.colors;
            cb2.normalColor = felFärg;
            cb2.highlightedColor = felFärg;
            cb2.pressedColor = felFärg;
            cb2.selectedColor = felFärg;
            cb2.disabledColor = felFärg;
            k2kompostKnapp.colors = cb2;
        }
    }
}
