using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class resetScore : MonoBehaviour
{
    public Text NameBox;
    // Start is called before the first frame update
    void Start()
    {
        if(NameBox != null)
        {
        NameBox.text = PlayerPrefs.GetString("score");
        }
    }

    public void ResetSavedScore()
    {
        PlayerPrefs.DeleteKey("score");
        SceneManager.LoadScene("Credits");
    }
    
}
