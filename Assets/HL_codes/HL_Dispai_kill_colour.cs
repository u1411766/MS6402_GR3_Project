using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HL_Dispai_kill_colour : MonoBehaviour
{
    private HL_temp_colour_Conunter counter;
   
    public Sprite red;
    public Sprite blue;
    public Sprite yellow;
    public Sprite black;
    public Image Ui_image;


    // Use this for initialization
    void Start()
    {
        counter = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<HL_temp_colour_Conunter>();
       
        Ui_image = GetComponent<Image>();
       
    }

    // Update is called once per frame
    void Update()
    {
        if ( gameObject.name == "Next_Balloon")
        {
            if (counter.int_next_colour == 2 || counter.str_next_colour == "red")
            {
                Ui_image.overrideSprite = red;

            }
             if (counter.int_next_colour == 1 || counter.str_next_colour == "blue")
            {
                Ui_image.overrideSprite = blue;
            }

            if (counter.int_next_colour == 3 || counter.str_next_colour == "yellow")
            {
                Ui_image.overrideSprite = yellow;
            }
            if (counter.int_next_colour == 4 || counter.str_next_colour == "black")
            {
                Ui_image.overrideSprite = black;
            }

            
        }

        if (gameObject.name == "Current_Balloon")
        {
            if (counter.bl_kill_blue)
            {
                
                Ui_image.overrideSprite = blue;

            }
            if (counter.bl_kill_red)
            {

                Ui_image.overrideSprite = red;


            }
            if (counter.bl_kill_yellow)
            {
                Ui_image.overrideSprite = yellow;

            }
            if (counter.bl_kill_black)
            {

                Ui_image.overrideSprite = black;

            }
        }
    }
}
