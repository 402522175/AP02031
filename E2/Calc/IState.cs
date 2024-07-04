namespace E2.Calc
{
    public interface IState
    {
        IState EnterZeroDigit();
        IState EnterNonZeroDigit(char c);
        IState EnterOperator(char c);
        IState EnterPoint();
        IState EnterEqual();
    }
}
