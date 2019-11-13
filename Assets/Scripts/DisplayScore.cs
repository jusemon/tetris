using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = GameObject.Find("Score").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = $"Score: {Playfield.score}";
    }
}
