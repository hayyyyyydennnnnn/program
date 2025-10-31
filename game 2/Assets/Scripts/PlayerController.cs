using UnityEngine;

public class PlayerController : MonoBehaviour
{
   private Rigidbody playerRb;
   public float speed = 5.0f;
   private GameObject focalPoint;
   public bool hasPowerup = false;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("Focal point");
    }

    
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Powerup"))
        {
            hasPowerup = true;
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy") && hasPowerup)
        {
            Debug.Log("Collided with: " + collision.gameObject.name + " with powerup set to " + hasPowerup);
        }
    }
}
