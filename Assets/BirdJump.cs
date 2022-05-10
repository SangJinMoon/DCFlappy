using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpPower;
    
    // Start is called before the first frame update 최초1번
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame 초당 60회 60fps
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 0: mouse left click
        {
            GetComponent<AudioSource>().Play(); // 효과음
            
            // velocity : 속도
            rb.velocity = Vector2.up * jumpPower; // Vector2.up = (0,1)
        }
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        // 최고점수 갱신
        if (Score.score > Score.bestScore)
        {
            Score.bestScore = Score.score;
        }

        SceneManager.LoadScene("GameOverScene"); // GameOver Scene 으로 이동
    }
}
