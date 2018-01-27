using UnityEngine;
using UnityEngine.Networking;

public class Move : MonoBehaviour
{   
    public float moveSpeed;
    public float rotSpeed;
    private int sprintSpeed;

    void Start() {
        moveSpeed = 3.0f;
        rotSpeed = 150.0f;
        sprintSpeed = 3;
    }
    void Update()	{
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * rotSpeed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;

        if(Input.GetKey(KeyCode.LeftShift)) {
            Debug.Log("Run");
            z = Input.GetAxis("Vertical") * Time.deltaTime * (moveSpeed + sprintSpeed);
        }
        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }
}