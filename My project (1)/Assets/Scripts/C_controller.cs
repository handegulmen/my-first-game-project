using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class C_controller : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public Text scoreText;
    private float score;
    public Transform cam;
    public GameObject panel;


    void Start()
    {
        Time.timeScale = 1;

    }

    private void Update()
    {
        if (rb.velocity.y > 0 && transform.position.y > score)
        {
            score = transform.position.y;

        }
        scoreText.text = Mathf.Round(score).ToString();

        if (cam.position.y > transform.position.y + 7f)
        {
            Time.timeScale = 0;
            panel.SetActive(true);

        }

    }



    void FixedUpdate()
    {
        float moveX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(
            moveX * speed,
            rb.velocity.y
            );

    }
    public void playAgain()
    {
        SceneManager.LoadScene(1);
    }
    public void exit()
    {
        SceneManager.LoadScene(0);
    }

    public bool oyundurumu = false;

    public void oyundurdur()
    {
        if (oyundurumu == false)
        {
            Time.timeScale = 0f;
            oyundurumu = true;

        }
        else
        {
            Time.timeScale = 1f;
            oyundurumu = false;

        }



    }
}
