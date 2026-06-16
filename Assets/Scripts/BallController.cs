using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] float moveSpeed;
    [SerializeField] GameObject eagle;

    public void SetPlayer(GameObject e) {  eagle = e; }

    public void SetMoveSpeed(float speed) {  moveSpeed = speed; }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ƒtƒŒ[ƒ€–ˆ‚ÉˆÚ“®
        transform.Translate(moveSpeed, 0, 0);

        if(transform.position.x < -10f)
        {
            Destroy(gameObject);
        }      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("eagle"))
        {
            Destroy(gameObject);
        }
    }
}
