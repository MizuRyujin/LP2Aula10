using System;

namespace Indexers
{
    struct MyVector
    {
        public float X { get; set; }
        public float Y { get; set; }

        public MyVector(float x, float y)
        {
            X = x;
            Y = y;
        }

        public float this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return X;
                }
                else if (index == 1)
                {
                    return Y;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
                
            }

            set
            {
                if (index == 0)
                {
                    X = value;
                }
                else if (index == 1)
                {
                    Y = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }

        public float this[string index]
        {
            get
            {
                string idx = "xa0";
                string idy = "yb1";
                if (idx.Contains(index.ToLower()))
                {
                    return X;
                }
                else if (idy.Contains(index.ToLower()))
                {
                    return Y;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }

            }

            set
            {
                string idx = "xa0";
                string idy = "yb1";
                if (idx.Contains(index.ToLower()))
                {
                    X = value;
                }
                else if (idy.Contains(index.ToLower()))
                {
                    Y = value;
                }
                else
                {
                    throw new IndexOutOfRangeException();
                }
            }
        }
    }
}
