﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace UnityIslandsTerrain
{
    public class ScreenRay : MonoBehaviour
    {
        private void FixedUpdate()
        {
            RaycastHit hit;
            Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit);
            transform.position = hit.point;
        }
    }
}