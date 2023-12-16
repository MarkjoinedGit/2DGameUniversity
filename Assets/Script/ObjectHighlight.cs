﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ObjectHighlight : MonoBehaviour
{
    public ObjectController controller;
    public Animator animator;

    public float delaySecond = 1;
    public string nameScene = "main";
    public KeyCode selectKey = KeyCode.Space;
    public GameObject puzzleSubScene;
    private Button btn;


    // Update is called once per frame
    void Update()
    {
        if (puzzleSubScene == null)
            puzzleSubScene = new GameObject();
        btn  = puzzleSubScene.GetComponentInChildren<Button>();
    }

    public void turnOnOffObject()
    {
        btn.interactable = true;
        if (puzzleSubScene.activeSelf != true)
            puzzleSubScene.SetActive(true);
        else
            puzzleSubScene.SetActive(false);
        Debug.Log(puzzleSubScene.name);
        Debug.Log("get in scene");
        Debug.Log(puzzleSubScene.activeSelf);
    }

    public void clickToBack()
    {
        turnOnOffObject();
        btn.interactable = false;
    }

    public void OnHighlight()
    {
        animator.SetBool("IsHighLight", true);
       
    }

    public void TurnAnotherScreen()
    {
        puzzleSubScene.SetActive(true);
        Debug.Log("Space");
        //ModeSelect();
    }

    public void turnOffSubScene()
    {
        puzzleSubScene.SetActive(false);
    }

    public void OffHighlight()
    {
        animator.SetBool("IsHighLight", false);
    }
}
