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

    // reference if light is on for the colours tochange on an object

    private HL_Level_Manager light_option;

    // Use this for initialization
    void Start()
    {
        // start the asign colour 
        Asign_Colour();

        // get the rendered to be modyfied from script
        rend_display_colour = GetComponent<Renderer>();
        light_option = GameObject.Find("Main Camera").GetComponent<HL_Level_Manager>();

    }

    // Update is called once per frame
    void Update()
    {
        set_colour();

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
            if (light_option.bl_lights == false)
            {
                rend_display_colour.material = mat[0];
                bl_blue_balloon = true;
                gameObject.tag = "balloon_blue";
            }
            if (light_option.bl_lights == true)
            {
                rend_display_colour.material = mat[1];
                //bl_red_balloon = true;
            }
        }
        if (int_colour_selected == 2)
        {
            if (light_option.bl_lights == false)
            {
                rend_display_colour.material = mat[1];
                bl_red_balloon = true;
                gameObject.tag = "balloon_red";
            }
            if (light_option.bl_lights == true)
            {
                rend_display_colour.material = mat[2];
                //bl_yellow_balloon = true;
            }
        }
        if (int_colour_selected == 3)
        {
            if (light_option.bl_lights == false)
            {
                rend_display_colour.material = mat[2];
                bl_yellow_balloon = true;
                gameObject.tag = "balloon_yellow";
            }
            if (light_option.bl_lights == true)
            {
                rend_display_colour.material = mat[3];
                //bl_black_balloon = true;
            }
        }
        if (int_colour_selected == 4)
        {
            if (light_option.bl_lights == false)
            {
                rend_display_colour.material = mat[3];
                bl_black_balloon = true;
                gameObject.tag = "balloon_black";
            }
            if (light_option.bl_lights == true)
            {
                rend_display_colour.material = mat[0];
               // bl_blue_balloon = true;
            }
            //++++++++++++++++++++++++++++++++++++++
        }
    }
}