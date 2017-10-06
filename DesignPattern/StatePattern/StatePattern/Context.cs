namespace StatePattern
{
    class Context
    {
        public Context(IState state)
        {
            this.State = state;
        }
        public IState State { get; set; }
        public void Request(IState nextState)
        {
            State.Handle();
            this.State = nextState;
        }
    }
}