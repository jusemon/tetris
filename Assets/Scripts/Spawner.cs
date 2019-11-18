using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Groups
    public GameObject[] groups;

    public Color[] colors;
    private int next;
    private GameObject currentInstance;

    public void Prepare()
    {
        next = Random.Range(0, groups.Length);
        Spawn(
            next,
            GameObject.Find("SpawnerNext").GetComponent<Component>().transform.position,
            true);
    }

    public void SpawnNext()
    {
        var i = next;
        Spawn(i, transform.position);
        Prepare();
    }

    private void Spawn(int index, Vector3 position, bool isNext = false)
    {
        // Destroy previous next
        if (currentInstance && currentInstance.GetComponent<Group>() == null)
        {
            Destroy(currentInstance);
        }

        currentInstance = Instantiate(groups[index],
            position,
            Quaternion.identity);
           
        // Get instance
        if (isNext)
        {
            Destroy(currentInstance.GetComponent<Group>());
        }

        // Setting instance colors
        var components = currentInstance.gameObject.GetComponentsInChildren<SpriteRenderer>();
        var color = colors[index];
        foreach (var item in components)
        {
            item.color = new Color(color.r, color.g, color.b);
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        // Spawn initial Group
        SpawnNext();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
