using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class BirdController : MonoBehaviour
{
    float speed = 10f;
    AudioSource aud;
    [SerializeField] AudioClip hitSE;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        aud = GetComponent<AudioSource>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.upArrowKey.isPressed)
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        else if(Keyboard.current.downArrowKey.isPressed)
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ball"))
        {
            aud.PlayOneShot(hitSE);
            Destroy(gameObject);
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
