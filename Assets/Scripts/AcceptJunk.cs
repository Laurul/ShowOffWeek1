﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcceptJunk : MonoBehaviour
{
    [SerializeField] string _tag;
    int count = 0;
    bool collected = false;
    AudioSource audioData;
    [SerializeField] private AudioClip good;
    [SerializeField] private AudioClip bad;

    // Start is called before the first frame update
    void Start()
    {
        audioData = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        collected = false;
        if ( other.tag == _tag)
        {
            collected = true;
            count++;
            audioData.PlayOneShot(good);
            Destroy(other.gameObject);
        }
        else
        {
            audioData.PlayOneShot(bad);
            Destroy(other.gameObject);
        }
        
    }
    public int returnCount()
    {
        return count;
    }
    public bool returnCollected()
    {
        return collected;

    }
    public void SwitchCollected()
    {
        collected = !collected;
    }
    public void RecycleJunk(int amount)
    {
        count-= amount;
    }
}
