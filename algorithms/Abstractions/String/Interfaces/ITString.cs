using System;
namespace Abstractions.String.Interfaces
{
    public interface ITString
    {
        int Length(string str);
        void Copy(string srt, string destination);
        int Compare(string left, string right);
        int StringNCompare(string left, string right, int n);
        string Append(string left, string b);
    }
}
