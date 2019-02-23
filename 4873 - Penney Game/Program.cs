using System;

namespace _4873___Penney_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalTrialNo = int.Parse(Console.ReadLine());
            int[] trailNo = new int[totalTrialNo];
            string[] trials = new string[totalTrialNo];
//Getting the input from the user in the correct format 
            for (int i = 0; i < totalTrialNo; i++)
            {
                trailNo[i] = int.Parse(Console.ReadLine());
                trials[i] = Console.ReadLine();
            }
            for (int i = 0; i < totalTrialNo; i++)
            {
                Console.WriteLine(PlayHeadTail(trials[i], trailNo[i].ToString()));
            }
        }
        public static string PlayHeadTail(string trials, string trailNo)
        {
            //TTT, TTH, THT, THH, HTT, HTH, HHT and
            // HHH.

            string[] probability = new string[8];
            int[] probabilityValues = new int[8];
            probability[0] = "TTT";
            probability[1] = "TTH";
            probability[2] = "THT";
            probability[3] = "THH";
            probability[4] = "HTT";
            probability[5] = "HTH";
            probability[6] = "HHT";
            probability[7] = "HHH";

            for (int i = 0; i <= trials.Length - 3; i++)
            {
                string temp = trials.Substring(i, 3);
                //  Array.Find(probability,p => p ==temp);
                probabilityValues[Array.IndexOf(probability, temp)]++;

            }


            Array.ForEach(probabilityValues, v => { trailNo += " "; trailNo += v; });
            return trailNo;
        }
    }
}
