using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class CubeSwap : MonoBehaviour, Interactable
{
    [SerializeField] private string _prompt;
    [SerializeField] private int _id;
    [SerializeField] private Object _obj;
    [SerializeField] private GameObject _cube;
    [SerializeField] private char _cam;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            _cam = 'R';
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            _cam = 'B';
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            _cam = 'G';
        }
    }

    public string InteractionPrompt => _prompt;
    public bool Interact(Interactor interactor)
    {
        _id = interactor.hitObj[0].GetInstanceID();
        _obj = EditorUtility.InstanceIDToObject(_id);
        _cube = GameObject.Find(_obj.name); 
        var cubeRenderer = _cube.GetComponent<Renderer>();

        if(_obj.name == "PuzzleRed")
        {
            if(_cam == 'R')
            {
                cubeRenderer.material.SetColor("_Color", Color.red);
            }
            if(_cam == 'B')
            {
                cubeRenderer.material.SetColor("_Color", Color.blue);
            }
            if(_cam == 'G')
            {
                cubeRenderer.material.SetColor("_Color", Color.green);
            }
        }
        if(_obj.name == "PuzzleBlue")
        {
            if(_cam == 'R')
            {
                cubeRenderer.material.SetColor("_Color", Color.red);
            }
            if(_cam == 'B')
            {
                cubeRenderer.material.SetColor("_Color", Color.blue);
            }
            if(_cam == 'G')
            {
                cubeRenderer.material.SetColor("_Color", Color.green);
            }
        }
        if(_obj.name == "PuzzleGreen")
        {
            if(_cam == 'R')
            {
                cubeRenderer.material.SetColor("_Color", Color.red);
            }
            if(_cam == 'B')
            {
                cubeRenderer.material.SetColor("_Color", Color.blue);
            }
            if(_cam == 'G')
            {
                cubeRenderer.material.SetColor("_Color", Color.green);
            }  
        }
        return true;
    }
}