
class Account {
    private List<int> _deposits = new List<int>();
    private String _name = "Dr. Who";
    private String _firstName = "Dr.";
    private String _lastName = "Who";

    // Getter
    public String GetName() {
        return $"{_firstName} {_lastName}";
    }

    // Setter
    public void SetName(String newName) {
        _name = newName;
    }

    public void Deposit(int amount) {
        _deposits.Add(amount);
    }

    public int GetBalance() {
        int balance = 0;
        foreach ( var deposit in _deposits) {
            balance += deposit;
        }
        return balance;
    }
}