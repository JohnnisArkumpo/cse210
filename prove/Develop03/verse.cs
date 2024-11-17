using System;

class Verse
{
    // start
    private string passageContent = "And my father dwelt in a tent";
    private string getPassage(string locator) {
        if(locator == "true") {
            passageContent = "scripture.location.content";
        }
        return passageContent;
    }
}