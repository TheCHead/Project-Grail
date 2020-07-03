using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundPlayer : MonoBehaviour
{
    [SerializeField] List<AudioClip> stoneFootsteps = new List<AudioClip>();
    AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayFootstepSFX()
    {
        int index = Random.Range(0, stoneFootsteps.Count);
        audioSource.pitch = Random.Range(0.6f, 1f);
        audioSource.PlayOneShot(stoneFootsteps[index]);
    }
}
