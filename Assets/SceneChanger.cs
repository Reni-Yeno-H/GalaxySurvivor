using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class SceneChanger : MonoBehaviour
{
    // public InputField input;
    public void changeScene(string scene_name){
        // PersistentData.Instance.SetName(input.text);
        SceneManager.LoadScene(scene_name);
    }

    // public void setName()
    // {
    //     PersistentData.Instance.SetName(input.text);
    // }
}
