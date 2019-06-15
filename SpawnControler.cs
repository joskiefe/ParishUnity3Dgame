using System;
using UnityEngine;
using System.Collections;
using System.Text.RegularExpressions;

public class SpawnControler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //Function for spawn calling
    public bool Input(String s)
    {
        Debug.Log("here");
        String[] split = s.Split(' ');
        if (split.Length < 2)
        {
            return false;
        }
        else if (split.Length >= 2)
        {
            if (split[0].ToUpper() == "EQUIP")
                return EoS(split,false);
            else if (split[0].ToUpper() == "SPAWN")
                return EoS(split,true);
            else
                return false;
        }
        return true;
    }
    //function for actually spawning/equiping differention
    public bool EoS(String[] text, bool type)
    {
        Debug.Log("here2");
        Regex regex = new Regex(@".+?,.+?,.+?");
        if (!type)
        {
            //call to characters equip function when implemented 
            return true;
        }
        else
        {
            if (text.Length == 2)
            {
                Instantiate(Resources.Load(text[1]), new Vector3(4.882647f, 0, 3.359211f), Quaternion.identity);
                Debug.Log("2");
                return true;
            }
            else if (text.Length == 3)
            {
                if (regex.IsMatch(text[2]))
                {
                    String[] split = text[2].Split(',');
                    Instantiate(Resources.Load(text[1]), new Vector3(Int32.Parse(split[0]), Int32.Parse(split[1]), Int32.Parse(split[2])), Quaternion.identity);
                }
                else
                    Instantiate(Resources.Load(text[1]+"/"+text[2]), new Vector3(0, 0, 5), Quaternion.identity);

                Debug.Log("3");
                return true;
            }
            else if (text.Length == 4)
            {
                Debug.Log("4");
                String[] split;
                if (regex.IsMatch(text[3]))
                { 
                    split = text[3].Split(',');
                }
                else
                    return false;
                Instantiate(Resources.Load(text[1] + "/" + text[2]), new Vector3(Int32.Parse(split[0]), Int32.Parse(split[1]), Int32.Parse(split[2])), Quaternion.identity);
            }
        }
        Debug.Log("Nope");
        return false;
    }
}
