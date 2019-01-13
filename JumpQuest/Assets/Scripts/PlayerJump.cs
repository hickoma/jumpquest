using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D m_Rigidbody = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name == "Platform")
        {
            Jump();
        }
    }

    void Jump()
    {
        m_Rigidbody.AddForce(new Vector3(0, 300, 0));
    }
}
