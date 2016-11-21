using UnityEngine;
using System.Collections;

public class HL_Asign_Colour : MonoBehaviour
{
    // first varaible is the random number
    // second is the max number that can be there. this will let us prepare more colour if we need to whithout modifying the code to much.
    public int int_colour_selected;
    public int int_max_colours;

    // variables too lookfor when popping the ballons.
    public bool bl_blue_balloon;
    public bool bl_red_balloon;
    public bool bl_yellow_balloon;
    public bool bl_black_balloon;

    public Material[] mat;
    public Renderer rend_display_colour;

    // optional variabels for the lights on and off levels. can be diactivated on any normal level so it does not interfear with gameplay.
    public bool bl_on_off_available;
    public bool bl_lights;

    // variable affecting swich time of light on off
    private float fl_swich_timer;
    public int int_swich_time;

    // referenced light component

    private Light light_sceen;
    public GameObject GO_light;

    // Use this for initialization
    void Start()
    {
        // start the asign colour 
        Asign_Colour();

        // get the rendered to be modyfied from script
        rend_display_colour = GetComponent<Renderer>();

        // get the componet light
        //light_sceen = GameObject.Find("Directional Light").GetComponent<Light>();
        light_sceen = GO_light.GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        set_colour();

        // this is for the optional on off lights
        if (bl_on_off_available == true)
        {
            fl_swich_timer += 1 * Time.deltaTime;

        }
        // truns lights on or off after a set seconds which is int_swich_time
        if (fl_swich_timer > int_swich_time)
        {
            bl_lights = !bl_lights;
            fl_swich_timer = 0;
            light_sceen.enabled = !light_sceen.enabled;


        }

        //+++++++++++

    }


    // this will select the colour at the start of the game only.
    void Asign_Colour()
    {
        int_colour_selected = Random.Range(1, int_max_colours);



    }
    void set_colour()
    {
        // set object colour to a new material.
        if (int_colour_selected == 1)
        {
            if (bl_lights == false)
            {
                rend_display_colour.material = mat[0];
                bl_blue_balloon = true;
            }
            if (bl_lights == true)
            {
                rend_display_colour.material = mat[1];
                //bl_red_balloon = true;
            }
        }
        if (int_colour_selected == 2)
        {
            if (bl_lights == false)
            {
                rend_display_colour.material = mat[1];
                bl_red_balloon = true;
            }
            if (bl_lights == true)
            {
                rend_display_colour.material = mat[2];
                //bl_yellow_balloon = true;
            }
        }
        if (int_colour_selected == 3)
        {
            if (bl_lights == false)
            {
                rend_display_colour.material = mat[2];
                bl_yellow_balloon = true;
            }
            if (bl_lights == true)
            {
                rend_display_colour.material = mat[3];
                //bl_black_balloon = true;
            }
        }
        if (int_colour_selected == 4)
        {
            if (bl_lights == false)
            {
                rend_display_colour.material = mat[3];
                bl_black_balloon = true;
            }
            if (bl_lights == true)
            {
                rend_display_colour.material = mat[0];
               // bl_blue_balloon = true;
            }
            //++++++++++++++++++++++++++++++++++++++
        }
    }
}