using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayLevel : MonoBehaviour
{
    Text levelText;

    // Start is called before the first frame update
    void Start()
    {
        levelText = GameObject.Find("Level").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        levelText.text = $"Level: {Playfield.level}";
    }
}
