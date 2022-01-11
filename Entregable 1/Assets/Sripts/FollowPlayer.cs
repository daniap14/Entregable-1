using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;
    public float runSpeed = 1.5f;
    int MaxDist = 10;
    int MinDist = 2;
    

    private Animator anim;

    private int battle_state = 0;

    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        
        anim = GetComponent<Animator>();

        battle_state = 1;

        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {

            transform.position += transform.forward * runSpeed * Time.deltaTime;
            anim.SetInteger("battle", 1);
            anim.SetInteger("moving", 1);
            
            


            if (Vector3.Distance(transform.position, Player.position) <= MinDist)
            {
                anim.SetInteger("moving", 2);
            }

        }
    }

    private void OnMouseDown()
    {
        if (gameObject.CompareTag("Bad"))
        {
            anim.SetInteger("moving", 13);
            Destroy(gameObject);
        }
    }
}
