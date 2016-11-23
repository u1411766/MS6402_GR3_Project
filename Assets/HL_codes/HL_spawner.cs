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
    public GameObject near_balloons;


    //public List<GameObject> list_respawn = new List<GameObject>();
    // Use this for initialization
    void Start()
    {
        can_spawn = GameObject.Find("Main Camera").GetComponent<HL_Level_Manager>();

        Instantiate(baloon, gameObject.transform.position, gameObject.transform.rotation);
    }
   

    // Update is called once per frame
    void Update()

    {  // this resets to allow a new spawm
        if (near_balloons == null)
        {
            // list_respawn.Clear();

            bl_can_spawn = true;
        }
        else bl_can_spawn = false;


        // if the level can spawn a bl_can spawn is true it will spawn a new baloon at spawner location.
        if (can_spawn.bl_inGame_spawn == true)
        {
            if (bl_can_spawn == true)
            {
                fl_Timer += 1 * Time.deltaTime;
                if (fl_Timer > int_timer_spawn)
                {
                    Instantiate(baloon, gameObject.transform.position, gameObject.transform.rotation);
                    fl_Timer = 0;
                }
            }
        }
    }
    void OnTriggerEnter(Collider col)
    {
        // this detects if an ballon was created inside the spawner
      
        near_balloons = col.gameObject;
        // list_respawn.Add(baloon);
    } 
}


// if the object is gone from the lost anew one can spawn in its place.
/*  if (list_respawn.Count == 0)
  {
      bl_can_spawn = true;
  }
  else bl_can_spawn = false;
*/
