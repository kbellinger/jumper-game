//Generates the random word, displays lines and updates correct letter guesses

public class Words{
    
    // string[] wordsArray = {"shake", "store", "jewel", "child", "tease", "space", "horse", "penny", "style", "robot"};
    List<string> words = new List<string>();
    public Words(){
        
    }

    public void createList(){
        this.words.Add("shake");
        this.words.Add("store");
        this.words.Add("jewel");
        this.words.Add("child");
        this.words.Add("tease");
        this.words.Add("space");
        this.words.Add("horse");
        this.words.Add("penny");
        this.words.Add("style");
        this.words.Add("robot");
    }
    
    //pick random word in list
    public string generateWord(){
        createList();
        Random ranWord = new Random();
        int i = ranWord.Next(0,words.Count);
        return words[i];
    }
    
};