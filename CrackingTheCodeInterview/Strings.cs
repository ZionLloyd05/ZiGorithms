using System;

namespace algorithm_v2.CrackingTheCodeInterview {
    public class Strings {
        //    public bool IsUnique(string word){
        //        Char[] wordArr = new Char[];
        //        Array.Sort(word);
        //    }

        // public string ReplaceUrl(string url){
        //     newUrl = "";
        //     char empty = '\0';
        //     for(int x=0; x < url.Length; x++){
        //         Console.WriteLine(url[x] == empty);
        //         // if(url[x].IsNullOrEmpty()){
        //         //     Console.WriteLine("yea");
        //         //     newUrl += "%20";
        //         // }
        //         newUrl += url[x];
        //     }

        //     return newUrl;
        // }

        public string CompressString (string str) {
            if (str == null)
                return null;
            string result = "";
            char curr;
            int val = 1;
            for (int x = 0; x < str.Length; x++) {
                curr = str[x];
                if (x + 1 != str.Length) {
                    if (curr == str[x + 1]) {
                        val++;
                    } else {
                        result += curr + "" + val;
                        val = 1;
                    }
                } else {
                    if (curr == str[x - 1]) {
                        result += curr + "" + val;
                    } else {
                        result += curr + "" + val;
                        val = 1;
                    }
                }
            }

            return result;
        }
    }
}