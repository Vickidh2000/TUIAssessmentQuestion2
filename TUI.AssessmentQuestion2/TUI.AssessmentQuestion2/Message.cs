using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUI.AssessmentQuestion2
{
    abstract class Message
    {
        public abstract void MethodMessage();
    }
    class MessageA : Message
    {
        public override void MethodMessage()
        {
            // Implementing My Custom MethodMessageOnA 
        }
    }
    class MessageB : Message
    {
        public override void MethodMessage()
        {
            // Implementing My Custom MethodMessageOnA 
        }
        public void MyOtherMethodOnB()
        {
            // Implementing My Other MethodMessageOnB
        }
    }
    class MessageC : Message
    {
        public override void MethodMessage()
        {
            // Implementing My Custom MethodMessageOnC
        }
    }
}
