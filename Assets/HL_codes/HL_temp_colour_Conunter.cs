﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HL_temp_colour_Conunter : MonoBehaviour
{
    //+++ list arrow to detect each colour of balloons
    public List<GameObject> ballons_blue = new List<GameObject>();
    public List<GameObject> ballons_red = new List<GameObject>();
    public List<GameObject> ballons_yellow = new List<GameObject>();
    public List<GameObject> ballons_black = new List<GameObject>();

    public List<string> L_available_colours = new List<string>();
    // private sting to be selected randomley from hte available ballon list
    public string str_curent_colour;


    private bool blue_added;
    private bool red_added;
    private bool yellow_added;
    private bool black_added;

    // timer and colour counter variables
    private float fl_timer;
    public int int_change_timer;
    public int int_curent_colour;
    public int int_available_colours;

    // bools that determine what colour is set to for each ballon to kill
    public bool bl_kill_blue;
    public bool bl_kill_red;
    public bool bl_kill_yellow;
    public bool bl_kill_black;

    private HL_Level_Manager random_c;
    // Use this for initialization
    void Start()
    {
        random_c = GameObject.Find("Main Camera").GetComponent<HL_Level_Manager>();
    }

    // Update is called once per frame
    void Update()
    {

        //++++++++++++++
        // checks what is on screen and adds ot to a list to be checkedl
        ballons_blue = new List<GameObject>(GameObject.FindGameObjectsWithTag("balloon_blue"));
        ballons_red = new List<GameObject>(GameObject.FindGameObjectsWithTag("balloon_red"));
        ballons_yellow = new List<GameObject>(GameObject.FindGameObjectsWithTag("balloon_yellow"));
        ballons_black = new List<GameObject>(GameObject.FindGameObjectsWithTag("balloon_black"));
        
        //+++++++++++


        if (random_c.random_C_change == false)
        {
            fl_timer += 1 * Time.deltaTime;
            if (fl_timer > int_change_timer)
            {
                int_curent_colour++;
                fl_timer = 0;
            }

            if (int_curent_colour > int_available_colours)
            {
                int_curent_colour = 1;
            }
        }
        // random colour selection activated from the level manager
        // colour is selected randomley from a list of available ballons;
        if (random_c.random_C_change == true)
        {//++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            Add_to_random_selection();

            fl_timer += 1 * Time.deltaTime;
            if (fl_timer > int_change_timer)
            {
                str_curent_colour = L_available_colours[Random.Range(0, L_available_colours.Count)];
                fl_timer = 0;
                
                //int_curent_colour = Random.Range(1, 5);
            }


        }

        kill_colours();

    }




    void kill_colours()
    {
        if (int_curent_colour == 1 || str_curent_colour =="blue")
        {
            bl_kill_blue = true;
            bl_kill_red = false;
            bl_kill_yellow = false;
            bl_kill_black = false;
        }

        if (int_curent_colour == 2 || str_curent_colour == "red")
        {
            bl_kill_red = true;
            bl_kill_blue = false;

            bl_kill_yellow = false;
            bl_kill_black = false;
        }

        if (int_curent_colour == 3 || str_curent_colour == "yellow")
        {
            bl_kill_yellow = true;
            bl_kill_blue = false;
            bl_kill_red = false;

            bl_kill_black = false;
        }

        if (int_curent_colour == 4 || str_curent_colour == "black")
        {
            bl_kill_black = true;
            bl_kill_blue = false;
            bl_kill_red = false;
            bl_kill_yellow = false;

        }


    }

    void Add_to_random_selection()
    {
        // adds the ballon on a list or a random selection
        if (ballons_blue.Contains(GameObject.FindGameObjectWithTag("balloon_blue")))
        {
            if (blue_added == false)
            {

                L_available_colours.Add("blue");
                blue_added = true;
            }
            

        }
 
        // removes from the list when tha coulour balone is no longer on screen
        if (ballons_blue.Count == 0)
            {
                L_available_colours.Remove("blue");
                blue_added = false;
            }
        if (ballons_red.Count > 0)
        {

            if (red_added == false)
            {
                L_available_colours.Add("red");
                red_added = true;
            }

        }
        // removes from the list when tha coulour balone is no longer on screen
        if (ballons_red.Count == 0)
        {
            L_available_colours.Remove("red");
            red_added = false;
        }
        if (ballons_yellow.Count > 0)
        {

            if (yellow_added == false)
            {
                L_available_colours.Add("yellow");
                yellow_added = true;
            }

        }
        // removes from the list when tha coulour balone is no longer on screen
        if (ballons_yellow.Count == 0)
        {
            L_available_colours.Remove("yellow");
            yellow_added = false;
        }
        if (ballons_black.Count > 0)
        {

            if (black_added == false)
            {
                L_available_colours.Add("black");
                black_added = true;
            }

        }
        // removes from the list when tha coulour balone is no longer on screen
        if (ballons_black.Count == 0)
        {
            L_available_colours.Remove("black");
            black_added = false;
        }



    }
}
