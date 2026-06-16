using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    AudioSource aud;
    [SerializeField] AudioClip titleSE;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        aud = GetComponent<AudioSource>();
        aud.PlayOneShot(titleSE);
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.enterKey.isPressed)
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
