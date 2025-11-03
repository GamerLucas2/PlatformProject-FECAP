using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

public class PlayerMovementCs : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    bool isAlive = true;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isAlive = false;
        gameObject.SetActive(false);
    }

}
