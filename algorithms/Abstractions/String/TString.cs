using System;
using Abstractions.String.Interfaces;

namespace Abstractions.String
{
    public class TString : ITString
    {
        public TString()
        {

        }

        public string Append(string left, string b)
        {
            throw new NotImplementedException();
        }

        public int Compare(string left, string right)
        {
            int minLength = left.Length < right.Length ? left.Length : (left.Length == right.Length ? 0 : right.Length);

            int i = 0;

            for (; i<minLength && left[i] == right[i]; i++)
            {
                if ( left[i] == 0 )
                {
                    return 0;
                }
            }

            return left[i] - right[i];
        }

        public void Copy(string srt, string destination)
        {
            throw new NotImplementedException();
        }

        public int Length(string str)
        {
            int i = 0;

            for (; str[i] != 0; i++) ;

            return i;
            

        }

        public int StringNCompare(string left, string right, int n)
        {
            throw new NotImplementedException();
        }
    }
}
