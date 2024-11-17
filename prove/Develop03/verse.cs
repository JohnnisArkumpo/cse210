using System;

class Verse {
    // start
    private string passageContent = "Behold, he offereth himself a sacrifice for sin, to answer the ends of the law, unto all those who have a broken heart and a contrite spirit; and unto none else can the ends of the law be answered.";
    public string getPassage(string locator) {
        if(locator == "true") {
            passageContent = "Scripture chosenScripture = new Scripture();\nforeach(i in chosenScripture.passages) {\nif(chosenScripture.passages[i] == locator) {\nreturn chosenScripture.passages[i];\n}\n}";// incomplete creation of usage for multiple scripture possibilities
        }
        return passageContent;
    }
}