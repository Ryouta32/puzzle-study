using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController
{
    float time = 0;
    float inv_time_max =1.0f;
    const float DELTA_TIME_MAX =1.0f;

    public void set(float max_time)
    {
        Debug.Assert(0 < max_time);

        time = max_time;
        inv_time_max =1.0f/max_time;
    }

    public bool Update(float delta_time)
    {
        if (DELTA_TIME_MAX < delta_time)
            delta_time = DELTA_TIME_MAX;

        time -= delta_time;

        if (time <= 0.0f)
        {
            time = 0.0f;
            return false;
        }
        
        return true;

    }

    public float GetNormalized()
    {
        return time * inv_time_max;
    }
}
