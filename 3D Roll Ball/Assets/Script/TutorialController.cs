using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TutorialController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    public Text countText;
    public Text winText;
    private int count_point;
    private int count_danger;
    private int life_point;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count_point = 0;
        count_danger = 0;
        SetCountText();
        winText.text = "";
        
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement*speed);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count_point = count_point + 1;
            SetCountText();
        }
    }
    void SetCountText()
    {
        countText.text = "Score :" + count_point.ToString();
        if (count_point == 16)
        {
            winText.text = "You Win";
            Time.timeScale=0f;
        }
    }
}
