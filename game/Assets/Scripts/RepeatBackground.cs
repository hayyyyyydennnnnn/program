using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    private Vector3 startPos;
    void Start()
    {
        startPos = transform.position;
    }

  
    void Update()
    {
        if (transform.position.x < startPos.x - 70)
        {
            transform.position = startPos;
        }
    }
}
