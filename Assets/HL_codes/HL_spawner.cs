﻿using UnityEngine;
using System.Collections;

public class HL_spawner : MonoBehaviour {
    public bool bl_can_spawn = true;
    public  bool bl_inGame_spawn;
    public float fl_Timer;
    public int int_timer_spawn;

    public bool test;
    public GameObject baloon;
    //private HL_temp_colour_Conunter counter;
	// Use this for initialization
	void Start ()
    {
        //counter = GameObject.Find("Main Camera").GetComponent<HL_temp_colour_Conunter>();
        Instantiate(baloon, gameObject.transform.position, gameObject.transform.rotation);
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Vector3.Distance(gameObject.transform.position, GameObject.FindGameObjectWithTag("baloon").transform.position) < 0.5f)
        {
            bl_can_spawn = false;
            test = true;
        }
        //else bl_can_spawn = true;

	   if (bl_inGame_spawn == true)
        {
            if (bl_can_spawn == true)
            {
                fl_Timer += 1 * Time.deltaTime;
                if (fl_Timer > int_timer_spawn)
                {
                    Instantiate(baloon, gameObject.transform.position, gameObject.transform.rotation);
                    fl_Timer = 0;
                    bl_can_spawn = false;
                }
            }
        }

    }
}