using UnityEngine;
using System.Collections;

public class HL_temp_colour_Conunter : MonoBehaviour {


    public float fl_timer;
    public int int_change_timer;
    public int int_curent_colour;
    public int int_available_colours;

    public bool bl_kill_blue;
    public bool bl_kill_red;
    public bool bl_kill_yellow;
    public bool bl_kill_black;


    // Use this for initialization
    void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {

        fl_timer += 1 * Time.deltaTime;
        if (fl_timer > int_change_timer)
        {
            int_curent_colour++;
            fl_timer = 0;
        }

        if (int_curent_colour > int_available_colours )
        {
            int_curent_colour = 1;
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
