using Bogus;
using Qase_Test.Constants;
using Qase_Test.Models;

namespace Qase_Test.Utils
{
    public static class TestDataGeneratorService
    {
        private const int CodeLength = 1;

        public static TestCase GetFakeCase()
        {
            return new Faker<TestCase>()
                .RuleFor(x => x.CaseTitle, f => f.Lorem.Word())
                .RuleFor(x => x.Description, f => f.Lorem.Paragraph())
                .RuleFor(x => x.Preconditions, f => f.Lorem.Paragraph())
                .RuleFor(x => x.Postconditions, f => f.Lorem.Paragraph())
                .RuleFor(x => x.Severity, f => f.PickRandom(TestCaseConstants.Severity))
                .RuleFor(x => x.Status, f => f.PickRandom(TestCaseConstants.Status))
                .RuleFor(x => x.Priority, f => f.PickRandom(TestCaseConstants.Priority))
                .RuleFor(x => x.Behavior, f => f.PickRandom(TestCaseConstants.Behavior))
                .RuleFor(x => x.Type, f => f.PickRandom(TestCaseConstants.Type))
                .RuleFor(x => x.IsFlaky, f => f.PickRandom(TestCaseConstants.IsFlaky))
                .RuleFor(x => x.Layer, f => f.PickRandom(TestCaseConstants.Layer))
                .RuleFor(x => x.Automation, f => f.PickRandom(TestCaseConstants.Automation));
        }

        public static Project GetFakeProject()
        {
            return new Faker<Project>()
                .RuleFor(x => x.ProjectName, f => f.Company.CompanyName())
                .RuleFor(x => x.ProjectCode, f => f.Finance.Account())
                .RuleFor(x => x.ProjectDescription, f => f.Lorem.Paragraph())
                .RuleFor(x => x.WrongProjectCode, f => f.Finance.Account(CodeLength));
        }

        public static User GetFakeUser()
        {
            return new Faker<User>()
                .RuleFor(x => x.Email, f => f.Internet.Email())
                .RuleFor(x => x.Password, f => f.Internet.Password());
        }
    }
}
