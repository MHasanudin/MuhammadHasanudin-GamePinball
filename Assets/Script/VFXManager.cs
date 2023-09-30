using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VFXManager : MonoBehaviour
{
    public GameObject vfxBumper;
    public GameObject vfxSwitch;

    public void BumperVFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxBumper, spawnPosition, Quaternion.identity);
    }

    public void SwitchVFX(Vector3 spawnPosition)
    {
        GameObject.Instantiate(vfxSwitch, spawnPosition, Quaternion.identity);
    }

}
