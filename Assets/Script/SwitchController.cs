using System.Collections;
using UnityEngine;
using UnityEngine.VFX;

public class SwitchController : MonoBehaviour
{
    private enum SwitchState
    {
        Off,
        On,
        Blink
    }

    public Collider bola;
    public Material offMaterial;
    public Material onMaterial;
    public float score;

    private SwitchState state;
    private bool isOn;
    private Renderer _renderer;

    public AudioManager audioManager;
    public VFXManager vfxManager;
    public ScoreManager scoreManager;

    private void Start()
    {
        _renderer = GetComponent<Renderer>();

        Set(false);
        StartCoroutine(BlinkTImerStart(5));
    }

    private void OnTriggerEnter(Collider collider)
    {
        if(collider == bola)
        {
            //Debug.Log("Bola Kena Switch");
            vfxManager.SwitchVFX(collider.transform.position);

            if (state == SwitchState.On)
            {
                audioManager.SwitchSFX(collider.transform.position, false);
                Toggle();
            }
            else
            {
                audioManager.SwitchSFX(collider.transform.position, true);
                Toggle();
            }
        }
    }

    private void Set(bool active)
    {
        if(active == true)
        {
            state = SwitchState.On;
            _renderer.material = onMaterial;
            StopAllCoroutines();
        }
        else
        {
            state = SwitchState.Off;
            _renderer.material = offMaterial;
            StartCoroutine(BlinkTImerStart(5));
   
        }
    }

    private void Toggle()
    {
        if(state == SwitchState.On)
        {
            Set(false);
        }
        else
        {
            Set(true);
        }

        scoreManager.AddScore(score);
    }

    private IEnumerator Blink(int times)
    {
        state = SwitchState.Blink;

        for(int i = 0; i < times; i++)
        {
            _renderer.material = onMaterial;
            yield return new WaitForSeconds(0.5f);
            _renderer.material = offMaterial;
            yield return new WaitForSeconds(0.5f);
        }

        state = SwitchState.Off;

        StartCoroutine(BlinkTImerStart(5));
    }

    private IEnumerator BlinkTImerStart(float times)
    {
        yield return new WaitForSeconds(times);
        StartCoroutine(Blink(2));
    }
}
