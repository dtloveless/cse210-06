class MathAssignment: Assignment {
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string textSection, string problems): base(name, topic){
        _studentName = name; // = GetStudentName() - if private and getter in parent
        _topic = topic;
        _textbookSection = textSection;
        _problems = problems;
    }

    public string GetHomeworkList(){
        return _textbookSection + " " + _problems;
    }
}
