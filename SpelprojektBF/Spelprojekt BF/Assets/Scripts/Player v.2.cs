using System.Runtime.CompilerServices;
using UnityEngine;

public class Playerv2 : MonoBehaviour
{

    [SerializeField]
    GameObject[] UiObject;
    public int skräpTyp;
    int Uinr = 0;

    private Vector3 startPosition;
    private Vector3 currentPosition;
    private Vector3 diff;
    public float shrinkSpeed;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        currentPosition = transform.position;
        diff = currentPosition - startPosition;
        diff = diff.normalized;
        diff.y = diff.x;
        var path = GetComponent<Path>();
        if (path.enabled == true)
        transform.localScale -= diff * Time.deltaTime * shrinkSpeed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        UiObject[Uinr].SetActive(true);
        Uinr++;
        var path = GetComponent<Path>();
        path.enabled = false;
    }
}
