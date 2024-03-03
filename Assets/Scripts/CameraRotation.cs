using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour
{
 public Transform CameraAxisTransform;

 public float minAngle;
 public float maxAngle;

  public float RotationSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      transform.localEulerAngles = new Vector3(0, transform.localEulerAngles.y + Time.deltaTime * RotationSpeed * Input.GetAxis("Mouse X") , 0);
      
      var newAnglesX = CameraAxisTransform.localEulerAngles.x - Time.deltaTime * RotationSpeed * Input.GetAxis("Mouse Y");
      if (newAnglesX > 180)
      newAnglesX -= 360;
      
      newAnglesX = Mathf.Clamp(newAnglesX, minAngle, maxAngle);
      

      CameraAxisTransform.localEulerAngles = new Vector3(newAnglesX , 0 , 0);

    }
}