using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class cameraShake : MonoBehaviour
{
    public float shakeLength;
    public float shakeStrength;
    public CinemachineVirtualCamera vCam;

    

    // use co-routines for timers -> loops in function holding up program
    public void Shake()
    {
        StartCoroutine(ShakeRoutine(shakeLength, shakeStrength));
    }

    public void Shake(float time, float strength)
    {
        StartCoroutine(ShakeRoutine(time, strength));
    }

    public IEnumerator ShakeRoutine(float timer, float strength)
    {
        CinemachineBasicMultiChannelPerlin perlin = vCam.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        perlin.m_AmplitudeGain = strength;

        while (timer > 0f)
        {
            timer -= Time.deltaTime;
            yield return null;
        }

        perlin.m_AmplitudeGain = 0f;
    }
}
