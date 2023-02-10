class Word {
    private string _text;
    private bool _isHidden;

    public Word(string text) {
        _text = text;
        _isHidden = false;
    }
    
    public void Hide() {
        _isHidden = true;
    }

    public bool GetIsHidden() {
        return _isHidden;
    }
    
    public string GetDisplay() {
        if (_isHidden) {
            string blank = new string('_', _text.Length);
            return blank;
        } else {
            return _text;
        }
    }
}