using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathBallController : MonoBehaviour
{
    public AudioClip deathSound;

    private void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
        SceneManager.LoadScene("Death");

        {
            GameObject gameObject = new GameObject("One shot audio");
            gameObject.transform.position = transform.position;
            AudioSource audioSource = (AudioSource)gameObject.AddComponent(typeof(AudioSource));
            audioSource.clip = deathSound;
            audioSource.spatialBlend = 1f;
            audioSource.volume = 1;
            audioSource.Play();
            Object.Destroy((Object)gameObject, deathSound.length * ((double)Time.timeScale >= 0.00999999977648258 ? Time.timeScale : 0.01f));
            DontDestroyOnLoad(gameObject);
        }
    }
}
