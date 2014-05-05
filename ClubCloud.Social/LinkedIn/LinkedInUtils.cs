using System;

namespace ClubCloud.Social.LinkedIn
{

    public class LinkedInUtils
    {
        public LinkedInUtils()
        {
        }

        public static string Convert(string u003f14u003f)
        {
            int length = u003f14u003f.Length;
            char[] chrArray = new char[length];
            int num = 0;
            while (true)
            {
                if (num >= (int)chrArray.Length)
                {
                    break;
                }
                char chr = u003f14u003f[num];
                byte num1 = (byte)(chr ^ (char)(length - num));
                byte num2 = (byte)(chr >> '\b' ^ num);
                chrArray[num] = (char)(num2 << 8 | num1);
                num++;
            }
            return string.Intern(new string(chrArray));
        }
    }
}