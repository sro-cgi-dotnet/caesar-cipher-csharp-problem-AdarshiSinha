using System;
using System.Linq;

namespace CaesarCipher
{
    public static class RotationalCipher
    {
        public static string Rotate(string text, int shiftKey)
        {
            string s=null;
            int n=shiftKey%26;
            foreach(char c in text)
            {
                if((c>='a'&& c<='z' ))
                  {
                      if(((int)c+n)>122)
                        s+=(char)(97+(c+n-123));
                     else
                        s+=(char)(c+n);
                  }
                else if(c>='A' && c<='Z')
                {
                    if(((int)c+n)>90)
                        s+=(char)(65 +(c+n-91));
                    else
                        s+=(char)(c+n);
                }
                else
                   s+=c;
            }
            return s;
           // throw new NotImplementedException("You need to implement this function.");
        }
    }
}
