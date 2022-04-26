using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
   
    void Update()
    {
        if(GameManager.singleton.GameStarted && !GameManager.singleton.GameEnded)
        transform.Translate(Vector3.forward * 5 * Time.deltaTime,Space.World);
    }
}
