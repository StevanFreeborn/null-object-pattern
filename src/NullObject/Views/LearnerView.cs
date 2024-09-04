namespace NullObject.Views;

class LearnerView(ILearner learner)
{
  private readonly ILearner _learner = learner;

  public void Render()
  {
    Console.WriteLine($"Learner: {_learner.Username}");
    Console.WriteLine($"Number of courses completed: {_learner.NumberOfCourseCompleted}");
  }
}