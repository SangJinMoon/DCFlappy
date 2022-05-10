using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Debug.Log(transform.position);

        // Vector3 : x, y, z
        // Time.deltaTime : 지난 프레임이 완료되는데 걸린 시간 (6fps => 1/6)
        transform.position += Vector3.left * speed * Time.deltaTime; // (-1, 0 , 0) fps 보정을 위해 Time.deltaTime을 곱해줌
    }
}
