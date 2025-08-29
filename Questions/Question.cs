namespace FutaQuiz.Questions
{
    public class Question
    {
        public string? StrQuestion { get; set; }
        public string[]? Options { get; set; }
        public string? Answer { get; set; }
        public int Score { get; set; }
        public string? Explanation { get; set; } = "Not Available";
    }

    public class QuestionPreset
    {
        public List<Question>? QuestionsList { get; set; } = new List<Question>();
        public int QuestionIndexer { get; set; } = 10;
        public string? CourseCode { get; }
        public QuestionPreset(string _courseCode)
        {
            CourseCode = _courseCode;
        }
    }

}
