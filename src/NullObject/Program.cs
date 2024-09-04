var learnerService = new LearnerService();
var learner = learnerService.GetCurrentLearner();

var view = new LearnerView(learner);
view.Render();