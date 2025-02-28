using Unity.VisualScripting;
using UnityEngine;

public class Fortsätt : MonoBehaviour
{
    public GameObject UiObject;
    public void OnClick()
    {
        var path = GetComponent<Path>();
        path.enabled = true;
        UiObject.SetActive(true);
    }
}
