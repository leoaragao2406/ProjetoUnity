using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    AudioSource audio;
    public float speed;
    public AudioClip enemySound;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        rb.MovePosition(rb.position + movement.normalized * speed * Time.fixedDeltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coletavel"))
        {
            audio.Play();
            GameController.AddCollectible();
            FindObjectOfType<Timer>().DecreaseTime(2f);
            Destroy(other.gameObject);
        }
        else if (other.gameObject.CompareTag("InimigoLosango"))
        {
            audio.PlayOneShot(enemySound);
            FindObjectOfType<Timer>().timeElapsed += 2f; // Aumenta 2 segundos
            Destroy(other.gameObject); // Opcional: remove o inimigo após contato
        }
    }
}
 