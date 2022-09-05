namespace StatePattern.Contracts
{
    public interface IMachineState
    {
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();
    }
}