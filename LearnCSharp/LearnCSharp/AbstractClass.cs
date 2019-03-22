using System;
namespace LearnCSharp
{
    public abstract class AbstractClass
    {
        public virtual void SetString()
        {
            Console.WriteLine("avad");
        }
    }

    public class SampleTest : AbstractClass
    {
        public override void SetString()
        {
            Console.WriteLine("vgksahfla");
        }
    }
}
