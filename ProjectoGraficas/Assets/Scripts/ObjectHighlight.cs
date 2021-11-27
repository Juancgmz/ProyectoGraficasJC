using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectHighlight : MonoBehaviour
{
    public GUISkin gameSkin;
    public string objectName;
    Renderer rend;

    private Color startColour;
    private bool _displayObjectName = false;

    private void Start()
    {
        rend = GetComponent<Renderer>();
    }
    void OnGUI()
    {
        GUI.skin = gameSkin;

        DisplayName();
    }

    void OnMouseEnter()
    {
        startColour = rend.material.color;
        rend.material.color = Color.green;
        _displayObjectName = true;
    }

    void OnMouseExit()
    {
        rend.material.color = startColour;
        _displayObjectName = false;
    }

    public void DisplayName()
    {
        if(_displayObjectName == true)
        {

        }
    }
}
