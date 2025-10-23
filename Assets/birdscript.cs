using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapstrength;
    public logic logic;
    public bool birdalive = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && birdalive == true)
        {
            myRigidbody.linearVelocity = Vector2.up * flapstrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameover();
        birdalive = false;
    }
}
