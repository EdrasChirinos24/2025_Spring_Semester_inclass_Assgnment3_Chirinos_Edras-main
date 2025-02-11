using TreeEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 20;
    public GameObject projectilePrefab;

    //new code for vertical update
    public float zMin;
    public float zMax;
    public float verticalInput; 

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //horizontal input
        horizontalInput = Input.GetAxis("Horizontal");

        //Vertical input
        verticalInput = Input.GetAxis("Vertical");

        //horizontal movement
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //vertical movement
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);


        //Keep player in x bounds
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        if(transform.position.z < zMin)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMin); 
        }
        if(transform.position.z > zMax)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zMax);
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Launch a projectile from player
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
