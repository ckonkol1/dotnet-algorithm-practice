namespace GreedyAlgorithms.Easy;

/*
 *Optimal Freelancing
   You recently started freelance software development and have been offered a variety of job opportunities. Each job has a deadline
   meaning there is no value in completing the work after the deadline. Additionally. each job has an associated payment representing the
   profit for completing that job. Given this information. write a function that returns the maximum profit that can be obtained in a 7-day
   period.
   Each job will take 1 full day to complete, and the deadline will be given as the number of days left to complete the job. For example, if a
   job has a deadline of 1, then it can only be completed if it is the first job worked on. If a job has a deadline of 2, then it could be started
   on the first or second day.
   Note: There is no requirement to complete all of the jobs. Only one job can be worked on at a time, meaning that in some scenarios it
   will be impossible to complete them all.

    Sample Input:
    {
     "jobs": [
       {
         "deadline": 8,
         "payment": 3
       },
       {
         "deadline": 1,
         "payment": 1
       },
       {
         "deadline": 1,
         "payment": 2
       }
     ]
   }
    Sample Output: 5

    O(n * log(n)) time | 0(1) space - where n is the number of jobs
 */
public static class OptimalFreelancing
{
    public static int GetOptimalFreelancing(Dictionary<string, int>[] jobs)
    {
        var maxDays = 7;
        Array.Sort(jobs, (a, b) => a["payment"].CompareTo(b["payment"]));

        var payments = new int[maxDays];

        for (var i = jobs.Length - 1; i >= 0; i--)
        {
            var index = Math.Min(jobs[i]["deadline"], maxDays);

            for (var j = index - 1; j >= 0; j--)
            {
                if (payments[j] == 0)
                {
                    payments[j] = jobs[i]["payment"];
                    break;
                }
            }
        }

        return payments.Sum();
        ;
    }
}