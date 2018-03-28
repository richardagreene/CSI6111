using System;
using System.Linq;

namespace CSI6111.Shared
{
    public interface IEvaluate
    {
        string Run(string studentId, int[] results);
    }

    /// <summary>
    /// Evaluate logic
    /// </summary>
    public class Evaluate : MarshalByRefObject, IEvaluate
    {
        /// <summary>
        /// Logic to work out results
        /// </summary>
        /// <param name="results"></param>
        /// <returns></returns>
        public string Run(string studentId, int[] results)
        {
            var evaluationResult = String.Empty;

            if (results.Length < 12) return "Not enough results entered; should be at least 12";

            if (results.Length > 30) return "To many results entered; should be at max 30";

            // show list in order
            Console.WriteLine($"--- All results in order of entry ---");
            foreach (var result in results)
                Console.WriteLine($"Entered {result}");

            // show top 8 results
            var top8 = results.OrderByDescending(x => x).Take(8);
            Console.WriteLine($"--- Top 8 Results ---");
            foreach (var result in top8)
                Console.WriteLine($"Entered {result}");

            // Calc Average of top 8
            var top8Average = top8.Average();
            Console.WriteLine($"--- Top 8 Result Average ---");
            Console.WriteLine($"Average {top8Average}");

            // Calc course Average
            var courseAverage = results.Average();
            Console.WriteLine($"--- Course Average ---");
            Console.WriteLine($"Average {courseAverage}");

            // Evalaute results
            if(courseAverage > 70)
                evaluationResult = $"{studentId}, {courseAverage:0.00}, QUALIFIED FOR HONOURS STUDY!";

            if (courseAverage < 70 && top8Average >= 80)
                evaluationResult = $"{studentId}, {courseAverage:0.00}, {top8Average:0.00}, MAY HAVE GOOD CHANCE! Need further assessment!";

            if (courseAverage < 70 && ( top8Average >= 70 && top8Average < 80))
                evaluationResult = $"{studentId}, {courseAverage:0.00}, {top8Average:0.00}, MAY HAVE A CHANCE! Must be carefully reassessed and get the coordinator’s special permission!";

            if (courseAverage < 70 && (top8Average < 70))
                evaluationResult = $"{studentId}, {courseAverage:0.00}, {top8Average:0.00},  DOES NOT QUALIFY FOR HONORS STUDY! Try Masters by course work.";

            Console.WriteLine($"Evaluation Result: {evaluationResult}");
            return evaluationResult;
        }
    }
}
