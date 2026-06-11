using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject timerText;
    [SerializeField] float time = 5.0f;
    [SerializeField] GameObject generator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time < 0)
        {
            time = 0;
            SceneManager.LoadScene("ClearScene");
        }
        timerText.GetComponent<TextMeshProUGUI>().text = time.ToString("F1");
    }
}
