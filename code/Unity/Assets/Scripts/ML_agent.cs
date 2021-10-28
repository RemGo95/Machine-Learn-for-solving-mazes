using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;
using Random = System.Random;
using System;
using System.IO;
using UnityEngine.UI;

public class ML_agent : Agent {

    int hit;
    [SerializeField] private Transform targetTransform;
    public override void OnEpisodeBegin()
    {
        //base.OnEpisodeBegin();
        hit = 0;
        transform.localPosition = new Vector3(-0.35f, 0.13f,-0.35f);
      

    }

    public void Update()
    {
        if (transform.localPosition.y < 0f)
        {
            EndEpisode();
        }
    }


    public override void CollectObservations(VectorSensor sensor)
    {
        base.CollectObservations(sensor);
        sensor.AddObservation(transform.localPosition);
        sensor.AddObservation(targetTransform.localPosition);
    }

    public override void OnActionReceived(float[] vectorAction)
    {
        float XaxisMovement = vectorAction[0];
        float ZaxisMovement = vectorAction[1];

        float speed = 0.8f;
        transform.position += new Vector3(XaxisMovement, 0, ZaxisMovement) * Time.deltaTime * speed;


    }


    public void OnTriggerEnter(Collider collision)
    {
        if(collision.TryGetComponent<Target>(out Target target))
        {
            SetReward(+1f);
            EndEpisode();
        }

        if (collision.TryGetComponent<Wall>(out Wall wall))
        {
            AddReward(-1f);
            EndEpisode();
            hit = hit + 1;
            if (hit >9)
            {
                EndEpisode();
            }
            //EndEpisode();
        }

    }


    
}
