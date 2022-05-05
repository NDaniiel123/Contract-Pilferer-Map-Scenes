using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatchingEnemy : MonoBehaviour
{
    public float rotationSpeed;
    public float distance = 10;
    public float angle = 30;
    public float height = 1.0f;
    public Color meshColor = Color.red;
    // Update is called once per frame
    private void Update()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
