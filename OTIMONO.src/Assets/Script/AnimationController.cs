using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class AnimationController
{
    int time = 0;
    float inv_time_max =1.0f;
    const float DELTA_TIME_MAX =1.0f;

    public void set(int max_time)
    {
        Debug.Assert(0 < max_time);

        time = max_time;
        inv_time_max =1.0f/(float)max_time;
    }

    public bool Update()
    {
        time = Math.Max(--time, 0);
        return (0 < time);

    }

    public float GetNormalized()
    {
        return (float)time * inv_time_max;
    }
}
