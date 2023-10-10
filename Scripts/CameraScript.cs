using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField]
    Transform targetBird;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //actualitzem la posici� de l'ocell per seguir-lo amb la c�mera
        transform.position = new Vector3(targetBird.position.x, transform.position.y, transform.position.z);
    }
}
