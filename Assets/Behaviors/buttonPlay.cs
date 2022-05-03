using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class buttonPlay : MonoBehaviour
{
    public Button yourButton;
    // Start is called before the first frame update
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }

    // Update is called once per frame
    void TaskOnClick()
    {
        Debug.Log("You have clicked the button!");
        SceneManager.LoadScene("Racetracks", LoadSceneMode.Additive);
    }
}
