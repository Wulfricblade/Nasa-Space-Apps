using UnityEngine;

public class MovementScript : MonoBehaviour
{
    [SerializeField] int moveSpeed = 2;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    double x = 0.1;
    // Update is called once per frame
    void Update()
    {
        movePlayer();
    }

    void movePlayer()
    {
        float xAxis = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yAxis = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xAxis, yAxis, 0);
    }
}
