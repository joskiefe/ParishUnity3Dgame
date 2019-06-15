using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Submit : MonoBehaviour {

    void Start()
    {
        var input = GameObject.Find("Canvas").GetComponentInChildren<InputField>();
        var se = new InputField.SubmitEvent();
        se.AddListener(SubmitName);
        input.onEndEdit = se;

        //or simply use the line below, 
        //input.onEndEdit.AddListener(SubmitName);  // This also works
    }

    private void SubmitName(string arg0)
    {
        this.GetComponent<SpawnControler>().Input(arg0);
    }
}
