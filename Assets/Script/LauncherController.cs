using System.Collections;
using UnityEngine;

public class LauncherController : MonoBehaviour
{
    public Collider bola;
    public KeyCode input;

    public float maxTimeHold;
    public float maxForce;

    private bool isHold = false;


    private void Start()
    {
    }


    private void OnCollisionStay(Collision collision)
    {
        if(collision.collider == bola)
        {
            ReadInput(bola);
        }
    }

    private void ReadInput(Collider collider)
    {
        if(Input.GetKey(input) && !isHold)
        {
            StartCoroutine(StartHold(collider));
        }
    }

    private IEnumerator StartHold(Collider collider)
    {
        isHold = true;

        Vector3 currentScale = transform.localScale;

        float force = 0.0f;
        float timeHold = 0.0f;
        float scaleZ;

        while (Input.GetKey(input))
        {
            force = Mathf.Lerp(0, maxForce, timeHold/maxTimeHold);
            scaleZ = Mathf.Lerp(2f, 0.5f, timeHold/maxTimeHold);

            transform.localScale = new Vector3(transform.localScale.x, transform.localScale.y, scaleZ);

            yield return new WaitForEndOfFrame();
            timeHold += Time.deltaTime;
        }

        collider.GetComponent<Rigidbody>().AddForce(Vector3.forward * force);
        isHold = false;

        transform.localScale = currentScale;
    }
}
