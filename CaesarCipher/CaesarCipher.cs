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
            int i=0;
            foreach(char c in text)
            {
                i=c+n;
                //rotation for small letters
                if((c>='a'&& c<='z' ))
                  {
                      if(i>122)
                        s+=(char)(i-26);
                     else
                        s+=(char)i;
                  }
                  //rotation for capital letters
                else if(c>='A' && c<='Z')
                {
                    if(i>90)
                        s+=(char)(i-26);
                    else
                        s+=(char)i;
                }
                //when character is not an alphabet
                else
                   s+=c;
            }
            return s;
           // throw new NotImplementedException("You need to implement this function.");
        }
    }
}
