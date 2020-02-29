/*
 * Matt Kirchoff
 * laser.cs
 * CIS452 Assignment 5
 * laser ammo for factory
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class laser : MonoBehaviour
{
    private float speed;
    public Score score;
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("Score").GetComponent<Score>();
        speed = 15f;
        Invoke("offFix", 3f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Equals("laser"))
        {
            score.score += 1;
            Destroy(collision.gameObject);
            Destroy(this.gameObject);
            
        }
        else if (collision.gameObject.tag.Equals("bullet"))
        {
            score.score -= 1;
            Destroy(this.gameObject);
            
        }
        else if (collision.gameObject.tag.Equals("rocket"))
        {
            score.score -= 1;
            Destroy(this.gameObject);
        }
    }
    void OnEnable()
    {
        gameObject.GetComponent<SpriteRenderer>().material.color = Color.red;
    }

    void offFix()
    {
        Destroy(this.gameObject);
    }
}
