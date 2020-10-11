using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float movement = 0f;
	public Rigidbody2D rigidbody;
    public float jumpSpeed = 5f;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }


    // Update is called once per framej
    void Update()
    {
        movement = Input.GetAxis("Horizontal");
        if(movement != 0f){
            rigidbody.velocity = new Vector2(movement*speed, rigidbody.velocity.y);

        }
        else if(Input.GetButtonDown("Jump")){
			rigidbody.velocity = new Vector2(rigidbody.velocity.x, jumpSpeed);
		}
    }
}
