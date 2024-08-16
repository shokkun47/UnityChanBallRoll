using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    int count;
    public Text countText;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SetCountText();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(moveH, 0, moveV);
        rb.AddForce(move * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.SetActive(false);
        count = count + 1;
                SetCountText();
    }

    void SetCountText()
    {
        countText.text ="ゲット数：" +  count.ToString();

    }
}

