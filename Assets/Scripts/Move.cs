using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class Move : MonoBehaviour
{   
    public float moveSpeed;
    public float rotSpeed;
    private int sprintSpeed;
    private bool isSprinting;
    public float Stamina = 10;

    public Slider staminaBar;

    void Start() {
        moveSpeed = 3.0f;
        rotSpeed = 150.0f;
        sprintSpeed = 3;
        staminaBar.maxValue = 10;
        isSprinting = false;
    }
    void Update()	{
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        var rot = Input.GetAxis("Turn") * Time.deltaTime * rotSpeed;
        if(Input.GetKey(KeyCode.LeftShift)) {
            if(Stamina > 0) {
                isSprinting = true;
                z = Input.GetAxis("Vertical") * Time.deltaTime * (moveSpeed + sprintSpeed);
                Stamina -= Time.deltaTime;
            }
        } else {
            isSprinting = false;
        }
        if (!isSprinting && Stamina < 10) {
            Stamina += Time.deltaTime * 0.5f;
        }
        staminaBar.value = Stamina;
        transform.Rotate(0, rot, 0);
        transform.Translate(x, 0, 0);
        transform.Translate(0, 0, z);
    }
}