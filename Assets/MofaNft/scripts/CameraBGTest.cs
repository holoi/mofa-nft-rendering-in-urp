using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBGTest : MonoBehaviour
{
    [SerializeField] bool trigger = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (trigger)
        {
            Camera.main.backgroundColor = Color.white;
        }
    }
}
