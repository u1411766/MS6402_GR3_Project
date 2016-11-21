using UnityEngine;
using System.Collections;

public class HL_Dispai_kill_colour : MonoBehaviour
{
    private HL_temp_colour_Conunter counter;
    public Material[] mat;
    public SpriteRenderer rend_display_colour;
    // Use this for initialization
    void Start()
    {
        counter = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<HL_temp_colour_Conunter>();
        rend_display_colour = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (counter.int_curent_colour == 1)
        {
            rend_display_colour.material = mat[0];


        }
        if (counter.int_curent_colour == 2)
        {

            rend_display_colour.material = mat[1];


        }
        if (counter.int_curent_colour == 3)
        {
            rend_display_colour.material = mat[2];

        }
        if (counter.int_curent_colour == 4)
        {

            rend_display_colour.material = mat[3];

        }
    }
}
