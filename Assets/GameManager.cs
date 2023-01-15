using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public NextLevelScreen NextLevelScreen;

    public FirstInstructions FirstInstructions;
    public SecondInstructions SecondInstructions;
    public ThirdInstructions ThirdInstructions;
    public FourthInstructions FourthInstructions;
    public FifthInstructions FifthInstructions;

    bool gameHasEnded = false;

    bool cubeGrabbed = false;
    bool cubePlaced = false;

    // ROOM 1

    bool grabbedCandle = false;
    bool placedCandle = false;
    bool grabbedBook = false;
    bool placedBook = false;

    //ROOM 2
    bool grabbedBottle = false;
    bool placedBottle = false;
    bool grabbedPicture = false;
    bool placedPicture = false;



    public Animator animator;
    public float delayTime = 1f;


    public void NextLevel()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;

            Debug.Log("NEXT LEVEL");

            StartCoroutine(DelayAction(delayTime));

            IEnumerator DelayAction(float delayTime)
            {
                yield return new WaitForSeconds(delayTime);
                NextLevelScreen.Activate();

            }

        }
    }

    public void GrabbedCubeSuccessfully()
    {

        if (cubeGrabbed == false)
        {
            cubeGrabbed = true;

            Debug.Log("PLACED CUBE!");

            StartCoroutine(DelayAction(delayTime));

            IEnumerator DelayAction(float delayTime)
            {
                yield return new WaitForSeconds(delayTime);

                // NextLevelScreen.Setup();

                FirstInstructions.DeActivate();
                SecondInstructions.Activate();

            }

        }

    }

    public void PlacedCubeSuccessfully()
    {

        if (cubePlaced == false)
        {
            cubePlaced = true;

            Debug.Log("PLACED CUBE!");

            StartCoroutine(DelayAction(delayTime));

            IEnumerator DelayAction(float delayTime)
            {
                yield return new WaitForSeconds(delayTime);

                // NextLevelScreen.Setup();

                SecondInstructions.DeActivate();
                ThirdInstructions.Activate();

            }

        }

    }





    public void GrabbedBottleSuccessfully()
    {

        if (grabbedBottle == false)
        {
            grabbedBottle = true;

            Debug.Log("PLACED CUBE!");

            StartCoroutine(DelayAction(delayTime));

            IEnumerator DelayAction(float delayTime)
            {
                yield return new WaitForSeconds(delayTime);

                // NextLevelScreen.Setup();

                FirstInstructions.DeActivate();
                SecondInstructions.Activate();

            }

        }

    }


    public void PlacedBottleSuccessfully()
    {

        if (placedBottle == false)
        {
            placedBottle = true;

            Debug.Log("PLACED CUBE!");

            StartCoroutine(DelayAction(delayTime));

            IEnumerator DelayAction(float delayTime)
            {
                yield return new WaitForSeconds(delayTime);

                // NextLevelScreen.Setup();

                SecondInstructions.DeActivate();
                ThirdInstructions.Activate();

            }

        }

    }


    public void GrabbedPictureSuccessfully()
    {

        if (grabbedPicture == false)
        {
            grabbedPicture = true;

            Debug.Log("PLACED CUBE!");

            StartCoroutine(DelayAction(delayTime));

            IEnumerator DelayAction(float delayTime)
            {
                yield return new WaitForSeconds(delayTime);

                // NextLevelScreen.Setup();

                ThirdInstructions.DeActivate();
                FourthInstructions.Activate();

            }

        }

    }

    public void PlacedPictureSuccessfully()
    {

        if (placedPicture == false)
        {
            placedPicture = true;

            Debug.Log("PLACED PICTURE!");

            StartCoroutine(DelayAction(delayTime));

            IEnumerator DelayAction(float delayTime)
            {
                yield return new WaitForSeconds(delayTime);

                NextLevelScreen.Activate();

                FourthInstructions.DeActivate();
                FifthInstructions.Activate();

            }

        }

    }



    public void GrabbedCandleSuccessfully()
    {

        if (grabbedCandle == false)
        {
            grabbedCandle = true;

            Debug.Log("PLACED CUBE!");

            StartCoroutine(DelayAction(delayTime));

            IEnumerator DelayAction(float delayTime)
            {
                yield return new WaitForSeconds(delayTime);

                // NextLevelScreen.Setup();

                FirstInstructions.DeActivate();
                SecondInstructions.Activate();

            }

        }

    }

    public void PlacedCandleSuccessfully()
    {

        if (placedCandle == false)
        {
            placedCandle = true;

            Debug.Log("PLACED PICTURE!");

            StartCoroutine(DelayAction(delayTime));

            IEnumerator DelayAction(float delayTime)
            {
                yield return new WaitForSeconds(delayTime);

                // NextLevelScreen.Setup();

                SecondInstructions.DeActivate();
                ThirdInstructions.Activate();

            }

        }

    }



    public void GrabbedBookSuccessfully()
    {

        if (grabbedBook == false)
        {
            grabbedBook = true;

            Debug.Log("PLACED CUBE!");

            StartCoroutine(DelayAction(delayTime));

            IEnumerator DelayAction(float delayTime)
            {
                yield return new WaitForSeconds(delayTime);

                // NextLevelScreen.Setup();

                ThirdInstructions.DeActivate();
                FourthInstructions.Activate();

            }

        }

    }

    public void PlacedBookSuccessfully()
    {

        if (placedBook == false)
        {
            placedBook = true;

            Debug.Log("PLACED BOOK!");

            StartCoroutine(DelayAction(delayTime));

            IEnumerator DelayAction(float delayTime)
            {
                yield return new WaitForSeconds(delayTime);

                NextLevelScreen.Activate();

                FourthInstructions.DeActivate();
                FifthInstructions.Activate();

            }

        }

    }




}