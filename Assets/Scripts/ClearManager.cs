using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ClearManager : MonoBehaviour
{
    AudioSource aud;
    [SerializeField] AudioClip gameClearSE;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        aud = GetComponent<AudioSource>();
        aud.PlayOneShot(gameClearSE);
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.rKey.isPressed)
        {
            SceneManager.LoadScene("GameScene");
        }
    }
}
