using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballCaster : MonoBehaviour
{
  public Fireball fireballPrefab;
  public Transform FireballSourceTransform;

  private void Update()
  {
        if (Input.GetMouseButtonDown(0))
        {
        Instantiate(fireballPrefab, FireballSourceTransform.position, FireballSourceTransform.rotation);
        }
  }
  }