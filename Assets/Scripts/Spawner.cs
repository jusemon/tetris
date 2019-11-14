using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Groups
    public GameObject[] groups;

    public Color[] colors;

    public void spawnNext()
    {
        // Random Index
        int i = Random.Range(0, groups.Length);

        // Spawn Group at current Position
        var instance = Instantiate(groups[i],
                    transform.position,
                    Quaternion.identity);

        // Setting instance colors
        var components = instance.gameObject.GetComponentsInChildren<SpriteRenderer>();
        var color = colors[i];
        foreach (var item in components)
        {
            item.color = new Color(color.r, color.g, color.b);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        // Spawn initial Group
        spawnNext();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
