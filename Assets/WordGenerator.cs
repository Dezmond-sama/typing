﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    private static string[] wordList = {"hurried",
"burst",
"dysfunctional",
"old-fashioned",
"normal",
"bright",
"collar",
"list",
"brave",
"zesty",
"cow",
"jagged",
"aftermath",
"cup",
"pink",
"reflective",
"design",
"internal",
"quizzical",
"wrist",
"offer",
"bubble",
"mice",
"wind",
"measure",
"aback",
"mature",
"new",
"substantial",
"nod",
"tense",
"poor",
"tricky",
"subdued",
"bottle",
"string",
"voyage",
"abstracted",
"sharp",
"rabbits",
"discovery",
"spiritual",
"lovely",
"skate",
"cream",
"cough",
"apparatus",
"amazing",
"luxuriant",
"chew",
"quiet",
"bitter",
"hateful",
"change",
"worm",
"frightening",
"festive",
"instrument",
"hook",
"record",
"accurate",
"flowers",
"tiny",
"godly",
"splendid",
"mug",
"humdrum",
"hands",
"maid",
"ratty",
"afterthought",
"salt",
"elated",
"sack",
"seed",
"uptight",
"toad",
"two",
"route",
"tasteful",
"jellyfish",
"fasten",
"pick",
"name",
"correct",
"weigh",
"soup",
"paper",
"distinct",
"depend",
"black",
"care",
"creature",
"thirsty",
"aware",
"camera",
"attack",
"flagrant",
"disappear",
"mind" };
    public static string GetRandomWord()
    {
        int index = Random.Range(0, wordList.Length);
        return wordList[index];
    }
}
