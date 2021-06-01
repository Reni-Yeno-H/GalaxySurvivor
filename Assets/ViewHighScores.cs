using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ViewHighScores : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Text[] nameTexts;
    [SerializeField] Text[] scoreTexts;

    public const string NAME_KEY = "Name";
    public const string SCORE_KEY = "Score";
    public int playerHighest = 2;
    void Start()
    {
        for(int i = 0; i< playerHighest; i++)
        {
            nameTexts[i].text = PlayerPrefs.GetString(NAME_KEY + i);
            //scoreTexts[i].text = PlayerPrefs.GetInt(SCORE_KEY + i).ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
