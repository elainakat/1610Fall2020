

using UnityEngine;

public class MoverScript : MonoBehaviour
{
    public float speed = 50f;

    public float x, y, z;

    //public float rotationVector3;
    
    void Start()
    {
        Debug.Log(message: "Hello World!");
    }
    
    void Update()
    {
        x = speed * Input.GetAxis("Horizontal") * Time.deltaTime;
        y = speed * Input.GetAxis("Vertical") * Time.deltaTime;

        //var vInput:float = speed * Input.GetAxis("Vertical") * Time.deltaTime;
        //var vInput:float = speed * Input.GetAxis("Vertical") * Time.deltaTime;

        transform.Translate(x, y, z);
    }
    

    public void Up()
    {
        print(message: "Up.");
        transform.Translate(0, speed, 0);
    }

    public void Down()
    {
        print(message: "Down.");
        transform.Translate(0, -speed, 0);
    }
    
    public void Left()
    {
        print(message: "Left.");
        transform.Translate(-speed, 0, 0);
    }
    
    public void Right()
    {
        print(message: "Right.");
        transform.Translate(speed, 0, 0);
    }

    //private void Update()
    //{
    //    rotationVector3.y = speed * Time.deltaTime;
    //    transform.Rotate(rotationVector3);
    //}
}
