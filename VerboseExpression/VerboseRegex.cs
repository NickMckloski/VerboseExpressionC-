using System.Text.RegularExpressions;

namespace VerboseExpression
{
    public class VerboseRegex
    {
        private string Expression;

        private RegexOptions Option;

        /// <summary>
        /// VerboseExpression onstructor
        /// </summary>
        /// <param name="option"></param>
        public VerboseRegex(RegexOptions option)
        {
            Option = option;
        }

        /// <summary>
        /// Returns the finalized regular expression
        /// </summary>
        /// <returns>finalized regex</returns>
        public Regex Finalize()
        {
            Regex regex = new Regex(Expression, Option);
            return regex;
        }

        /// <summary>
        /// Regex matches logic
        /// </summary>
        /// <param name="s">string to match</param>
        public void Matches(string s)
        {
            Expression += "[" + s + "]";
        }
    }
}
