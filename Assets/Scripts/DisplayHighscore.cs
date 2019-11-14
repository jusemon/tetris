using UnityEngine;
using UnityEngine.UI;

public class DisplayHighscore : MonoBehaviour
{
    Text highscoreText;

    // Start is called before the first frame update
    void Start()
    {
        highscoreText = GameObject.Find("Highscore").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        var highscore = PlayerPrefs.GetInt("highscore", 0);
        highscoreText.text = $"Highscore: {highscore}";
    }
}
