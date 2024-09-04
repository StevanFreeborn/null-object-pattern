namespace NullObject.Models;

class NullLearner : ILearner
{
  public int Id => -1;
  public string Username => "Guest";
  public int NumberOfCourseCompleted => 0;
}