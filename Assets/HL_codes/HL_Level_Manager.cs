using UnityEngine;
using System.Collections;

public class HL_Level_Manager : MonoBehaviour
{
    
    // optional variabels for the lights on and off levels. can be diactivated on any normal level so it does not interfear with gameplay.
    public bool bl_on_off_available;
    public  bool bl_lights;

    // variable affecting swich time of light on off
    private float fl_swich_timer;
    public int int_swich_time;

    // referenced light component
    private Light light_sceen;
    public GameObject GO_light;

    // spawner is available to spawn during game
    public bool bl_inGame_spawn;

    // randon colour change in level display
    public bool random_C_change;
    // Use this for initialization
    void Start ()
    {
        // get the componet light from the sceen
        light_sceen = GO_light.GetComponent<Light>();
    }
	
	// Update is called once per frame
	void Update ()
    {
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




    }
}
