using UnityEngine;
using UnityEngine.InputSystem;

public class Cameras : MonoBehaviour
{
    [SerializeField]

    private InputAction action;

    private Animator animator;

    private int cnt = 1;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        action.performed += _ => SwitchState();
    }

    private void SwitchState()
    {
        cnt++;
        if (cnt > 4)
        {
            cnt = 1;
        }
        if(cnt == 1)
        {
            animator.Play("3rd Person");
        }
        if (cnt == 2)
        {
            animator.Play("1st Person");
        }
        if (cnt == 3)
        {
            animator.Play("Dolly");
        }
        if (cnt == 4)
        {
            animator.Play("Ortho");
        }
    }

    // Update is called once per frame
    public void OnEnable()
    {
        action.Enable();
    }

    public void onDisable()
    {
        action.Disable();
    }
}
