using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour{
   
    public float speed;
    public float jumpForce;
    public Text countText;
    public Text winText;
    public Text loseText;
    public Text livesText;
public AudioClip musicClipOne;
public AudioClip musicClipTwo;
public AudioSource musicSource;

    private Rigidbody2D rb2d;
    private int count;
    private int lives;
    
    // Start is called before the first frame update
    void Start() {
        rb2d = GetComponent<Rigidbody2D>();

        count = 0;
        lives = 3;
        winText.text = "";
        loseText.text = "";
        SetCountText ();
        if (Input.GetKeyDown(KeyCode.Space))
    {
        musicSource.clip = musicClipOne;
        musicSource.Play();
    }
    if (Input.GetKeyUp(KeyCode.Space))
    {
        musicSource.Stop();
    }
        
    }

    // Update is called once per frame
    void Update() {
        
    }

        void FixedUpdate()
        {
            float moveHorizontal = Input.GetAxis("Horizontal");

            Vector2 movement = new Vector2(moveHorizontal, 0);
            rb2d.AddForce(movement * speed);

            if (Input.GetKey("escape"))
     Application.Quit();
        }


        void OnCollisionStay2D(Collision2D collision)
        {
            if(collision.collider.tag == "Ground"){
                if(Input.GetKey(KeyCode.UpArrow)){
                    rb2d.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
                }
            }
        }

         void OnTriggerEnter2D(Collider2D other) 
    {
        
        if (other.gameObject.CompareTag("PickUp"))
                {
                     other.gameObject.SetActive(false);
                     count = count + 1;
                     SetCountText ();
                }
                 else if (other.gameObject.CompareTag("Enemy"))
                {
                    other.gameObject.SetActive(false);
                    lives = lives - 1;
                    SetCountText ();}
               
                if (count == 5)
               {
                    transform.position = new Vector2(72.71f, -2.24f);
                    lives = 3;
                    SetCountText ();
               }
    }


    void SetCountText()
    {
        
        countText.text = "Count: " + count.ToString ();
        livesText.text = "Lives : " + lives.ToString ();
        
        if (count >= 12)
            
            winText.text = "You win!";
    

     if (lives == 0)
        {
            loseText.text = "You Lose!";
            Destroy(gameObject);
        }
}
}


