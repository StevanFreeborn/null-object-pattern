namespace NullObject.Models;

interface ILearner
{
  int Id { get; }
  string Username { get; }
  int NumberOfCourseCompleted { get; }
}