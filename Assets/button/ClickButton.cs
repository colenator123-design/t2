using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class ClickButton : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    // Start is called before the first frame update
    [SerializeField] private Image _img;
    [SerializeField] private Sprite _default,_pressed;
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioClip _compressClip,_uncompressClip;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerDown(PointerEventData eventData){
        _img.sprite=_pressed;
        _source.PlayOneShot(_compressClip);
    }
     public void OnPointerUp(PointerEventData eventData){
        _img.sprite=_default;
        _source.PlayOneShot(_uncompressClip);
    }
}
