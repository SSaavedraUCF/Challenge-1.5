using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public AudioSource musicSource; // For the game object to be place

    public AudioClip musicClipOne; //holder for variable 1

    public AudioClip musicClipTwo; //holder for variable 2

    Animator anim;

    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W)) //holding down W will play musicClipone
        {
            musicSource.clip = musicClipOne;
            musicSource.Play();
            anim.SetInteger("State", 1);
        }

        if (Input.GetKeyUp(KeyCode.W)) //letting go will stop musicClipone
        {
            musicSource.Stop();
            anim.SetInteger("State", 0);

        }

        if (Input.GetKeyDown(KeyCode.R)) //R will play musicCliptwo
        {
            musicSource.clip = musicClipTwo;
            musicSource.Play();
            anim.SetInteger("State", 2);
        }

        if (Input.GetKeyUp(KeyCode.R))//Letting go will stop musicCliptwo
        {
            musicSource.Stop();
            anim.SetInteger("State", 0);

        }

        if (Input.GetKeyDown(KeyCode.L)) //holding L will repeat the song
        {
            musicSource.loop = true;
        }

        if (Input.GetKeyUp(KeyCode.L))// if let go or not held at all, the music will disappear into the darkness
        {
            musicSource.loop = false;
        }
    }
}
