using System;

namespace Isogram
{
    public class CheckIsogram {
        public bool checkText(string text) {
            bool result = true;
            text = text.Replace(" ", "");
            text = text.Replace("-", "");
            foreach (var item1 in text)
            {
                int count = 0;
                foreach (var item2 in text)
                {
                    if (item1 == item2) {
                        ++count;
                    }
                }
                if (count > 1) {
                    result = false;
                }
            }
            return result;
        }
    }
}