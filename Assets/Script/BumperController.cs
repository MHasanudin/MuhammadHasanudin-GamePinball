using UnityEngine;

public class BumperController : MonoBehaviour
{
    public Collider bola;
    public float multiplier;
    public Color color;

    public AudioManager audioManager;
    public VFXManager vfxManager;

    private Renderer _renderer;
    private Animator animator;


    private void Start()
    {
        _renderer = GetComponent<Renderer>();
        animator = GetComponent<Animator>();    

        _renderer.material.color = color;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider == bola) 
        {
            Rigidbody RBBola = bola.GetComponent<Rigidbody>();
            RBBola.velocity *= multiplier;


            //animation
            animator.SetTrigger("Hit");

            //playSFX
            audioManager.BumperSFX(collision.transform.position);

            //playVFX
            vfxManager.BumperVFX(collision.transform.position);
        }
    }
}
