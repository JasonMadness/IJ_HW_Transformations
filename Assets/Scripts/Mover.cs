using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private bool _isSelfSpaced = false;

    private Space _space;

    private void Start()
    {
        if (_isSelfSpaced)
            _space = Space.Self;
        else
            _space = Space.World;
    }

    private void Update()
    {
        transform.Translate(Vector3.forward * (_speed * Time.deltaTime), _space);
    }
}
