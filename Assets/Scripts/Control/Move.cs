using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Control
{

    public class Move : MonoBehaviour
    {
        [SerializeField] private float _speed;

        private float _positionX;
        private float _positionZ;

        void Update()
        {
            _positionX = _speed * Input.GetAxis("Horizontal");
            _positionZ = _speed * Input.GetAxis("Vertical");

            Vector3 movement = new Vector3(_positionX, 0, _positionZ);

            movement *= Time.deltaTime;

            transform.Translate(movement, Space.World);
        }
    }
}