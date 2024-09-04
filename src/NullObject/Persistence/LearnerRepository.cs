namespace NullObject.Persistence;

class LearnerRepository
{
  private readonly List<ILearner> _learners = [
    new Learner(1, "John", 2),
    new Learner(2, "Jane", 3),
    new Learner(3, "Doe", 1)
  ];

  internal ILearner? GetLearnerById(int id)
  {
    return _learners.FirstOrDefault(l => l.Id == id);
  }
}