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


        if (counter.bl_kill_blue)
        {
            //rend_display_colour.sprite = test;
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
