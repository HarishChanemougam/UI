using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ButtonBehaviour : MonoBehaviour
{
    [SerializeField] Button _buttonToCOntrol;

    [SerializeField] UnityEvent _onPressed;
    [SerializeField] UnityEvent _onReleased;

    bool _isPressed;
    

    
    private void Start()
    {
        _buttonToCOntrol.onClick.AddListener(MaFonction);
        _isPressed = false;
    }
    

    private void MaFonction()
    {
        //1-Change Intenal state
       /* _isPressed == !_isPressed;*/ //normal way to do it!


        if(_isPressed == true)
        {
            _isPressed = false;
        }
        else if(_isPressed == false)
        {
            _isPressed = true;
        }

        //2-
        //Call our events
        if(_isPressed)
        {
            _onPressed.Invoke();
        }

        else
        {
            _onReleased.Invoke();
        }
    }

}
