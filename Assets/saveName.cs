using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class saveName : MonoBehaviour
{
    public InputField textbox;
    
    public void clickSaveButton()
    {
        PlayerPrefs.SetString("name", textbox.text);
        
    }
}
