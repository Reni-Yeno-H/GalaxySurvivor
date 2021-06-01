using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class username : MonoBehaviour
{
    public InputField usernameInput;
    //public static string username;
    public bool alreadyName;
    // Start is called before the first frame update
    void Start()
    {
        if(alreadyName = true)
        usernameInput.text = PlayerPrefs.GetString("name");
    }

    public void SaveUsername(string newName)
    {
        alreadyName = true;
        PlayerPrefs.SetString("name", newName);
    }
    
}
