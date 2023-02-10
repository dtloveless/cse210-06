class Scripture {
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text) {
        _reference = reference;
        string[] words = text.Split();
        foreach (string word in words) {
            _words.Add(new Word(word));
        }
    }

    public void HideWords(int count) {
        for (int i = count; i > 0; i--) {
            Random rand = new Random();
            int randInt = rand.Next(0, _words.Count);
            bool wordIsHidden = _words[randInt].GetIsHidden();
            if (!IsCompletelyHidden()) {
                while (wordIsHidden) {
                    randInt = rand.Next(0, _words.Count);
                    wordIsHidden = _words[randInt].GetIsHidden();
                }
               _words[randInt].Hide();
            }
        }
    }

    public bool IsCompletelyHidden() {
        foreach(Word word in _words) {
            if (!word.GetIsHidden()) {
                return false;
            }
        }
        return true;
    }

    public void Display() {
        // Print reference
        Console.Write(_reference.GetDisplay() + " ");

        // Print verse text
        foreach (Word word in _words) {
            Console.Write(word.GetDisplay() + " ");
        }
        Console.WriteLine();
    }
}