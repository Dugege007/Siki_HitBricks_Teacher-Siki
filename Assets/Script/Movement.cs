using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //transform.Translate(Vector3.left);
    }

    // Update is called once per frame
    void Update()
    {

        float h = Input.GetAxis("Horizontal");//0~-1 0~1 加速变化
        float v = Input.GetAxis("Vertical");//0~-1 0~1 加速变化
        transform.Translate(new Vector3(h, v, 0) * Time.deltaTime * 5);
    }

}
