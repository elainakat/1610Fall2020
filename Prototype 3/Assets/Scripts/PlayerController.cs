using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    
    public float jumpForce;
    public float gravityModifier;
    public bool isOnGround;
    public bool gameOver = false;
    
    private Animator playerAnim;
    
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParicle;
    
    public AudioClip jumpSound;
    public AudioClip crashSound;
    private AudioSource playerAudio;
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
            dirtParicle.Stop();
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }

    private void OnCollisionEnter(Collision collision0)
    {
        if (collision0.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            dirtParicle.Play();
        }
        else if (collision0.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Game Over.");
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            explosionParticle.Play();
            dirtParicle.Stop();
            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }
}
