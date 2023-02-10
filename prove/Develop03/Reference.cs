class Reference {
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    
    public Reference(string book, int chapter, int start, int end=0) {
        _book = book;
        _chapter = chapter;
        _startVerse = start;
        _endVerse = end;
    }

    public string GetDisplay() {
        string reference;
        if (_endVerse == 0) {
            reference = $"{_book} {_chapter}:{_startVerse}";
        } else {
            reference = $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        return reference;
    }
}
