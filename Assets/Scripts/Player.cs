using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Joystick joystick;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        var eulerAngle = Quaternion.Euler(new Vector3(0, 0, Mathf.Atan2(joystick.Vertical, joystick.Horizontal) * 180 / Mathf.PI));
        transform.rotation = eulerAngle;
    }
}
