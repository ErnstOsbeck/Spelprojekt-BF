using Unity.VisualScripting;
using UnityEngine;

public class Fortsätt : MonoBehaviour
{
    public GameObject UiObject;
    public GameObject UiObject2;
    public GameObject UiObject3;
    public Path path;
    public Path path2;
    public Path path3;
    public KompostKnapp KompostKnapp;
    public KompostKnapp KompostKnapp2;
    public KompostKnapp KompostKnapp3;

    
    
    public void OnClick()
    {
        if (KompostKnapp.klar == true)
        {
            path.enabled = true;
            path2.enabled = true;
            path3.enabled = true;
            UiObject.SetActive(false);
            UiObject2.SetActive(false);
            UiObject3.SetActive(false);
        }
        else if (KompostKnapp2.klar == true)
        {
            path.enabled = true;
            path2.enabled = true;
            path3.enabled = true;
            UiObject.SetActive(false);
            UiObject2.SetActive(false);
            UiObject3.SetActive(false);
        }
        else if (KompostKnapp3.klar == true)
        {
            path.enabled = true;
            path2.enabled = true;
            path3.enabled = true;
            UiObject.SetActive(false);
            UiObject2.SetActive(false);
            UiObject3.SetActive(false);
        }
    }
}
