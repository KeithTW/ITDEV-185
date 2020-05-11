using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Project
{
    class GenericNode<T>
    {
        public T data;
        public GenericNode<T> link;

        public GenericNode(T inputData)
        {
            data = inputData;

            link = null;

        }

    }

}
