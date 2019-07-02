using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private string horizontalInputName;
    [SerializeField] private string verticalInputName;
    [SerializeField] private float movementSpeed;
    [SerializeField] private float dashCooldown;
    [SerializeField] private float dash;
    [SerializeField] private float dashSpeed;
    [SerializeField] private float maxDashCooldown;
    [SerializeField] private float dashStopMultiplier;

    private CharacterController charController;

    private void Awake()
    {
        charController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        PlayerMovement();
        Dash();
    }

    private void PlayerMovement()
    {
        float verInput = Input.GetAxis(verticalInputName) * movementSpeed * dash;
        float horInput = Input.GetAxis(horizontalInputName) * movementSpeed * dash;

        Vector3 forwardMovement = transform.forward * verInput;
        Vector3 rightMovement = transform.right * horInput;

        charController.SimpleMove(forwardMovement + rightMovement);
    }

    private void Dash()
    {
        if (Input.GetButton("Dash") && dashCooldown <= 0)
        {
            dash *= dashSpeed;
            dashCooldown = maxDashCooldown;
        }

        dashCooldown -= Time.deltaTime;
        if (dash > 1)
        {
            dash -= Time.deltaTime * dashStopMultiplier;
        }
        else
        {
            dash = 1;
        }
    }
}
