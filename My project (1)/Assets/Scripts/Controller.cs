using UnityEngine;

public class Controller : MonoBehaviour
{   
    Vector3 m_Movement;

    [SerializeField] private float _speed = 10.0F;
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        m_Movement.z = Input.GetAxis("Vertical");
        m_Movement.x = Input.GetAxis("Horizontal");
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
        }

    }
    private void FixedUpdate()
    {
        var speed = m_Movement * _speed * Time.deltaTime;
        transform.Translate(speed);
    }   

}
