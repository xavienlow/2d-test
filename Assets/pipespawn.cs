using UnityEngine;

public class pipespawn : MonoBehaviour
{
    public GameObject pipe;
    public float spawnrate = 2;
    public float timer = 0;
    public float heightchange = 10;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnpipe();
    }

    void spawnpipe()
    {
        float lowest = transform.position.y - heightchange;
        float highest = transform.position.y + heightchange;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowest,highest), 0), transform.rotation);
    }


    // Update is called once per frame
    void Update()
    {
        if (timer < spawnrate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnpipe();
            timer = 0;
        }

    }

}
