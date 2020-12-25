using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinComponent : MonoBehaviour
{
    private Transform myTransform;
    // Start is called before the first frame update
    void Start()
    {
        var myTransform = GetComponent<Transform>();
        Debug.Log(myTransform.position);

    }

    // Update is called once per frame
    void Update()
    {
        myTransform.Rotate(0.1f, 0.1f, 0.1f);
    }
}
