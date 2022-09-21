using UnityEngine;
using UnityEngine.UI;


public class Manager : MonoBehaviour
{
    public GameObject blueButton;
    public GameObject redButton;
    public GameObject greenButton;
    public GameObject Button;
 

    // Start is called before the first frame update
    void Start()
    {
        blueButton.GetComponent<Image>().color = Color.blue;
        redButton.GetComponent<Image>().color = Color.red;
        greenButton.GetComponent<Image>().color = Color.green;
        Button.GetComponent<Button>().interactable = false;
    }


    public bool blueButtonWasClicked;
    public bool redButtonWasClicked;
    public bool greenButtonWasClicked;

    // Update is called once per frame
    void Update()
    {
        bool blueButtonWasClicked = false;
        bool redButtonWasClicked = false;
        bool greenButtonWasClicked = false;

        if (blueButtonWasClicked && redButtonWasClicked && greenButtonWasClicked)
            Button.GetComponent<Button>().interactable = true;
    }

    public void changeColor()
    {
        blueButton.GetComponent<Image>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        redButton.GetComponent<Image>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        greenButton.GetComponent<Image>().color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

    
    
}

