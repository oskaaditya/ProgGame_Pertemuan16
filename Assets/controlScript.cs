﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlScript : MonoBehaviour
{
    AudioSource audio;
    public AudioClip[] clips;

    public void pindahGame()
    {
        SceneManager.LoadScene("main");
    }

    public void playSound(int sound)
    {
        audio.clip = clips[sound];
        audio.Play();
    }

    private IEnumerator introJingle()
    {
        yield return new WaitForSeconds(1);
        playSound(0);
        StartCoroutine(bunyiBurung());
    }
    private IEnumerator bunyiBurung()
    {
        yield return new WaitForSeconds(1);
        playSound(1);
        StartCoroutine(anjingMenyalak());
    }
    private IEnumerator anjingMenyalak()
    {
        yield return new WaitForSeconds(1);
        playSound(2);
        StartCoroutine(tembakJingle());
    }
    private IEnumerator tembakJingle()
    {
        yield return new WaitForSeconds(1);
        playSound(3);
        
    }
}
