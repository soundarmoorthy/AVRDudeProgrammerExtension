namespace AtmelStudio.AVRDude.Wrapper
{
    public class AVRDudeOutputMessage
    {

        public string Message { get; set; }
        public bool Error { get; set; }
        public AVRDudeOutputMessage(string msg, bool error)
        {
            this.Message = msg;
            this.Error = error;

        }
    }
}