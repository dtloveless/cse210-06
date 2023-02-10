class Program {
    static void Main(string[] args) {
        var divider =  new IntegerDivision();
        // divider.Result(1, 10);
        // divider.DisplayResult();

        // divider.Result(0, 100);
        // divider.DisplayResult();

        // divider.Result(5, 0);
        // divider.DisplayResult();

        // divider.Inte(25, 5);
        // divider.DisplayResult();
    }
}

class IntegerDivision {
    private int _lhs;
    public int _rhs;
    public IntegerDivision(int lhs=1, int rhs=1) {
       this._lhs = lhs;
       this._rhs = rhs;
    }

    public int GetLHS() {
        return _lhs;
    }

    public void SetLHS(int newLHS) {
        if (newLHS == 0) {
            Console.WriteLine("Cannot divide by zero. LHS defaulted to one.");
            _lhs = 1;
        } else {
            _lhs = newLHS;
        }
    }

    public int GetRHS() {
        return _rhs;
    }

    public void SetRHS(int newRHS) {
        _rhs = newRHS;
    }

    public int Result() {
        return _lhs / _rhs;
    }

    public void DisplayResult() {
        var result = Result();
        Console.WriteLine($"{_lhs} divided by {_rhs} is {result}");
    }
}
