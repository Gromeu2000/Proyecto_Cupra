using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayPause : MonoBehaviour
{

    [SerializeField] private Sprite[] buttonSprites;
    [SerializeField] private Image targetButton;

    public AudioClip song1;
    private AudioSource audioSource;

    private bool paused1;
    private bool paused2;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        
    }

    

public void ChangeSprite()

    {
        if(targetButton.sprite == buttonSprites[0])
        {
           

            targetButton.sprite = buttonSprites[1];
            return;
        }

        targetButton.sprite = buttonSprites[0];
    }
   
}
