using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.NoteStatistics
{
    class NoteStatistics
    {
        static void Main(string[] args)
        {
            List<double> notes = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            Console.WriteLine($"Notes: {string.Join(" ", GetNotesAsStrings(notes))}");
            Console.WriteLine($"Naturals: {string.Join(", ", GetNaturalNotes(notes))}");
            Console.WriteLine($"Sharps: {string.Join(", ", GetSharpNotes(notes))}");
            Console.WriteLine($"Naturals sum: {Math.Round(GetNaturalsSum(notes), 2)}");
            Console.WriteLine($"Sharps sum: {Math.Round(GetSharpsSum(notes), 2)}");
        }
        static double GetSharpsSum(List<double> notes)
        {
            double sharpSum = 0.0;

            for (int i = 0; i < notes.Count; i++)
            {
                if (notes[i] == 277.18 || notes[i] == 311.13 || notes[i] == 369.99 || notes[i] == 415.30 || notes[i] == 466.16)
                {
                    sharpSum += notes[i];
                }
            }
            return sharpSum;
        }
        static double GetNaturalsSum(List<double> notes)
        {
            double naturalSum = 0.0;

            for (int i = 0; i < notes.Count; i++)
            {
                if (notes[i] != 277.18 && notes[i] != 311.13 && notes[i] != 369.99 && notes[i] != 415.30 && notes[i] != 466.16)
                {
                    naturalSum += notes[i];
                }
            }

            return naturalSum;
        }
        static List<string> GetSharpNotes(List<double> notes)
        {
            List<string> sharps = new List<string>();

            foreach (string note in GetNotesAsStrings(notes))
            {
                if (note.Contains("#"))
                {
                    sharps.Add(note);
                }
            }
            return sharps;
        }
        static List<string> GetNaturalNotes(List<double> notes)
        {
            List<string> naturals = new List<string>();

            foreach (string note in GetNotesAsStrings(notes))
            {
                if (!note.Contains("#"))
                {
                    naturals.Add(note);
                }
            }
            return naturals;
        }
        static List<string> GetNotesAsStrings(List<double> notes)
        {
            List<string> stringNotes = new List<string>();

            string[] arr = { "C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B" };

            for (int i = 0; i < notes.Count; i++)
            {
                switch (notes[i])
                {
                    case 261.63:
                        stringNotes.Add(arr[0]);
                        break;
                    case 277.18:
                        stringNotes.Add(arr[1]);
                        break;
                    case 293.66:
                        stringNotes.Add(arr[2]);
                        break;
                    case 311.13:
                        stringNotes.Add(arr[3]);
                        break;
                    case 329.63:
                        stringNotes.Add(arr[4]);
                        break;
                    case 349.23:
                        stringNotes.Add(arr[5]);
                        break;
                    case 369.99:
                        stringNotes.Add(arr[6]);
                        break;
                    case 392.00:
                        stringNotes.Add(arr[7]);
                        break;
                    case 415.30:
                        stringNotes.Add(arr[8]);
                        break;
                    case 440.00:
                        stringNotes.Add(arr[9]);
                        break;
                    case 466.16:
                        stringNotes.Add(arr[10]);
                        break;
                    case 493.88:
                        stringNotes.Add(arr[11]);
                        break;

                }
            }
            return stringNotes;
        }
    }
}
