namespace NullObject.Models;

class Learner(int id, string username, int numberOfCourseCompleted) : ILearner
{
  public int Id { get; init; } = id;
  public string Username { get; init; } = username;
  public int NumberOfCourseCompleted { get; init; } = numberOfCourseCompleted;
}