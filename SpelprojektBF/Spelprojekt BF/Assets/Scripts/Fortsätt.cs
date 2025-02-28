using Unity.VisualScripting;
using UnityEngine;

public class Fortsätt : MonoBehaviour
{
    public GameObject UiObject;
    public Path path;
    public Path path2;
    public Path path3;
    public void OnClick()
    {
        path.enabled = true;
        path2.enabled = true;
        path3.enabled = true;
        UiObject.SetActive(false);
    }
}
