using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float speed;
    public int health;
    int score;
    public TMP_Text healthPoints;
    public TMP_Text scoreBoard;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * speed * Input.GetAxisRaw("Horizontal") * Time.deltaTime);
/*        if(Input.GetKeyDown(KeyCode.D))
        {
            transform.Rotate(transform.position.x, transform.position.y, transform.position.y - speed);
        }
        else if(Input.GetKeyDown(KeyCode.A))
        {
            transform.Rotate(transform.position.x, transform.position.y, transform.position.y + speed);
        }*/
    }
    public void TakeDamage()
    {
        health--;
        healthPoints.text = "Health: " + health;
        if(health <= 0)
        {
            SceneManager.LoadScene("Game");
        }
    }
    public void AddScore()
    {
        score++;
        scoreBoard.text = "Score: " + score;
    }
}
