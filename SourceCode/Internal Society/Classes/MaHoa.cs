using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Internal_Society
{
    public class MaHoa
    {
        public static string EncryptDecrypt2(string szPlainText, int szEncryptionKey)
        {
            StringBuilder szInputStringBuild = new StringBuilder(szPlainText);
            StringBuilder szOutStringBuild = new StringBuilder(szPlainText.Length);
            char Textch;
            for (int iCount = 0; iCount < szPlainText.Length; iCount++)
            {
                Textch = szInputStringBuild[iCount];
                Textch = (char)(Textch ^ szEncryptionKey);
                szOutStringBuild.Append(Textch);
            }
            return szOutStringBuild.ToString();
        }

        public static string EncryptDecrypt1(string kunPlainText, string kunEncryptionKey)
        {
            StringBuilder kunInputStringBuild = new StringBuilder(kunPlainText);
            StringBuilder kunOutStringBuild = new StringBuilder(kunPlainText.Length);
            char Textch;
            char kunKey;
            for (int iCount = 0; iCount < kunPlainText.Length;)
            {
                for (int jCount = 0; (jCount < kunEncryptionKey.Length && iCount < kunPlainText.Length); jCount++, iCount++)
                {
                    Textch = kunInputStringBuild[iCount];
                    kunKey = kunEncryptionKey[jCount];

                    Textch = (char)(Textch ^ kunKey);
                    kunOutStringBuild.Append(Textch);
                }

            }
            return kunOutStringBuild.ToString();
        }
    }
}
