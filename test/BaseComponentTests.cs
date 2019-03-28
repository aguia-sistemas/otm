using System;
using Xunit;

namespace Qtm.UnitTests.Components
{
    public class BaseComponentTests
    {
        [Fact]
        public void SendMessage()
        {
            // create two components 
            

            // send message


            Assert.True();
        }
    }

    public class FakeComponent : BaseComponent
    {
        public int Count { get; private set; }

        protected void ProcessMessage(ComponentMessage msg)
        {
            switch (msg.Name)
            {
                case "ADD":
                    Count++;
                    break;
                default:
                    Logger.Error($"{ComponentName}: Mensagem não esperado ({msg.Name}).");
                    break;                    
            }
        }        
    }
}
