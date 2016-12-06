using UnityEngine;
using System.Collections;

public class RotateCube : MonoBehaviour {

    public float RotationSpeed;
    public Vector3 RotationAngle = Vector3.up;

    //Monobehavior funcitons
    private void Update()
    {
        this.transform.Rotate(RotationAngle * RotationSpeed * Time.deltaTime);
    }


}
