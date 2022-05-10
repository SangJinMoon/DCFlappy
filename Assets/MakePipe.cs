using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float timeDiff;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 1초마다 생성되도록 수정
        timer += Time.deltaTime; // fps 에 맞게 매 프레임이 걸린 시간
        if (timer > timeDiff)
        {
            GameObject newPipe = Instantiate(pipe); // pipe 생성

            newPipe.transform.position = new Vector3(6, Random.Range(-0.5f, 4.5f), 0); // 위치 설정

            timer = 0;

            Destroy(newPipe, 10.0f); // 사라질 시간 설정
        }
    }
}
