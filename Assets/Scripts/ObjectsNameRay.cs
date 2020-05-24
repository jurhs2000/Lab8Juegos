using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsNameRay : MonoBehaviour
{
    public GameObject canvas;
    public UnityEngine.UI.Text text;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hitInfo;
        Vector3 rayOrigin = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
        if (Physics.Raycast(rayOrigin, transform.forward, out hitInfo, 6f))
        {
            if (hitInfo.collider.CompareTag("Target"))
            {
                canvas.SetActive(true);
                text.text = hitInfo.collider.gameObject.name;
            } else
            {
                canvas.SetActive(false);
            }
        }
    }
}
