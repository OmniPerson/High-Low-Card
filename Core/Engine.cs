namespace Core
{
    class Engine
    {


        public bool IsRunning { get; set; }
        public int Round { get; set; }

        void reset()
        {
            Round = 0;
        }
        public Engine()
        {
            IsRunning = true;
            Round = 0;
        }
        public void  NextRound(){
            Round ++;
        }
    }



}