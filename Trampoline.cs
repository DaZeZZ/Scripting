using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
      //Changes the jump height to 10
      other.GetComponent<Jump>().jumpStrength = 10;
    }
    void OnTriggerExit(Collider other)
    {
      //Changes the jump height back to 2
      other.GetComponent<Jump>().jumpStrength = 2;
    }
}
