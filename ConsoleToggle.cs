using System;
using UnityEngine;
using System.Collections;
using System.Linq.Expressions;
using UnityEngine.UI;

public class ConsoleToggle : MonoBehaviour
{


    public InputField Simple;
    // Use this for initialization
    void Start ()
	{
        Simple = GameObject.Find("Canvas").GetComponentInChildren<InputField>();
        Simple.interactable = false;
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKeyDown("`"))
	    {
            Simple.interactable = !Simple.interactable;

	        if (!Simple.interactable)
	        {
                Simple.textComponent.color = new Color(0, 0, 0, 0);
            }
            else
                Simple.textComponent.color = new Color(0, 0, 0, 255);

            Simple.text = String.Empty;
        }
	}
}
