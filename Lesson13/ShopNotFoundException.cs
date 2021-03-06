using System;

namespace Lesson13
{
    class ShopNotFoundException : Exception
    {
        public ShopNotFoundException()
        {
        }

        public ShopNotFoundException(string message)
            : base(message)
        {
        }

        public ShopNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
