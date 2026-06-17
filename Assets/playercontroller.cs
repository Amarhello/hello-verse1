using System.Collections;
using System.Collections.Generic;
using System.Net;
using System.Numerics;
using Unity.Collections;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playercontroller : MonoBehaviour
{
    public Rigidbody2D Rb;
    public float speed = 5f;
    public float jump = 5f;
    public bool ground = true;
    public int Hlt2 = 20;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        Rb = GetComponent<Rigidbody2D>(); 
    }
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        var direction = new UnityEngine.Vector2(horizontal, 0f).normalized;
        transform.Translate(direction * Time.deltaTime * speed) ;
        if (Input.GetKeyUp(KeyCode.UpArrow) && ground)
        {
            Rb.AddForce(UnityEngine.Vector2.up * jump, ForceMode2D.Impulse);
            ground = false;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            ground = true;
        }
        else if (collision.CompareTag("void"))
        {
            SceneManager.LoadScene("SampleScene");



            if (collision.CompareTag("Finish"))
                SceneManager.LoadScene("Victory");

        }
        else if (collision.TryGetComponent(out enemy_controller enemy))
        {
            Hlt2 -= enemy.damage;
        }
        else if (collision.TryGetComponent<xegada_du_jogimn>(out _))
            
        {
            SceneManager.LoadScene("Victory");

        }


        



        }










}

















