using UnityEngine;
using System.Collections;

public class HL_temp_colour_Conunter : MonoBehaviour {

    // timer and colour counter variables
    private float fl_timer;
    public int int_change_timer;
    public int int_curent_colour;
    public int int_available_colours;

    // bools that determine what the colour is set to for each ballon
    public bool bl_kill_blue;
    public bool bl_kill_red;
    public bool bl_kill_yellow;
    public bool bl_kill_black;

    private HL_Level_Manager random_c;
    // Use this for initialization
    void Start ()
    {
        random_c = GameObject.Find("Main Camera").GetComponent<HL_Level_Manager>();
    }
	
	// Update is called once per frame
	void Update ()
    {
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
        // random colour selection devived from the level manager
        if (random_c.random_C_change == true)
        {
            fl_timer += 1 * Time.deltaTime;
            if (fl_timer > int_change_timer)
            {
                int_curent_colour =  Random.Range(1, 5); ;
                fl_timer = 0;
            }

           
        }




        kill_colours();

	}
    void kill_colours()
    {
        if (int_curent_colour == 1)
        {
            bl_kill_blue = true;
            bl_kill_red = false;
            bl_kill_yellow = false;
            bl_kill_black = false;
        }

        if (int_curent_colour == 2)
        {
            bl_kill_red = true;
            bl_kill_blue = false;
            
            bl_kill_yellow = false;
            bl_kill_black = false;
        }

        if (int_curent_colour == 3)
        {
            bl_kill_yellow = true;
            bl_kill_blue = false;
            bl_kill_red = false;
            
            bl_kill_black = false;
        }

        if (int_curent_colour == 4)
        {
            bl_kill_black= true;
            bl_kill_blue = false;
            bl_kill_red = false;
            bl_kill_yellow = false;
            
        }


    }
}
