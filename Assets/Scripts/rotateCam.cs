using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateCam : MonoBehaviour
{
    public float rotationSpeed;
    public float coneWidth;
    public float turnAngle;

    // Update is called once per frame
    private void Update()
    {
        transform.localEulerAngles = new Vector3(0, 0, Mathf.PingPong(Time.time * rotationSpeed, coneWidth) - turnAngle);

    }
}
