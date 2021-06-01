using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class saveNames : MonoBehaviour
{
    public Text textbox;
    
    public void savedName()
    {
        PlayerPrefs.SetString("name", textbox.text);
        
    }
}
