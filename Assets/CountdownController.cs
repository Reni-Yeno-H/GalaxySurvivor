using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;

public class CountdownController : MonoBehaviour
{
    // public int countdownTime;
    // public Text countdownDisplay;
    public GameObject countDown;

    //[SerializeField] GameObject pauseScript;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("StartDelay");    
    }

IEnumerator StartDelay()
{
    Time.timeScale = 0;
    float pauseTime = Time.realtimeSinceStartup + 3f;
    //while(countdownTime > 0 || Time.realtimeSinceStartup < pauseTime)
    while(Time.realtimeSinceStartup < pauseTime)
    
        yield return 0;
        countDown.gameObject.SetActive(false);
        Time.timeScale = 1;
        //countdownDisplay.text = countdownTime.ToString();
        //yield return new WaitForSeconds(1f);
        //countdownTime--;
        // countdownDisplay.gameObject.SetActive(false);
        // Time.timeScale = 1;
    
    //countdownDisplay.text = "GO!";
    
    //yield return 0;
    // yield return new WaitForSeconds(1f);
    // countdownDisplay.gameObject.SetActive(false);
    
}

// public void Pause()
//     {
//         pauseScript.SetActive(true);
//         Time.timeScale = 0f;
//     }

//     public void Resume()
//     {
//         pauseScript.SetActive(false);
//         Time.timeScale=1f;
//     }
}
