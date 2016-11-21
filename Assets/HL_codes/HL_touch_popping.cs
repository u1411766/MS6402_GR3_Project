using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class HL_touch_popping : MonoBehaviour
{
    public bool test;

    private RaycastHit hit;

    public GameObject[] touchOld;
    public List<GameObject> touchList = new List<GameObject>();
    public LayerMask touchImputMask;

    private HL_Asign_Colour balloon;
    private HL_temp_colour_Conunter counter;

    void Start()
    {
        counter = GetComponent<HL_temp_colour_Conunter>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0) || Input.GetMouseButtonDown(0) || Input.GetMouseButtonUp(0))
        {
            touchOld = new GameObject[touchList.Count];
            touchList.CopyTo(touchOld);
            touchList.Clear();

            {
                Ray rey = Camera.main.ScreenPointToRay(Input.mousePosition);
                RaycastHit hit;
                if (Physics.Raycast(rey, out hit, touchImputMask))
                {
                    GameObject recipient = hit.transform.gameObject;
                    touchList.Add(recipient);
                    if (Input.GetMouseButtonDown(0))
                    {
                        Destroy(recipient);
                        recipient.SendMessage("began", hit.point, SendMessageOptions.DontRequireReceiver);
                        balloon = recipient.GetComponent<HL_Asign_Colour>();
                        if (balloon.bl_blue_balloon == true && counter.bl_kill_blue == true)
                        {
                            // Destroy(recipient);
                            // add score reference here ++++-------++++++
                        }
                        if (balloon.bl_red_balloon == true && counter.bl_kill_red == true)
                        {
                            // Destroy(recipient);
                            // add score reference here ++++-------++++++
                        }
                        if (balloon.bl_yellow_balloon == true && counter.bl_kill_yellow == true)
                        {
                            // Destroy(recipient);
                            // add score reference here ++++-------++++++
                        }
                        if (balloon.bl_black_balloon == true && counter.bl_kill_black == true)
                        {
                            // Destroy(recipient);
                            // add score reference here ++++-------++++++
                        }

                    }

                    if (Input.GetMouseButtonUp(0))
                    {
                        recipient.SendMessage("ended ", hit.point, SendMessageOptions.DontRequireReceiver);
                        if (balloon.bl_blue_balloon == true && counter.bl_kill_blue == true)
                        {
                            //Destroy(recipient);
                        }
                        if (balloon.bl_red_balloon == true && counter.bl_kill_red == true)
                        {
                           // Destroy(recipient);
                        }
                        if (balloon.bl_yellow_balloon == true && counter.bl_kill_yellow == true)
                        {
                           // Destroy(recipient);
                        }
                        if (balloon.bl_black_balloon == true && counter.bl_kill_black == true)
                        {
                           // Destroy(recipient);
                        }
                    }

                    if (Input.GetMouseButton(0))
                    {
                        recipient.SendMessage("cstationary", hit.point, SendMessageOptions.DontRequireReceiver);
                        if (balloon.bl_blue_balloon == true && counter.bl_kill_blue == true)
                        {
                           // Destroy(recipient);
                        }
                        if (balloon.bl_red_balloon == true && counter.bl_kill_red == true)
                        {
                           // Destroy(recipient);
                        }
                        if (balloon.bl_yellow_balloon == true && counter.bl_kill_yellow == true)
                        {
                           // Destroy(recipient);
                        }
                        if (balloon.bl_black_balloon == true && counter.bl_kill_black == true)
                        {
                           // Destroy(recipient);
                        }
                    }
                }
            }
        }
    }
}
