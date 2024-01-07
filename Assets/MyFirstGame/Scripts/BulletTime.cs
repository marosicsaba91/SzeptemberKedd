using System.Collections;
using UnityEngine;

class BulletTime : MonoBehaviour
{
    [SerializeField] KeyCode key = KeyCode.B;
    [SerializeField, Range(0,1)] float timeScale = 0.3f;
    [SerializeField, Min(0)] float duration = 3;
    [SerializeField, Min(0)] float phaseInTime = 1; 

    void Update()
    {
        if (Input.GetKeyDown(key)) 
        {
            StartCoroutine(BulletTimeCoroutine());
        }
    }

    IEnumerator BulletTimeCoroutine() 
    {
        Time.timeScale = timeScale;
        yield return new WaitForSecondsRealtime(duration - phaseInTime);

        float phaseInStart = Time.unscaledTime;

        while (Time.unscaledTime - phaseInStart < phaseInTime)
        {
            float rate = (Time.unscaledTime - phaseInStart) / phaseInTime;  // 0 -> 1;
            Time.timeScale = Mathf.Lerp(timeScale, 1, rate);
            yield return null; // Következõ képfrissítésig
        }

        Time.timeScale = 1;
    }
}
