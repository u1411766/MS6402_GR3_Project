using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MS_Score_Test : MonoBehaviour {

    public HL_temp_colour_Conunter cycle;
    public Text gui_score;
    public Text gui_time;
    public Text gui_cycle;
    public float fl_score;
    public int int_time;
    public int int_max_time;
    public  float fl_cycle;



	// Use this for initialization
	void Start () {

        cycle = GameObject.Find("Main Camera").GetComponent<HL_temp_colour_Conunter>();
        fl_cycle = cycle.int_change_timer;
        fl_score = 0;
        UpdateScore();
        UpdateTime();
        CycleTime();
        InvokeRepeating("MinusTime", 1,1);
        
        
	}
	
	// Update is called once per frame
	void Update () {

        CycleTime();
        UpdateScore();
        UpdateTime();
        if (int_time < 1)
        {
            Application.LoadLevel(Application.loadedLevel);

        }

        if (fl_cycle <1)
        {
            fl_cycle = cycle.int_change_timer;
        }

	}

    void UpdateScore()
    {

        gui_score.text = "Score:" + "  " + fl_score;
         
    }

    void UpdateTime()
    {
        gui_time.text = "  " + int_time;

    }

    void CycleTime()
    {
       gui_cycle.text = "" + fl_cycle;

    }

    void MinusTime()
    {

        int_time -= 1;
        fl_cycle -= 1;
    }
}
