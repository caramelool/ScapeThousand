using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour {

    public float velocity;
    public AudioClip audioRun;

    private SpriteRenderer spriteRender;
    private Animator animator;
    private AudioSource audioSource;

    private float moveX;
    private float moveY;

    public static int GetStage() {
        return PlayerPrefs.GetInt("PLAYER_STAGE");
    }

    public static void NewStage()
    {
        int stage = GetStage() + 1;
        PlayerPrefs.SetInt("PLAYER_STAGE", stage);
        PlayerPrefs.Save();
        SceneManager.LoadScene(stage % 2);
    }

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        spriteRender = GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        moveX = Input.GetAxis("Horizontal") * velocity * Time.deltaTime;
        moveY = Input.GetAxis("Vertical") * velocity * Time.deltaTime;
        transform.Translate(moveX, moveY, 0f);

        if (moveX > 0.0f)
        {
            spriteRender.flipX = false;
        }
        else spriteRender.flipX |= moveX < 0.0f;

        float move = moveX + moveY;
        bool isMoving = move != 0f;
        //Não tinha o audio de run ):
        //if (isMoving) {
        //    PlayAudioRun();
        //}
        animator.SetBool("move", isMoving);       
	}

    private void PlayAudioRun() {
        audioSource.clip = audioRun;
        audioSource.Play();
    }
}
