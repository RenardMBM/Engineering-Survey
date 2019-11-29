using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class FollowButton : MonoBehaviour
{
    private void Update()
    {
        var objects = GameObject.FindGameObjectsWithTag("Player");
        if (!objects.Any())
            return;

        var target = objects.First();
        if (target == null)
            return;

        var p1 = transform.position;
        var p2 = target.transform.position;
        var position = new Vector3(p2.x, p2.y, p2.z);
        transform.LookAt(position);
    }
}