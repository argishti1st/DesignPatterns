using StatePattern.Contracts;

namespace StatePattern.Models
{
    public class SoldOutState : IMachineState
    {
        private readonly GumBallMachine gumBallMachine;

        public SoldOutState(GumBallMachine gumBallMachine)
        {
            this.gumBallMachine = gumBallMachine;
        }

        public void Dispense()
        {
            throw new NotImplementedException();
        }

        public void EjectQuarter()
        {
            throw new NotImplementedException();
        }

        public void InsertQuarter()
        {
            throw new NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new NotImplementedException();
        }
    }
}