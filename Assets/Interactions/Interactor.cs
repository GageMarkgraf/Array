using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interactor : MonoBehaviour
{
    [SerializeField] public Transform _interactionPoint;
    [SerializeField] public float _interactionPointRadius = 0.5f;
    [SerializeField] public LayerMask _interactableMask;

    public readonly Collider[] _colliders = new Collider[3];
    [SerializeField] public int _numFound;

    public Collider[] hitObj;
    

    public void Update()
    {
        _numFound = Physics.OverlapSphereNonAlloc(_interactionPoint.position, _interactionPointRadius, _colliders, (int)_interactableMask);
        hitObj = Physics.OverlapSphere(_interactionPoint.position, _interactionPointRadius);

        if(_numFound > 0)
        {
            var interactable = _colliders[0].GetComponent<Interactable>();

            if(interactable != null && Keyboard.current.eKey.wasPressedThisFrame)
            {
                interactable.Interact(this);
            }
        }
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(_interactionPoint.position, _interactionPointRadius);
    }
}
