using System;

namespace CodeWars.CSharp._8kyu.StriveMatching1
{
    // This class is added to avoid errors, as Candidate class is described in CodeWars directly, so don't use it.
    public class Candidate
    {
        public int MinSalary;
    }

    // This class is added to avoid errors, as Candidate class is described in CodeWars directly, so don't use it.
    public class Job
    {
        public int MaxSalary;
    }

    // Strive Matching #1
    // https://www.codewars.com/kata/56c22c5ae8b139416c00175d
    public class Strive
    {
        public static bool Match(Candidate c, Job j)
        {
            if (j.MaxSalary == null || c.MinSalary == null) throw new Exception();
            return j.MaxSalary >= c.MinSalary * 0.9;
        }
    }
}
