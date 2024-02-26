using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchTime : MonoBehaviour
{
    public bool isMoving = false;
    public float reducirtiempo = 0.25f;
    public AudioClip paratiempo;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            AudioSource src = AudioManager.instance.PlayAudio(paratiempo, "time");
            StartCoroutine(WaitAudioEnd(src));
        }
    }
    IEnumerator WaitAudioEnd(AudioSource src)
    {
        Time.timeScale = reducirtiempo;
        while (src && src.isPlaying)
        {
            yield return null;
        }
        Time.timeScale = 1.0f;

        
    }
}
