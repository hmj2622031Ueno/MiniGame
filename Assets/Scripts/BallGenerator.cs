using UnityEngine;

public class BallGenerator : MonoBehaviour
{
    [SerializeField] GameObject ballPrefab;
    float m_span = 0.3f;
    float delta = 0;
    float m_speed = -0.03f;

    public void SetParameter(float span, float speed)
    {
        m_span = span;
        m_speed = speed;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > m_span)
        {
            delta = 0;
            GameObject ball = Instantiate(ballPrefab);
            int eagleX = Random.Range(-4, 6);
            ball.transform.position = new Vector3(10, eagleX, 0);
            ball.GetComponent<BallController>().SetMoveSpeed(m_speed);
            
        }
    }
}
