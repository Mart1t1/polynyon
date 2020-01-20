using UnityEngine;
using UnityEngine.SceneManagement;

public class Mouvement : MonoBehaviour
{

   
    public Rigidbody rb;
    public int Force = 2000;
    public float G_D = 500f;
    public float speed = 5.0f;
    public Transform CAM;
    public GameObject Boule;
    public Transform BouleTransform;
    public Camera Camera1;
    private float X = 0.0f;
    
    

    void Start()
    {
     
    }
    

    // Update is called once per frame
    void FixedUpdate()
    {
        

        if (Input.GetKey("z"))
        {
            transform.Translate(new Vector3(0, 0, Force) * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            transform.Translate(new Vector3(0, 0, -Force) * Time.deltaTime);

        }
        if (Input.GetKey("q"))
        {
            transform.Rotate(0.0f, -100.0f * Time.deltaTime, 0.0f);
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(0.0f, 100.0f * Time.deltaTime, 0.0f);
        }
    


        /*if (transform.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
            
        }*/
    }
}
