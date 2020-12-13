using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    [SerializeField] RuntimeData _runtimeData;
    [SerializeField] Dialogue _intro;
    [SerializeField] GameObject _canvas;
    [SerializeField] GameObject _fade;
    public float speed = 10f;
    public float gravity = -10f;
    Vector3 velocity;
    
    void Awake()
    {
        DontDestroyOnLoad(_canvas);
    }
    void Start() 
    {
        GameEvents.InvokeDialogInitiated(_intro);
    }

    // This video helped me with the player movements: https://www.youtube.com/watch?v=_QajrabyTJc
    void Update()
    {
        if (_runtimeData.CurrentGameplayState == GameplayState.FreeWalk)
        {
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");

            Vector3 move = transform.right * x + transform.forward * z;

            controller.Move(move * speed * Time.deltaTime);

            velocity.y += gravity * Time.deltaTime;

            controller.Move(velocity * Time.deltaTime);
        }

        if (Input.GetButtonDown("Fire3"))
        {
            SceneManager.LoadScene("SampleScene");
        }
    }
}
