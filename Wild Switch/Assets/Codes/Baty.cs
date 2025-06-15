using UnityEngine;

public class Baty : MonoBehaviour
{
    public float velocity = 1f;
    public Rigidbody2D rb2D;
    public bool isDead;
    public GameManager managerGame;
    void Update()
    {
        // T�klamay� al
        if (Input.GetMouseButtonDown(0))
        {
            // Havada ku�u s��rat
            rb2D.linearVelocity = Vector2.up * velocity;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "ScoreArea")
        {
            managerGame.UpdateScore();
        }
    }
}
