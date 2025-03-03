using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class UI_InputHandler : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text_;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void changetext()
    {
        text_.text = "karim";
    }
}
