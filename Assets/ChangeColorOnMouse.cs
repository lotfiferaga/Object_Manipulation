using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnMouse : MonoBehaviour
{
    private Color basicColor = Color.green;
    private Color hoverColor = Color.red;
    private Renderer renderer;
    // Start is called before the first frame update
    void Start()
    {
            renderer = GetComponent<Renderer>();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseEnter() {
    renderer.material.color = hoverColor;
    }
 
    void OnMouseExit() {
    renderer.material.color = basicColor;
    }
}
