using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Destroy objects on collisions
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Horse"))
        {
            Debug.Log("Horse, game over!");
        }
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
