using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour {

    //public WordManager mWordManager;

    public Transform A_prefab;
    public Transform B_prefab;
    public Transform C_prefab;
    public Transform D_prefab;
    public Transform E_prefab;
    public Transform F_prefab;
    public Transform G_prefab;
    public Transform H_prefab;
    public Transform I_prefab;
    public Transform J_prefab;
    public Transform K_prefab;
    public Transform L_prefab;
    public Transform M_prefab;
    public Transform N_prefab;
    public Transform O_prefab;
    public Transform P_prefab;
    public Transform Q_prefab;
    public Transform R_prefab;
    public Transform S_prefab;
    public Transform T_prefab;
    public Transform U_prefab;
    public Transform V_prefab;
    public Transform W_prefab;
    public Transform X_prefab;
    public Transform Y_prefab;
    public Transform Z_prefab;

    //public, and can be accessed by word manager
    public List<Transform> letters;

    private void Start()
    {
        letters = new List<Transform>();
    }

    public void SpawnWord(string wordToSpawn)
    {
        //Debug.Log("Word to spawn is " + wordToSpawn);

        letters = new List<Transform>();

        //if (letters.Count != 0) { //if list is not empty
        //    letters.Clear(); //clean set of 5 letters
        //}

        Vector3 pos1 = new Vector3(-40.0f, 0.5f, -4.0f);
        Vector3 pos2 = new Vector3(-40.0f, 0.5f, -2.0f);
        Vector3 pos3 = new Vector3(-40.0f, 0.5f, 0.0f);
        Vector3 pos4 = new Vector3(-40.0f, 0.5f, 2.0f);
        Vector3 pos5 = new Vector3(-40.0f, 0.5f, 4.0f);

        Vector3[] startingPositions = new Vector3[5] {pos1, pos2, pos3, pos4, pos5};

        //only 5 letters, instantiated left to right
        for (int i = 0; i < 5; i++) {
            switch (wordToSpawn[i])
            {
                case 'a':
                    //Debug.Log("Letter to spawn is: " + wordToSpawn[i]);
                    Transform thisLetterA = Instantiate(A_prefab, startingPositions[i], Quaternion.identity) as Transform;
                    thisLetterA.Rotate(0, 90, 0);
                    letters.Add(thisLetterA);
                    break;
                case 'b':
                    //Debug.Log("Letter to spawn is: " + wordToSpawn[i]);
                    Transform thisLetterB = Instantiate(B_prefab, startingPositions[i], Quaternion.identity) as Transform;
                    thisLetterB.Rotate(0, 90, 0);
                    letters.Add(thisLetterB);
                    break;
                case 'c':
                    //Debug.Log("Letter to spawn is: " + wordToSpawn[i]);
                    Transform thisLetterC = Instantiate(C_prefab, startingPositions[i], Quaternion.identity) as Transform;
                    thisLetterC.Rotate(0, 90, 0);
                    letters.Add(thisLetterC);
                    break;
                case 'd':
                    //Debug.Log("Letter to spawn is: " + wordToSpawn[i]);
                    Transform thisLetterD = Instantiate(D_prefab, startingPositions[i], Quaternion.identity) as Transform;
                    thisLetterD.Rotate(0, 90, 0);
                    letters.Add(thisLetterD);
                    break;
                case 'e':
                    //Debug.Log("Letter to spawn is: " + wordToSpawn[i]);
                    Transform thisLetterE = Instantiate(E_prefab, startingPositions[i], Quaternion.identity) as Transform;
                    thisLetterE.Rotate(0, 90, 0);
                    letters.Add(thisLetterE);
                    break;
                case 'f':
                    //Debug.Log("Letter to spawn is: " + wordToSpawn[i]);
                    Transform thisLetterF = Instantiate(F_prefab, startingPositions[i], Quaternion.identity) as Transform;
                    thisLetterF.Rotate(0, 90, 0);
                    letters.Add(thisLetterF);
                    break;
                case 'g':
                    //Debug.Log("Letter to spawn is: " + wordToSpawn[i]);
                    Transform thisLetterG = Instantiate(G_prefab, startingPositions[i], Quaternion.identity) as Transform;
                    thisLetterG.Rotate(0, 90, 0);
                    letters.Add(thisLetterG);
                    break;
                case 'h':
                    Debug.Log("Letter to spawn is: " + wordToSpawn[i]);
                    Transform thisLetterH = Instantiate(H_prefab, startingPositions[i], Quaternion.identity) as Transform;
                    thisLetterH.Rotate(0, 90, 0);
                    letters.Add(thisLetterH);
                    break;
                case 'i':
                    //Debug.Log("Letter to spawn is: " + wordToSpawn[i]);
                    Transform thisLetterI = Instantiate(I_prefab, startingPositions[i], Quaternion.identity) as Transform;
                    thisLetterI.Rotate(0, 90, 0);
                    letters.Add(thisLetterI);
                    break;
                case 'j':
                    //Debug.Log("Letter to spawn is: " + wordToSpawn[i]);
                    Transform thisLetterJ = Instantiate(J_prefab, startingPositions[i], Quaternion.identity) as Transform;
                    thisLetterJ.Rotate(0, 90, 0);
                    letters.Add(thisLetterJ);
                    break;
                case 'k':
                    //Debug.Log("Letter to spawn is: " + wordToSpawn[i]);
                    Transform thisLetterK = Instantiate(K_prefab, startingPositions[i], Quaternion.identity) as Transform;
                    thisLetterK.Rotate(0, 90, 0);
                    letters.Add(thisLetterK);
                    break;
                case 'l':
                    //Debug.Log("Letter to spawn is: " + wordToSpawn[i]);
                    Transform thisLetterL = Instantiate(L_prefab, startingPositions[i], Quaternion.identity) as Transform;
                    thisLetterL.Rotate(0, 90, 0);
                    letters.Add(thisLetterL);
                    break;
                case 'm':
                    //Debug.Log("Letter to spawn is: " + wordToSpawn[i]);
                    Transform thisLetterM = Instantiate(M_prefab, startingPositions[i], Quaternion.identity) as Transform;
                    thisLetterM.Rotate(0, 90, 0);
                    letters.Add(thisLetterM);
                    break;
                case 'n':
                    //Debug.Log("Letter to spawn is: " + wordToSpawn[i]);
                    Transform thisLetterN = Instantiate(N_prefab, startingPositions[i], Quaternion.identity) as Transform;
                    thisLetterN.Rotate(0, 90, 0);
                    letters.Add(thisLetterN);
                    break;
                case 'o':
                    //Debug.Log("Letter to spawn is: " + wordToSpawn[i]);
                    Debug.Log("Spawning O at position: " + startingPositions[i].x + " " + startingPositions[i].y + " " + startingPositions[i].z);
                    Transform thisLetterO = Instantiate(O_prefab, startingPositions[i], Quaternion.identity) as Transform;
                    thisLetterO.Rotate(0, 90, 0);
                    letters.Add(thisLetterO);
                    break;
                case 'p':
                    //Debug.Log("Letter to spawn is: " + wordToSpawn[i]);
                    Transform thisLetterP = Instantiate(P_prefab, startingPositions[i], Quaternion.identity) as Transform;
                    thisLetterP.Rotate(0, 90, 0);
                    letters.Add(thisLetterP);
                    break;
                case 'q':
                    //Debug.Log("Letter to spawn is: " + wordToSpawn[i]);
                    Vector3 qSpawnUpALittle = startingPositions[i];
                    qSpawnUpALittle.y += 0.2f;
                    Transform thisLetterQ = Instantiate(Q_prefab, qSpawnUpALittle, Quaternion.identity) as Transform;
                    thisLetterQ.Rotate(0, 90, 0);
                    letters.Add(thisLetterQ);
                    break;
                case 'r':
                    //Debug.Log("Letter to spawn is: " + wordToSpawn[i]);
                    Transform thisLetterR = Instantiate(R_prefab, startingPositions[i], Quaternion.identity) as Transform;
                    thisLetterR.Rotate(0, 90, 0);
                    letters.Add(thisLetterR);
                    break;
                case 's':
                    //Debug.Log("Letter to spawn is: " + wordToSpawn[i]);
                    Transform thisLetterS = Instantiate(S_prefab, startingPositions[i], Quaternion.identity) as Transform;
                    thisLetterS.Rotate(0, 90, 0);
                    letters.Add(thisLetterS);
                    break;
                case 't':
                    //Debug.Log("Letter to spawn is: " + wordToSpawn[i]);
                    Transform thisLetterT = Instantiate(T_prefab, startingPositions[i], Quaternion.identity) as Transform;
                    thisLetterT.Rotate(0, 90, 0);
                    letters.Add(thisLetterT);
                    break;
                case 'u':
                    //Debug.Log("Letter to spawn is: " + wordToSpawn[i]);
                    Transform thisLetterU = Instantiate(U_prefab, startingPositions[i], Quaternion.identity) as Transform;
                    thisLetterU.Rotate(0, 90, 0);
                    letters.Add(thisLetterU);
                    break;
                case 'v':
                    //Debug.Log("Letter to spawn is: " + wordToSpawn[i]);
                    Transform thisLetterV = Instantiate(V_prefab, startingPositions[i], Quaternion.identity) as Transform;
                    thisLetterV.Rotate(0, 90, 0);
                    letters.Add(thisLetterV);
                    break;
                case 'w':
                    //Debug.Log("Letter to spawn is: " + wordToSpawn[i]);
                    Transform thisLetterW = Instantiate(W_prefab, startingPositions[i], Quaternion.identity) as Transform;
                    thisLetterW.Rotate(0, 90, 0);
                    letters.Add(thisLetterW);
                    break;
                case 'x':
                    //Debug.Log("Letter to spawn is: " + wordToSpawn[i]);
                    Transform thisLetterX = Instantiate(X_prefab, startingPositions[i], Quaternion.identity) as Transform;
                    thisLetterX.Rotate(0, 90, 0);
                    letters.Add(thisLetterX);
                    break;
                case 'y':
                    //Debug.Log("Letter to spawn is: " + wordToSpawn[i]);
                    Transform thisLetterY = Instantiate(Y_prefab, startingPositions[i], Quaternion.identity) as Transform;
                    thisLetterY.Rotate(0, 90, 0);
                    letters.Add(thisLetterY);
                    break;
                case 'z':
                    //Debug.Log("Letter to spawn is: " + wordToSpawn[i]);
                    Transform thisLetterZ = Instantiate(Z_prefab, startingPositions[i], Quaternion.identity) as Transform;
                    thisLetterZ.Rotate(0, 90, 0);
                    letters.Add(thisLetterZ);
                    break;
            }
        }
    }
}
