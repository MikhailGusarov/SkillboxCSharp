namespace Example_1912
{
    public class Args
    {
        public int Level { get; set; }
        
        public int Hp {get; set;}
        
        public int Gold {get; set;}
        
        public string Message {get; set;}
        

        public Args(int Level, int Hp, int Gold, string Message )
        {
            this.Level = Level;
            this.Hp = Hp;
            this.Gold = Gold;
            this.Message = Message;
        }


    }
}