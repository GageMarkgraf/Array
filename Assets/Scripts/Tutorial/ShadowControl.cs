using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShadowControl: MonoBehaviour
{
    private PlayerInput playerInput;
    private PlayerInput.OnFootActions onFoot;
    Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
    }

    void Update()
    {
    if (Input.GetKeyDown(KeyCode.R))
    {
        rend.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
    }
    if (Input.GetKeyDown(KeyCode.B))
    {
        rend.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
    }
    if (Input.GetKeyDown(KeyCode.G))
    {
        rend.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.ShadowsOnly;
    }
    }
}