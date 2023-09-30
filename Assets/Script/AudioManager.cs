using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource bgmAudioSource;
    public GameObject bumperSFX;
    public GameObject switchSFXOn;
    public GameObject switchSFXOff;

    private void Start()
    {
        PlayBGM();
    }

    private void PlayBGM()
    {
        bgmAudioSource.Play();
    }

    public void BumperSFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(bumperSFX, spawnPosition, Quaternion.identity);
    }

    public void SwitchSFX(Vector3 spawnPosition, bool sfxON = true)
    {
        //GameObject.Instantiate(swi, spawnPosition, Quaternion.identity);
        GameObject sfxPrefab = sfxON ? switchSFXOn : switchSFXOff;
        GameObject.Instantiate(sfxPrefab, spawnPosition, Quaternion.identity);
    }
}
