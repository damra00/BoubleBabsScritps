using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopKontrol : MonoBehaviour
{
    public UnityEngine.UI.Text ZamanSayac,KazandýnTx,KaybettinTx;
    public UnityEngine.UI.Button RestartBtn,NewLevel;
    public float Sayac;
    public GameObject other,Kirilma,Babs;
    // Start is called before the first frame update
    private Rigidbody rg;
    public FixedJoystick Joystick;
    public float hiz = 1.5f;
    bool OyunDevam; 
    void Start()
    {      
        rg = GetComponent<Rigidbody>();       
        OyunDevam = true;
    }

    // Update is called once per frame
    void Update()
    {     
        Sayac -= Time.deltaTime;
        if (Sayac > 0 && OyunDevam == true)
        {        
            ZamanSayac.text = (int)Sayac + "";
        }      
    }
    private void FixedUpdate()
    {      
        float dikey = Input.GetAxis("Vertical");
        float yatay = Input.GetAxis("Horizontal");
        Vector3 kuvvet = new Vector3(-dikey, 0, yatay);
        Vector3 kuvvetJoystick = new Vector3(-Joystick.Vertical, 0, Joystick.Horizontal);
        if (Sayac > 0 && OyunDevam == true)
        {  
         rg.AddForce(kuvvet*hiz);
         rg.AddForce(kuvvetJoystick * hiz);
        }
        else if (Sayac <=0)
        {
            KaybettinTx.text = "Kaybettin(Süre Bitti)";
            OyunDevam = false;
            RestartBtn.gameObject.SetActive(true);
            Destroy(other);
        }         
    }
    void OnCollisionEnter(Collision collision)
    {
        if (!(collision.gameObject.name == "finish") && !(collision.gameObject.name == "Zemin") && !(collision.gameObject.name == "Plane") && !(collision.gameObject.tag == "Zemin"))
        {
            KaybettinTx.text = "Kaybettin";
            hiz = 0;
            OyunDevam = false;
            RestartBtn.gameObject.SetActive(true);
            Instantiate(Kirilma, transform.position, transform.rotation);
            Instantiate(Babs, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        else if (collision.gameObject.name == "finish")
        {         
            KazandýnTx.text = "Kazandýn";
            hiz = 0;
            rg.gameObject.GetComponent<Rigidbody>().isKinematic = true;
            OyunDevam = false;
            NewLevel.gameObject.SetActive(true);
            RestartBtn.gameObject.SetActive(true);
        }
    }
}
