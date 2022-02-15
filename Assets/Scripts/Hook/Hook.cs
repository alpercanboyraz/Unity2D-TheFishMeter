using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Hook : MonoBehaviour
{
    public Transform hookedTransform;
    private Camera mainCamera;
    private int lenght;
    private int strenght;
    private int fishCount;

    private Collider2D coll;
    private bool canMove=true;

    //List<fish>      private Tweener cameraTween;

    void Awake(){
       mainCamera = Camera.main;
       coll = GetComponent<Collider2D>();
       //List<Fish>
    }
    void Start()
    {
        print("This message will be second");
    }
    void Update()
    {
        if(canMove && Input.GetMouseButton(0)){
            Vector3 vector = mainCamera.ScreenToWorldPoint(Input.mousePosition); // vector isimli değişkene uzayda tıklanan noktayı alır
            Vector3 pos = transform.position; // şu anki x konumu
            pos.x = vector.x; // x konumunu günceller
            
            transform.position = pos; // x konumunu objeye uygular


        }
    }
}
