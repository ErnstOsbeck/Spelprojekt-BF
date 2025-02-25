using Unity.VisualScripting;
using UnityEngine;

public class Fortsätt : MonoBehaviour
{
    public void OnClick()
    {
        
        var path = GetComponent<Path>();
        path.enabled = true;
    }
}
