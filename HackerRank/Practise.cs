using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;

namespace algorithm_v2.HackerRank {
    public class Practise {
        public void PrintStars (int n) {
            for (int i = 1; i <= n; i++) {
                int spaceToPrint = n - i;
                int hashToPrint = i;

                for (int x = 1; x <= spaceToPrint; x++) {
                    Console.Write (" ");
                }

                for (int z = 0; z < hashToPrint; z++) {
                    Console.Write ("#");
                }

                Console.WriteLine ("");
            }
        }

        public int BirthdayCakeCandles (int[] ar) {
            if (ar.Length < 1)
                return 0;
            Hashtable ht = new Hashtable ();

            // ht.Add (1, 2);
            // ht.Add (2, 5);
            // ht.Add (3, 6);
            // ht.Add (4, 7);
            // ht.Add (5, 8);

            // foreach (DictionaryEntry de in ht) {
            //     Console.WriteLine ("Key = {0}, Value = {1}", de.Key, de.Value);
            // }

            // ht[3] = (int) ht[3] + 1;
            // Console.WriteLine (ht[3]);

            // return 0;

            int max = ar[0];
            ht.Add (max, 1);
            for (int x = 1; x < ar.Length; x++) {
                // Console.WriteLine ("elem = {0}, max = {1}", ar[x], max);
                if (ar[x] > max) {
                    max = ar[x];
                    ht.Add (max, 1);
                } else if (ar[x] == max) {
                    // Console.WriteLine ("max = {0}", max);
                    if (ht[max] != null) {
                        // Console.WriteLine (ht[max]);
                        ht[max] = (int) ht[max] + 1;
                    }
                    // Console.WriteLine ("ht[max] = {0}", ht[max]);
                }

                // foreach (DictionaryEntry de in ht) {
                //     Console.WriteLine ("Key = {0}, Value = {1}", de.Key, de.Value);
                // }
            }

            if (ht[max] != null)
                return (int) ht[max];
            else return 0;
        }

    }
}