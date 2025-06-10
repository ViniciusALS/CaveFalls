using UnityEngine;

public class Player : Core 
{
    enum PlayerState { Idle, Running, Airbourne }

    PlayerState state;

    bool stateComplete = false;

    public float acceleration; [Range(0f, 1f)]
    public float groundDecay;
    public float maxXSpeed;
    public float jumpSpeed;

    float xInput;
    float yInput;


    void Update()
    {
        CheckInput();
        HandleJump();

        if (stateComplete)
        {
            SelectState();
        }

        UpdateState();
    }

    void FixedUpdate()
    {
        HandleXMovement();
        ApplyFriction();
    }

    void SelectState()
    {
        stateComplete = false;

        if (IsGrounded())
        {
            if (xInput == 0)
            {
                state = PlayerState.Idle;
                StartIdle();
            } 
            else 
            {
                state = PlayerState.Running;
                StartRunning();
            }
        }
        else 
        {
            state = PlayerState.Airbourne;
            StartAirbourne();
        }
    }


    void UpdateState()
    {
        switch(state)
        {
            case PlayerState.Idle:
                UpdateIdle();
                break;
            
            case PlayerState.Running:
                UpdateRunning();
                break;

            case PlayerState.Airbourne:
                UpdateAirbourne();
                break;
        }
    }

    void UpdateIdle()
    {
        if (xInput != 0)
        {

        }
    }

    void UpdateRunning()
    {
        if (xInput == 0)
        {
            state = PlayerState.Idle;
        }
        if (!IsGrounded())
        {

        }
    }

    void UpdateAirbourne()
    {
        if (IsGrounded())
        {

        }
    }

    void CheckInput()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");
    }
}