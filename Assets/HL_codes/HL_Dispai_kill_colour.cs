using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class HL_Dispai_kill_colour : MonoBehaviour
{
    private HL_temp_colour_Conunter counter;
   // public Material[] mat;
   // public SpriteRenderer rend_display_colour;
    //public Sprite[] sprites;
    public Sprite red;
    public Sprite blue;
    public Sprite yellow;
    public Sprite black;
    public Image Ui_image;
    // Use this for initialization
    void Start()
    {
        counter = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<HL_temp_colour_Conunter>();
       // rend_display_colour = GetComponent<SpriteRenderer>();
        Ui_image = GetComponent<Image>();
        //rend_display_colour = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {


        if (counter.int_curent_colour == 1)
        {
            //rend_display_colour.sprite = test;
            Ui_image.overrideSprite = blue;

        }
        if (counter.int_curent_colour == 2)
        {

            Ui_image.overrideSprite = red;


        }
        if (counter.int_curent_colour == 3)
        {
            Ui_image.overrideSprite = yellow;

        }
        if (counter.int_curent_colour == 4)
        {

            Ui_image.overrideSprite = black;

        }
    }
}
