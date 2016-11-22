using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HL_spawner : MonoBehaviour
{
    // st to active when object nearby is killed so a new one can spawn.
    public bool bl_can_spawn = true;

    // reference to level manager
    private HL_Level_Manager can_spawn;

    //spawn timer variables
    public float fl_Timer;
    public int int_timer_spawn;

    // sett PreFab of that will be spawned 
    public GameObject baloon;

    public bool test;


    public GameObject near_balloons;

    // Use this for initialization
    void Start()
    {
        can_spawn = GameObject.Find("Main Camera").GetComponent<HL_Level_Manager>();

        Instantiate(baloon, gameObject.transform.position, gameObject.transform.rotation);
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "baloon")
        {
            test = true;
            near_balloons = col.gameObject;

        }
    }

    // Update is called once per frame
    void Update()

    {
        /*
        //near_balloons = baloon;
        if (Vector3.Distance(gameObject.transform.position, near_balloons.transform.position) < 1f)
        {
            Debug.Log("exit");
            bl_can_spawn = false;
            test = false;

        }
        //else bl_can_spawn = true;

        if (can_spawn.bl_inGame_spawn == true)
        {
            if (bl_can_spawn == true)
            {
                fl_Timer += 1 * Time.deltaTime;
                if (fl_Timer > int_timer_spawn)
                {
                    Instantiate(baloon, gameObject.transform.position, gameObject.transform.rotation);
                    fl_Timer = 0;
                    // bl_can_spawn = false;
                    //near_balloons = baloon;
                }
            }
        }
        if (near_balloons == null)
        {
            test = false;
            bl_can_spawn = true;

        }
*/
    }

    
}


