using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState
{
    walking,
    idle
}
public class PlayerMovement : MonoBehaviour
{
    public PlayerState currentState;
    public float speed;
    private Rigidbody2D myRigidBody;
    private Vector3 change;
    private Animator animator;
    public MoodLevel moodLevel;
    public MoodSignal playerMoodSignal;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector3.zero;
        change.x = Input.GetAxis("Horizontal");
        change.y = Input.GetAxis("Vertical");
        updatePlayerAnimationAndMovement();
    }

    void updatePlayerAnimationAndMovement()
    {
        if (change != Vector3.zero)
        {
            MoveCharacter();
            animator.SetFloat("moveX", change.x);
            animator.SetFloat("moveY", change.y);
            animator.SetBool("walking", true);
            currentState = PlayerState.walking;
            moodLevel.runTimeMood = moodLevel.runTimeMood + 0.01f;
            playerMoodSignal.Raise();
        }
        else
        {
            animator.SetBool("walking", false);
            currentState = PlayerState.idle;
        }
    }

    void MoveCharacter()
    {
        myRigidBody.MovePosition(
            transform.position + change * speed * Time.deltaTime
        );
    }
}
