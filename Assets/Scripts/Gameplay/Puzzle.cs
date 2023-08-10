using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Puzzle : MonoBehaviour, Interactable
{
    [SerializeField] private string _prompt;
    [SerializeField] private GameObject _redCube;
    [SerializeField] private GameObject _blueCube;
    [SerializeField] private GameObject _greenCube;

    public string InteractionPrompt => _prompt;
    public bool Interact(Interactor interactor)
    {

        if(_redCube.GetComponent<Renderer>().material.color == Color.red &&
        _blueCube.GetComponent<Renderer>().material.color == Color.blue &&
        _greenCube.GetComponent<Renderer>().material.color == Color.green)
        {
            SceneManager.LoadScene(4);
            return true;
        }
        return true;
    }
}
