using UnityEngine;

public class Boru : MonoBehaviour
{
    public float speed;
    private void Start()
    {
        Destroy(gameObject, 4);
    }

    void FixedUpdate()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
