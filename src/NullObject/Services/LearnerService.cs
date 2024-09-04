
using NullObject.Persistence;

namespace NullObject.Services;

class LearnerService
{
  private readonly LearnerRepository _learnerRepository = new();
  public ILearner GetCurrentLearner()
  {
    var learnerId = 1;
    return _learnerRepository.GetLearnerById(learnerId) ?? new NullLearner();
  }
}