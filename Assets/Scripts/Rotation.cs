using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{

    [SerializeField] float orbitalSpeed;
    [SerializeField] GameObject rotationCenter;
    
    void Update()
    {
        transform.RotateAround(rotationCenter.transform.position, new Vector3(0, 1, 0), orbitalSpeed * Time.deltaTime);
    }
}
